using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using WMPLib;

namespace MusicPlayerApp
{
    public partial class Form1 : Form
    {
        //icons created by Aswell Studio - Flaticon
        public DataBaseConnector dbConnector;
        public MusicPlayer musicPlayer;
        private List<MusicTrack> musicTracks = new List<MusicTrack>(); //musicTracks list to itterate through the tracks
        private IWMPPlaylist playlist;
        ToolTip toolTip=new ToolTip();

        public Form1()
        {
            InitializeComponent();
            dbConnector = new DataBaseConnector();
            musicPlayer = new MusicPlayer();
            dbConnector.CreateIfNotExists();
            LoadTracksFromDb();
            updateDataGridView();
            dataGridView1.DataSource = dbConnector.LoadTracks(); //DataBind datagridview -> TracksDB.db
            playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Playlist");
            toolTip.SetToolTip(buttonAddToPlaylist, "Select song row to add to the playlist");
            toolTip.SetToolTip(buttonRemove, "Select song row to remove from the playlist");
            toolTip.SetToolTip(button1, "Edit song and select song row to remove from the playlist");
            toolTip.SetToolTip(listBoxPlaylist, "Add songs to the playlist");
        }

        private void LoadTracksFromDb()
        {
            //Loads Tracks From Db and creates MusicTrack Object and adds Item to the musicTracks List
            DataTable dt = dbConnector.LoadTracks();

            foreach (DataRow row in dt.Rows)
            {
                string title = row["Title"].ToString();
                MusicTrack track = new MusicTrack
                {
                    title = title,
                    artist = row["Artist"].ToString(),
                    year = Convert.ToInt32(row["Year"]),
                    genre = row["Genre"].ToString(),
                    language = row["Language"].ToString(),
                    path = row["Path"].ToString()
                };
                musicTracks.Add(track);
            }
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            //Impementation of the data Reading from .mp3/.wav/.flac files using TagLib
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Music Files|*.mp3;*.wav;*.flac";
            openFileDialog.Multiselect = true;
            DataTable dt = dbConnector.LoadTracks();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Columns.Clear();
                foreach (string filename in openFileDialog.FileNames)
                {
                    //If Track Exists in db don't add 
                    //else create MusicTrack(via tagLib) and add to db
                    bool existsInDataBase = false;

                    foreach (DataRow row in dt.Rows)
                    {
                        string titleFromDb = row["Title"].ToString();
                        if (titleFromDb.Equals(filename, StringComparison.OrdinalIgnoreCase))
                        {
                            existsInDataBase = true;
                            MessageBox.Show("Track already Exists In Db", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    if (!existsInDataBase)
                    {
                        TagLib.File file = TagLib.File.Create(filename);
                        string title = file.Tag.Title;
                        MusicTrack newTrack = new MusicTrack
                        {
                            title = title,
                            artist = string.Join(", ", file.Tag.Performers),
                            year = (int)file.Tag.Year,
                            genre = string.Join(", ", file.Tag.Genres),
                            path = filename,
                            duration = file.Properties.Duration
                        };
                        musicTracks.Add(newTrack);
                        dbConnector.AddTrackToDataBase(newTrack);
                    }
                }
                updateDataGridView(); //Update UI
                dataGridView1.Refresh();
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void updateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dbConnector.LoadTracks();
            dataGridView1.Refresh();
            //MessageBox.Show("Updated TrackListBox", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void updatePlaylist()
        {
            listBoxPlaylist.Items.Clear();
            for (int i = 0; i < playlist.count; i++)
            {
                listBoxPlaylist.Items.Add(playlist.Item[i].name);
            }
        }

        private void buttonAddToPlaylist_Click(object sender, EventArgs e)
        {
            musicPlayer.musicTracks = musicTracks;
            playlist.clear();
            listBoxPlaylist.Items.Clear();
            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
            {
                string selectedTitle = selectedRow.Cells[0].Value.ToString();
                if (selectedTitle != null)
                {
                    MusicTrack selectedTrack = musicPlayer.FindTrackByTitle(selectedTitle);
                    if (selectedTrack != null)
                    {
                        var media = axWindowsMediaPlayer1.newMedia(selectedTrack.path);
                        playlist.appendItem(media);
                        axWindowsMediaPlayer1.currentPlaylist = playlist;
                        listBoxPlaylist.Items.Add(selectedTrack.title);
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    else
                    {
                        MessageBox.Show("Select tracks to add to the queue", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (playlist.count >= 0)
            {
                toolTip.SetToolTip(listBoxPlaylist, "Double click song to play");
            }
        }

        public void timesPlayed(string title)
        {
            MusicTrack playTrack = musicPlayer.FindTrackByTitle(title);
            if (playTrack != null)
            {
                playTrack.count++;
            }
        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {//When track ends increament counter+ UI
         //Else if track is playing update the "Now playing: " label
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsMediaEnded)
            {
                MusicTrack playTrack = musicPlayer.FindTrackByTitle(axWindowsMediaPlayer1.currentMedia.name);
                timesPlayed(playTrack.title);
                dbConnector.updateTrackCount(playTrack.title, playTrack.count);
                updateDataGridView();
            }
            else if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                label1.Text = "Now Playing: " + axWindowsMediaPlayer1.currentMedia.name.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//Shuffle selected tracks OR all tracks(if playlist is Empty)

            if (playlist.count == 0)
            {
                foreach (MusicTrack track in musicTracks)
                {
                    var media = axWindowsMediaPlayer1.newMedia(track.path);
                    playlist.appendItem(media);
                    axWindowsMediaPlayer1.currentPlaylist = playlist;
                }
            }

            musicPlayer.ShuffleTracks(playlist);
            updatePlaylist();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string selectedTitle = row.Cells["Title"].Value.ToString();
                MusicTrack selectedTrack = musicPlayer.FindTrackByTitle(selectedTitle);
                if (selectedTrack != null)
                {
                    var listBoxItem =listBoxPlaylist.FindString(selectedTitle);
                    if(listBoxItem != -1)
                    {//If track exists in playlist remove it
                        var remove = playlist.Item[listBoxItem];
                        playlist.removeItem(remove);
                        updatePlaylist();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//Edit track on DB
            musicPlayer.musicTracks = musicTracks;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int selectedIndex = selectedRow.Index;
                MusicTrack selectedTrack = musicPlayer.FindTrackByIndex(selectedIndex);
                if (selectedTrack != null)
                {
                    selectedTrack.title = selectedRow.Cells["Title"].Value.ToString();
                    selectedTrack.artist = selectedRow.Cells["Artist"].Value.ToString();
                    selectedTrack.genre = selectedRow.Cells["Genre"].Value.ToString();
                    selectedTrack.language = selectedRow.Cells["Language"].Value.ToString();

                    string yearCell = selectedRow.Cells["Year"].Value.ToString();
                    if (Int32.TryParse(yearCell, out Int32 year))
                        selectedTrack.year = year;

                    string countCell = selectedRow.Cells["Count"].Value.ToString();
                    if (Int32.TryParse(countCell, out Int32 count))
                        selectedTrack.count = count;

                    dbConnector.UpdateTrackToDataBase(selectedTrack);
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Track did not Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxPlaylist_DoubleClick(object sender, EventArgs e)
        {//Double click listBox Item to play song
            var selectedIndex = listBoxPlaylist.SelectedIndex;
            if (selectedIndex>=0 && selectedIndex<playlist.count)
            {
                axWindowsMediaPlayer1.Ctlcontrols.playItem(playlist.Item[selectedIndex]);
                
            }
        }
    }
}

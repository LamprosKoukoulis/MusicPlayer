using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayerApp
{
    public class MusicPlayer
    {
        public List<MusicTrack> musicTracks { get; set; }

        public MusicPlayer()
        {
            musicTracks = new List<MusicTrack>();
        }

        public void ShuffleTracks(IWMPPlaylist playlist)
        {
            Random random = new Random();
            List<IWMPMedia> tempList = new List<IWMPMedia>();

            for (int i = 0; i < playlist.count; i++)
            {
                tempList.Add(playlist.Item[i]);
            }

            int numberOfTracks = tempList.Count;
            while (numberOfTracks > 1)
            {
                int k = random.Next(0, numberOfTracks);
                numberOfTracks--;
                IWMPMedia temp = tempList[k];
                tempList[k] = tempList[numberOfTracks];
                tempList[numberOfTracks] = temp;
            }

            playlist.clear();

            foreach (IWMPMedia track in tempList)
            {
                playlist.appendItem(track);
            }
        }

        public MusicTrack FindTrackByTitle(string title)
        {
            return musicTracks.Find(track => track.title == title);
        }

        public MusicTrack FindTrackByIndex(int index)
        {
            return musicTracks.ElementAt(index);
        }
    }
}

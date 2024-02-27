using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public class DataBaseConnector
    {
        public const string connectionString = "Data source=..\\..\\TracksDB.db;Version=3";
        public const string createtable = @"Create Table If Not Exists Tracks(
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Title TEXT,
                                        Artist TEXT,
                                        Year INTEGER,
                                        Genre TEXT,
                                        Language TEXT,
                                        Count INTEGER,
                                        Path TEXT
                                        )";

        public void CreateIfNotExists()
        {
            ExecuteNonQuery(createtable);
        }
        
        //Method για την εκτέλεση εντολών Insert Update Delete
        public void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }        

        public void AddTrackToDataBase(MusicTrack track)
        {
            const string insertQuery = "Insert Into Tracks(" +
                "Title,Artist,Year,Genre,Language,Count,Path)" +
                "Values(@Title,@Artist,@Year,@Genre,@Language,@Count,@Path)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("Title", track.title);
                    command.Parameters.AddWithValue("Artist", track.artist);
                    command.Parameters.AddWithValue("Year", track.year);
                    command.Parameters.AddWithValue("Genre", track.genre);
                    command.Parameters.AddWithValue("Language", track.language);
                    command.Parameters.AddWithValue("Count", track.count);
                    command.Parameters.AddWithValue("Path", track.path);
                    //command.Parameters.AddWithValue("Music", File.ReadAllBytes(track.path));

                    command.ExecuteNonQuery();
                }
            }
            //MessageBox.Show("Added To Data Base", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateTrackToDataBase(MusicTrack track)
        {
            const string insertQuery = "UPDATE Tracks SET " +
                "Title=@Title," +
                "Artist=@Artist," +
                "Year=@Year," +
                "Genre=@Genre," +
                "Language=@Language," +
                "Count=@Count " +
                "WHERE Title=@Title";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("Title", track.title);
                    command.Parameters.AddWithValue("Artist", track.artist);
                    command.Parameters.AddWithValue("Year", track.year);
                    command.Parameters.AddWithValue("Genre", track.genre);
                    command.Parameters.AddWithValue("Language", track.language);
                    command.Parameters.AddWithValue("Count", track.count);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Track successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void updateTrackCount(string title, int count)
        {
            const string query = "UPDATE Tracks SET Count =@Count WHERE Title = @Title";
            using(SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using(SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count",count);
                    command.Parameters.AddWithValue("@Title",title);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable LoadTracks()
        {
            string selectQuery = "Select Title,Artist,Year,Genre,Language,Path,Count From Tracks";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

    
    }
}

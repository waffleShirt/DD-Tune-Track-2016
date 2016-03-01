using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite; 

namespace DD_Tune_Track
{
    class SQLiteDBTestDriver
    {
        public static void Execute()
        {
            // Create database
            SQLiteConnection.CreateFile("TestDB.sqlite");

            // Connection object
            SQLiteConnection mDBConnection;

            // Open Connection
            mDBConnection = new SQLiteConnection("Data Source=TestDB.sqlite;Version=3");
            mDBConnection.Open();

            // Create a table
            string sql = "CREATE TABLE highscores (name VARCHAR(20), score INT)";

            SQLiteCommand command = new SQLiteCommand(sql, mDBConnection);

            command.ExecuteNonQuery();

            // Write data into table
            sql = "insert into highscores (name, score) values ('Me', 3000)";
            command = new SQLiteCommand(sql, mDBConnection);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('Myself', 6000)";
            command = new SQLiteCommand(sql, mDBConnection);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('And I', 9001)";
            command = new SQLiteCommand(sql, mDBConnection);
            command.ExecuteNonQuery();

            // Read some data back from the database
            sql = "select * from highscores order by score desc";
            command = new SQLiteCommand(sql, mDBConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            sql = "select * from highscores order by score desc";
            command = new SQLiteCommand(sql, mDBConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
            }

            // Close Connection
            mDBConnection.Close(); 
        }

        public static void ExecuteDDTTDBCreationTest()
        {
            // Create database
            SQLiteConnection.CreateFile("DDTTTestDB.sqlite");

            // Connection object
            SQLiteConnection mDBConnection;

            // Open Connection
            mDBConnection = new SQLiteConnection("Data Source=TestDB.sqlite;Version=3");
            mDBConnection.Open();

            // Create summer tunes table
            string sql = "CREATE TABLE [Tunes Summer] (" +
                            "[Index]        INTEGER PRIMARY KEY AUTOINCREMENT, " +
                            "[Asset Number] TEXT(0) REFERENCES Bikes ([Asset Number]) " +
                            "               NOT NULL, " +
                            "[Tune Date]    DATE     NOT NULL, " +
                            "Tech           TEXT     REFERENCES Techs(Initial) " +
                            "               NOT NULL, " +
                            "[Parts Labour] TEXT, " +
                            "Notes          TEXT, " +
                            "[Charged By]   STRING   REFERENCES Techs(Initial) " +
                            "               NOT NULL, " +
                            "[Charge Date]  DATE     NOT NULL );";

            SQLiteCommand command = new SQLiteCommand(sql, mDBConnection);

            command.ExecuteNonQuery();

            mDBConnection.Close(); 
        }
    }
}

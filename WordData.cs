using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLearning
{
    public static class WordData
    {
        static string _FileName;
        static SqliteConnection db;
        static public SqliteCommand sql;
        static bool Opened = false;

        public static string FileName
        {
            set
            {
                _FileName = value;
            }
            get
            {
                return _FileName;
            }
        }

        public static void Connect()
        {
            if (Opened) db.Dispose();
            db = new SqliteConnection("Data Source=" + _FileName);
            db.Open();
            Opened = true;
            sql = db.CreateCommand();
            sql.CommandText = @"CREATE TABLE IF NOT EXISTS MAIN (
                ID INTEGER PRIMARY KEY,
                WORD TEXT,
                DESCRIPTION TEXT,
                FLAG INTEGER DEFAULT 0
            )";
            sql.ExecuteNonQuery();
        }

        public static void Add(string word, string des)
        {
            sql.CommandText = $"INSERT INTO MAIN (WORD, DESCRIPTION) VALUES ('{word}', '{des}')";
            sql.ExecuteNonQuery();
        }

        public static void Remove(string word, string des)
        {
            sql.CommandText = $"DELETE FROM MAIN WHERE WORD = '{word}' AND DESCRIPTION = '{des}'";
            sql.ExecuteNonQuery();
        }

        public static void Update(string word1, string des1, string word2, string des2)
        {
            sql.CommandText = $"UPDATE MAIN SET WORD = '{word2}', DESCRIPTION = '{des2}' WHERE WORD = '{word1}', DESCRIPTION = '{des1}'";
            sql.ExecuteNonQuery();
        }

        public static void Dispose()
        {
            db.Dispose();
        }
    }
}

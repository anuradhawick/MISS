using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MISS
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            /*
            Initiate the database connection or create a new database and connect with it
            */
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\Users\\anuradhawick\\Documents\\MISS_DB.sqlite;Version=3;");
                conn.Open();
            }
            catch (Exception ex)
            {
                SQLiteConnection.CreateFile("C:\\Users\\anuradhawick\\Documents\\MISS_DB.sqlite");
                Console.WriteLine("Created the DB");
            }

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Debtors : Form
    {
        string sessionValue;
        public Debtors(string sessionValue)
        {
            InitializeComponent();
            this.sessionValue = sessionValue;
            string query;
            DB db = new DB();
            DataSet set = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if(sessionValue != "Администратор")
            {
                label1.Text = "Задолженности " + sessionValue;
                query = "SELECT * FROM `debtors` WHERE `idDebtor` = @name";
            }
            else
            {
                label1.Text = "Все задолженности";
                query = "SELECT * FROM `debtors`";
            }
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = sessionValue;
            adapter.SelectCommand = command;
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

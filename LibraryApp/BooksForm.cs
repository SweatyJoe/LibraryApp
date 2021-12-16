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
    
    public partial class BooksForm : Form
    {
        string nameForm = "books";

        string sessionValue;
        public BooksForm(string sessionValue, string nameForm)
        {
            InitializeComponent();
            DB db = new DB();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `books` ", db.getConnection());

            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            //Обзор пользователей (admin)

            this.sessionValue = sessionValue;
            label1.Text = "Список книг";
            this.Text = "Обзор книг (" + sessionValue + ")";
            ErrorField.Text = "";
            this.nameForm = nameForm;
            errorText.Text = "";

            adminPanel.Hide();
            //combobox items
            if (sessionValue == "Администратор")
            {
                adminPanel.Show();
                comboBox2.Items.AddRange(new String[] { "Авторы", "Теги", "Должники", "Журналы", "Книги", "Издатели", "Пользователи", "Газеты" });
            }
            else
            {
                adminPanel.Hide();
                comboBox2.Items.AddRange(new String[] { "Авторы", "Теги", "Должники", "Журналы", "Книги", "Издатели", "Газеты" });
            }

            comboBox2.SelectedItem = "Книги";

            if(nameForm == "books")
            {
                nameLabel.Text = "Название Книги";
                label1.Text = "Список книг";
                this.Text = "Обзор книг (" + sessionValue + ")";

            }
            else if (nameForm == "newspapers")
            {
                nameLabel.Text = "Название газеты";
                label1.Text = "Список гизет";
                this.Text = "Обзор газет (" + sessionValue + ")";
            }
            else
            {
                nameLabel.Text = "Название журнала";
                label1.Text = "Список журналов";
                this.Text = "Обзор журналов (" + sessionValue + ")";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Close();
        }

        private void gotoButton_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Авторы":
                    {
                        MessageBox.Show("Авторы");
                        break;
                    }
                case "Теги":
                    {
                        Tags tg = new Tags(sessionValue);
                        tg.Show();
                        this.Hide();
                        break;
                    }
                case "Должники":
                    {
                        Debtors deb = new Debtors(sessionValue);
                        deb.Show();
                        this.Hide();
                        break;
                    }
                case "Журналы":
                    {
                        nameForm = "magazines";
                        label1.Text = "Список журналов";
                        this.Text = "Обзор журналов (" + sessionValue + ")";
                        DB db = new DB();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                        MySqlCommand command = new MySqlCommand("SELECT * FROM `magazines` ", db.getConnection());
                        dataAdapter.SelectCommand = command;
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables[0];
                        nameLabel.Text = "Название Журнала";
                        break;
                    }
                case "Книги":
                    {
                        nameForm = "books";
                        this.Text = "Обзор книг (" + sessionValue + ")";
                        DB db = new DB();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                        MySqlCommand command = new MySqlCommand("SELECT * FROM `books` ", db.getConnection());
                        dataAdapter.SelectCommand = command;
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables[0];
                        nameLabel.Text = "Название Книги";
                        label1.Text = "Список книг";
                        break;
                    }
                case "Издатели":
                    {
                        
                        break;
                    }
                case "Пользователи":
                    {
                        
                        break;
                    }
                case "Газеты":
                    {
                        nameForm = "newspapers";
                        label1.Text = "Список газет";
                        this.Text = "Обзор газет (" + sessionValue + ")";
                        DB db = new DB();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                        MySqlCommand command = new MySqlCommand("SELECT * FROM `newspapers` ", db.getConnection());
                        dataAdapter.SelectCommand = command;
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables[0];
                        nameLabel.Text = "Название журнала";
                        break;
                    }
                default: break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            string query = "SELECT * FROM `"+nameForm+"` WHERE ";
            if (autorBox.Text != "")
                query +="`autor` LIKE '"+ autorBox.Text+"',";
            if (nameBox.Text != "")
                query+= " `bookName` LIKE '"+nameBox.Text+"',";
            if (publushBox.Text != "")
                query += " `publishers` LIKE '"+publushBox.Text+"',";


            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            adapter.SelectCommand = command;
            DataSet set = new DataSet();
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM @nameF ", db.getConnection());
            command.Parameters.Add("@nameF", MySqlDbType.VarChar).Value = nameForm;

            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            autorBox.Text = "";
            nameBox.Text = "";
            publushBox.Text = "";
            date1Box.Text = "";
            date1Box.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string autor = autorText.Text;
            string pub = publText.Text;
            string year = yearText.Text;
            string tag = tagText.Text;

            if (name == "")
            {
                errorText.ForeColor = Color.Red;
                errorText.Text = "Не введено имя";
            }
            else
            {
                if (autor != "") autor = "'" + autor + "'";
                else autor = "NULL";

                if (pub != "") pub = "'" + pub + "'";
                else pub = "NULL";

                if (year != "") year = "'" + year + "'";
                else year = "NULL";

                if (tag != "") tag = "'" + tag + "'";
                else tag = "NULL";

                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO `@nameForm` VALUES (NULL, @name, @autor, @bup, @date, @tag", db.getConnection());
                command.Parameters.Add("@nameForm", MySqlDbType.VarChar).Value = nameForm;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@autor", MySqlDbType.VarChar).Value = autor;
                command.Parameters.Add("@bup", MySqlDbType.VarChar).Value = pub;
                command.Parameters.Add("@date", MySqlDbType.Int32).Value = year;
                command.Parameters.Add("@tag", MySqlDbType.VarChar).Value = tag;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    errorText.Text = "Пользователь добавлен";
                    errorText.ForeColor = Color.Green;
                }
                else
                {
                    errorText.Text = "Ошибка добавления";
                    errorText.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            if (dataGridView1.RowCount >= 2)
            {
                index = dataGridView1.CurrentRow.Index;
                if (index == dataGridView1.RowCount - 1)
                {
                    errorText.ForeColor = Color.Red;
                    errorText.Text = "строка не выделена";
                    return;
                }
                nameText.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
                autorText.Text = (string)dataGridView1.Rows[index].Cells[2].Value.ToString();
                publText.Text = (string)dataGridView1.Rows[index].Cells[3].Value.ToString();
                yearText.Text = (string)dataGridView1.Rows[index].Cells[4].Value.ToString();
                tagText.Text = (string)dataGridView1.Rows[index].Cells[5].Value.ToString();
            }
            else errorText.Text = "Ошибка в распозновании таблицы";
        }
    }
}

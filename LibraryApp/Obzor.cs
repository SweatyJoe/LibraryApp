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
    public partial class Obzor : Form
    {
        string sessionValue = "";
        public Obzor(string sessionValue)
        {
            InitializeComponent();

            DB db = new DB();
            

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` ", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `reader_card`", db.getConnection());

            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            DataSet dataSet2 = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            dataAdapter.SelectCommand = command2;
            dataAdapter.Fill(dataSet2);
            dataGridView3.DataSource = dataSet2.Tables[0];
            
            dataGridView1.Columns[1].Width = 250;

            //add items combobox
            comboBox2.Items.AddRange(new String[] { "Авторы", "Теги", "Должники", "Журналы", "Книги", "Издатели", "Пользователи"});
            comboBox2.SelectedItem = "Авторы"; //def item (иначе можно случайно нажать на кнопку перехода и крашнуть прогу)

            //Обзор пользователей (admin)
            this.sessionValue = sessionValue;

            this.Text = "Обзор пользователей("+ sessionValue + ")";

            error1.Text = "";
            error2.Text = "";
        }
        private void gotoButton_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();
            string nameForm;
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
                        BooksForm dk = new BooksForm(sessionValue, nameForm);
                        dk.Show();
                        this.Hide();
                        break;
                    }
                case "Книги":
                    {
                        nameForm = "books";
                        BooksForm book = new BooksForm(sessionValue, nameForm);
                        this.Close();
                        book.Show();
                        break;
                    }
                case "Издатели":
                    {
                        MessageBox.Show("Издатели");
                        break;
                    }
                case "Пользователи":
                    {
                        MessageBox.Show("Вы уже здесь");
                        break;
                    }
                case "Газеты":
                    {
                        nameForm = "newspapers";
                        BooksForm dk = new BooksForm(sessionValue, nameForm);
                        dk.Show();
                        this.Hide();
                        break;
                    }
                default: break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            error1.Text = "";
            error2.Text = "";
            this.Close();
            Form1 for1 = new Form1();
            for1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            error1.Text = "";
            error2.Text = "";
            string addNewUser = addFioUser.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            DataSet set = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand commandserch = new MySqlCommand("SELECT * FROM `users` WHERE `FIO` = @insertValue", db.getConnection());

            commandserch.Parameters.Add("@insertValue", MySqlDbType.VarChar).Value = addNewUser;
            db.openConnection();
            adapter.SelectCommand = commandserch;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`idUser`, `FIO`) VALUES (NULL, @insertValue) ", db.getConnection());
                command.Parameters.Add("@insertValue", MySqlDbType.VarChar).Value = addNewUser;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    error1.Text = "Пользователь добавлен";
                    error1.ForeColor = Color.Green;
                }
                else
                {
                    error1.Text = "Ошибка добавления";
                    error1.ForeColor = Color.Red;
                }
                   
            }
            else error1.Text = "Данный пользователь уже существует в базе";

            db.closeConnection();
            MySqlCommand commandreset = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
            adapter.SelectCommand = commandreset;
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            error1.Text = "";
            error2.Text = "";
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    DB db = new DB();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand commandInsert = new MySqlCommand("INSERT INTO `reader_card` (`idCard`,`FIO`,`telNumber`) VALUES (null, @tb, @numb)", db.getConnection());
                    commandInsert.Parameters.Add("@tb", MySqlDbType.VarChar).Value = textBox3.Text;
                    commandInsert.Parameters.Add("@numb", MySqlDbType.VarChar).Value = textBox2.Text;
                    db.openConnection();
                    adapter.SelectCommand = commandInsert;
                    if (commandInsert.ExecuteNonQuery() == 1) //если что, это метод который обычно возвращает количество обработанных строк
                    {
                        MessageBox.Show("Поле успешно добавлено!");
                        DataSet set = new DataSet();
                        MySqlCommand cmdUpdate = new MySqlCommand("SELECT * FROM `reader_card`", db.getConnection());
                        adapter.SelectCommand = cmdUpdate;
                        adapter.Fill(set);
                        dataGridView3.DataSource = set.Tables[0];
                        db.closeConnection();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления!");
                        db.closeConnection();
                    }
                }
                else error2.Text = "не заполнено поле \"Телефон пользователя\"";
            }
            else error2.Text = "Не заполнено поле \"ФИО\"";  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            if (dataGridView1.RowCount >= 2)
            {
                index = dataGridView1.CurrentRow.Index;
                if (index == dataGridView1.RowCount - 1)
                {
                    error2.Text = "строка не выделена";
                    error2.ForeColor = Color.Red;
                    return;
                }
                textBox1.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
                textBox3.Text = (string)dataGridView1.Rows[index].Cells[0].Value.ToString();
            }
            else
            {
                error2.Text = "Ошибка в распозновании таблицы";
                error2.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            error1.Text = "";
            error2.Text = "";
            DB bd = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `idUser` = @id", bd.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox4.Text;
            adapter.SelectCommand = command;
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Удаление успешно!");
                MySqlCommand cmdUpdate = new MySqlCommand("SELECT * FROM `users`", bd.getConnection());
                adapter.SelectCommand = cmdUpdate;
                DataSet set = new DataSet();
                adapter.Fill(set);
                dataGridView1.DataSource = set.Tables[0];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            error1.Text = "";
            error2.Text = "";
            DB bd = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM `reader_card` WHERE `idCard` = @id", bd.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox3.Text;
            adapter.SelectCommand = command;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Удаление успешно!");
                MySqlCommand cmdUpdate = new MySqlCommand("SELECT * FROM `reader_card`", bd.getConnection());
                adapter.SelectCommand = cmdUpdate;
                DataSet set = new DataSet();
                adapter.Fill(set);
                dataGridView3.DataSource = set.Tables[0];
            }
        }
    }
}

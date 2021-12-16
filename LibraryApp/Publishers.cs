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
    public partial class Publishers : Form
    {
        string sessionValue;
        public Publishers(string sessionValue)
        {
            InitializeComponent();
            this.sessionValue = sessionValue;

            DB db = new DB();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `publishers` ", db.getConnection());
            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            this.sessionValue = sessionValue;
            errorText.Text = "";
            this.Text = "Тэги (" + sessionValue + ")";
            comboBox2.SelectedItem = "Книги";

            if (sessionValue == "Администратор")
            {
                this.Width = 766;
                panel1.Show();
                comboBox2.Items.AddRange(new String[] { "Авторы", "Теги", "Должники", "Журналы", "Книги", "Издатели", "Пользователи", "Газеты" });
            }
            else
            {
                this.Width = 363;
                panel1.Hide();
                comboBox2.Items.AddRange(new String[] { "Авторы", "Теги", "Должники", "Журналы", "Книги", "Издатели", "Газеты" });
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            if (dataGridView1.RowCount >= 2)
            {
                index = dataGridView1.CurrentRow.Index;
                if (index == dataGridView1.RowCount - 1)
                {
                    errorText.Text = "строка не выделена";
                    errorText.ForeColor = Color.Red;
                    return;
                }
                textBox1.Text = (string)dataGridView1.Rows[index].Cells[1].Value;
                textBox2.Text = (string)dataGridView1.Rows[index].Cells[1].Value;

                idText.Text = (string)dataGridView1.Rows[index].Cells[0].Value.ToString();
            }
            else
            {
                errorText.Text = "Ошибка в распозновании таблицы";
                errorText.ForeColor = Color.Red;
            }
        }

        private void gotoButton_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();
            string nameForm;
            switch (selectedItem)
            {
                case "Авторы":
                    {

                        break;
                    }
                case "Теги":
                    {
                        MessageBox.Show("Вы уже здесь!");
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
                        BooksForm bk = new BooksForm(sessionValue, nameForm);
                        bk.Show();
                        this.Hide();
                        break;
                    }
                case "Книги":
                    {
                        nameForm = "books";
                        BooksForm bk = new BooksForm(sessionValue, nameForm);
                        bk.Show();
                        this.Hide();
                        break;
                    }
                case "Издатели":
                    {

                        break;
                    }
                case "Пользователи":
                    {
                        Obzor ob = new Obzor(sessionValue);
                        ob.Show();
                        this.Hide();
                        break;
                    }
                case "Газеты":
                    {
                        nameForm = "newspapers";
                        BooksForm bk = new BooksForm(sessionValue, nameForm);
                        bk.Show();
                        this.Hide();
                        break;
                    }
                default: break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = idText.Text;
            int intId = Convert.ToInt32(id);
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `publishers` SET `idPublisher`=@item, `publisher`=@item2 WHERE `publisher`=@item1", db.getConnection());
            command.Parameters.Add("@item", MySqlDbType.VarChar).Value = intId;
            command.Parameters.Add("@item1", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@item2", MySqlDbType.VarChar).Value = textBox4.Text;
            db.openConnection();
            adapter.InsertCommand = command;
            if (command.ExecuteNonQuery() == 1)
            {
                errorText.Text = "Тэг изменён успешно";
                errorText.ForeColor = Color.Green;
            }
            else
            {
                errorText.Text = "Ошибка изменения";
                errorText.ForeColor = Color.Red;
            }
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `publishers` ", db.getConnection());
            adapter.SelectCommand = command1;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM `publishers` WHERE `publisher` = @item", db.getConnection());
            command.Parameters.Add("@item", MySqlDbType.VarChar).Value = textBox1.Text;
            db.openConnection();
            adapter.InsertCommand = command;
            if (command.ExecuteNonQuery() == 1)
            {
                errorText.Text = "Издатель удалён успешно";
                errorText.ForeColor = Color.Green;
            }
            else
            {
                errorText.Text = "Ошибка удаления";
                errorText.ForeColor = Color.Red;
            }
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `publishers` ", db.getConnection());
            adapter.SelectCommand = command1;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `publishers` VALUES (NULL, @item)", db.getConnection());
            command.Parameters.Add("@item", MySqlDbType.VarChar).Value = textBox3.Text;
            db.openConnection();
            adapter.InsertCommand = command;
            if (command.ExecuteNonQuery() == 1)
            {
                errorText.Text = "Тэг изменён успешно";
                errorText.ForeColor = Color.Green;
            }
            else
            {
                errorText.Text = "Ошибка изменения";
                errorText.ForeColor = Color.Red;
            }
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `publishers` ", db.getConnection());
            adapter.SelectCommand = command1;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            db.closeConnection();
        }
    }
}

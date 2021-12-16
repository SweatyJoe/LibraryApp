using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        string sessionValue = "UserDefault"; //����� ��� �� ������. �������

        public Form1()
        {
            InitializeComponent();
            groupBox2.Hide();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Hide();
                groupBox2.Show();
                button1.Text = "����� ��� �������������";
                uppertext.Text = "�� �������������?";
            }
            else
            {
                groupBox1.Show();
                groupBox2.Hide();
                button1.Text = "����� ��� ������������";
                uppertext.Text = "��������� ��� ��� ��� ����?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin"){
                if (textBox2.Text == "admin")
                {
                    sessionValue = "�������������";
                    this.Hide();
                    Obzor obzor = new Obzor(sessionValue);
                    obzor.Show();
                }
                else 
                    errorlabel.Text = "�� ������ ������!"; 
            }
            else
                errorlabel.Text = "�� ������ �����";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String newuser = userName.Text;
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `FIO` = @zz", db.getConnection());
            command.Parameters.Add("@zz", MySqlDbType.VarChar).Value = newuser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0)
            {
                sessionValue = newuser;
            }
            else
            {
                sessionValue = newuser;
                MySqlCommand command1 = new MySqlCommand("INSERT INTO `users` (`idUser`, `FIO`) VALUES (NULL, @name)", db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = newuser;
                adapter.SelectCommand = command1;
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("�� ��������� � ����. ������ ��������.");
                }
                else
                {
                    MessageBox.Show("������ ����������. ����������� ���������� �� ���������.");
                }
            }
            BooksForm bkf = new BooksForm(sessionValue, "books");
            bkf.Show();
            this.Hide();
        }  
    }
}
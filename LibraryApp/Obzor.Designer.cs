namespace LibraryApp
{
    partial class Obzor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obzor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addFioUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gotoButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(428, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Все текущие пользователи";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(482, 38);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(603, 305);
            this.dataGridView3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(482, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пользователи с читательским билетом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Добавить читательский билет для пользователя";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(404, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addFioUser
            // 
            this.addFioUser.Location = new System.Drawing.Point(171, 33);
            this.addFioUser.Name = "addFioUser";
            this.addFioUser.Size = new System.Drawing.Size(142, 23);
            this.addFioUser.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Добавить пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "ФИО пользователя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "ФИО пользователя";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 23);
            this.textBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(284, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Телефон пользователя";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.error2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(482, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 176);
            this.panel1.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(5, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(37, 23);
            this.textBox3.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Выберите из соседней таблицы";
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(69, 127);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(84, 15);
            this.error2.TabIndex = 14;
            this.error2.Text = "Поле ошибки";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.error1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addFioUser);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 176);
            this.panel2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Удалить пользователя";
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(324, 8);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(84, 15);
            this.error1.TabIndex = 15;
            this.error1.Text = "Поле ошибки";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(350, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gotoButton
            // 
            this.gotoButton.Location = new System.Drawing.Point(970, 404);
            this.gotoButton.Name = "gotoButton";
            this.gotoButton.Size = new System.Drawing.Size(121, 23);
            this.gotoButton.TabIndex = 16;
            this.gotoButton.Text = "Перейти";
            this.gotoButton.UseVisualStyleBackColor = true;
            this.gotoButton.Click += new System.EventHandler(this.gotoButton_Click);
            // 
            // canselButton
            // 
            this.canselButton.Location = new System.Drawing.Point(971, 450);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(122, 23);
            this.canselButton.TabIndex = 18;
            this.canselButton.Text = "Выйти в начало";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.canselButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(971, 512);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 44);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Закрыть программу";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Книги";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(970, 375);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "Книги";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(37, 23);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(166, 23);
            this.textBox5.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(353, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(323, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Obzor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1096, 568);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.gotoButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Obzor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обзор пользователей (admin)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox addFioUser;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Panel panel1;
        private Label error2;
        private Panel panel2;
        private Label error1;
        private Button button2;
        private Button gotoButton;
        private Button canselButton;
        private Button exitButton;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button4;
    }
}
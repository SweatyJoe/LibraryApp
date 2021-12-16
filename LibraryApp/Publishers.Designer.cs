namespace LibraryApp
{
    partial class Publishers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.gotoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(330, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Книги";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 331);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 32;
            this.comboBox2.ValueMember = "Книги";
            // 
            // exitButton
            // 
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(222, 368);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 44);
            this.exitButton.TabIndex = 31;
            this.exitButton.Text = "Закрыть программу";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // canselButton
            // 
            this.canselButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.canselButton.Location = new System.Drawing.Point(220, 330);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(122, 23);
            this.canselButton.TabIndex = 30;
            this.canselButton.Text = "Выйти в начало";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.canselButton_Click);
            // 
            // gotoButton
            // 
            this.gotoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gotoButton.Location = new System.Drawing.Point(12, 360);
            this.gotoButton.Name = "gotoButton";
            this.gotoButton.Size = new System.Drawing.Size(121, 23);
            this.gotoButton.TabIndex = 29;
            this.gotoButton.Text = "Перейти";
            this.gotoButton.UseVisualStyleBackColor = true;
            this.gotoButton.Click += new System.EventHandler(this.gotoButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.idText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.errorText);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(348, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 313);
            this.panel1.TabIndex = 33;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(6, 256);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(23, 23);
            this.idText.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(162, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "на поле:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 23);
            this.textBox4.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(29, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "изменить поле";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 23);
            this.textBox3.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(300, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(252, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(127, 23);
            this.textBox2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Изменение";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorText.Location = new System.Drawing.Point(15, 292);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(38, 15);
            this.errorText.TabIndex = 22;
            this.errorText.Text = "label5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(72, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "- для удаление выберите значение в таблице";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Удаление";
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(162, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название тега";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Добавление";
            // 
            // Publishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(742, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.gotoButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Publishers";
            this.Text = "Publishers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Button exitButton;
        private Button canselButton;
        private Button gotoButton;
        private Panel panel1;
        private TextBox idText;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Button button3;
        private Button button2;
        private TextBox textBox2;
        private Label label5;
        private Label errorText;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}
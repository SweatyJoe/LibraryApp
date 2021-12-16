namespace LibraryApp
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.tagText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.publText = new System.Windows.Forms.TextBox();
            this.autorText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.gotoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.autorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.ErrorField = new System.Windows.Forms.Label();
            this.date2Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date1Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.publushBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(8, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(920, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.adminPanel.Controls.Add(this.comboBox1);
            this.adminPanel.Controls.Add(this.label14);
            this.adminPanel.Controls.Add(this.errorText);
            this.adminPanel.Controls.Add(this.tagText);
            this.adminPanel.Controls.Add(this.label13);
            this.adminPanel.Controls.Add(this.label12);
            this.adminPanel.Controls.Add(this.yearText);
            this.adminPanel.Controls.Add(this.publText);
            this.adminPanel.Controls.Add(this.autorText);
            this.adminPanel.Controls.Add(this.label11);
            this.adminPanel.Controls.Add(this.label10);
            this.adminPanel.Controls.Add(this.nameLabel);
            this.adminPanel.Controls.Add(this.addButton);
            this.adminPanel.Controls.Add(this.label9);
            this.adminPanel.Controls.Add(this.nameText);
            this.adminPanel.Location = new System.Drawing.Point(8, 303);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(431, 203);
            this.adminPanel.TabIndex = 1;
            this.adminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(127, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "- для этого выберите поле в таблице выше";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(132, 34);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(61, 17);
            this.errorText.TabIndex = 14;
            this.errorText.Text = "errorText";
            // 
            // tagText
            // 
            this.tagText.Location = new System.Drawing.Point(96, 172);
            this.tagText.Name = "tagText";
            this.tagText.Size = new System.Drawing.Size(135, 23);
            this.tagText.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Тэг";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Год издания";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(96, 143);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(135, 23);
            this.yearText.TabIndex = 8;
            // 
            // publText
            // 
            this.publText.Location = new System.Drawing.Point(96, 114);
            this.publText.Name = "publText";
            this.publText.Size = new System.Drawing.Size(190, 23);
            this.publText.TabIndex = 7;
            // 
            // autorText
            // 
            this.autorText.Location = new System.Drawing.Point(96, 85);
            this.autorText.Name = "autorText";
            this.autorText.Size = new System.Drawing.Size(190, 23);
            this.autorText.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Издатель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Автор";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 15);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Название книги";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(343, 159);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(4, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Изменение";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(17, 57);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(386, 23);
            this.nameText.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Книги";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(811, 325);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "Книги";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(812, 462);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 44);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Закрыть программу";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // canselButton
            // 
            this.canselButton.Location = new System.Drawing.Point(812, 400);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(122, 23);
            this.canselButton.TabIndex = 22;
            this.canselButton.Text = "Выйти в начало";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.canselButton_Click);
            // 
            // gotoButton
            // 
            this.gotoButton.Location = new System.Drawing.Point(811, 354);
            this.gotoButton.Name = "gotoButton";
            this.gotoButton.Size = new System.Drawing.Size(121, 23);
            this.gotoButton.TabIndex = 21;
            this.gotoButton.Text = "Перейти";
            this.gotoButton.UseVisualStyleBackColor = true;
            this.gotoButton.Click += new System.EventHandler(this.gotoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Список книг";
            // 
            // autorBox
            // 
            this.autorBox.Location = new System.Drawing.Point(23, 65);
            this.autorBox.Name = "autorBox";
            this.autorBox.Size = new System.Drawing.Size(100, 23);
            this.autorBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Поиск";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.ErrorField);
            this.panel1.Controls.Add(this.date2Box);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.date1Box);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.publushBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.autorBox);
            this.panel1.Location = new System.Drawing.Point(459, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 203);
            this.panel1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Gainsboro;
            this.searchButton.FlatAppearance.BorderSize = 4;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(260, 159);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 34);
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ErrorField
            // 
            this.ErrorField.AutoSize = true;
            this.ErrorField.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ErrorField.ForeColor = System.Drawing.Color.Red;
            this.ErrorField.Location = new System.Drawing.Point(176, 14);
            this.ErrorField.Name = "ErrorField";
            this.ErrorField.Size = new System.Drawing.Size(57, 15);
            this.ErrorField.TabIndex = 38;
            this.ErrorField.Text = "ErrorField";
            // 
            // date2Box
            // 
            this.date2Box.Location = new System.Drawing.Point(265, 123);
            this.date2Box.Name = "date2Box";
            this.date2Box.Size = new System.Drawing.Size(70, 23);
            this.date2Box.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "до";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "от";
            // 
            // date1Box
            // 
            this.date1Box.Location = new System.Drawing.Point(167, 123);
            this.date1Box.Name = "date1Box";
            this.date1Box.Size = new System.Drawing.Size(66, 23);
            this.date1Box.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "По году издания";
            // 
            // publushBox
            // 
            this.publushBox.Location = new System.Drawing.Point(23, 123);
            this.publushBox.Name = "publushBox";
            this.publushBox.Size = new System.Drawing.Size(100, 23);
            this.publushBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "По издателю";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(136, 65);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(185, 23);
            this.nameBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "По названию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "По автору";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(940, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.gotoButton);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel adminPanel;
        private ComboBox comboBox2;
        private Button exitButton;
        private Button canselButton;
        private Button gotoButton;
        private TextBox nameText;
        private Label label1;
        private TextBox autorBox;
        private Label label2;
        private Panel panel1;
        private Label ErrorField;
        private TextBox date2Box;
        private Label label8;
        private Label label7;
        private TextBox date1Box;
        private Label label6;
        private TextBox publushBox;
        private Label label5;
        private TextBox nameBox;
        private Label label4;
        private Label label3;
        private Button searchButton;
        private Button button1;
        private Label label9;
        private TextBox tagText;
        private Label label13;
        private Label label12;
        private TextBox yearText;
        private TextBox publText;
        private TextBox autorText;
        private Label label11;
        private Label label10;
        private Label nameLabel;
        private Button addButton;
        private Label errorText;
        private Label label14;
        private ComboBox comboBox1;
    }
}
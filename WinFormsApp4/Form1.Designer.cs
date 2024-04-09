namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            ChangeButton = new Button();
            AddButton = new Button();
            NameBox = new TextBox();
            SurnameBox = new TextBox();
            EmailBox = new TextBox();
            PhoneBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FileBox = new TextBox();
            LoadButton = new Button();
            SaveButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(367, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 274);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChangeButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(NameBox);
            groupBox1.Controls.Add(SurnameBox);
            groupBox1.Controls.Add(EmailBox);
            groupBox1.Controls.Add(PhoneBox);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 333);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(249, 251);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(75, 40);
            ChangeButton.TabIndex = 5;
            ChangeButton.Text = "Dəyiş";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(249, 297);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 30);
            AddButton.TabIndex = 6;
            AddButton.Text = "Əlavə et";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(79, 19);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Name";
            NameBox.Size = new Size(200, 23);
            NameBox.TabIndex = 2;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(79, 67);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.PlaceholderText = "Surname";
            SurnameBox.Size = new Size(200, 23);
            SurnameBox.TabIndex = 3;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(79, 110);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.Size = new Size(200, 23);
            EmailBox.TabIndex = 4;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(79, 153);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.PlaceholderText = "Telefon";
            PhoneBox.Size = new Size(200, 23);
            PhoneBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(79, 202);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 202);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 6;
            label5.Text = "Doğum";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 2;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 3;
            label2.Text = "SoyAd";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 108);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 155);
            label4.Name = "label4";
            label4.Size = new Size(32, 21);
            label4.TabIndex = 5;
            label4.Text = "Tel";
            // 
            // FileBox
            // 
            FileBox.Location = new Point(367, 311);
            FileBox.Name = "FileBox";
            FileBox.PlaceholderText = "FileName";
            FileBox.Size = new Size(172, 23);
            FileBox.TabIndex = 2;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(367, 340);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 27);
            LoadButton.TabIndex = 3;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(448, 340);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(91, 27);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 387);
            Controls.Add(SaveButton);
            Controls.Add(LoadButton);
            Controls.Add(FileBox);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameBox;
        private TextBox SurnameBox;
        private TextBox EmailBox;
        private TextBox PhoneBox;
        private DateTimePicker dateTimePicker1;
        private Button AddButton;
        private TextBox FileBox;
        private Button LoadButton;
        private Button SaveButton;
        private Button ChangeButton;
    }
}
namespace TodoListApp
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
            Label label1;
            listBox1 = new ListBox();
            panel1 = new Panel();
            btnCancel = new Button();
            rbStatus2 = new RadioButton();
            rbStatus1 = new RadioButton();
            rbStatus0 = new RadioButton();
            pictureBox1 = new PictureBox();
            dtPickerDue = new DateTimePicker();
            btnDelete = new Button();
            btnModify = new Button();
            btnAdd = new Button();
            label5 = new Label();
            tbCreatedDate = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbDesc = new TextBox();
            tbTitle = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 72);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 41);
            label1.TabIndex = 0;
            label1.Text = "標題";
            // 
            // listBox1
            // 
            listBox1.DisplayMember = "Description";
            listBox1.Dock = DockStyle.Left;
            listBox1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            listBox1.Location = new Point(16, 15);
            listBox1.Margin = new Padding(5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(350, 566);
            listBox1.TabIndex = 0;
            listBox1.ValueMember = "Description";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(rbStatus2);
            panel1.Controls.Add(rbStatus1);
            panel1.Controls.Add(rbStatus0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dtPickerDue);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnModify);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbCreatedDate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbDesc);
            panel1.Controls.Add(tbTitle);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(366, 15);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 566);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(613, 446);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 69);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbStatus2
            // 
            rbStatus2.AutoSize = true;
            rbStatus2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            rbStatus2.Location = new Point(649, 354);
            rbStatus2.Margin = new Padding(5);
            rbStatus2.Name = "rbStatus2";
            rbStatus2.Size = new Size(139, 45);
            rbStatus2.TabIndex = 18;
            rbStatus2.Text = "已取消";
            rbStatus2.UseVisualStyleBackColor = true;
            // 
            // rbStatus1
            // 
            rbStatus1.AutoSize = true;
            rbStatus1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            rbStatus1.Location = new Point(435, 354);
            rbStatus1.Margin = new Padding(5);
            rbStatus1.Name = "rbStatus1";
            rbStatus1.Size = new Size(139, 45);
            rbStatus1.TabIndex = 17;
            rbStatus1.Text = "已完成";
            rbStatus1.UseVisualStyleBackColor = true;
            // 
            // rbStatus0
            // 
            rbStatus0.AutoSize = true;
            rbStatus0.Checked = true;
            rbStatus0.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            rbStatus0.Location = new Point(239, 354);
            rbStatus0.Margin = new Padding(5);
            rbStatus0.Name = "rbStatus0";
            rbStatus0.Size = new Size(139, 45);
            rbStatus0.TabIndex = 16;
            rbStatus0.TabStop = true;
            rbStatus0.Text = "未完成";
            rbStatus0.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.check_list;
            pictureBox1.Location = new Point(833, 72);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dtPickerDue
            // 
            dtPickerDue.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dtPickerDue.Location = new Point(239, 282);
            dtPickerDue.Margin = new Padding(5);
            dtPickerDue.Name = "dtPickerDue";
            dtPickerDue.Size = new Size(559, 48);
            dtPickerDue.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(437, 446);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 69);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnModify.Location = new Point(239, 446);
            btnModify.Margin = new Padding(5);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(189, 69);
            btnModify.TabIndex = 11;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(33, 446);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 69);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(141, 354);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 41);
            label5.TabIndex = 8;
            label5.Text = "狀態";
            // 
            // tbCreatedDate
            // 
            tbCreatedDate.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbCreatedDate.Location = new Point(239, 209);
            tbCreatedDate.Margin = new Padding(5);
            tbCreatedDate.Name = "tbCreatedDate";
            tbCreatedDate.ReadOnly = true;
            tbCreatedDate.Size = new Size(559, 48);
            tbCreatedDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 282);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 41);
            label4.TabIndex = 5;
            label4.Text = "完成日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 219);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 4;
            label3.Text = "創建日期";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 147);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 3;
            label2.Text = "說明";
            // 
            // tbDesc
            // 
            tbDesc.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbDesc.Location = new Point(239, 136);
            tbDesc.Margin = new Padding(5);
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(559, 48);
            tbDesc.TabIndex = 2;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(239, 72);
            tbTitle.Margin = new Padding(5);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(559, 48);
            tbTitle.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 596);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5);
            Name = "Form1";
            Padding = new Padding(16, 15, 16, 15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TODO List 管理系統, Author: 翁欣惠";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panel1;
        private Button btnDelete;
        private Button btnModify;
        private Button btnAdd;
        private Label label5;
        private TextBox tbCreatedDate;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbDesc;
        private TextBox tbTitle;
        private Label label1;
        private DateTimePicker dtPickerDue;
        private PictureBox pictureBox1;
        private RadioButton rbStatus2;
        private RadioButton rbStatus1;
        private RadioButton rbStatus0;
        private Button btnCancel;
    }
}

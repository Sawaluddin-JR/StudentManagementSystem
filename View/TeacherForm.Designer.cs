namespace StudentManagementSystem.View
{
    partial class TeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridView_addTeacher = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_lastEduc = new System.Windows.Forms.ComboBox();
            this.button_clearReg = new System.Windows.Forms.Button();
            this.button_addReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_woman = new System.Windows.Forms.RadioButton();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_phoneReg = new System.Windows.Forms.TextBox();
            this.textBox_lastnameReg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_nispReg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_addressReg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_firstnameReg = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_addTeacher)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkBlue;
            this.panel4.Location = new System.Drawing.Point(11, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 8);
            this.panel4.TabIndex = 88;
            // 
            // DataGridView_addTeacher
            // 
            this.DataGridView_addTeacher.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_addTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_addTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_addTeacher.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_addTeacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_addTeacher.ColumnHeadersHeight = 40;
            this.DataGridView_addTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_addTeacher.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_addTeacher.GridColor = System.Drawing.Color.Olive;
            this.DataGridView_addTeacher.Location = new System.Drawing.Point(12, 78);
            this.DataGridView_addTeacher.Name = "DataGridView_addTeacher";
            this.DataGridView_addTeacher.RowHeadersVisible = false;
            this.DataGridView_addTeacher.RowHeadersWidth = 50;
            this.DataGridView_addTeacher.RowTemplate.Height = 80;
            this.DataGridView_addTeacher.Size = new System.Drawing.Size(1024, 409);
            this.DataGridView_addTeacher.TabIndex = 87;
            this.DataGridView_addTeacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_addTeacher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_addTeacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_addTeacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_addTeacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_addTeacher.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_addTeacher.ThemeStyle.GridColor = System.Drawing.Color.Olive;
            this.DataGridView_addTeacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_addTeacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_addTeacher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_addTeacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_addTeacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_addTeacher.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridView_addTeacher.ThemeStyle.ReadOnly = false;
            this.DataGridView_addTeacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_addTeacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_addTeacher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_addTeacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_addTeacher.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_addTeacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_addTeacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkBlue;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1048, 72);
            this.panel5.TabIndex = 86;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(397, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Teacher Registration";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_lastEduc);
            this.panel1.Controls.Add(this.button_clearReg);
            this.panel1.Controls.Add(this.button_addReg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton_woman);
            this.panel1.Controls.Add(this.radioButton_man);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox_phoneReg);
            this.panel1.Controls.Add(this.textBox_lastnameReg);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBox_nispReg);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_addressReg);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dateTimePicker_date);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox_firstnameReg);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 311);
            this.panel1.TabIndex = 89;
            // 
            // comboBox_lastEduc
            // 
            this.comboBox_lastEduc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lastEduc.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_lastEduc.FormattingEnabled = true;
            this.comboBox_lastEduc.Items.AddRange(new object[] {
            "S2",
            "S1",
            "D3"});
            this.comboBox_lastEduc.Location = new System.Drawing.Point(237, 219);
            this.comboBox_lastEduc.Name = "comboBox_lastEduc";
            this.comboBox_lastEduc.Size = new System.Drawing.Size(136, 27);
            this.comboBox_lastEduc.TabIndex = 125;
            // 
            // button_clearReg
            // 
            this.button_clearReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearReg.BackColor = System.Drawing.Color.DarkOrange;
            this.button_clearReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearReg.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clearReg.ForeColor = System.Drawing.Color.White;
            this.button_clearReg.Location = new System.Drawing.Point(731, 258);
            this.button_clearReg.Name = "button_clearReg";
            this.button_clearReg.Size = new System.Drawing.Size(118, 41);
            this.button_clearReg.TabIndex = 124;
            this.button_clearReg.Text = "Clear";
            this.button_clearReg.UseVisualStyleBackColor = false;
            this.button_clearReg.Click += new System.EventHandler(this.button_clearReg_Click);
            // 
            // button_addReg
            // 
            this.button_addReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addReg.BackColor = System.Drawing.Color.DarkBlue;
            this.button_addReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addReg.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_addReg.ForeColor = System.Drawing.Color.White;
            this.button_addReg.Location = new System.Drawing.Point(893, 258);
            this.button_addReg.Name = "button_addReg";
            this.button_addReg.Size = new System.Drawing.Size(118, 41);
            this.button_addReg.TabIndex = 123;
            this.button_addReg.Text = "Add";
            this.button_addReg.UseVisualStyleBackColor = false;
            this.button_addReg.Click += new System.EventHandler(this.button_addReg_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(26, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 121;
            this.label1.Text = "Last education       :";
            // 
            // radioButton_woman
            // 
            this.radioButton_woman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_woman.AutoSize = true;
            this.radioButton_woman.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_woman.ForeColor = System.Drawing.Color.Navy;
            this.radioButton_woman.Location = new System.Drawing.Point(879, 117);
            this.radioButton_woman.Name = "radioButton_woman";
            this.radioButton_woman.Size = new System.Drawing.Size(103, 26);
            this.radioButton_woman.TabIndex = 120;
            this.radioButton_woman.Text = "Woman";
            this.radioButton_woman.UseVisualStyleBackColor = true;
            // 
            // radioButton_man
            // 
            this.radioButton_man.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Checked = true;
            this.radioButton_man.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_man.ForeColor = System.Drawing.Color.Navy;
            this.radioButton_man.Location = new System.Drawing.Point(792, 124);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(74, 26);
            this.radioButton_man.TabIndex = 119;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "Man";
            this.radioButton_man.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(638, 128);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 22);
            this.label12.TabIndex = 118;
            this.label12.Text = "Gender            :";
            // 
            // textBox_phoneReg
            // 
            this.textBox_phoneReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_phoneReg.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_phoneReg.Location = new System.Drawing.Point(797, 174);
            this.textBox_phoneReg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_phoneReg.Multiline = true;
            this.textBox_phoneReg.Name = "textBox_phoneReg";
            this.textBox_phoneReg.Size = new System.Drawing.Size(189, 31);
            this.textBox_phoneReg.TabIndex = 117;
            this.textBox_phoneReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phoneReg_KeyPress);
            // 
            // textBox_lastnameReg
            // 
            this.textBox_lastnameReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_lastnameReg.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_lastnameReg.Location = new System.Drawing.Point(794, 72);
            this.textBox_lastnameReg.Margin = new System.Windows.Forms.Padding(6, 2, 4, 2);
            this.textBox_lastnameReg.Multiline = true;
            this.textBox_lastnameReg.Name = "textBox_lastnameReg";
            this.textBox_lastnameReg.Size = new System.Drawing.Size(217, 31);
            this.textBox_lastnameReg.TabIndex = 116;
            this.textBox_lastnameReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lastnameReg_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(641, 178);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 22);
            this.label14.TabIndex = 115;
            this.label14.Text = "Phone              :";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(640, 79);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 22);
            this.label15.TabIndex = 114;
            this.label15.Text = "Last Name       :";
            // 
            // textBox_nispReg
            // 
            this.textBox_nispReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_nispReg.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_nispReg.Location = new System.Drawing.Point(236, 28);
            this.textBox_nispReg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_nispReg.Multiline = true;
            this.textBox_nispReg.Name = "textBox_nispReg";
            this.textBox_nispReg.Size = new System.Drawing.Size(182, 31);
            this.textBox_nispReg.TabIndex = 113;
            this.textBox_nispReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nispReg_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(28, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 22);
            this.label10.TabIndex = 112;
            this.label10.Text = "NIP                           :";
            // 
            // textBox_addressReg
            // 
            this.textBox_addressReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_addressReg.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_addressReg.Location = new System.Drawing.Point(236, 167);
            this.textBox_addressReg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_addressReg.Multiline = true;
            this.textBox_addressReg.Name = "textBox_addressReg";
            this.textBox_addressReg.Size = new System.Drawing.Size(330, 37);
            this.textBox_addressReg.TabIndex = 111;
            this.textBox_addressReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_addressReg_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(28, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 22);
            this.label11.TabIndex = 110;
            this.label11.Text = "Address/Kota        :";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_date.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_date.Location = new System.Drawing.Point(236, 120);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(330, 32);
            this.dateTimePicker_date.TabIndex = 109;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(28, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 22);
            this.label13.TabIndex = 108;
            this.label13.Text = "Date Of Birth           :";
            // 
            // textBox_firstnameReg
            // 
            this.textBox_firstnameReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_firstnameReg.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_firstnameReg.Location = new System.Drawing.Point(236, 72);
            this.textBox_firstnameReg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_firstnameReg.Multiline = true;
            this.textBox_firstnameReg.Name = "textBox_firstnameReg";
            this.textBox_firstnameReg.Size = new System.Drawing.Size(220, 31);
            this.textBox_firstnameReg.TabIndex = 107;
            this.textBox_firstnameReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_firstnameReg_KeyPress);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(28, 79);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 22);
            this.label16.TabIndex = 106;
            this.label16.Text = "First Name              :";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 797);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView_addTeacher);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_addTeacher)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel4;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridView_addTeacher;
        private Panel panel5;
        private Label label9;
        private Panel panel1;
        private TextBox textBox_nispReg;
        private Label label10;
        private TextBox textBox_addressReg;
        private Label label11;
        private DateTimePicker dateTimePicker_date;
        private Label label13;
        private TextBox textBox_firstnameReg;
        private Label label16;
        private Label label1;
        private RadioButton radioButton_woman;
        private RadioButton radioButton_man;
        private Label label12;
        private TextBox textBox_phoneReg;
        private TextBox textBox_lastnameReg;
        private Label label14;
        private Label label15;
        private Button button_clearReg;
        private Button button_addReg;
        private ComboBox comboBox_lastEduc;
    }
}
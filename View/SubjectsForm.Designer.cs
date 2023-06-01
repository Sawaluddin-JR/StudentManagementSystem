namespace StudentManagementSystem.View
{
    partial class SubjectsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_showSubjects = new System.Windows.Forms.Button();
            this.button_showCompt = new System.Windows.Forms.Button();
            this.button_showTeacher = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DataGridView_subjects = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_levelClass = new System.Windows.Forms.ComboBox();
            this.comboBox_nip = new System.Windows.Forms.ComboBox();
            this.comboBox_codeCompt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nameSubjects = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_hour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label_code = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_subjects)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.button_showSubjects);
            this.panel1.Controls.Add(this.button_showCompt);
            this.panel1.Controls.Add(this.button_showTeacher);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 72);
            this.panel1.TabIndex = 104;
            // 
            // button_showSubjects
            // 
            this.button_showSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_showSubjects.BackColor = System.Drawing.Color.DarkBlue;
            this.button_showSubjects.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_showSubjects.ForeColor = System.Drawing.Color.White;
            this.button_showSubjects.Location = new System.Drawing.Point(892, 15);
            this.button_showSubjects.Name = "button_showSubjects";
            this.button_showSubjects.Size = new System.Drawing.Size(130, 42);
            this.button_showSubjects.TabIndex = 116;
            this.button_showSubjects.Text = "Show Subjects";
            this.button_showSubjects.UseVisualStyleBackColor = false;
            this.button_showSubjects.Click += new System.EventHandler(this.button_showSubjects_Click_1);
            // 
            // button_showCompt
            // 
            this.button_showCompt.BackColor = System.Drawing.Color.DarkBlue;
            this.button_showCompt.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_showCompt.ForeColor = System.Drawing.Color.White;
            this.button_showCompt.Location = new System.Drawing.Point(12, 12);
            this.button_showCompt.Name = "button_showCompt";
            this.button_showCompt.Size = new System.Drawing.Size(174, 42);
            this.button_showCompt.TabIndex = 117;
            this.button_showCompt.Text = "Show Competency";
            this.button_showCompt.UseVisualStyleBackColor = false;
            this.button_showCompt.Click += new System.EventHandler(this.button_showCompt_Click_1);
            // 
            // button_showTeacher
            // 
            this.button_showTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_showTeacher.BackColor = System.Drawing.Color.DarkBlue;
            this.button_showTeacher.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_showTeacher.ForeColor = System.Drawing.Color.White;
            this.button_showTeacher.Location = new System.Drawing.Point(746, 14);
            this.button_showTeacher.Name = "button_showTeacher";
            this.button_showTeacher.Size = new System.Drawing.Size(130, 42);
            this.button_showTeacher.TabIndex = 115;
            this.button_showTeacher.Text = "Show Tacher";
            this.button_showTeacher.UseVisualStyleBackColor = false;
            this.button_showTeacher.Click += new System.EventHandler(this.button_showTeacher_Click_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(446, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Subjects";
            // 
            // DataGridView_subjects
            // 
            this.DataGridView_subjects.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_subjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_subjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_subjects.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_subjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_subjects.ColumnHeadersHeight = 40;
            this.DataGridView_subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_subjects.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_subjects.GridColor = System.Drawing.Color.Olive;
            this.DataGridView_subjects.Location = new System.Drawing.Point(12, 81);
            this.DataGridView_subjects.Name = "DataGridView_subjects";
            this.DataGridView_subjects.RowHeadersVisible = false;
            this.DataGridView_subjects.RowHeadersWidth = 50;
            this.DataGridView_subjects.RowTemplate.Height = 80;
            this.DataGridView_subjects.Size = new System.Drawing.Size(1018, 414);
            this.DataGridView_subjects.TabIndex = 111;
            this.DataGridView_subjects.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_subjects.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_subjects.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_subjects.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_subjects.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_subjects.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_subjects.ThemeStyle.GridColor = System.Drawing.Color.Olive;
            this.DataGridView_subjects.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_subjects.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_subjects.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_subjects.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_subjects.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_subjects.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridView_subjects.ThemeStyle.ReadOnly = false;
            this.DataGridView_subjects.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_subjects.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_subjects.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataGridView_subjects.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_subjects.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_subjects.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_subjects.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_subjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_subjects_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_levelClass);
            this.panel2.Controls.Add(this.comboBox_nip);
            this.panel2.Controls.Add(this.comboBox_codeCompt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_nameSubjects);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_clear);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.textBox_hour);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_code);
            this.panel2.Controls.Add(this.label_code);
            this.panel2.Controls.Add(this.textBox_description);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 296);
            this.panel2.TabIndex = 113;
            // 
            // comboBox_levelClass
            // 
            this.comboBox_levelClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_levelClass.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_levelClass.FormattingEnabled = true;
            this.comboBox_levelClass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_levelClass.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.comboBox_levelClass.Location = new System.Drawing.Point(737, 129);
            this.comboBox_levelClass.Name = "comboBox_levelClass";
            this.comboBox_levelClass.Size = new System.Drawing.Size(87, 27);
            this.comboBox_levelClass.TabIndex = 156;
            // 
            // comboBox_nip
            // 
            this.comboBox_nip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nip.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_nip.FormattingEnabled = true;
            this.comboBox_nip.Location = new System.Drawing.Point(186, 76);
            this.comboBox_nip.Name = "comboBox_nip";
            this.comboBox_nip.Size = new System.Drawing.Size(197, 27);
            this.comboBox_nip.TabIndex = 155;
            // 
            // comboBox_codeCompt
            // 
            this.comboBox_codeCompt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_codeCompt.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox_codeCompt.FormattingEnabled = true;
            this.comboBox_codeCompt.Location = new System.Drawing.Point(737, 20);
            this.comboBox_codeCompt.Name = "comboBox_codeCompt";
            this.comboBox_codeCompt.Size = new System.Drawing.Size(87, 27);
            this.comboBox_codeCompt.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(571, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 152;
            this.label5.Text = "Level Class         :";
            // 
            // textBox_nameSubjects
            // 
            this.textBox_nameSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_nameSubjects.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_nameSubjects.Location = new System.Drawing.Point(737, 74);
            this.textBox_nameSubjects.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_nameSubjects.Multiline = true;
            this.textBox_nameSubjects.Name = "textBox_nameSubjects";
            this.textBox_nameSubjects.Size = new System.Drawing.Size(241, 32);
            this.textBox_nameSubjects.TabIndex = 151;
            this.textBox_nameSubjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nameSubjects_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(571, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 150;
            this.label4.Text = "Name Subjects  :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 148;
            this.label3.Text = "NIP                      :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(571, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 146;
            this.label2.Text = "Code Compt     :";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.Color.DarkOrange;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(762, 245);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 145;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.BackColor = System.Drawing.Color.DarkBlue;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(916, 245);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(118, 39);
            this.button_add.TabIndex = 144;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_hour
            // 
            this.textBox_hour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_hour.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_hour.Location = new System.Drawing.Point(186, 132);
            this.textBox_hour.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_hour.Multiline = true;
            this.textBox_hour.Name = "textBox_hour";
            this.textBox_hour.Size = new System.Drawing.Size(141, 32);
            this.textBox_hour.TabIndex = 143;
            this.textBox_hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hour_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(24, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 142;
            this.label1.Text = "Hour                   :";
            // 
            // textBox_code
            // 
            this.textBox_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_code.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_code.Location = new System.Drawing.Point(186, 26);
            this.textBox_code.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_code.Multiline = true;
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(90, 32);
            this.textBox_code.TabIndex = 141;
            this.textBox_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_code_KeyPress);
            // 
            // label_code
            // 
            this.label_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_code.AutoSize = true;
            this.label_code.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_code.ForeColor = System.Drawing.Color.Navy;
            this.label_code.Location = new System.Drawing.Point(24, 28);
            this.label_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(154, 22);
            this.label_code.TabIndex = 140;
            this.label_code.Text = "Code Subjects  :";
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_description.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_description.Location = new System.Drawing.Point(186, 182);
            this.textBox_description.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(314, 64);
            this.textBox_description.TabIndex = 137;
            this.textBox_description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_description_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(24, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 136;
            this.label6.Text = "Description       :";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Location = new System.Drawing.Point(12, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 8);
            this.panel3.TabIndex = 154;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 797);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_subjects);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_subjects)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridView_subjects;
        private Panel panel2;
        private Label label1;
        private TextBox textBox_code;
        private Label label_code;
        private TextBox textBox_description;
        private Label label6;
        private Button button_clear;
        private Button button_add;
        private Label label5;
        private TextBox textBox_nameSubjects;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Button button_showCompt;
        private Button button_showSubjects;
        private Button button_showTeacher;
        private Panel panel3;
        private ComboBox comboBox_nip;
        private ComboBox comboBox_codeCompt;
        private TextBox textBox_hour;
        private ComboBox comboBox_levelClass;
    }
}
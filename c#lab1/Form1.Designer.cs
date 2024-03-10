namespace c_lab1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1_selectAll = new System.Windows.Forms.CheckBox();
            this.panel1_num1_label2 = new System.Windows.Forms.Label();
            this.panel1_calculate = new System.Windows.Forms.Button();
            this.panel1_input2 = new System.Windows.Forms.TextBox();
            this.panel1_input1 = new System.Windows.Forms.TextBox();
            this.panel1_num1_label = new System.Windows.Forms.Label();
            this.panel1_divisionCheck = new System.Windows.Forms.CheckBox();
            this.panel1_multiplicationCheck = new System.Windows.Forms.CheckBox();
            this.panel1_subtractionCheck = new System.Windows.Forms.CheckBox();
            this.panel1_label = new System.Windows.Forms.Label();
            this.panel1_additionCheck = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2_ClearButton = new System.Windows.Forms.Button();
            this.panel2_Calculate = new System.Windows.Forms.Button();
            this.panel2_Remove = new System.Windows.Forms.Button();
            this.panel2_Add = new System.Windows.Forms.Button();
            this.panel2_listBox = new System.Windows.Forms.ListBox();
            this.panel2_input = new System.Windows.Forms.TextBox();
            this.panel2_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3_Clear = new System.Windows.Forms.Button();
            this.panel3_Calculate = new System.Windows.Forms.Button();
            this.panel3_Remove = new System.Windows.Forms.Button();
            this.panel3_Add = new System.Windows.Forms.Button();
            this.panel3_comboBox = new System.Windows.Forms.ComboBox();
            this.panel3_result = new System.Windows.Forms.Label();
            this.panel3_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4_increase = new System.Windows.Forms.RadioButton();
            this.panel4_decrease = new System.Windows.Forms.RadioButton();
            this.panel4_start = new System.Windows.Forms.Button();
            this.panel4_progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel1_selectAll);
            this.panel1.Controls.Add(this.panel1_num1_label2);
            this.panel1.Controls.Add(this.panel1_calculate);
            this.panel1.Controls.Add(this.panel1_input2);
            this.panel1.Controls.Add(this.panel1_input1);
            this.panel1.Controls.Add(this.panel1_num1_label);
            this.panel1.Controls.Add(this.panel1_divisionCheck);
            this.panel1.Controls.Add(this.panel1_multiplicationCheck);
            this.panel1.Controls.Add(this.panel1_subtractionCheck);
            this.panel1.Controls.Add(this.panel1_label);
            this.panel1.Controls.Add(this.panel1_additionCheck);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 141);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1_selectAll
            // 
            this.panel1_selectAll.AutoSize = true;
            this.panel1_selectAll.Location = new System.Drawing.Point(387, 54);
            this.panel1_selectAll.Name = "panel1_selectAll";
            this.panel1_selectAll.Size = new System.Drawing.Size(75, 24);
            this.panel1_selectAll.TabIndex = 11;
            this.panel1_selectAll.Text = "Tümü";
            this.panel1_selectAll.UseVisualStyleBackColor = true;
            this.panel1_selectAll.CheckedChanged += new System.EventHandler(this.panel1_selectAll_CheckedChanged_1);
            // 
            // panel1_num1_label2
            // 
            this.panel1_num1_label2.AutoSize = true;
            this.panel1_num1_label2.ForeColor = System.Drawing.Color.Snow;
            this.panel1_num1_label2.Location = new System.Drawing.Point(256, 105);
            this.panel1_num1_label2.Name = "panel1_num1_label2";
            this.panel1_num1_label2.Size = new System.Drawing.Size(65, 20);
            this.panel1_num1_label2.TabIndex = 10;
            this.panel1_num1_label2.Text = "Sayı 2 =";
            // 
            // panel1_calculate
            // 
            this.panel1_calculate.Location = new System.Drawing.Point(498, 98);
            this.panel1_calculate.Name = "panel1_calculate";
            this.panel1_calculate.Size = new System.Drawing.Size(141, 29);
            this.panel1_calculate.TabIndex = 9;
            this.panel1_calculate.Text = "OK";
            this.panel1_calculate.UseVisualStyleBackColor = true;
            this.panel1_calculate.Click += new System.EventHandler(this.panel1_calculate_Click);
            // 
            // panel1_input2
            // 
            this.panel1_input2.Location = new System.Drawing.Point(327, 99);
            this.panel1_input2.Name = "panel1_input2";
            this.panel1_input2.Size = new System.Drawing.Size(151, 26);
            this.panel1_input2.TabIndex = 8;
            // 
            // panel1_input1
            // 
            this.panel1_input1.Location = new System.Drawing.Point(82, 102);
            this.panel1_input1.Name = "panel1_input1";
            this.panel1_input1.Size = new System.Drawing.Size(151, 26);
            this.panel1_input1.TabIndex = 7;
            // 
            // panel1_num1_label
            // 
            this.panel1_num1_label.AutoSize = true;
            this.panel1_num1_label.ForeColor = System.Drawing.Color.Snow;
            this.panel1_num1_label.Location = new System.Drawing.Point(11, 102);
            this.panel1_num1_label.Name = "panel1_num1_label";
            this.panel1_num1_label.Size = new System.Drawing.Size(65, 20);
            this.panel1_num1_label.TabIndex = 6;
            this.panel1_num1_label.Text = "Sayı 1 =";
            // 
            // panel1_divisionCheck
            // 
            this.panel1_divisionCheck.AutoSize = true;
            this.panel1_divisionCheck.Location = new System.Drawing.Point(302, 54);
            this.panel1_divisionCheck.Name = "panel1_divisionCheck";
            this.panel1_divisionCheck.Size = new System.Drawing.Size(58, 24);
            this.panel1_divisionCheck.TabIndex = 4;
            this.panel1_divisionCheck.Text = "Böl";
            this.panel1_divisionCheck.UseVisualStyleBackColor = true;
            // 
            // panel1_multiplicationCheck
            // 
            this.panel1_multiplicationCheck.AutoSize = true;
            this.panel1_multiplicationCheck.Location = new System.Drawing.Point(205, 54);
            this.panel1_multiplicationCheck.Name = "panel1_multiplicationCheck";
            this.panel1_multiplicationCheck.Size = new System.Drawing.Size(69, 24);
            this.panel1_multiplicationCheck.TabIndex = 3;
            this.panel1_multiplicationCheck.Text = "Çarp";
            this.panel1_multiplicationCheck.UseVisualStyleBackColor = true;
            // 
            // panel1_subtractionCheck
            // 
            this.panel1_subtractionCheck.AutoSize = true;
            this.panel1_subtractionCheck.Location = new System.Drawing.Point(106, 54);
            this.panel1_subtractionCheck.Name = "panel1_subtractionCheck";
            this.panel1_subtractionCheck.Size = new System.Drawing.Size(76, 24);
            this.panel1_subtractionCheck.TabIndex = 2;
            this.panel1_subtractionCheck.Text = "Çıkart";
            this.panel1_subtractionCheck.UseVisualStyleBackColor = true;
            // 
            // panel1_label
            // 
            this.panel1_label.BackColor = System.Drawing.Color.Blue;
            this.panel1_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1_label.ForeColor = System.Drawing.Color.Transparent;
            this.panel1_label.Location = new System.Drawing.Point(-2, 0);
            this.panel1_label.Name = "panel1_label";
            this.panel1_label.Size = new System.Drawing.Size(652, 31);
            this.panel1_label.TabIndex = 1;
            this.panel1_label.Text = "Panel 1";
            this.panel1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1_additionCheck
            // 
            this.panel1_additionCheck.AutoSize = true;
            this.panel1_additionCheck.Location = new System.Drawing.Point(15, 54);
            this.panel1_additionCheck.Name = "panel1_additionCheck";
            this.panel1_additionCheck.Size = new System.Drawing.Size(74, 24);
            this.panel1_additionCheck.TabIndex = 0;
            this.panel1_additionCheck.Text = "Topla";
            this.panel1_additionCheck.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.panel2_ClearButton);
            this.panel2.Controls.Add(this.panel2_Calculate);
            this.panel2.Controls.Add(this.panel2_Remove);
            this.panel2.Controls.Add(this.panel2_Add);
            this.panel2.Controls.Add(this.panel2_listBox);
            this.panel2.Controls.Add(this.panel2_input);
            this.panel2.Controls.Add(this.panel2_label);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 271);
            this.panel2.TabIndex = 1;
            // 
            // panel2_ClearButton
            // 
            this.panel2_ClearButton.Location = new System.Drawing.Point(186, 170);
            this.panel2_ClearButton.Name = "panel2_ClearButton";
            this.panel2_ClearButton.Size = new System.Drawing.Size(133, 46);
            this.panel2_ClearButton.TabIndex = 14;
            this.panel2_ClearButton.Text = "Temizle";
            this.panel2_ClearButton.UseVisualStyleBackColor = true;
            this.panel2_ClearButton.Click += new System.EventHandler(this.panel2_ClearButton_Click);
            // 
            // panel2_Calculate
            // 
            this.panel2_Calculate.Location = new System.Drawing.Point(186, 222);
            this.panel2_Calculate.Name = "panel2_Calculate";
            this.panel2_Calculate.Size = new System.Drawing.Size(133, 46);
            this.panel2_Calculate.TabIndex = 13;
            this.panel2_Calculate.Text = "Hesapla";
            this.panel2_Calculate.UseVisualStyleBackColor = true;
            this.panel2_Calculate.Click += new System.EventHandler(this.panel2_Calculate_Click);
            // 
            // panel2_Remove
            // 
            this.panel2_Remove.Location = new System.Drawing.Point(186, 118);
            this.panel2_Remove.Name = "panel2_Remove";
            this.panel2_Remove.Size = new System.Drawing.Size(133, 46);
            this.panel2_Remove.TabIndex = 11;
            this.panel2_Remove.Text = "Kaldır";
            this.panel2_Remove.UseVisualStyleBackColor = true;
            this.panel2_Remove.Click += new System.EventHandler(this.panel2_Remove_Click);
            // 
            // panel2_Add
            // 
            this.panel2_Add.Location = new System.Drawing.Point(186, 66);
            this.panel2_Add.Name = "panel2_Add";
            this.panel2_Add.Size = new System.Drawing.Size(133, 46);
            this.panel2_Add.TabIndex = 10;
            this.panel2_Add.Text = "Ekle";
            this.panel2_Add.UseVisualStyleBackColor = true;
            this.panel2_Add.Click += new System.EventHandler(this.panel2_Add_Click);
            // 
            // panel2_listBox
            // 
            this.panel2_listBox.BackColor = System.Drawing.Color.Azure;
            this.panel2_listBox.FormattingEnabled = true;
            this.panel2_listBox.ItemHeight = 20;
            this.panel2_listBox.Location = new System.Drawing.Point(3, 66);
            this.panel2_listBox.Name = "panel2_listBox";
            this.panel2_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.panel2_listBox.Size = new System.Drawing.Size(180, 204);
            this.panel2_listBox.TabIndex = 9;
            this.panel2_listBox.SelectedIndexChanged += new System.EventHandler(this.panel2_listBox_SelectedIndexChanged);
            // 
            // panel2_input
            // 
            this.panel2_input.Location = new System.Drawing.Point(83, 34);
            this.panel2_input.Name = "panel2_input";
            this.panel2_input.Size = new System.Drawing.Size(236, 26);
            this.panel2_input.TabIndex = 8;
            // 
            // panel2_label
            // 
            this.panel2_label.AutoSize = true;
            this.panel2_label.ForeColor = System.Drawing.Color.Snow;
            this.panel2_label.Location = new System.Drawing.Point(12, 37);
            this.panel2_label.Name = "panel2_label";
            this.panel2_label.Size = new System.Drawing.Size(60, 20);
            this.panel2_label.TabIndex = 7;
            this.panel2_label.Text = "İşlem =";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Panel 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.panel3_Clear);
            this.panel3.Controls.Add(this.panel3_Calculate);
            this.panel3.Controls.Add(this.panel3_Remove);
            this.panel3.Controls.Add(this.panel3_Add);
            this.panel3.Controls.Add(this.panel3_comboBox);
            this.panel3.Controls.Add(this.panel3_result);
            this.panel3.Controls.Add(this.panel3_label);
            this.panel3.Location = new System.Drawing.Point(340, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 270);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel3_Clear
            // 
            this.panel3_Clear.Location = new System.Drawing.Point(94, 157);
            this.panel3_Clear.Name = "panel3_Clear";
            this.panel3_Clear.Size = new System.Drawing.Size(145, 34);
            this.panel3_Clear.TabIndex = 23;
            this.panel3_Clear.Text = "Temizle";
            this.panel3_Clear.UseVisualStyleBackColor = true;
            this.panel3_Clear.Click += new System.EventHandler(this.panel3_Clear_Click);
            // 
            // panel3_Calculate
            // 
            this.panel3_Calculate.Location = new System.Drawing.Point(94, 197);
            this.panel3_Calculate.Name = "panel3_Calculate";
            this.panel3_Calculate.Size = new System.Drawing.Size(145, 34);
            this.panel3_Calculate.TabIndex = 22;
            this.panel3_Calculate.Text = "Hesapla";
            this.panel3_Calculate.UseVisualStyleBackColor = true;
            this.panel3_Calculate.Click += new System.EventHandler(this.panel3_Calculate_Click);
            // 
            // panel3_Remove
            // 
            this.panel3_Remove.Location = new System.Drawing.Point(94, 119);
            this.panel3_Remove.Name = "panel3_Remove";
            this.panel3_Remove.Size = new System.Drawing.Size(145, 34);
            this.panel3_Remove.TabIndex = 21;
            this.panel3_Remove.Text = "Kaldır";
            this.panel3_Remove.UseVisualStyleBackColor = true;
            this.panel3_Remove.Click += new System.EventHandler(this.panel3_Remove_Click);
            // 
            // panel3_Add
            // 
            this.panel3_Add.Location = new System.Drawing.Point(94, 81);
            this.panel3_Add.Name = "panel3_Add";
            this.panel3_Add.Size = new System.Drawing.Size(145, 34);
            this.panel3_Add.TabIndex = 20;
            this.panel3_Add.Text = "Ekle";
            this.panel3_Add.UseVisualStyleBackColor = true;
            this.panel3_Add.Click += new System.EventHandler(this.panel3_Add_Click);
            // 
            // panel3_comboBox
            // 
            this.panel3_comboBox.FormattingEnabled = true;
            this.panel3_comboBox.Location = new System.Drawing.Point(3, 40);
            this.panel3_comboBox.Name = "panel3_comboBox";
            this.panel3_comboBox.Size = new System.Drawing.Size(316, 28);
            this.panel3_comboBox.TabIndex = 19;
            // 
            // panel3_result
            // 
            this.panel3_result.BackColor = System.Drawing.Color.Blue;
            this.panel3_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3_result.ForeColor = System.Drawing.Color.Transparent;
            this.panel3_result.Location = new System.Drawing.Point(0, 237);
            this.panel3_result.Name = "panel3_result";
            this.panel3_result.Size = new System.Drawing.Size(323, 31);
            this.panel3_result.TabIndex = 6;
            this.panel3_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3_label
            // 
            this.panel3_label.BackColor = System.Drawing.Color.Blue;
            this.panel3_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3_label.ForeColor = System.Drawing.Color.Transparent;
            this.panel3_label.Location = new System.Drawing.Point(0, 0);
            this.panel3_label.Name = "panel3_label";
            this.panel3_label.Size = new System.Drawing.Size(322, 31);
            this.panel3_label.TabIndex = 3;
            this.panel3_label.Text = "Panel 3";
            this.panel3_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.panel4_progressBar);
            this.panel4.Controls.Add(this.panel4_start);
            this.panel4.Controls.Add(this.panel4_decrease);
            this.panel4.Controls.Add(this.panel4_increase);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(15, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 130);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Panel 4";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4_increase
            // 
            this.panel4_increase.AutoSize = true;
            this.panel4_increase.Location = new System.Drawing.Point(13, 48);
            this.panel4_increase.Name = "panel4_increase";
            this.panel4_increase.Size = new System.Drawing.Size(66, 24);
            this.panel4_increase.TabIndex = 5;
            this.panel4_increase.TabStop = true;
            this.panel4_increase.Text = "arttır";
            this.panel4_increase.UseVisualStyleBackColor = true;
            this.panel4_increase.CheckedChanged += new System.EventHandler(this.panel4_increase_CheckedChanged);
            // 
            // panel4_decrease
            // 
            this.panel4_decrease.AutoSize = true;
            this.panel4_decrease.Location = new System.Drawing.Point(146, 48);
            this.panel4_decrease.Name = "panel4_decrease";
            this.panel4_decrease.Size = new System.Drawing.Size(68, 24);
            this.panel4_decrease.TabIndex = 6;
            this.panel4_decrease.TabStop = true;
            this.panel4_decrease.Text = "azalt";
            this.panel4_decrease.UseVisualStyleBackColor = true;
            this.panel4_decrease.CheckedChanged += new System.EventHandler(this.panel4_decrease_CheckedChanged);
            // 
            // panel4_start
            // 
            this.panel4_start.Location = new System.Drawing.Point(290, 45);
            this.panel4_start.Name = "panel4_start";
            this.panel4_start.Size = new System.Drawing.Size(347, 31);
            this.panel4_start.TabIndex = 7;
            this.panel4_start.Text = "Başla";
            this.panel4_start.UseVisualStyleBackColor = true;
            this.panel4_start.Click += new System.EventHandler(this.panel4_start_Click);
            // 
            // panel4_progressBar
            // 
            this.panel4_progressBar.Location = new System.Drawing.Point(13, 82);
            this.panel4_progressBar.Name = "panel4_progressBar";
            this.panel4_progressBar.Size = new System.Drawing.Size(624, 39);
            this.panel4_progressBar.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(672, 585);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label panel1_label;
        private System.Windows.Forms.CheckBox panel1_additionCheck;
        private System.Windows.Forms.CheckBox panel1_divisionCheck;
        private System.Windows.Forms.CheckBox panel1_multiplicationCheck;
        private System.Windows.Forms.CheckBox panel1_subtractionCheck;
        private System.Windows.Forms.TextBox panel1_input2;
        private System.Windows.Forms.TextBox panel1_input1;
        private System.Windows.Forms.Label panel1_num1_label;
        private System.Windows.Forms.Button panel1_calculate;
        private System.Windows.Forms.Label panel1_num1_label2;
        private System.Windows.Forms.CheckBox panel1_selectAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button panel2_Calculate;
        private System.Windows.Forms.Button panel2_Remove;
        private System.Windows.Forms.Button panel2_Add;
        private System.Windows.Forms.ListBox panel2_listBox;
        private System.Windows.Forms.TextBox panel2_input;
        private System.Windows.Forms.Label panel2_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button panel2_ClearButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label panel3_label;
        private System.Windows.Forms.Label panel3_result;
        private System.Windows.Forms.Button panel3_Clear;
        private System.Windows.Forms.Button panel3_Calculate;
        private System.Windows.Forms.Button panel3_Remove;
        private System.Windows.Forms.Button panel3_Add;
        private System.Windows.Forms.ComboBox panel3_comboBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar panel4_progressBar;
        private System.Windows.Forms.Button panel4_start;
        private System.Windows.Forms.RadioButton panel4_decrease;
        private System.Windows.Forms.RadioButton panel4_increase;
        private System.Windows.Forms.Timer timer1;
    }
}


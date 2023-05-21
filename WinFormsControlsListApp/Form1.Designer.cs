namespace WinFormsControlsListApp
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkedListBox1 = new CheckedListBox();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            domainUpDown1 = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(215, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(252, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 23);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(252, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(342, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Del";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 340);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Add User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(252, 84);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(252, 58);
            checkedListBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(252, 157);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Select 2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 15, 0, 0, 65536 });
            numericUpDown1.Location = new Point(252, 205);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(252, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(252, 252);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(252, 23);
            domainUpDown1.TabIndex = 8;
            domainUpDown1.Text = "domainUpDown1";
            domainUpDown1.Wrap = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(domainUpDown1);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(checkedListBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private DomainUpDown domainUpDown1;
    }
}
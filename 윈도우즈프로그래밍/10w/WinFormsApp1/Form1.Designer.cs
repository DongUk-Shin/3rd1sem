namespace WinFormsApp1
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
            cbox = new ComboBox();
            btn_add1 = new Button();
            btn_remove1 = new Button();
            tbox_1 = new TextBox();
            btn_add2 = new Button();
            lbox_1 = new ListBox();
            btn_remove2 = new Button();
            tbox_2 = new TextBox();
            btn_add3 = new Button();
            chbox = new CheckedListBox();
            btn_remove3 = new Button();
            btn_summary = new Button();
            lbox2 = new ListBox();
            lb_msg = new Label();
            SuspendLayout();
            // 
            // cbox
            // 
            cbox.FormattingEnabled = true;
            cbox.Items.AddRange(new object[] { "고양이", "강아지" });
            cbox.Location = new Point(29, 32);
            cbox.Name = "cbox";
            cbox.Size = new Size(121, 23);
            cbox.TabIndex = 0;
            cbox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_add1
            // 
            btn_add1.Location = new Point(161, 35);
            btn_add1.Name = "btn_add1";
            btn_add1.Size = new Size(75, 23);
            btn_add1.TabIndex = 1;
            btn_add1.Text = "추가";
            btn_add1.UseVisualStyleBackColor = true;
            btn_add1.Click += button1_Click;
            // 
            // btn_remove1
            // 
            btn_remove1.Location = new Point(161, 64);
            btn_remove1.Name = "btn_remove1";
            btn_remove1.Size = new Size(75, 23);
            btn_remove1.TabIndex = 2;
            btn_remove1.Text = "삭제";
            btn_remove1.UseVisualStyleBackColor = true;
            btn_remove1.Click += button2_Click;
            // 
            // tbox_1
            // 
            tbox_1.Location = new Point(29, 173);
            tbox_1.Name = "tbox_1";
            tbox_1.Size = new Size(119, 23);
            tbox_1.TabIndex = 3;
            tbox_1.TextChanged += textBox1_TextChanged;
            // 
            // btn_add2
            // 
            btn_add2.Location = new Point(160, 172);
            btn_add2.Name = "btn_add2";
            btn_add2.Size = new Size(75, 23);
            btn_add2.TabIndex = 4;
            btn_add2.Text = "추가";
            btn_add2.UseVisualStyleBackColor = true;
            btn_add2.Click += button3_Click;
            // 
            // lbox_1
            // 
            lbox_1.FormattingEnabled = true;
            lbox_1.ItemHeight = 15;
            lbox_1.Items.AddRange(new object[] { "제주", "서울", "천안", "수원" });
            lbox_1.Location = new Point(29, 203);
            lbox_1.Name = "lbox_1";
            lbox_1.Size = new Size(120, 109);
            lbox_1.TabIndex = 5;
            lbox_1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btn_remove2
            // 
            btn_remove2.Location = new Point(160, 203);
            btn_remove2.Name = "btn_remove2";
            btn_remove2.Size = new Size(75, 23);
            btn_remove2.TabIndex = 6;
            btn_remove2.Text = "삭제";
            btn_remove2.UseVisualStyleBackColor = true;
            btn_remove2.Click += button4_Click;
            // 
            // tbox_2
            // 
            tbox_2.Location = new Point(291, 35);
            tbox_2.Name = "tbox_2";
            tbox_2.Size = new Size(122, 23);
            tbox_2.TabIndex = 7;
            // 
            // btn_add3
            // 
            btn_add3.Location = new Point(425, 35);
            btn_add3.Name = "btn_add3";
            btn_add3.Size = new Size(75, 23);
            btn_add3.TabIndex = 8;
            btn_add3.Text = "추가";
            btn_add3.UseVisualStyleBackColor = true;
            btn_add3.Click += button5_Click;
            // 
            // chbox
            // 
            chbox.FormattingEnabled = true;
            chbox.Items.AddRange(new object[] { "집", "자동차", "결혼" });
            chbox.Location = new Point(292, 69);
            chbox.Name = "chbox";
            chbox.Size = new Size(120, 94);
            chbox.TabIndex = 9;
            // 
            // btn_remove3
            // 
            btn_remove3.Location = new Point(425, 67);
            btn_remove3.Name = "btn_remove3";
            btn_remove3.Size = new Size(75, 23);
            btn_remove3.TabIndex = 10;
            btn_remove3.Text = "삭제";
            btn_remove3.UseVisualStyleBackColor = true;
            btn_remove3.Click += button6_Click;
            // 
            // btn_summary
            // 
            btn_summary.Location = new Point(292, 203);
            btn_summary.Name = "btn_summary";
            btn_summary.Size = new Size(75, 23);
            btn_summary.TabIndex = 11;
            btn_summary.Text = "요약";
            btn_summary.UseVisualStyleBackColor = true;
            btn_summary.Click += button7_Click;
            // 
            // lbox2
            // 
            lbox2.FormattingEnabled = true;
            lbox2.ItemHeight = 15;
            lbox2.Location = new Point(291, 232);
            lbox2.Name = "lbox2";
            lbox2.Size = new Size(187, 199);
            lbox2.TabIndex = 12;
            lbox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // lb_msg
            // 
            lb_msg.AutoSize = true;
            lb_msg.Location = new Point(29, 451);
            lb_msg.Name = "lb_msg";
            lb_msg.Size = new Size(38, 15);
            lb_msg.TabIndex = 13;
            lb_msg.Text = "[msg]";
            lb_msg.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 497);
            Controls.Add(lb_msg);
            Controls.Add(lbox2);
            Controls.Add(btn_summary);
            Controls.Add(btn_remove3);
            Controls.Add(chbox);
            Controls.Add(btn_add3);
            Controls.Add(tbox_2);
            Controls.Add(btn_remove2);
            Controls.Add(lbox_1);
            Controls.Add(btn_add2);
            Controls.Add(tbox_1);
            Controls.Add(btn_remove1);
            Controls.Add(btn_add1);
            Controls.Add(cbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbox;
        private Button btn_add1;
        private Button btn_remove1;
        private TextBox tbox_1;
        private Button btn_add2;
        private ListBox lbox_1;
        private Button btn_remove2;
        private TextBox tbox_2;
        private Button btn_add3;
        private CheckedListBox chbox;
        private Button btn_remove3;
        private Button btn_summary;
        private ListBox lbox2;
        private Label lb_msg;
    }
}
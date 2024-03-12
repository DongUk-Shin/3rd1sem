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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            toolStripContainer1 = new ToolStripContainer();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._1;
            button1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(549, 75);
            button1.Name = "button1";
            button1.Size = new Size(152, 69);
            button1.TabIndex = 0;
            button1.Text = "버튼이름";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(150, 150);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Location = new Point(237, 40);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(150, 175);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ToolStripContainer toolStripContainer1;
    }
}
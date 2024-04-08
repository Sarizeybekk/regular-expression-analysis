namespace RgxApp
{
    partial class RegexSonucFrm
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
            sncListBox = new ListBox();
            SuspendLayout();
            // 
            // sncListBox
            // 
            sncListBox.FormattingEnabled = true;
            sncListBox.ItemHeight = 20;
            sncListBox.Location = new Point(49, 70);
            sncListBox.Name = "sncListBox";
            sncListBox.Size = new Size(670, 324);
            sncListBox.TabIndex = 0;
            // 
            // RegexSonucFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sncListBox);
            Name = "RegexSonucFrm";
            Text = "RegexSonucFrm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox sncListBox;
    }
}
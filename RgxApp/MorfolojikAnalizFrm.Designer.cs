namespace RgxApp
{
    partial class MorfolojikAnalizFrm
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
            oncekiKelimeSayisiLbl = new Label();
            sonrakikelimeSayisi = new Label();
            listBox1 = new ListBox();
            sonrakiKelimeSayisiLbl = new Label();
            SuspendLayout();
            // 
            // oncekiKelimeSayisiLbl
            // 
            oncekiKelimeSayisiLbl.AutoSize = true;
            oncekiKelimeSayisiLbl.Location = new Point(93, 407);
            oncekiKelimeSayisiLbl.Name = "oncekiKelimeSayisiLbl";
            oncekiKelimeSayisiLbl.Size = new Size(50, 20);
            oncekiKelimeSayisiLbl.TabIndex = 0;
            oncekiKelimeSayisiLbl.Text = "label1";
            // 
            // sonrakikelimeSayisi
            // 
            sonrakikelimeSayisi.AutoSize = true;
            sonrakikelimeSayisi.Location = new Point(787, 438);
            sonrakikelimeSayisi.Name = "sonrakikelimeSayisi";
            sonrakikelimeSayisi.Size = new Size(0, 20);
            sonrakikelimeSayisi.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(93, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(796, 244);
            listBox1.TabIndex = 2;
            // 
            // sonrakiKelimeSayisiLbl
            // 
            sonrakiKelimeSayisiLbl.AutoSize = true;
            sonrakiKelimeSayisiLbl.Location = new Point(801, 407);
            sonrakiKelimeSayisiLbl.Name = "sonrakiKelimeSayisiLbl";
            sonrakiKelimeSayisiLbl.Size = new Size(50, 20);
            sonrakiKelimeSayisiLbl.TabIndex = 3;
            sonrakiKelimeSayisiLbl.Text = "label2";
            // 
            // MorfolojikAnalizFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 506);
            Controls.Add(sonrakiKelimeSayisiLbl);
            Controls.Add(listBox1);
            Controls.Add(sonrakikelimeSayisi);
            Controls.Add(oncekiKelimeSayisiLbl);
            Name = "MorfolojikAnalizFrm";
            Text = "MorfolojikAnalizFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label oncekiKelimeSayisiLbl;
        private Label sonrakikelimeSayisi;
        private ListBox listBox1;
        private Label sonrakiKelimeSayisiLbl;
    }
}
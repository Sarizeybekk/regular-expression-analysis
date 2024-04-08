namespace RgxApp
{
    partial class AnaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaFrm));
            AnaFrmPanel = new Panel();
            morfolojikAnalizBtn = new Button();
            rgxAraBtn = new Button();
            rgxAraTxtBx = new TextBox();
            rgxLbl = new Label();
            dosyaAdiLbl = new Label();
            dosyaEkleBtn = new Button();
            panel1 = new Panel();
            AnaFrmPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AnaFrmPanel
            // 
            AnaFrmPanel.BackColor = SystemColors.ControlLightLight;
            AnaFrmPanel.BorderStyle = BorderStyle.FixedSingle;
            AnaFrmPanel.Controls.Add(morfolojikAnalizBtn);
            AnaFrmPanel.Controls.Add(rgxAraBtn);
            AnaFrmPanel.Controls.Add(rgxAraTxtBx);
            AnaFrmPanel.Controls.Add(rgxLbl);
            AnaFrmPanel.Controls.Add(dosyaAdiLbl);
            AnaFrmPanel.Controls.Add(dosyaEkleBtn);
            AnaFrmPanel.ForeColor = Color.Black;
            AnaFrmPanel.Location = new Point(37, 22);
            AnaFrmPanel.Name = "AnaFrmPanel";
            AnaFrmPanel.Size = new Size(449, 446);
            AnaFrmPanel.TabIndex = 0;
            // 
            // morfolojikAnalizBtn
            // 
            morfolojikAnalizBtn.BackColor = Color.LightGreen;
            morfolojikAnalizBtn.FlatStyle = FlatStyle.Popup;
            morfolojikAnalizBtn.Location = new Point(13, 273);
            morfolojikAnalizBtn.Name = "morfolojikAnalizBtn";
            morfolojikAnalizBtn.Size = new Size(418, 44);
            morfolojikAnalizBtn.TabIndex = 5;
            morfolojikAnalizBtn.Text = "Morfolojik Analiz Getir";
            morfolojikAnalizBtn.UseVisualStyleBackColor = false;
            morfolojikAnalizBtn.Click += morfolojikAnalizBtn_Click_1;
            // 
            // rgxAraBtn
            // 
            rgxAraBtn.BackColor = Color.LightGreen;
            rgxAraBtn.FlatStyle = FlatStyle.Popup;
            rgxAraBtn.Location = new Point(205, 169);
            rgxAraBtn.Name = "rgxAraBtn";
            rgxAraBtn.Size = new Size(225, 35);
            rgxAraBtn.TabIndex = 4;
            rgxAraBtn.Text = "Ara";
            rgxAraBtn.UseVisualStyleBackColor = false;
            rgxAraBtn.Click += rgxAraBtn_Click;
            // 
            // rgxAraTxtBx
            // 
            rgxAraTxtBx.BorderStyle = BorderStyle.FixedSingle;
            rgxAraTxtBx.Location = new Point(205, 104);
            rgxAraTxtBx.Name = "rgxAraTxtBx";
            rgxAraTxtBx.Size = new Size(226, 27);
            rgxAraTxtBx.TabIndex = 3;
            // 
            // rgxLbl
            // 
            rgxLbl.AutoSize = true;
            rgxLbl.Location = new Point(12, 111);
            rgxLbl.Name = "rgxLbl";
            rgxLbl.Size = new Size(166, 20);
            rgxLbl.TabIndex = 2;
            rgxLbl.Text = "Regex ifadesini giriniz  :";
            // 
            // dosyaAdiLbl
            // 
            dosyaAdiLbl.AutoSize = true;
            dosyaAdiLbl.Location = new Point(12, 46);
            dosyaAdiLbl.Name = "dosyaAdiLbl";
            dosyaAdiLbl.Size = new Size(138, 20);
            dosyaAdiLbl.TabIndex = 1;
            dosyaAdiLbl.Text = "Dosya Seçilemedi  :";
            // 
            // dosyaEkleBtn
            // 
            dosyaEkleBtn.FlatStyle = FlatStyle.Popup;
            dosyaEkleBtn.Location = new Point(205, 39);
            dosyaEkleBtn.Name = "dosyaEkleBtn";
            dosyaEkleBtn.Size = new Size(225, 34);
            dosyaEkleBtn.TabIndex = 0;
            dosyaEkleBtn.Text = "Dosya Ekle";
            dosyaEkleBtn.UseVisualStyleBackColor = true;
            dosyaEkleBtn.Click += dosyaEkleBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(517, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 445);
            panel1.TabIndex = 1;
            // 
            // AnaFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1001, 499);
            Controls.Add(panel1);
            Controls.Add(AnaFrmPanel);
            Name = "AnaFrm";
            Text = "Form1";
            AnaFrmPanel.ResumeLayout(false);
            AnaFrmPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AnaFrmPanel;
        private Button dosyaEkleBtn;
        private Panel panel1;
        private Label dosyaAdiLbl;
        private Label rgxLbl;
        private TextBox rgxAraTxtBx;
        private Button rgxAraBtn;
        private Button morfolojikAnalizBtn;
    }
}
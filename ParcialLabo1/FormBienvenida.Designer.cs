namespace ParcialLabo1
{
    partial class FormBienvenida
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenida));
            labelBienvenidoNOmbre = new Label();
            labelSitemaInfo = new Label();
            panelWelcome = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            timerFadeIn = new System.Windows.Forms.Timer(components);
            timerFadeOut = new System.Windows.Forms.Timer(components);
            panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelBienvenidoNOmbre
            // 
            labelBienvenidoNOmbre.AutoSize = true;
            labelBienvenidoNOmbre.Font = new Font("Microsoft JhengHei UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelBienvenidoNOmbre.Location = new Point(752, 478);
            labelBienvenidoNOmbre.Name = "labelBienvenidoNOmbre";
            labelBienvenidoNOmbre.Size = new Size(300, 60);
            labelBienvenidoNOmbre.TabIndex = 1;
            labelBienvenidoNOmbre.Text = "¡Bienvenido!";
            // 
            // labelSitemaInfo
            // 
            labelSitemaInfo.AutoSize = true;
            labelSitemaInfo.BackColor = Color.Transparent;
            labelSitemaInfo.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelSitemaInfo.ForeColor = Color.Azure;
            labelSitemaInfo.Location = new Point(537, 248);
            labelSitemaInfo.Name = "labelSitemaInfo";
            labelSitemaInfo.Size = new Size(515, 50);
            labelSitemaInfo.TabIndex = 2;
            labelSitemaInfo.Text = "Sistema de administracion";
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.SteelBlue;
            panelWelcome.Controls.Add(label3);
            panelWelcome.Controls.Add(label2);
            panelWelcome.Controls.Add(pictureBox2);
            panelWelcome.Dock = DockStyle.Top;
            panelWelcome.Location = new Point(0, 0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(1342, 110);
            panelWelcome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(185, 45);
            label3.Name = "label3";
            label3.Size = new Size(126, 38);
            label3.TabIndex = 7;
            label3.Text = "Express";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(112, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 6;
            label2.Text = "Aerolineas";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-351, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1181, 703);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(644, 298);
            label1.Name = "label1";
            label1.Size = new Size(278, 50);
            label1.TabIndex = 5;
            label1.Text = "de Aerolineas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(928, 298);
            label4.Name = "label4";
            label4.Size = new Size(163, 50);
            label4.TabIndex = 6;
            label4.Text = "Express";
            // 
            // timerFadeIn
            // 
            timerFadeIn.Interval = 30;
            timerFadeIn.Tick += timer1_Tick;
            // 
            // timerFadeOut
            // 
            timerFadeOut.Interval = 30;
            timerFadeOut.Tick += timerFadeOut_Tick;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(1342, 721);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(labelBienvenidoNOmbre);
            Controls.Add(labelSitemaInfo);
            Controls.Add(pictureBox1);
            Controls.Add(panelWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBienvenida";
            Load += FormBienvenida_Load;
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelBienvenidoNOmbre;
        private Label labelSitemaInfo;
        private Panel panelWelcome;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Timer timerFadeOut;
    }
}
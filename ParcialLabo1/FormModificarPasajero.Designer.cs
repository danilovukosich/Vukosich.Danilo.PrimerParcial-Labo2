namespace ParcialLabo1
{
    partial class FormModificarPasajero
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
            panel1 = new Panel();
            label4 = new Label();
            textBoxApellido = new TextBox();
            label3 = new Label();
            textBoxNombre = new TextBox();
            label2 = new Label();
            labelDniValor = new Label();
            label1 = new Label();
            numericUpDownEdad = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelDniValor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDownEdad);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 426);
            panel1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(143, 215);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 23;
            label4.Text = "Edad";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(228, 148);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(125, 27);
            textBoxApellido.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(143, 148);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 21;
            label3.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(228, 92);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 92);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // labelDniValor
            // 
            labelDniValor.AutoSize = true;
            labelDniValor.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelDniValor.Location = new Point(228, 36);
            labelDniValor.Name = "labelDniValor";
            labelDniValor.Size = new Size(37, 22);
            labelDniValor.TabIndex = 19;
            labelDniValor.Text = "dni";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(178, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 22);
            label1.TabIndex = 0;
            label1.Text = "Dni";
            // 
            // numericUpDownEdad
            // 
            numericUpDownEdad.Location = new Point(228, 214);
            numericUpDownEdad.Name = "numericUpDownEdad";
            numericUpDownEdad.Size = new Size(125, 27);
            numericUpDownEdad.TabIndex = 17;
            // 
            // FormModificarPasajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificarPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarPasajero";
            Load += FormModificarPasajero_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDownAsientosPremium;
        private NumericUpDown numericUpDownAsientosTurista;
        private Label label2;
        private Label labelDniValor;
        private Label label1;
        private NumericUpDown numericUpDownEdad;
        private Label label4;
        private TextBox textBoxApellido;
        private Label label3;
        private TextBox textBoxNombre;
        private NumericUpDown numericUpDownCantidadBanos;
        private GroupBox groupBoxComida;
        private RadioButton radioButtonNoComida;
        private RadioButton radioButtonSiComida;
        private GroupBox groupBoxInternet;
        private RadioButton radioButtonSiInternet;
        private Label label7;
        private RadioButton radioButtonNoInternet;
        private Label label5;
    }
}
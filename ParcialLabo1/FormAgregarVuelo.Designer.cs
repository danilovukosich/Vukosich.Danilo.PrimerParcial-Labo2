namespace ParcialLabo1
{
    partial class FormAgregarVuelo
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
            dataGridViewAeronaves = new DataGridView();
            matriculaAeronave = new DataGridViewTextBoxColumn();
            internet = new DataGridViewTextBoxColumn();
            comida = new DataGridViewTextBoxColumn();
            capacidadBodega = new DataGridViewTextBoxColumn();
            asientosPrem = new DataGridViewTextBoxColumn();
            asientosTurista = new DataGridViewTextBoxColumn();
            label7 = new Label();
            dateTimePickerHorarioSalida = new DateTimePicker();
            label6 = new Label();
            comboBoxAeronaveDelVuelo = new ComboBox();
            label5 = new Label();
            groupBoxDestino = new GroupBox();
            radioButtonViajeInternacional = new RadioButton();
            radioButtonViajeNacional = new RadioButton();
            comboBoxVueloPartida = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePickerFechaVuelo = new DateTimePicker();
            comboBoxDestinos = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            buttonCancelar = new Button();
            buttonAgregarVuelo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAeronaves).BeginInit();
            groupBoxDestino.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(dataGridViewAeronaves);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePickerHorarioSalida);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxAeronaveDelVuelo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(groupBoxDestino);
            panel1.Controls.Add(comboBoxVueloPartida);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePickerFechaVuelo);
            panel1.Controls.Add(comboBoxDestinos);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 338);
            panel1.TabIndex = 11;
            // 
            // dataGridViewAeronaves
            // 
            dataGridViewAeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAeronaves.Columns.AddRange(new DataGridViewColumn[] { matriculaAeronave, internet, comida, capacidadBodega, asientosPrem, asientosTurista });
            dataGridViewAeronaves.Location = new Point(663, 58);
            dataGridViewAeronaves.Name = "dataGridViewAeronaves";
            dataGridViewAeronaves.RowHeadersWidth = 51;
            dataGridViewAeronaves.RowTemplate.Height = 29;
            dataGridViewAeronaves.Size = new Size(492, 263);
            dataGridViewAeronaves.TabIndex = 30;
            // 
            // matriculaAeronave
            // 
            matriculaAeronave.HeaderText = "Matricula";
            matriculaAeronave.MinimumWidth = 6;
            matriculaAeronave.Name = "matriculaAeronave";
            matriculaAeronave.ReadOnly = true;
            matriculaAeronave.Width = 125;
            // 
            // internet
            // 
            internet.HeaderText = "Internet";
            internet.MinimumWidth = 6;
            internet.Name = "internet";
            internet.ReadOnly = true;
            internet.Width = 125;
            // 
            // comida
            // 
            comida.HeaderText = "Comida";
            comida.MinimumWidth = 6;
            comida.Name = "comida";
            comida.ReadOnly = true;
            comida.Width = 125;
            // 
            // capacidadBodega
            // 
            capacidadBodega.HeaderText = "Bodega";
            capacidadBodega.MinimumWidth = 6;
            capacidadBodega.Name = "capacidadBodega";
            capacidadBodega.ReadOnly = true;
            capacidadBodega.Width = 125;
            // 
            // asientosPrem
            // 
            asientosPrem.HeaderText = "Asientos Prem.";
            asientosPrem.MinimumWidth = 6;
            asientosPrem.Name = "asientosPrem";
            asientosPrem.ReadOnly = true;
            asientosPrem.Width = 125;
            // 
            // asientosTurista
            // 
            asientosTurista.HeaderText = "Asientos Tur.";
            asientosTurista.MinimumWidth = 6;
            asientosTurista.Name = "asientosTurista";
            asientosTurista.ReadOnly = true;
            asientosTurista.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(663, 19);
            label7.Name = "label7";
            label7.Size = new Size(387, 36);
            label7.TabIndex = 29;
            label7.Text = "Lista aeronaves disponibles";
            // 
            // dateTimePickerHorarioSalida
            // 
            dateTimePickerHorarioSalida.Location = new Point(176, 282);
            dateTimePickerHorarioSalida.Name = "dateTimePickerHorarioSalida";
            dateTimePickerHorarioSalida.Size = new Size(156, 27);
            dateTimePickerHorarioSalida.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(58, 288);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 27;
            label6.Text = "Horario Salida";
            // 
            // comboBoxAeronaveDelVuelo
            // 
            comboBoxAeronaveDelVuelo.FormattingEnabled = true;
            comboBoxAeronaveDelVuelo.Location = new Point(181, 76);
            comboBoxAeronaveDelVuelo.Name = "comboBoxAeronaveDelVuelo";
            comboBoxAeronaveDelVuelo.Size = new Size(151, 28);
            comboBoxAeronaveDelVuelo.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 80);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 25;
            label5.Text = "Aeronave";
            // 
            // groupBoxDestino
            // 
            groupBoxDestino.Controls.Add(radioButtonViajeInternacional);
            groupBoxDestino.Controls.Add(radioButtonViajeNacional);
            groupBoxDestino.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDestino.Location = new Point(431, 74);
            groupBoxDestino.Name = "groupBoxDestino";
            groupBoxDestino.Size = new Size(188, 115);
            groupBoxDestino.TabIndex = 24;
            groupBoxDestino.TabStop = false;
            groupBoxDestino.Text = "Viaje";
            // 
            // radioButtonViajeInternacional
            // 
            radioButtonViajeInternacional.AutoSize = true;
            radioButtonViajeInternacional.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonViajeInternacional.Location = new Point(31, 44);
            radioButtonViajeInternacional.Name = "radioButtonViajeInternacional";
            radioButtonViajeInternacional.Size = new Size(120, 23);
            radioButtonViajeInternacional.TabIndex = 22;
            radioButtonViajeInternacional.TabStop = true;
            radioButtonViajeInternacional.Text = "Internacional";
            radioButtonViajeInternacional.UseVisualStyleBackColor = true;
            radioButtonViajeInternacional.CheckedChanged += radioButtonViajeInternacional_CheckedChanged;
            // 
            // radioButtonViajeNacional
            // 
            radioButtonViajeNacional.AutoSize = true;
            radioButtonViajeNacional.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonViajeNacional.Location = new Point(31, 73);
            radioButtonViajeNacional.Name = "radioButtonViajeNacional";
            radioButtonViajeNacional.Size = new Size(91, 23);
            radioButtonViajeNacional.TabIndex = 23;
            radioButtonViajeNacional.TabStop = true;
            radioButtonViajeNacional.Text = "Nacional";
            radioButtonViajeNacional.UseVisualStyleBackColor = true;
            radioButtonViajeNacional.CheckedChanged += radioButtonViajeNacional_CheckedChanged;
            // 
            // comboBoxVueloPartida
            // 
            comboBoxVueloPartida.FormattingEnabled = true;
            comboBoxVueloPartida.Location = new Point(181, 147);
            comboBoxVueloPartida.Name = "comboBoxVueloPartida";
            comboBoxVueloPartida.Size = new Size(151, 28);
            comboBoxVueloPartida.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(109, 151);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 20;
            label3.Text = "Partida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(119, 223);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 19;
            label2.Text = "Fecha";
            // 
            // dateTimePickerFechaVuelo
            // 
            dateTimePickerFechaVuelo.CustomFormat = "";
            dateTimePickerFechaVuelo.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFechaVuelo.Location = new Point(176, 217);
            dateTimePickerFechaVuelo.MaxDate = new DateTime(2030, 12, 1, 0, 0, 0, 0);
            dateTimePickerFechaVuelo.MinDate = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            dateTimePickerFechaVuelo.Name = "dateTimePickerFechaVuelo";
            dateTimePickerFechaVuelo.Size = new Size(156, 27);
            dateTimePickerFechaVuelo.TabIndex = 18;
            dateTimePickerFechaVuelo.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // comboBoxDestinos
            // 
            comboBoxDestinos.FormattingEnabled = true;
            comboBoxDestinos.Location = new Point(468, 221);
            comboBoxDestinos.Name = "comboBoxDestinos";
            comboBoxDestinos.Size = new Size(151, 28);
            comboBoxDestinos.TabIndex = 17;
            comboBoxDestinos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 225);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 16;
            label1.Text = "Destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(218, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 36);
            label4.TabIndex = 14;
            label4.Text = "Agregar Vuelo";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.Highlight;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancelar.Location = new Point(648, 366);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(156, 63);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAgregarVuelo
            // 
            buttonAgregarVuelo.BackColor = SystemColors.Highlight;
            buttonAgregarVuelo.Cursor = Cursors.Hand;
            buttonAgregarVuelo.FlatStyle = FlatStyle.Flat;
            buttonAgregarVuelo.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarVuelo.ForeColor = SystemColors.ActiveCaptionText;
            buttonAgregarVuelo.Location = new Point(443, 366);
            buttonAgregarVuelo.Name = "buttonAgregarVuelo";
            buttonAgregarVuelo.Size = new Size(156, 63);
            buttonAgregarVuelo.TabIndex = 9;
            buttonAgregarVuelo.Text = "Agregar";
            buttonAgregarVuelo.UseVisualStyleBackColor = false;
            buttonAgregarVuelo.Click += buttonAgregarVuelo_Click;
            // 
            // FormAgregarVuelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(1222, 450);
            Controls.Add(panel1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAgregarVuelo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarVuelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarVuelo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAeronaves).EndInit();
            groupBoxDestino.ResumeLayout(false);
            groupBoxDestino.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button buttonCancelar;
        private Button buttonAgregarVuelo;
        private Label label1;
        private ComboBox comboBoxDestinos;
        private DateTimePicker dateTimePickerFechaVuelo;
        private ComboBox comboBoxVueloPartida;
        private Label label3;
        private Label label2;
        private GroupBox groupBoxDestino;
        private RadioButton radioButtonViajeInternacional;
        private RadioButton radioButtonViajeNacional;
        private ComboBox comboBoxAeronaveDelVuelo;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerHorarioSalida;
        private DataGridView dataGridViewAeronaves;
        private DataGridViewTextBoxColumn matriculaAeronave;
        private DataGridViewTextBoxColumn internet;
        private DataGridViewTextBoxColumn comida;
        private DataGridViewTextBoxColumn capacidadBodega;
        private DataGridViewTextBoxColumn asientosPrem;
        private DataGridViewTextBoxColumn asientosTurista;
        private Label label7;
    }
}
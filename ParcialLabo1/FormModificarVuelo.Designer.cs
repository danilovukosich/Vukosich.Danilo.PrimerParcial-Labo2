namespace ParcialLabo1
{
    partial class FormModificarVuelo
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
            buttonModificarVuelo = new Button();
            buttonCancelar = new Button();
            dateTimePickerHorarioSalida = new DateTimePicker();
            label6 = new Label();
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
            groupBoxDestino.SuspendLayout();
            SuspendLayout();
            // 
            // buttonModificarVuelo
            // 
            buttonModificarVuelo.BackColor = SystemColors.ButtonHighlight;
            buttonModificarVuelo.FlatStyle = FlatStyle.Popup;
            buttonModificarVuelo.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModificarVuelo.Location = new Point(238, 368);
            buttonModificarVuelo.Name = "buttonModificarVuelo";
            buttonModificarVuelo.Size = new Size(151, 61);
            buttonModificarVuelo.TabIndex = 2;
            buttonModificarVuelo.Text = "Modificar";
            buttonModificarVuelo.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.Red;
            buttonCancelar.Location = new Point(409, 368);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(151, 61);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerHorarioSalida
            // 
            dateTimePickerHorarioSalida.Location = new Point(207, 229);
            dateTimePickerHorarioSalida.Name = "dateTimePickerHorarioSalida";
            dateTimePickerHorarioSalida.Size = new Size(156, 27);
            dateTimePickerHorarioSalida.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, 235);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 36;
            label6.Text = "Horario Salida";
            // 
            // groupBoxDestino
            // 
            groupBoxDestino.Controls.Add(radioButtonViajeInternacional);
            groupBoxDestino.Controls.Add(radioButtonViajeNacional);
            groupBoxDestino.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDestino.Location = new Point(418, 94);
            groupBoxDestino.Name = "groupBoxDestino";
            groupBoxDestino.Size = new Size(188, 115);
            groupBoxDestino.TabIndex = 35;
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
            comboBoxVueloPartida.Location = new Point(212, 94);
            comboBoxVueloPartida.Name = "comboBoxVueloPartida";
            comboBoxVueloPartida.Size = new Size(151, 28);
            comboBoxVueloPartida.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(140, 98);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 33;
            label3.Text = "Partida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 170);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 32;
            label2.Text = "Fecha";
            // 
            // dateTimePickerFechaVuelo
            // 
            dateTimePickerFechaVuelo.CustomFormat = "";
            dateTimePickerFechaVuelo.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFechaVuelo.Location = new Point(207, 164);
            dateTimePickerFechaVuelo.MaxDate = new DateTime(2030, 12, 1, 0, 0, 0, 0);
            dateTimePickerFechaVuelo.MinDate = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            dateTimePickerFechaVuelo.Name = "dateTimePickerFechaVuelo";
            dateTimePickerFechaVuelo.Size = new Size(156, 27);
            dateTimePickerFechaVuelo.TabIndex = 31;
            dateTimePickerFechaVuelo.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // comboBoxDestinos
            // 
            comboBoxDestinos.FormattingEnabled = true;
            comboBoxDestinos.Location = new Point(490, 238);
            comboBoxDestinos.Name = "comboBoxDestinos";
            comboBoxDestinos.Size = new Size(151, 28);
            comboBoxDestinos.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(418, 242);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 29;
            label1.Text = "Destino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(274, 23);
            label4.Name = "label4";
            label4.Size = new Size(232, 36);
            label4.TabIndex = 38;
            label4.Text = "Modificar Vuelo";
            // 
            // FormModificarVuelo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dateTimePickerHorarioSalida);
            Controls.Add(label6);
            Controls.Add(groupBoxDestino);
            Controls.Add(comboBoxVueloPartida);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerFechaVuelo);
            Controls.Add(comboBoxDestinos);
            Controls.Add(label1);
            Controls.Add(buttonModificarVuelo);
            Controls.Add(buttonCancelar);
            Name = "FormModificarVuelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormModificarVuelo";
            groupBoxDestino.ResumeLayout(false);
            groupBoxDestino.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonModificarVuelo;
        private Button buttonCancelar;
        private DateTimePicker dateTimePickerHorarioSalida;
        private Label label6;
        private GroupBox groupBoxDestino;
        private RadioButton radioButtonViajeInternacional;
        private RadioButton radioButtonViajeNacional;
        private ComboBox comboBoxVueloPartida;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerFechaVuelo;
        private ComboBox comboBoxDestinos;
        private Label label1;
        private Label label4;
    }
}
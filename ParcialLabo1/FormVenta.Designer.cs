namespace ParcialLabo1
{
    partial class FormVenta
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
            label2 = new Label();
            panel1 = new Panel();
            textBoxCodigoVuelo = new TextBox();
            textBoxDniPasajero = new TextBox();
            label5 = new Label();
            numericUpDownPesoequipaje = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            dataGridViewListaPasajeros = new DataGridView();
            dniPasajero = new DataGridViewTextBoxColumn();
            nombrePasajero = new DataGridViewTextBoxColumn();
            apellidoPasajero = new DataGridViewTextBoxColumn();
            dataGridViewListaVuelos = new DataGridView();
            codigoVuelo = new DataGridViewTextBoxColumn();
            fechaPartida = new DataGridViewTextBoxColumn();
            horarioPartida = new DataGridViewTextBoxColumn();
            partida = new DataGridViewTextBoxColumn();
            destino = new DataGridViewTextBoxColumn();
            asientosPremium = new DataGridViewTextBoxColumn();
            precioPremium = new DataGridViewTextBoxColumn();
            asientoTurista = new DataGridViewTextBoxColumn();
            precioTurista = new DataGridViewTextBoxColumn();
            duracionVuelo = new DataGridViewTextBoxColumn();
            checkBoxEquipajeBodega = new CheckBox();
            checkBoxEquipajeMano = new CheckBox();
            groupBoxClases = new GroupBox();
            radioButtonClaseTurista = new RadioButton();
            radioButtonClasePremium = new RadioButton();
            label1 = new Label();
            buttonAgregarVuelo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPesoequipaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPasajeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelos).BeginInit();
            groupBoxClases.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 24);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 5;
            label2.Text = "Codigo de Vuelo";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxCodigoVuelo);
            panel1.Controls.Add(textBoxDniPasajero);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericUpDownPesoequipaje);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridViewListaPasajeros);
            panel1.Controls.Add(dataGridViewListaVuelos);
            panel1.Controls.Add(checkBoxEquipajeBodega);
            panel1.Controls.Add(checkBoxEquipajeMano);
            panel1.Controls.Add(groupBoxClases);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 462);
            panel1.TabIndex = 6;
            // 
            // textBoxCodigoVuelo
            // 
            textBoxCodigoVuelo.Location = new Point(59, 50);
            textBoxCodigoVuelo.Name = "textBoxCodigoVuelo";
            textBoxCodigoVuelo.Size = new Size(151, 27);
            textBoxCodigoVuelo.TabIndex = 35;
            // 
            // textBoxDniPasajero
            // 
            textBoxDniPasajero.Location = new Point(250, 51);
            textBoxDniPasajero.Name = "textBoxDniPasajero";
            textBoxDniPasajero.Size = new Size(151, 27);
            textBoxDniPasajero.TabIndex = 34;
            textBoxDniPasajero.KeyPress += textBoxDniPasajero_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(845, 21);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 33;
            label5.Text = "Peso equipaje";
            // 
            // numericUpDownPesoequipaje
            // 
            numericUpDownPesoequipaje.Location = new Point(845, 50);
            numericUpDownPesoequipaje.Name = "numericUpDownPesoequipaje";
            numericUpDownPesoequipaje.Size = new Size(127, 27);
            numericUpDownPesoequipaje.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(572, 96);
            label4.Name = "label4";
            label4.Size = new Size(247, 23);
            label4.TabIndex = 31;
            label4.Text = "Lista Pasajeros Disponibles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 94);
            label3.Name = "label3";
            label3.Size = new Size(223, 23);
            label3.TabIndex = 30;
            label3.Text = "Lista Vuelos Disponibles";
            // 
            // dataGridViewListaPasajeros
            // 
            dataGridViewListaPasajeros.BackgroundColor = Color.MediumAquamarine;
            dataGridViewListaPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaPasajeros.Columns.AddRange(new DataGridViewColumn[] { dniPasajero, nombrePasajero, apellidoPasajero });
            dataGridViewListaPasajeros.Location = new Point(572, 120);
            dataGridViewListaPasajeros.Name = "dataGridViewListaPasajeros";
            dataGridViewListaPasajeros.RowHeadersWidth = 51;
            dataGridViewListaPasajeros.RowTemplate.Height = 29;
            dataGridViewListaPasajeros.Size = new Size(411, 338);
            dataGridViewListaPasajeros.TabIndex = 29;
            // 
            // dniPasajero
            // 
            dniPasajero.HeaderText = "Dni";
            dniPasajero.MinimumWidth = 6;
            dniPasajero.Name = "dniPasajero";
            dniPasajero.ReadOnly = true;
            dniPasajero.Width = 125;
            // 
            // nombrePasajero
            // 
            nombrePasajero.HeaderText = "Nombre";
            nombrePasajero.MinimumWidth = 6;
            nombrePasajero.Name = "nombrePasajero";
            nombrePasajero.ReadOnly = true;
            nombrePasajero.Width = 125;
            // 
            // apellidoPasajero
            // 
            apellidoPasajero.HeaderText = "Apellido";
            apellidoPasajero.MinimumWidth = 6;
            apellidoPasajero.Name = "apellidoPasajero";
            apellidoPasajero.ReadOnly = true;
            apellidoPasajero.Width = 125;
            // 
            // dataGridViewListaVuelos
            // 
            dataGridViewListaVuelos.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaVuelos.Columns.AddRange(new DataGridViewColumn[] { codigoVuelo, fechaPartida, horarioPartida, partida, destino, asientosPremium, precioPremium, asientoTurista, precioTurista, duracionVuelo });
            dataGridViewListaVuelos.Location = new Point(17, 120);
            dataGridViewListaVuelos.Name = "dataGridViewListaVuelos";
            dataGridViewListaVuelos.RowHeadersWidth = 51;
            dataGridViewListaVuelos.RowTemplate.Height = 29;
            dataGridViewListaVuelos.Size = new Size(536, 338);
            dataGridViewListaVuelos.TabIndex = 28;
            // 
            // codigoVuelo
            // 
            codigoVuelo.HeaderText = "Codigo";
            codigoVuelo.MinimumWidth = 6;
            codigoVuelo.Name = "codigoVuelo";
            codigoVuelo.ReadOnly = true;
            codigoVuelo.Width = 125;
            // 
            // fechaPartida
            // 
            fechaPartida.HeaderText = "Fecha Partida";
            fechaPartida.MinimumWidth = 6;
            fechaPartida.Name = "fechaPartida";
            fechaPartida.ReadOnly = true;
            fechaPartida.Width = 125;
            // 
            // horarioPartida
            // 
            horarioPartida.HeaderText = "Horario Partida";
            horarioPartida.MinimumWidth = 6;
            horarioPartida.Name = "horarioPartida";
            horarioPartida.ReadOnly = true;
            horarioPartida.Width = 125;
            // 
            // partida
            // 
            partida.HeaderText = "Partida";
            partida.MinimumWidth = 6;
            partida.Name = "partida";
            partida.ReadOnly = true;
            partida.Width = 125;
            // 
            // destino
            // 
            destino.HeaderText = "Destino";
            destino.MinimumWidth = 6;
            destino.Name = "destino";
            destino.ReadOnly = true;
            destino.Width = 125;
            // 
            // asientosPremium
            // 
            asientosPremium.HeaderText = "Asientos Premium";
            asientosPremium.MinimumWidth = 6;
            asientosPremium.Name = "asientosPremium";
            asientosPremium.ReadOnly = true;
            asientosPremium.Width = 125;
            // 
            // precioPremium
            // 
            precioPremium.HeaderText = "Precio Premium";
            precioPremium.MinimumWidth = 6;
            precioPremium.Name = "precioPremium";
            precioPremium.ReadOnly = true;
            precioPremium.Width = 125;
            // 
            // asientoTurista
            // 
            asientoTurista.HeaderText = "Asientos Turista";
            asientoTurista.MinimumWidth = 6;
            asientoTurista.Name = "asientoTurista";
            asientoTurista.ReadOnly = true;
            asientoTurista.Width = 125;
            // 
            // precioTurista
            // 
            precioTurista.HeaderText = "PrecioTurista";
            precioTurista.MinimumWidth = 6;
            precioTurista.Name = "precioTurista";
            precioTurista.ReadOnly = true;
            precioTurista.Width = 125;
            // 
            // duracionVuelo
            // 
            duracionVuelo.HeaderText = "Duracion";
            duracionVuelo.MinimumWidth = 6;
            duracionVuelo.Name = "duracionVuelo";
            duracionVuelo.ReadOnly = true;
            duracionVuelo.Width = 125;
            // 
            // checkBoxEquipajeBodega
            // 
            checkBoxEquipajeBodega.AutoSize = true;
            checkBoxEquipajeBodega.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxEquipajeBodega.Location = new Point(651, 53);
            checkBoxEquipajeBodega.Name = "checkBoxEquipajeBodega";
            checkBoxEquipajeBodega.Size = new Size(166, 26);
            checkBoxEquipajeBodega.TabIndex = 27;
            checkBoxEquipajeBodega.Text = "Equipaje Bodega";
            checkBoxEquipajeBodega.UseVisualStyleBackColor = true;
            // 
            // checkBoxEquipajeMano
            // 
            checkBoxEquipajeMano.AutoSize = true;
            checkBoxEquipajeMano.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxEquipajeMano.Location = new Point(651, 21);
            checkBoxEquipajeMano.Name = "checkBoxEquipajeMano";
            checkBoxEquipajeMano.Size = new Size(150, 26);
            checkBoxEquipajeMano.TabIndex = 26;
            checkBoxEquipajeMano.Text = "Equipaje mano";
            checkBoxEquipajeMano.UseVisualStyleBackColor = true;
            // 
            // groupBoxClases
            // 
            groupBoxClases.Controls.Add(radioButtonClaseTurista);
            groupBoxClases.Controls.Add(radioButtonClasePremium);
            groupBoxClases.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxClases.Location = new Point(443, 3);
            groupBoxClases.Name = "groupBoxClases";
            groupBoxClases.Size = new Size(188, 90);
            groupBoxClases.TabIndex = 25;
            groupBoxClases.TabStop = false;
            groupBoxClases.Text = "Clase";
            // 
            // radioButtonClaseTurista
            // 
            radioButtonClaseTurista.AutoSize = true;
            radioButtonClaseTurista.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonClaseTurista.Location = new Point(33, 28);
            radioButtonClaseTurista.Name = "radioButtonClaseTurista";
            radioButtonClaseTurista.Size = new Size(77, 23);
            radioButtonClaseTurista.TabIndex = 22;
            radioButtonClaseTurista.TabStop = true;
            radioButtonClaseTurista.Text = "Turista";
            radioButtonClaseTurista.UseVisualStyleBackColor = true;
            radioButtonClaseTurista.CheckedChanged += radioButtonClaseTurista_CheckedChanged;
            // 
            // radioButtonClasePremium
            // 
            radioButtonClasePremium.AutoSize = true;
            radioButtonClasePremium.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonClasePremium.Location = new Point(33, 57);
            radioButtonClasePremium.Name = "radioButtonClasePremium";
            radioButtonClasePremium.Size = new Size(94, 23);
            radioButtonClasePremium.TabIndex = 23;
            radioButtonClasePremium.TabStop = true;
            radioButtonClasePremium.Text = "Premium";
            radioButtonClasePremium.UseVisualStyleBackColor = true;
            radioButtonClasePremium.CheckedChanged += radioButtonClasePremium_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 24);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 7;
            label1.Text = "DNI Pasajero";
            // 
            // buttonAgregarVuelo
            // 
            buttonAgregarVuelo.BackColor = SystemColors.Highlight;
            buttonAgregarVuelo.Cursor = Cursors.Hand;
            buttonAgregarVuelo.FlatStyle = FlatStyle.Flat;
            buttonAgregarVuelo.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarVuelo.ForeColor = SystemColors.ActiveCaptionText;
            buttonAgregarVuelo.Location = new Point(58, 480);
            buttonAgregarVuelo.Name = "buttonAgregarVuelo";
            buttonAgregarVuelo.Size = new Size(938, 63);
            buttonAgregarVuelo.TabIndex = 10;
            buttonAgregarVuelo.Text = "Vender";
            buttonAgregarVuelo.UseVisualStyleBackColor = false;
            buttonAgregarVuelo.Click += buttonAgregarVuelo_Click;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1052, 548);
            Controls.Add(buttonAgregarVuelo);
            Controls.Add(panel1);
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPesoequipaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPasajeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelos).EndInit();
            groupBoxClases.ResumeLayout(false);
            groupBoxClases.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button buttonAgregarVuelo;
        private CheckBox checkBoxEquipajeBodega;
        private CheckBox checkBoxEquipajeMano;
        private GroupBox groupBoxClases;
        private RadioButton radioButtonClaseTurista;
        private RadioButton radioButtonClasePremium;
        private DataGridView dataGridViewListaVuelos;
        private DataGridViewTextBoxColumn codigoVuelo;
        private DataGridViewTextBoxColumn fechaPartida;
        private DataGridViewTextBoxColumn horarioPartida;
        private DataGridViewTextBoxColumn partida;
        private DataGridViewTextBoxColumn destino;
        private DataGridViewTextBoxColumn asientosPremium;
        private DataGridViewTextBoxColumn precioPremium;
        private DataGridViewTextBoxColumn asientoTurista;
        private DataGridViewTextBoxColumn precioTurista;
        private DataGridViewTextBoxColumn duracionVuelo;
        private Label label4;
        private Label label3;
        private DataGridView dataGridViewListaPasajeros;
        private Label label5;
        private NumericUpDown numericUpDownPesoequipaje;
        private DataGridViewTextBoxColumn dniPasajero;
        private DataGridViewTextBoxColumn nombrePasajero;
        private DataGridViewTextBoxColumn apellidoPasajero;
        private TextBox textBoxDniPasajero;
        private ComboBox comboBoxCodigoVuelos;
        private TextBox textBoxCodigoVuelo;
    }
}
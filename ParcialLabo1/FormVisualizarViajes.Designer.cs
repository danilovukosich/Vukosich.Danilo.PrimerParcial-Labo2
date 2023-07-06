namespace ParcialLabo1
{
    partial class FormVisualizarViajes
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
            dataGridViewListaVuelos = new DataGridView();
            label2 = new Label();
            comboBoxCodigoVuelo = new ComboBox();
            dataGridViewPasajerosVuelo = new DataGridView();
            dniPasajero = new DataGridViewTextBoxColumn();
            nombrePasajero = new DataGridViewTextBoxColumn();
            apellidoPasajero = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label1 = new Label();
            codigoVuelo = new DataGridViewTextBoxColumn();
            fechaPartida = new DataGridViewTextBoxColumn();
            horarioPartida = new DataGridViewTextBoxColumn();
            partida = new DataGridViewTextBoxColumn();
            destino = new DataGridViewTextBoxColumn();
            ganaciaTotal = new DataGridViewTextBoxColumn();
            pesoBodega = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasajerosVuelo).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaVuelos
            // 
            dataGridViewListaVuelos.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaVuelos.Columns.AddRange(new DataGridViewColumn[] { codigoVuelo, fechaPartida, horarioPartida, partida, destino, ganaciaTotal, pesoBodega });
            dataGridViewListaVuelos.Location = new Point(30, 38);
            dataGridViewListaVuelos.Name = "dataGridViewListaVuelos";
            dataGridViewListaVuelos.RowHeadersWidth = 51;
            dataGridViewListaVuelos.RowTemplate.Height = 29;
            dataGridViewListaVuelos.Size = new Size(679, 478);
            dataGridViewListaVuelos.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(794, 35);
            label2.Name = "label2";
            label2.Size = new Size(218, 23);
            label2.TabIndex = 31;
            label2.Text = "Ingrese Codigo de Vuelo";
            // 
            // comboBoxCodigoVuelo
            // 
            comboBoxCodigoVuelo.FormattingEnabled = true;
            comboBoxCodigoVuelo.Location = new Point(824, 61);
            comboBoxCodigoVuelo.Name = "comboBoxCodigoVuelo";
            comboBoxCodigoVuelo.Size = new Size(151, 28);
            comboBoxCodigoVuelo.TabIndex = 30;
            comboBoxCodigoVuelo.SelectedIndexChanged += comboBoxCodigoVuelo_SelectedIndexChanged;
            // 
            // dataGridViewPasajerosVuelo
            // 
            dataGridViewPasajerosVuelo.BackgroundColor = Color.MediumAquamarine;
            dataGridViewPasajerosVuelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPasajerosVuelo.Columns.AddRange(new DataGridViewColumn[] { dniPasajero, nombrePasajero, apellidoPasajero });
            dataGridViewPasajerosVuelo.Location = new Point(727, 128);
            dataGridViewPasajerosVuelo.Name = "dataGridViewPasajerosVuelo";
            dataGridViewPasajerosVuelo.RowHeadersWidth = 51;
            dataGridViewPasajerosVuelo.RowTemplate.Height = 29;
            dataGridViewPasajerosVuelo.Size = new Size(313, 388);
            dataGridViewPasajerosVuelo.TabIndex = 32;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 9);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 33;
            label3.Text = "Lista Vuelos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(727, 102);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 34;
            label1.Text = "Lista pasajeros";
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
            // ganaciaTotal
            // 
            ganaciaTotal.HeaderText = "Ganancia";
            ganaciaTotal.MinimumWidth = 6;
            ganaciaTotal.Name = "ganaciaTotal";
            ganaciaTotal.ReadOnly = true;
            ganaciaTotal.Width = 125;
            // 
            // pesoBodega
            // 
            pesoBodega.HeaderText = "Peso Bodega";
            pesoBodega.MinimumWidth = 6;
            pesoBodega.Name = "pesoBodega";
            pesoBodega.ReadOnly = true;
            pesoBodega.Width = 125;
            // 
            // FormVisualizarViajes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1052, 548);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dataGridViewPasajerosVuelo);
            Controls.Add(label2);
            Controls.Add(comboBoxCodigoVuelo);
            Controls.Add(dataGridViewListaVuelos);
            Name = "FormVisualizarViajes";
            Text = "FormVisualizarViajes";
            Load += FormVisualizarViajes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasajerosVuelo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaVuelos;
        private Label label2;
        private ComboBox comboBoxCodigoVuelo;
        private DataGridView dataGridViewPasajerosVuelo;
        private Label label3;
        private Label label1;
        private DataGridViewTextBoxColumn codigoVuelo;
        private DataGridViewTextBoxColumn fechaPartida;
        private DataGridViewTextBoxColumn horarioPartida;
        private DataGridViewTextBoxColumn partida;
        private DataGridViewTextBoxColumn destino;
        private DataGridViewTextBoxColumn ganaciaTotal;
        private DataGridViewTextBoxColumn pesoBodega;
        private DataGridViewTextBoxColumn dniPasajero;
        private DataGridViewTextBoxColumn nombrePasajero;
        private DataGridViewTextBoxColumn apellidoPasajero;
    }
}
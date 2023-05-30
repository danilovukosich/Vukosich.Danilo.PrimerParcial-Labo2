namespace ParcialLabo1
{
    partial class FormEstadisticas
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
            tabControlEstadisticas = new TabControl();
            tabPage2 = new TabPage();
            dataGridViewListaPasajeros = new DataGridView();
            dniPasajero = new DataGridViewTextBoxColumn();
            nombrePasajero = new DataGridViewTextBoxColumn();
            apellidoPasajero = new DataGridViewTextBoxColumn();
            cantidadViajes = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            labelGananciasInternacional = new Label();
            labelGananciasCabotaje = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dataGridViewListaVuelosInternacional = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dataGridViewListaVuelosCabotaje = new DataGridView();
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
            tabPage4 = new TabPage();
            dataGridViewListaAeronaves = new DataGridView();
            columnaMatriculaAeronave = new DataGridViewTextBoxColumn();
            columnaCantidadAsientosPremium = new DataGridViewTextBoxColumn();
            columnaCantidadAsientosTurista = new DataGridViewTextBoxColumn();
            columnaHorasDeVuelo = new DataGridViewTextBoxColumn();
            label5 = new Label();
            tabControlEstadisticas.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPasajeros).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelosInternacional).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelosCabotaje).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaAeronaves).BeginInit();
            SuspendLayout();
            // 
            // tabControlEstadisticas
            // 
            tabControlEstadisticas.Controls.Add(tabPage2);
            tabControlEstadisticas.Controls.Add(tabPage3);
            tabControlEstadisticas.Controls.Add(tabPage4);
            tabControlEstadisticas.Cursor = Cursors.Hand;
            tabControlEstadisticas.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabControlEstadisticas.Location = new Point(12, 12);
            tabControlEstadisticas.Name = "tabControlEstadisticas";
            tabControlEstadisticas.SelectedIndex = 0;
            tabControlEstadisticas.Size = new Size(1015, 516);
            tabControlEstadisticas.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.MenuHighlight;
            tabPage2.Controls.Add(dataGridViewListaPasajeros);
            tabPage2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1007, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pasajeros mas frecuentes";
            // 
            // dataGridViewListaPasajeros
            // 
            dataGridViewListaPasajeros.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaPasajeros.Columns.AddRange(new DataGridViewColumn[] { dniPasajero, nombrePasajero, apellidoPasajero, cantidadViajes });
            dataGridViewListaPasajeros.Location = new Point(234, 31);
            dataGridViewListaPasajeros.Name = "dataGridViewListaPasajeros";
            dataGridViewListaPasajeros.RowHeadersWidth = 51;
            dataGridViewListaPasajeros.RowTemplate.Height = 29;
            dataGridViewListaPasajeros.Size = new Size(550, 414);
            dataGridViewListaPasajeros.TabIndex = 7;
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
            // cantidadViajes
            // 
            cantidadViajes.HeaderText = "Viajes";
            cantidadViajes.MinimumWidth = 6;
            cantidadViajes.Name = "cantidadViajes";
            cantidadViajes.ReadOnly = true;
            cantidadViajes.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.MenuHighlight;
            tabPage3.Controls.Add(labelGananciasInternacional);
            tabPage3.Controls.Add(labelGananciasCabotaje);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridViewListaVuelosInternacional);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(dataGridViewListaVuelosCabotaje);
            tabPage3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 38);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1007, 474);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ganancias";
            // 
            // labelGananciasInternacional
            // 
            labelGananciasInternacional.AutoSize = true;
            labelGananciasInternacional.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelGananciasInternacional.Location = new Point(493, 237);
            labelGananciasInternacional.Name = "labelGananciasInternacional";
            labelGananciasInternacional.Size = new Size(212, 23);
            labelGananciasInternacional.TabIndex = 13;
            labelGananciasInternacional.Text = "Gananciasinternacional";
            // 
            // labelGananciasCabotaje
            // 
            labelGananciasCabotaje.AutoSize = true;
            labelGananciasCabotaje.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelGananciasCabotaje.Location = new Point(493, 12);
            labelGananciasCabotaje.Name = "labelGananciasCabotaje";
            labelGananciasCabotaje.Size = new Size(174, 23);
            labelGananciasCabotaje.TabIndex = 12;
            labelGananciasCabotaje.Text = "Gananciascabotaje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(392, 12);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 11;
            label4.Text = "Ganancias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(392, 237);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 10;
            label3.Text = "Ganancias:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 240);
            label1.Name = "label1";
            label1.Size = new Size(188, 23);
            label1.TabIndex = 9;
            label1.Text = "Vuelos Internacional";
            // 
            // dataGridViewListaVuelosInternacional
            // 
            dataGridViewListaVuelosInternacional.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaVuelosInternacional.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaVuelosInternacional.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridViewListaVuelosInternacional.Location = new Point(22, 266);
            dataGridViewListaVuelosInternacional.Name = "dataGridViewListaVuelosInternacional";
            dataGridViewListaVuelosInternacional.RowHeadersWidth = 51;
            dataGridViewListaVuelosInternacional.RowTemplate.Height = 29;
            dataGridViewListaVuelosInternacional.Size = new Size(955, 196);
            dataGridViewListaVuelosInternacional.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Fecha Partida";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Horario Partida";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Partida";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Destino";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Asientos Premium";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Precio Premium";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Asientos Turista";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "PrecioTurista";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Duracion";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 12);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 7;
            label2.Text = "Vuelos Cabotaje";
            // 
            // dataGridViewListaVuelosCabotaje
            // 
            dataGridViewListaVuelosCabotaje.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaVuelosCabotaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaVuelosCabotaje.Columns.AddRange(new DataGridViewColumn[] { codigoVuelo, fechaPartida, horarioPartida, partida, destino, asientosPremium, precioPremium, asientoTurista, precioTurista, duracionVuelo });
            dataGridViewListaVuelosCabotaje.Location = new Point(22, 38);
            dataGridViewListaVuelosCabotaje.Name = "dataGridViewListaVuelosCabotaje";
            dataGridViewListaVuelosCabotaje.RowHeadersWidth = 51;
            dataGridViewListaVuelosCabotaje.RowTemplate.Height = 29;
            dataGridViewListaVuelosCabotaje.Size = new Size(955, 196);
            dataGridViewListaVuelosCabotaje.TabIndex = 2;
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
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.MenuHighlight;
            tabPage4.Controls.Add(dataGridViewListaAeronaves);
            tabPage4.Controls.Add(label5);
            tabPage4.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 38);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1007, 474);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Horas De vuelo";
            // 
            // dataGridViewListaAeronaves
            // 
            dataGridViewListaAeronaves.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaAeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaAeronaves.Columns.AddRange(new DataGridViewColumn[] { columnaMatriculaAeronave, columnaCantidadAsientosPremium, columnaCantidadAsientosTurista, columnaHorasDeVuelo });
            dataGridViewListaAeronaves.Location = new Point(218, 72);
            dataGridViewListaAeronaves.Name = "dataGridViewListaAeronaves";
            dataGridViewListaAeronaves.RowHeadersWidth = 51;
            dataGridViewListaAeronaves.RowTemplate.Height = 29;
            dataGridViewListaAeronaves.Size = new Size(554, 364);
            dataGridViewListaAeronaves.TabIndex = 9;
            // 
            // columnaMatriculaAeronave
            // 
            columnaMatriculaAeronave.HeaderText = "Matricula";
            columnaMatriculaAeronave.MinimumWidth = 6;
            columnaMatriculaAeronave.Name = "columnaMatriculaAeronave";
            columnaMatriculaAeronave.Width = 125;
            // 
            // columnaCantidadAsientosPremium
            // 
            columnaCantidadAsientosPremium.HeaderText = "Asientos premium";
            columnaCantidadAsientosPremium.MinimumWidth = 6;
            columnaCantidadAsientosPremium.Name = "columnaCantidadAsientosPremium";
            columnaCantidadAsientosPremium.Width = 125;
            // 
            // columnaCantidadAsientosTurista
            // 
            columnaCantidadAsientosTurista.HeaderText = "Asientos turista";
            columnaCantidadAsientosTurista.MinimumWidth = 6;
            columnaCantidadAsientosTurista.Name = "columnaCantidadAsientosTurista";
            columnaCantidadAsientosTurista.Width = 125;
            // 
            // columnaHorasDeVuelo
            // 
            columnaHorasDeVuelo.HeaderText = "Horas de vuelo";
            columnaHorasDeVuelo.MinimumWidth = 6;
            columnaHorasDeVuelo.Name = "columnaHorasDeVuelo";
            columnaHorasDeVuelo.ReadOnly = true;
            columnaHorasDeVuelo.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(218, 46);
            label5.Name = "label5";
            label5.Size = new Size(303, 23);
            label5.TabIndex = 8;
            label5.Text = "Horas de vuelo de cada Aeronave";
            // 
            // FormEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1052, 548);
            Controls.Add(tabControlEstadisticas);
            Name = "FormEstadisticas";
            Text = "FormEstadisticas";
            Load += FormEstadisticas_Load;
            tabControlEstadisticas.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPasajeros).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelosInternacional).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelosCabotaje).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaAeronaves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlEstadisticas;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridViewListaPasajeros;
        private DataGridViewTextBoxColumn dniPasajero;
        private DataGridViewTextBoxColumn nombrePasajero;
        private DataGridViewTextBoxColumn apellidoPasajero;
        private DataGridViewTextBoxColumn cantidadViajes;
        private DataGridView dataGridViewListaVuelosCabotaje;
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
        private Label label1;
        private DataGridView dataGridViewListaVuelosInternacional;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label label2;
        private Label labelGananciasInternacional;
        private Label labelGananciasCabotaje;
        private Label label5;
        private DataGridView dataGridViewListaAeronaves;
        private DataGridViewTextBoxColumn columnaMatriculaAeronave;
        private DataGridViewTextBoxColumn columnaCantidadAsientosPremium;
        private DataGridViewTextBoxColumn columnaCantidadAsientosTurista;
        private DataGridViewTextBoxColumn columnaHorasDeVuelo;
    }
}
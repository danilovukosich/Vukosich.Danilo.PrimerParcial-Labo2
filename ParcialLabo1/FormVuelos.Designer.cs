namespace ParcialLabo1
{
    partial class FormVuelos
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
            buttonAgregarVuelo = new Button();
            buttonModificarVuelo = new Button();
            buttonEliminarVuelo = new Button();
            label2 = new Label();
            textBoxMatriculaAEliminar = new TextBox();
            label1 = new Label();
            textBoxCodigoEliminar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaVuelos
            // 
            dataGridViewListaVuelos.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaVuelos.Columns.AddRange(new DataGridViewColumn[] { codigoVuelo, fechaPartida, horarioPartida, partida, destino, asientosPremium, precioPremium, asientoTurista, precioTurista, duracionVuelo });
            dataGridViewListaVuelos.Location = new Point(56, 54);
            dataGridViewListaVuelos.Name = "dataGridViewListaVuelos";
            dataGridViewListaVuelos.RowHeadersWidth = 51;
            dataGridViewListaVuelos.RowTemplate.Height = 29;
            dataGridViewListaVuelos.Size = new Size(953, 338);
            dataGridViewListaVuelos.TabIndex = 1;
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
            // buttonAgregarVuelo
            // 
            buttonAgregarVuelo.BackColor = Color.FromArgb(0, 122, 204);
            buttonAgregarVuelo.FlatStyle = FlatStyle.Popup;
            buttonAgregarVuelo.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarVuelo.Location = new Point(115, 467);
            buttonAgregarVuelo.Name = "buttonAgregarVuelo";
            buttonAgregarVuelo.Size = new Size(243, 54);
            buttonAgregarVuelo.TabIndex = 2;
            buttonAgregarVuelo.Text = "Agregar";
            buttonAgregarVuelo.UseVisualStyleBackColor = false;
            buttonAgregarVuelo.Click += buttonAgregarVuelo_Click;
            // 
            // buttonModificarVuelo
            // 
            buttonModificarVuelo.BackColor = Color.FromArgb(0, 122, 204);
            buttonModificarVuelo.FlatStyle = FlatStyle.Popup;
            buttonModificarVuelo.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificarVuelo.Location = new Point(414, 467);
            buttonModificarVuelo.Name = "buttonModificarVuelo";
            buttonModificarVuelo.Size = new Size(243, 54);
            buttonModificarVuelo.TabIndex = 3;
            buttonModificarVuelo.Text = "Modificar";
            buttonModificarVuelo.UseVisualStyleBackColor = false;
            buttonModificarVuelo.Click += button1_Click;
            // 
            // buttonEliminarVuelo
            // 
            buttonEliminarVuelo.BackColor = Color.FromArgb(0, 122, 204);
            buttonEliminarVuelo.FlatStyle = FlatStyle.Popup;
            buttonEliminarVuelo.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminarVuelo.ForeColor = Color.Red;
            buttonEliminarVuelo.Location = new Point(727, 467);
            buttonEliminarVuelo.Name = "buttonEliminarVuelo";
            buttonEliminarVuelo.Size = new Size(243, 54);
            buttonEliminarVuelo.TabIndex = 4;
            buttonEliminarVuelo.Text = "Eliminar";
            buttonEliminarVuelo.UseVisualStyleBackColor = false;
            buttonEliminarVuelo.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(478, 408);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 6;
            label2.Text = "Ingrese Codigo:";
            // 
            // textBoxMatriculaAEliminar
            // 
            textBoxMatriculaAEliminar.Location = new Point(467, 430);
            textBoxMatriculaAEliminar.Name = "textBoxMatriculaAEliminar";
            textBoxMatriculaAEliminar.Size = new Size(142, 27);
            textBoxMatriculaAEliminar.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(799, 408);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 8;
            label1.Text = "Ingrese Codigo:";
            // 
            // textBoxCodigoEliminar
            // 
            textBoxCodigoEliminar.Location = new Point(788, 430);
            textBoxCodigoEliminar.Name = "textBoxCodigoEliminar";
            textBoxCodigoEliminar.Size = new Size(142, 27);
            textBoxCodigoEliminar.TabIndex = 7;
            // 
            // FormVuelos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1052, 548);
            Controls.Add(label1);
            Controls.Add(textBoxCodigoEliminar);
            Controls.Add(label2);
            Controls.Add(textBoxMatriculaAEliminar);
            Controls.Add(buttonEliminarVuelo);
            Controls.Add(buttonModificarVuelo);
            Controls.Add(buttonAgregarVuelo);
            Controls.Add(dataGridViewListaVuelos);
            Name = "FormVuelos";
            Text = "FormVuelos";
            Load += FormVuelos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaVuelos;
        private Button buttonAgregarVuelo;
        private Button buttonModificarVuelo;
        private Button buttonEliminarVuelo;
        private Label label2;
        private TextBox textBoxMatriculaAEliminar;
        private Label label1;
        private TextBox textBoxCodigoEliminar;
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
    }
}
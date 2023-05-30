namespace ParcialLabo1
{
    partial class FormAeronaves
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
            dataGridViewListaAeronaves = new DataGridView();
            columnaMatriculaAeronave = new DataGridViewTextBoxColumn();
            columnaCantidadAsientosPremium = new DataGridViewTextBoxColumn();
            columnaCantidadAsientosTurista = new DataGridViewTextBoxColumn();
            columnaCantidadBanos = new DataGridViewTextBoxColumn();
            columnaPoseeInternet = new DataGridViewTextBoxColumn();
            columnaOfreceComida = new DataGridViewTextBoxColumn();
            columnaCapacidadBodega = new DataGridViewTextBoxColumn();
            columnaHorasDeVuelo = new DataGridViewTextBoxColumn();
            buttonAgregarAeronaves = new Button();
            buttonModificarAeronave = new Button();
            buttonEliminarAeronave = new Button();
            panel1 = new Panel();
            label1 = new Label();
            textBoxMatriculaAModificar = new TextBox();
            label2 = new Label();
            textBoxMatriculaAEliminar = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaAeronaves).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewListaAeronaves
            // 
            dataGridViewListaAeronaves.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaAeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaAeronaves.Columns.AddRange(new DataGridViewColumn[] { columnaMatriculaAeronave, columnaCantidadAsientosPremium, columnaCantidadAsientosTurista, columnaCantidadBanos, columnaPoseeInternet, columnaOfreceComida, columnaCapacidadBodega, columnaHorasDeVuelo });
            dataGridViewListaAeronaves.Location = new Point(54, 42);
            dataGridViewListaAeronaves.Name = "dataGridViewListaAeronaves";
            dataGridViewListaAeronaves.RowHeadersWidth = 51;
            dataGridViewListaAeronaves.RowTemplate.Height = 29;
            dataGridViewListaAeronaves.Size = new Size(953, 338);
            dataGridViewListaAeronaves.TabIndex = 0;
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
            // columnaCantidadBanos
            // 
            columnaCantidadBanos.HeaderText = "Baños";
            columnaCantidadBanos.MinimumWidth = 6;
            columnaCantidadBanos.Name = "columnaCantidadBanos";
            columnaCantidadBanos.ReadOnly = true;
            columnaCantidadBanos.Width = 125;
            // 
            // columnaPoseeInternet
            // 
            columnaPoseeInternet.HeaderText = "Internet";
            columnaPoseeInternet.MinimumWidth = 6;
            columnaPoseeInternet.Name = "columnaPoseeInternet";
            columnaPoseeInternet.ReadOnly = true;
            columnaPoseeInternet.Width = 125;
            // 
            // columnaOfreceComida
            // 
            columnaOfreceComida.HeaderText = "Comida";
            columnaOfreceComida.MinimumWidth = 6;
            columnaOfreceComida.Name = "columnaOfreceComida";
            columnaOfreceComida.ReadOnly = true;
            columnaOfreceComida.Width = 125;
            // 
            // columnaCapacidadBodega
            // 
            columnaCapacidadBodega.HeaderText = "Capacidad Bodega";
            columnaCapacidadBodega.MinimumWidth = 6;
            columnaCapacidadBodega.Name = "columnaCapacidadBodega";
            columnaCapacidadBodega.ReadOnly = true;
            columnaCapacidadBodega.Width = 125;
            // 
            // columnaHorasDeVuelo
            // 
            columnaHorasDeVuelo.HeaderText = "Horas de vuelo";
            columnaHorasDeVuelo.MinimumWidth = 6;
            columnaHorasDeVuelo.Name = "columnaHorasDeVuelo";
            columnaHorasDeVuelo.ReadOnly = true;
            columnaHorasDeVuelo.Width = 125;
            // 
            // buttonAgregarAeronaves
            // 
            buttonAgregarAeronaves.BackColor = Color.FromArgb(0, 122, 204);
            buttonAgregarAeronaves.FlatStyle = FlatStyle.Popup;
            buttonAgregarAeronaves.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarAeronaves.Location = new Point(92, 456);
            buttonAgregarAeronaves.Name = "buttonAgregarAeronaves";
            buttonAgregarAeronaves.Size = new Size(243, 54);
            buttonAgregarAeronaves.TabIndex = 1;
            buttonAgregarAeronaves.Text = "Agregar";
            buttonAgregarAeronaves.UseVisualStyleBackColor = false;
            buttonAgregarAeronaves.Click += buttonAgregarAeronaves_Click;
            // 
            // buttonModificarAeronave
            // 
            buttonModificarAeronave.BackColor = Color.FromArgb(0, 122, 204);
            buttonModificarAeronave.FlatStyle = FlatStyle.Popup;
            buttonModificarAeronave.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificarAeronave.Location = new Point(30, 70);
            buttonModificarAeronave.Name = "buttonModificarAeronave";
            buttonModificarAeronave.Size = new Size(243, 54);
            buttonModificarAeronave.TabIndex = 2;
            buttonModificarAeronave.Text = "Modificar";
            buttonModificarAeronave.UseVisualStyleBackColor = false;
            buttonModificarAeronave.Click += buttonModificarAeronave_Click;
            // 
            // buttonEliminarAeronave
            // 
            buttonEliminarAeronave.BackColor = Color.FromArgb(0, 122, 204);
            buttonEliminarAeronave.FlatStyle = FlatStyle.Popup;
            buttonEliminarAeronave.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminarAeronave.ForeColor = Color.Red;
            buttonEliminarAeronave.Location = new Point(407, 456);
            buttonEliminarAeronave.Name = "buttonEliminarAeronave";
            buttonEliminarAeronave.Size = new Size(243, 54);
            buttonEliminarAeronave.TabIndex = 3;
            buttonEliminarAeronave.Text = "Eliminar";
            buttonEliminarAeronave.UseVisualStyleBackColor = false;
            buttonEliminarAeronave.Click += buttonEliminarAeronave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxMatriculaAModificar);
            panel1.Controls.Add(buttonModificarAeronave);
            panel1.Location = new Point(694, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 150);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 15);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 1;
            label1.Text = "Ingrese matricula:";
            // 
            // textBoxMatriculaAModificar
            // 
            textBoxMatriculaAModificar.Location = new Point(85, 37);
            textBoxMatriculaAModificar.Name = "textBoxMatriculaAModificar";
            textBoxMatriculaAModificar.Size = new Size(133, 27);
            textBoxMatriculaAModificar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(460, 401);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 4;
            label2.Text = "Ingrese matricula:";
            // 
            // textBoxMatriculaAEliminar
            // 
            textBoxMatriculaAEliminar.Location = new Point(460, 423);
            textBoxMatriculaAEliminar.Name = "textBoxMatriculaAEliminar";
            textBoxMatriculaAEliminar.Size = new Size(142, 27);
            textBoxMatriculaAEliminar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(440, 9);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 5;
            label3.Text = "Lista Aeronaves";
            // 
            // FormAeronaves
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1052, 548);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxMatriculaAEliminar);
            Controls.Add(panel1);
            Controls.Add(buttonEliminarAeronave);
            Controls.Add(buttonAgregarAeronaves);
            Controls.Add(dataGridViewListaAeronaves);
            Name = "FormAeronaves";
            Text = "FormAeronaves";
            Load += FormAeronaves_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaAeronaves).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaAeronaves;
        private Button buttonAgregarAeronaves;
        private Button buttonModificarAeronave;
        private Button buttonEliminarAeronave;
        private DataGridViewTextBoxColumn columnaMatriculaAeronave;
        private DataGridViewTextBoxColumn columnaCantidadAsientosPremium;
        private DataGridViewTextBoxColumn columnaCantidadAsientosTurista;
        private DataGridViewTextBoxColumn columnaCantidadBanos;
        private DataGridViewTextBoxColumn columnaPoseeInternet;
        private DataGridViewTextBoxColumn columnaOfreceComida;
        private DataGridViewTextBoxColumn columnaCapacidadBodega;
        private DataGridViewTextBoxColumn columnaHorasDeVuelo;
        private Panel panel1;
        private Label label1;
        private TextBox textBoxMatriculaAModificar;
        private Label label2;
        private TextBox textBoxMatriculaAEliminar;
        private Label label3;
    }
}
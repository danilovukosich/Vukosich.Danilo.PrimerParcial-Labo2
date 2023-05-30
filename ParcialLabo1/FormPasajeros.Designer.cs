namespace ParcialLabo1
{
    partial class FormPasajeros
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
            label3 = new Label();
            label2 = new Label();
            textBoxDniAEliminar = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            textBoxDniPasajeroAModificar = new TextBox();
            buttonModificarPasajero = new Button();
            buttonEliminarPasajero = new Button();
            buttonAgregarPasajero = new Button();
            dataGridViewListaPasajeros = new DataGridView();
            dniPasajero = new DataGridViewTextBoxColumn();
            nombrePasajero = new DataGridViewTextBoxColumn();
            apellidoPasajero = new DataGridViewTextBoxColumn();
            edadPasajero = new DataGridViewTextBoxColumn();
            equipajeDeManoPasajero = new DataGridViewTextBoxColumn();
            equipajeDeBodegaPasajero = new DataGridViewTextBoxColumn();
            estadoPasajero = new DataGridViewTextBoxColumn();
            claseDeVueloPasajero = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPasajeros).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(436, 11);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 12;
            label3.Text = "Lista Pasajeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(477, 403);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 10;
            label2.Text = "Ingrese DNI:";
            // 
            // textBoxDniAEliminar
            // 
            textBoxDniAEliminar.Location = new Point(456, 425);
            textBoxDniAEliminar.Name = "textBoxDniAEliminar";
            textBoxDniAEliminar.Size = new Size(142, 27);
            textBoxDniAEliminar.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDniPasajeroAModificar);
            panel1.Controls.Add(buttonModificarPasajero);
            panel1.Location = new Point(690, 388);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 150);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 13;
            label1.Text = "Ingrese DNI:";
            // 
            // textBoxDniPasajeroAModificar
            // 
            textBoxDniPasajeroAModificar.Location = new Point(85, 37);
            textBoxDniPasajeroAModificar.Name = "textBoxDniPasajeroAModificar";
            textBoxDniPasajeroAModificar.Size = new Size(133, 27);
            textBoxDniPasajeroAModificar.TabIndex = 0;
            // 
            // buttonModificarPasajero
            // 
            buttonModificarPasajero.BackColor = Color.FromArgb(0, 122, 204);
            buttonModificarPasajero.FlatStyle = FlatStyle.Popup;
            buttonModificarPasajero.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificarPasajero.Location = new Point(30, 70);
            buttonModificarPasajero.Name = "buttonModificarPasajero";
            buttonModificarPasajero.Size = new Size(243, 54);
            buttonModificarPasajero.TabIndex = 2;
            buttonModificarPasajero.Text = "Modificar";
            buttonModificarPasajero.UseVisualStyleBackColor = false;
            buttonModificarPasajero.Click += buttonModificarPasajero_Click;
            // 
            // buttonEliminarPasajero
            // 
            buttonEliminarPasajero.BackColor = Color.FromArgb(0, 122, 204);
            buttonEliminarPasajero.FlatStyle = FlatStyle.Popup;
            buttonEliminarPasajero.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminarPasajero.ForeColor = Color.Red;
            buttonEliminarPasajero.Location = new Point(403, 458);
            buttonEliminarPasajero.Name = "buttonEliminarPasajero";
            buttonEliminarPasajero.Size = new Size(243, 54);
            buttonEliminarPasajero.TabIndex = 9;
            buttonEliminarPasajero.Text = "Eliminar";
            buttonEliminarPasajero.UseVisualStyleBackColor = false;
            buttonEliminarPasajero.Click += buttonEliminarPasajero_Click;
            // 
            // buttonAgregarPasajero
            // 
            buttonAgregarPasajero.BackColor = Color.FromArgb(0, 122, 204);
            buttonAgregarPasajero.FlatStyle = FlatStyle.Popup;
            buttonAgregarPasajero.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarPasajero.Location = new Point(88, 458);
            buttonAgregarPasajero.Name = "buttonAgregarPasajero";
            buttonAgregarPasajero.Size = new Size(243, 54);
            buttonAgregarPasajero.TabIndex = 7;
            buttonAgregarPasajero.Text = "Agregar";
            buttonAgregarPasajero.UseVisualStyleBackColor = false;
            buttonAgregarPasajero.Click += buttonAgregarPasajero_Click;
            // 
            // dataGridViewListaPasajeros
            // 
            dataGridViewListaPasajeros.BackgroundColor = Color.FromArgb(0, 122, 204);
            dataGridViewListaPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaPasajeros.Columns.AddRange(new DataGridViewColumn[] { dniPasajero, nombrePasajero, apellidoPasajero, edadPasajero, equipajeDeManoPasajero, equipajeDeBodegaPasajero, estadoPasajero, claseDeVueloPasajero });
            dataGridViewListaPasajeros.Location = new Point(50, 44);
            dataGridViewListaPasajeros.Name = "dataGridViewListaPasajeros";
            dataGridViewListaPasajeros.RowHeadersWidth = 51;
            dataGridViewListaPasajeros.RowTemplate.Height = 29;
            dataGridViewListaPasajeros.Size = new Size(953, 338);
            dataGridViewListaPasajeros.TabIndex = 6;
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
            // edadPasajero
            // 
            edadPasajero.HeaderText = "Edad";
            edadPasajero.MinimumWidth = 6;
            edadPasajero.Name = "edadPasajero";
            edadPasajero.ReadOnly = true;
            edadPasajero.Width = 125;
            // 
            // equipajeDeManoPasajero
            // 
            equipajeDeManoPasajero.HeaderText = "Equipaje mano";
            equipajeDeManoPasajero.MinimumWidth = 6;
            equipajeDeManoPasajero.Name = "equipajeDeManoPasajero";
            equipajeDeManoPasajero.ReadOnly = true;
            equipajeDeManoPasajero.Width = 125;
            // 
            // equipajeDeBodegaPasajero
            // 
            equipajeDeBodegaPasajero.HeaderText = "Equipaje bodega";
            equipajeDeBodegaPasajero.MinimumWidth = 6;
            equipajeDeBodegaPasajero.Name = "equipajeDeBodegaPasajero";
            equipajeDeBodegaPasajero.ReadOnly = true;
            equipajeDeBodegaPasajero.Width = 125;
            // 
            // estadoPasajero
            // 
            estadoPasajero.HeaderText = "Estado";
            estadoPasajero.MinimumWidth = 6;
            estadoPasajero.Name = "estadoPasajero";
            estadoPasajero.ReadOnly = true;
            estadoPasajero.Width = 125;
            // 
            // claseDeVueloPasajero
            // 
            claseDeVueloPasajero.HeaderText = "Clase";
            claseDeVueloPasajero.MinimumWidth = 6;
            claseDeVueloPasajero.Name = "claseDeVueloPasajero";
            claseDeVueloPasajero.ReadOnly = true;
            claseDeVueloPasajero.Width = 125;
            // 
            // FormPasajeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1052, 548);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDniAEliminar);
            Controls.Add(panel1);
            Controls.Add(buttonEliminarPasajero);
            Controls.Add(buttonAgregarPasajero);
            Controls.Add(dataGridViewListaPasajeros);
            Name = "FormPasajeros";
            Text = "FormAgregarPasajero";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaPasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox textBoxDniAEliminar;
        private Panel panel1;
        private Label label1;
        private TextBox textBoxDniPasajeroAModificar;
        private Button buttonModificarPasajero;
        private Button buttonEliminarPasajero;
        private Button buttonAgregarPasajero;
        private DataGridView dataGridViewListaPasajeros;
        private DataGridViewTextBoxColumn dniPasajero;
        private DataGridViewTextBoxColumn nombrePasajero;
        private DataGridViewTextBoxColumn apellidoPasajero;
        private DataGridViewTextBoxColumn edadPasajero;
        private DataGridViewTextBoxColumn equipajeDeManoPasajero;
        private DataGridViewTextBoxColumn equipajeDeBodegaPasajero;
        private DataGridViewTextBoxColumn estadoPasajero;
        private DataGridViewTextBoxColumn claseDeVueloPasajero;
    }
}
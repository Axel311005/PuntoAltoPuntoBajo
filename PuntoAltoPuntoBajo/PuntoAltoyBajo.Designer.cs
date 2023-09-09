namespace PuntoAltoPuntoBajo
{
    partial class PuntoAltoyBajo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCostosTotales = new TextBox();
            txtUnidades = new TextBox();
            btnIngresar = new Button();
            lvDatos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCostoTotal = new TextBox();
            txtCostosFijos = new TextBox();
            txtCostosVariables = new TextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(310, 25);
            label1.Name = "label1";
            label1.Size = new Size(478, 45);
            label1.TabIndex = 0;
            label1.Text = "PUNTO ALTO Y PUNTO BAJO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 121);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 1;
            label2.Text = "Costos Totales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 121);
            label3.Name = "label3";
            label3.Size = new Size(306, 32);
            label3.TabIndex = 2;
            label3.Text = "Horas/Unidades Producidas";
            // 
            // txtCostosTotales
            // 
            txtCostosTotales.Location = new Point(41, 178);
            txtCostosTotales.Name = "txtCostosTotales";
            txtCostosTotales.Size = new Size(200, 39);
            txtCostosTotales.TabIndex = 3;
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(310, 175);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(200, 39);
            txtUnidades.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(573, 168);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(150, 46);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lvDatos
            // 
            lvDatos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvDatos.GridLines = true;
            lvDatos.Location = new Point(41, 278);
            lvDatos.Name = "lvDatos";
            lvDatos.Size = new Size(653, 518);
            lvDatos.TabIndex = 6;
            lvDatos.UseCompatibleStateImageBehavior = false;
            lvDatos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Costos Totales";
            columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Horas/Unidades producidas";
            columnHeader2.Width = 320;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(762, 310);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 7;
            label4.Text = "Costo Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(724, 429);
            label5.Name = "label5";
            label5.Size = new Size(221, 32);
            label5.TabIndex = 8;
            label5.Text = "Costos Fijos Totales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(700, 557);
            label6.Name = "label6";
            label6.Size = new Size(264, 32);
            label6.TabIndex = 9;
            label6.Text = "Costos Variables totales";
            // 
            // txtCostoTotal
            // 
            txtCostoTotal.Location = new Point(765, 366);
            txtCostoTotal.Name = "txtCostoTotal";
            txtCostoTotal.Size = new Size(131, 39);
            txtCostoTotal.TabIndex = 10;
            // 
            // txtCostosFijos
            // 
            txtCostosFijos.Location = new Point(765, 479);
            txtCostosFijos.Name = "txtCostosFijos";
            txtCostosFijos.Size = new Size(130, 39);
            txtCostosFijos.TabIndex = 11;
            // 
            // txtCostosVariables
            // 
            txtCostosVariables.Location = new Point(765, 609);
            txtCostosVariables.Name = "txtCostosVariables";
            txtCostosVariables.Size = new Size(131, 39);
            txtCostosVariables.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(114, 820);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(360, 820);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 46);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // PuntoAltoyBajo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 891);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(txtCostosVariables);
            Controls.Add(txtCostosFijos);
            Controls.Add(txtCostoTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lvDatos);
            Controls.Add(btnIngresar);
            Controls.Add(txtUnidades);
            Controls.Add(txtCostosTotales);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PuntoAltoyBajo";
            Text = "PuntoAltoyBajo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCostosTotales;
        private TextBox txtUnidades;
        private Button btnIngresar;
        private ListView lvDatos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCostoTotal;
        private TextBox txtCostosFijos;
        private TextBox txtCostosVariables;
        private Button btnCalcular;
        private Button btnSalir;
    }
}
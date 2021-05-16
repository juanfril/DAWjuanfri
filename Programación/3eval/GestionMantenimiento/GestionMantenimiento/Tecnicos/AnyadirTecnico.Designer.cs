
namespace GestionMantenimiento.Tecnicos
{
    partial class AnyadirTecnico
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbOficio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.mcAntiguedad = new System.Windows.Forms.MonthCalendar();
            this.cbOficio = new System.Windows.Forms.ComboBox();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(28, 40);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(28, 136);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(174, 17);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Antigüedad en la empresa";
            // 
            // lbOficio
            // 
            this.lbOficio.AutoSize = true;
            this.lbOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOficio.Location = new System.Drawing.Point(28, 84);
            this.lbOficio.Name = "lbOficio";
            this.lbOficio.Size = new System.Drawing.Size(44, 17);
            this.lbOficio.TabIndex = 2;
            this.lbOficio.Text = "Oficio";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 40);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // mcAntiguedad
            // 
            this.mcAntiguedad.Location = new System.Drawing.Point(19, 162);
            this.mcAntiguedad.MaxSelectionCount = 1;
            this.mcAntiguedad.Name = "mcAntiguedad";
            this.mcAntiguedad.TabIndex = 5;
            // 
            // cbOficio
            // 
            this.cbOficio.FormattingEnabled = true;
            this.cbOficio.Items.AddRange(new object[] {
            "electricista",
            "frigorista",
            "fontanero"});
            this.cbOficio.Location = new System.Drawing.Point(111, 84);
            this.cbOficio.Name = "cbOficio";
            this.cbOficio.Size = new System.Drawing.Size(100, 21);
            this.cbOficio.TabIndex = 6;
            this.cbOficio.Text = "Elegir un oficio";
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(57, 336);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(113, 34);
            this.btnAnyadir.TabIndex = 7;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // AnyadirTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 382);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.cbOficio);
            this.Controls.Add(this.mcAntiguedad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbOficio);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbNombre);
            this.Name = "AnyadirTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirTecnico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbOficio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.MonthCalendar mcAntiguedad;
        private System.Windows.Forms.ComboBox cbOficio;
        private System.Windows.Forms.Button btnAnyadir;
    }
}
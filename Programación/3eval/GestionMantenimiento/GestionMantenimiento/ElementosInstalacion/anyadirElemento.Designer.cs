
namespace GestionMantenimiento.ElementosInstalacion
{
    partial class anyadirElemento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOpcion = new System.Windows.Forms.Label();
            this.tbOpcion = new System.Windows.Forms.TextBox();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.cbOficio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación";
            // 
            // lbOpcion
            // 
            this.lbOpcion.AutoSize = true;
            this.lbOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcion.Location = new System.Drawing.Point(13, 99);
            this.lbOpcion.Name = "lbOpcion";
            this.lbOpcion.Size = new System.Drawing.Size(61, 17);
            this.lbOpcion.TabIndex = 4;
            this.lbOpcion.Text = "Elija tipo";
            // 
            // tbOpcion
            // 
            this.tbOpcion.Location = new System.Drawing.Point(99, 98);
            this.tbOpcion.Name = "tbOpcion";
            this.tbOpcion.Size = new System.Drawing.Size(100, 20);
            this.tbOpcion.TabIndex = 5;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(99, 47);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(100, 20);
            this.tbUbicacion.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(99, 21);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(142, 137);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(80, 33);
            this.btnAnyadir.TabIndex = 10;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // cbOficio
            // 
            this.cbOficio.FormattingEnabled = true;
            this.cbOficio.Items.AddRange(new object[] {
            "electricista",
            "frigorista",
            "fontanero"});
            this.cbOficio.Location = new System.Drawing.Point(99, 72);
            this.cbOficio.Name = "cbOficio";
            this.cbOficio.Size = new System.Drawing.Size(100, 21);
            this.cbOficio.TabIndex = 11;
            this.cbOficio.Text = "Elegir un tipo";
            this.cbOficio.SelectedIndexChanged += new System.EventHandler(this.cbOficio_SelectedIndexChanged);
            // 
            // anyadirElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 182);
            this.Controls.Add(this.cbOficio);
            this.Controls.Add(this.btnAnyadir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.tbOpcion);
            this.Controls.Add(this.lbOpcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "anyadirElemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anyadirElemento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOpcion;
        private System.Windows.Forms.TextBox tbOpcion;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.ComboBox cbOficio;
    }
}
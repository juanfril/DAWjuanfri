
namespace GestionMantenimiento
{
    partial class GestionMaquinas
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
            this.components = new System.ComponentModel.Container();
            this.tbnAnyadir = new System.Windows.Forms.Button();
            this.btnEliminarClima = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgwClimatizacion = new System.Windows.Forms.DataGridView();
            this.introducirUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionFicherosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwElectricidad = new System.Windows.Forms.DataGridView();
            this.dgwFontaneria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarElectricidad = new System.Windows.Forms.Button();
            this.btnEliminarFontaneria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClimatizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introducirUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFicherosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElectricidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFontaneria)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnAnyadir
            // 
            this.tbnAnyadir.Location = new System.Drawing.Point(542, 12);
            this.tbnAnyadir.Name = "tbnAnyadir";
            this.tbnAnyadir.Size = new System.Drawing.Size(100, 23);
            this.tbnAnyadir.TabIndex = 1;
            this.tbnAnyadir.Text = "Añadir Elemento";
            this.tbnAnyadir.UseVisualStyleBackColor = true;
            this.tbnAnyadir.Click += new System.EventHandler(this.tbnAnyadir_Click);
            // 
            // btnEliminarClima
            // 
            this.btnEliminarClima.Location = new System.Drawing.Point(616, 51);
            this.btnEliminarClima.Name = "btnEliminarClima";
            this.btnEliminarClima.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarClima.TabIndex = 2;
            this.btnEliminarClima.Text = "Eliminar selección";
            this.btnEliminarClima.UseVisualStyleBackColor = true;
            this.btnEliminarClima.Click += new System.EventHandler(this.btnEliminarClima_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Location = new System.Drawing.Point(648, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgwClimatizacion
            // 
            this.dgwClimatizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwClimatizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClimatizacion.Location = new System.Drawing.Point(25, 80);
            this.dgwClimatizacion.Name = "dgwClimatizacion";
            this.dgwClimatizacion.Size = new System.Drawing.Size(698, 174);
            this.dgwClimatizacion.TabIndex = 4;
            // 
            // introducirUsuarioBindingSource
            // 
            this.introducirUsuarioBindingSource.DataSource = typeof(GestionMantenimiento.Login);
            // 
            // gestionFicherosBindingSource
            // 
            this.gestionFicherosBindingSource.DataSource = typeof(GestionMantenimiento.GestionFicherosUsuario);
            // 
            // dgwElectricidad
            // 
            this.dgwElectricidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwElectricidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwElectricidad.Location = new System.Drawing.Point(25, 286);
            this.dgwElectricidad.Name = "dgwElectricidad";
            this.dgwElectricidad.Size = new System.Drawing.Size(698, 174);
            this.dgwElectricidad.TabIndex = 5;
            // 
            // dgwFontaneria
            // 
            this.dgwFontaneria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFontaneria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFontaneria.Location = new System.Drawing.Point(25, 494);
            this.dgwFontaneria.Name = "dgwFontaneria";
            this.dgwFontaneria.Size = new System.Drawing.Size(698, 174);
            this.dgwFontaneria.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Climatizacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Electricidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fontanería";
            // 
            // btnEliminarElectricidad
            // 
            this.btnEliminarElectricidad.Location = new System.Drawing.Point(616, 260);
            this.btnEliminarElectricidad.Name = "btnEliminarElectricidad";
            this.btnEliminarElectricidad.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarElectricidad.TabIndex = 10;
            this.btnEliminarElectricidad.Text = "Eliminar selección";
            this.btnEliminarElectricidad.UseVisualStyleBackColor = true;
            this.btnEliminarElectricidad.Click += new System.EventHandler(this.btnEliminarElectricidad_Click);
            // 
            // btnEliminarFontaneria
            // 
            this.btnEliminarFontaneria.Location = new System.Drawing.Point(616, 468);
            this.btnEliminarFontaneria.Name = "btnEliminarFontaneria";
            this.btnEliminarFontaneria.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarFontaneria.TabIndex = 11;
            this.btnEliminarFontaneria.Text = "Eliminar selección";
            this.btnEliminarFontaneria.UseVisualStyleBackColor = true;
            this.btnEliminarFontaneria.Click += new System.EventHandler(this.btnEliminarFontaneria_Click);
            // 
            // GestionMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 680);
            this.Controls.Add(this.btnEliminarFontaneria);
            this.Controls.Add(this.btnEliminarElectricidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwFontaneria);
            this.Controls.Add(this.dgwElectricidad);
            this.Controls.Add(this.dgwClimatizacion);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminarClima);
            this.Controls.Add(this.tbnAnyadir);
            this.Name = "GestionMaquinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de técnicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgwClimatizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introducirUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFicherosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwElectricidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFontaneria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tbnAnyadir;
        private System.Windows.Forms.Button btnEliminarClima;
        private System.Windows.Forms.BindingSource introducirUsuarioBindingSource;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgwClimatizacion;
        private System.Windows.Forms.BindingSource gestionFicherosBindingSource;
        private System.Windows.Forms.DataGridView dgwElectricidad;
        private System.Windows.Forms.DataGridView dgwFontaneria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarElectricidad;
        private System.Windows.Forms.Button btnEliminarFontaneria;
    }
}
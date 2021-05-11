
namespace GestionMantenimiento
{
    partial class GestionTecnicos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgwTecnicos = new System.Windows.Forms.DataGridView();
            this.introducirUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionFicherosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTecnicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introducirUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFicherosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnAnyadir
            // 
            this.tbnAnyadir.Location = new System.Drawing.Point(25, 13);
            this.tbnAnyadir.Name = "tbnAnyadir";
            this.tbnAnyadir.Size = new System.Drawing.Size(75, 23);
            this.tbnAnyadir.TabIndex = 1;
            this.tbnAnyadir.Text = "Añadir";
            this.tbnAnyadir.UseVisualStyleBackColor = true;
            this.tbnAnyadir.Click += new System.EventHandler(this.tbnAnyadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(133, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Location = new System.Drawing.Point(610, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgwTecnicos
            // 
            this.dgwTecnicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTecnicos.Location = new System.Drawing.Point(25, 52);
            this.dgwTecnicos.Name = "dgwTecnicos";
            this.dgwTecnicos.Size = new System.Drawing.Size(660, 365);
            this.dgwTecnicos.TabIndex = 4;
            //this.dgwTecnicos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsuarios_CellEndEdit);
            // 
            // introducirUsuarioBindingSource
            // 
            this.introducirUsuarioBindingSource.DataSource = typeof(GestionMantenimiento.Login);
            // 
            // gestionFicherosBindingSource
            // 
            this.gestionFicherosBindingSource.DataSource = typeof(GestionMantenimiento.GestionFicheros);
            // 
            // GestionTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 448);
            this.Controls.Add(this.dgwTecnicos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbnAnyadir);
            this.Name = "GestionTecnicos";
            this.Text = "Gestion de técnicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTecnicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introducirUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFicherosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tbnAnyadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource introducirUsuarioBindingSource;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgwTecnicos;
        private System.Windows.Forms.BindingSource gestionFicherosBindingSource;
    }
}
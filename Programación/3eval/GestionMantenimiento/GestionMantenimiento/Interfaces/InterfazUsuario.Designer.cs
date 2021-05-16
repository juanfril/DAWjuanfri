
namespace GestionMantenimiento
{
    partial class InterfazUsuario
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
            this.dgwPeventivos = new System.Windows.Forms.DataGridView();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.btnAtrás = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTecnicos = new System.Windows.Forms.ComboBox();
            this.lbAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPeventivos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preventivos pendientes mensual";
            // 
            // dgwPeventivos
            // 
            this.dgwPeventivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPeventivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPeventivos.Location = new System.Drawing.Point(15, 102);
            this.dgwPeventivos.Name = "dgwPeventivos";
            this.dgwPeventivos.ReadOnly = true;
            this.dgwPeventivos.Size = new System.Drawing.Size(678, 342);
            this.dgwPeventivos.TabIndex = 1;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRealizar.Location = new System.Drawing.Point(594, 450);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(99, 38);
            this.btnRealizar.TabIndex = 2;
            this.btnRealizar.Text = "Cerrar selección";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // btnAtrás
            // 
            this.btnAtrás.Location = new System.Drawing.Point(617, 19);
            this.btnAtrás.Name = "btnAtrás";
            this.btnAtrás.Size = new System.Drawing.Size(75, 23);
            this.btnAtrás.TabIndex = 3;
            this.btnAtrás.Text = "Atrás";
            this.btnAtrás.UseVisualStyleBackColor = true;
            this.btnAtrás.Click += new System.EventHandler(this.btnAtrás_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tecnico que realizó el preventivo";
            // 
            // cbTecnicos
            // 
            this.cbTecnicos.FormattingEnabled = true;
            this.cbTecnicos.Location = new System.Drawing.Point(15, 40);
            this.cbTecnicos.Name = "cbTecnicos";
            this.cbTecnicos.Size = new System.Drawing.Size(121, 21);
            this.cbTecnicos.TabIndex = 5;
            this.cbTecnicos.Text = "Especificar técnico";
            this.cbTecnicos.SelectedIndexChanged += new System.EventHandler(this.cbTecnicos_SelectedIndexChanged);
            // 
            // lbAdvertencia
            // 
            this.lbAdvertencia.AutoSize = true;
            this.lbAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lbAdvertencia.Location = new System.Drawing.Point(142, 48);
            this.lbAdvertencia.Name = "lbAdvertencia";
            this.lbAdvertencia.Size = new System.Drawing.Size(254, 13);
            this.lbAdvertencia.TabIndex = 6;
            this.lbAdvertencia.Text = "Seleccionar un técnico para mostrar sus preventivos";
            // 
            // InterfazUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 500);
            this.Controls.Add(this.lbAdvertencia);
            this.Controls.Add(this.cbTecnicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtrás);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.dgwPeventivos);
            this.Controls.Add(this.label1);
            this.Name = "InterfazUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPeventivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwPeventivos;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Button btnAtrás;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTecnicos;
        private System.Windows.Forms.Label lbAdvertencia;
    }
}
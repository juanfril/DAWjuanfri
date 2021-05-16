
namespace GestionMantenimiento.GestionPreventivos
{
    partial class PreventivosRealizados
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lbVisor = new System.Windows.Forms.ListBox();
            this.preventivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.preventivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preventivos realizados";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(619, 6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lbVisor
            // 
            this.lbVisor.FormattingEnabled = true;
            this.lbVisor.Location = new System.Drawing.Point(12, 35);
            this.lbVisor.Name = "lbVisor";
            this.lbVisor.Size = new System.Drawing.Size(682, 225);
            this.lbVisor.TabIndex = 4;
            // 
            // preventivoBindingSource
            // 
            this.preventivoBindingSource.DataSource = typeof(GestionMantenimiento.GestionPreventivos.Preventivo);
            // 
            // PreventivosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 274);
            this.Controls.Add(this.lbVisor);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label1);
            this.Name = "PreventivosRealizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreventivosRealizados";
            ((System.ComponentModel.ISupportInitialize)(this.preventivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.BindingSource preventivoBindingSource;
        private System.Windows.Forms.ListBox lbVisor;
    }
}
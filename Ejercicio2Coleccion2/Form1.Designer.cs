namespace Ejercicio2Coleccion2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAllDerecha = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnAllIzq = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(282, 58);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(120, 134);
            this.lst2.TabIndex = 0;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(23, 58);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 134);
            this.lst1.TabIndex = 0;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(175, 56);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAllDerecha
            // 
            this.btnAllDerecha.Location = new System.Drawing.Point(175, 85);
            this.btnAllDerecha.Name = "btnAllDerecha";
            this.btnAllDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnAllDerecha.TabIndex = 1;
            this.btnAllDerecha.Text = ">>";
            this.btnAllDerecha.UseVisualStyleBackColor = true;
            this.btnAllDerecha.Click += new System.EventHandler(this.btnAllDerecha_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.Location = new System.Drawing.Point(175, 114);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(75, 23);
            this.btnIzq.TabIndex = 1;
            this.btnIzq.Text = "<";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnAllIzq
            // 
            this.btnAllIzq.Location = new System.Drawing.Point(175, 143);
            this.btnAllIzq.Name = "btnAllIzq";
            this.btnAllIzq.Size = new System.Drawing.Size(75, 23);
            this.btnAllIzq.TabIndex = 1;
            this.btnAllIzq.Text = "<<";
            this.btnAllIzq.UseVisualStyleBackColor = true;
            this.btnAllIzq.Click += new System.EventHandler(this.btnAllIzq_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Meses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAllIzq);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnAllDerecha);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.lst2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAllDerecha;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button btnAllIzq;
        private System.Windows.Forms.Label lbl1;
    }
}


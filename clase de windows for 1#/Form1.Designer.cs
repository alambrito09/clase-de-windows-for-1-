namespace clase_de_windows_for_1_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombrebox = new System.Windows.Forms.ComboBox();
            this.contrabox = new System.Windows.Forms.ComboBox();
            this.registro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese sus credenciales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "contraseña";
            // 
            // nombrebox
            // 
            this.nombrebox.FormattingEnabled = true;
            this.nombrebox.Location = new System.Drawing.Point(541, 87);
            this.nombrebox.Name = "nombrebox";
            this.nombrebox.Size = new System.Drawing.Size(121, 24);
            this.nombrebox.TabIndex = 3;
            // 
            // contrabox
            // 
            this.contrabox.AccessibleName = "";
            this.contrabox.FormattingEnabled = true;
            this.contrabox.Location = new System.Drawing.Point(541, 150);
            this.contrabox.Name = "contrabox";
            this.contrabox.Size = new System.Drawing.Size(121, 24);
            this.contrabox.TabIndex = 4;
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(565, 220);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(75, 23);
            this.registro.TabIndex = 5;
            this.registro.Text = "registrar";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.contrabox);
            this.Controls.Add(this.nombrebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "formulario1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nombrebox;
        private System.Windows.Forms.ComboBox contrabox;
        private System.Windows.Forms.Button registro;
    }
}


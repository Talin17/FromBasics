namespace numeroRomanoFormDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtRomano = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblRomano = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(137, 186);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(149, 23);
            this.btnConvertir.TabIndex = 19;
            this.btnConvertir.Text = "Convertir a Romano";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
            // 
            // txtRomano
            // 
            this.txtRomano.Location = new System.Drawing.Point(289, 119);
            this.txtRomano.Name = "txtRomano";
            this.txtRomano.Size = new System.Drawing.Size(121, 23);
            this.txtRomano.TabIndex = 18;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(29, 119);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 23);
            this.txtCantidad.TabIndex = 17;
            // 
            // lblRomano
            // 
            this.lblRomano.AutoSize = true;
            this.lblRomano.Location = new System.Drawing.Point(289, 90);
            this.lblRomano.Name = "lblRomano";
            this.lblRomano.Size = new System.Drawing.Size(99, 15);
            this.lblRomano.TabIndex = 16;
            this.lblRomano.Text = "Numero Romano";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(26, 90);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(124, 15);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Introduzca la cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 254);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtRomano);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblRomano);
            this.Controls.Add(this.lblCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnConvertir;
        private TextBox txtRomano;
        private TextBox txtCantidad;
        private Label lblRomano;
        private Label lblCantidad;
    }
}
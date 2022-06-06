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
            this.dbButton = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRomano = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtRomano = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbButton
            // 
            this.dbButton.Location = new System.Drawing.Point(146, 12);
            this.dbButton.Name = "dbButton";
            this.dbButton.Size = new System.Drawing.Size(149, 23);
            this.dbButton.TabIndex = 0;
            this.dbButton.Text = "Provar conexion DB";
            this.dbButton.UseVisualStyleBackColor = true;
            this.dbButton.Click += new System.EventHandler(this.dbButton_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(31, 81);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(124, 15);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Introduzca la cantidad";
            // 
            // lblRomano
            // 
            this.lblRomano.AutoSize = true;
            this.lblRomano.Location = new System.Drawing.Point(294, 81);
            this.lblRomano.Name = "lblRomano";
            this.lblRomano.Size = new System.Drawing.Size(99, 15);
            this.lblRomano.TabIndex = 2;
            this.lblRomano.Text = "Numero Romano";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(34, 110);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 23);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtRomano
            // 
            this.txtRomano.Location = new System.Drawing.Point(294, 110);
            this.txtRomano.Name = "txtRomano";
            this.txtRomano.Size = new System.Drawing.Size(121, 23);
            this.txtRomano.TabIndex = 4;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(146, 166);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(149, 23);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir a Romano";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar conexion DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtRomano);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblRomano);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dbButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button dbButton;
        private Label lblCantidad;
        private Label lblRomano;
        private TextBox txtCantidad;
        private TextBox txtRomano;
        private Button btnConvertir;
        private Button button1;
    }
}
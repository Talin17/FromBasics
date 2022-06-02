namespace numerosRomanosForms
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
            this.labelMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtRomano = new System.Windows.Forms.TextBox();
            this.labelRomano = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(30, 34);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(99, 15);
            this.labelMonto.TabIndex = 0;
            this.labelMonto.Text = "Inserte el numero";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(36, 55);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(117, 23);
            this.txtMonto.TabIndex = 1;
            // 
            // txtRomano
            // 
            this.txtRomano.Location = new System.Drawing.Point(190, 55);
            this.txtRomano.Name = "txtRomano";
            this.txtRomano.Size = new System.Drawing.Size(143, 23);
            this.txtRomano.TabIndex = 2;
            // 
            // labelRomano
            // 
            this.labelRomano.AutoSize = true;
            this.labelRomano.Location = new System.Drawing.Point(190, 34);
            this.labelRomano.Name = "labelRomano";
            this.labelRomano.Size = new System.Drawing.Size(99, 15);
            this.labelRomano.TabIndex = 3;
            this.labelRomano.Text = "Numero Romano";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(134, 125);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 237);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.labelRomano);
            this.Controls.Add(this.txtRomano);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.labelMonto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMonto;
        private TextBox txtMonto;
        private TextBox txtRomano;
        private Label labelRomano;
        private Button btnConvertir;
    }
}
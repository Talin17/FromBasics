namespace numeroRomanoFormDB
{
    partial class AgregarRomano
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
            this.noRomanoTxt = new System.Windows.Forms.TextBox();
            this.valorRom = new System.Windows.Forms.ComboBox();
            this.tipoRom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridAdd = new System.Windows.Forms.DataGridView();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // noRomanoTxt
            // 
            this.noRomanoTxt.Location = new System.Drawing.Point(22, 58);
            this.noRomanoTxt.Name = "noRomanoTxt";
            this.noRomanoTxt.Size = new System.Drawing.Size(116, 23);
            this.noRomanoTxt.TabIndex = 0;
            // 
            // valorRom
            // 
            this.valorRom.FormattingEnabled = true;
            this.valorRom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.valorRom.Location = new System.Drawing.Point(159, 58);
            this.valorRom.Name = "valorRom";
            this.valorRom.Size = new System.Drawing.Size(65, 23);
            this.valorRom.TabIndex = 1;
            // 
            // tipoRom
            // 
            this.tipoRom.FormattingEnabled = true;
            this.tipoRom.Items.AddRange(new object[] {
            "Unidad",
            "Decena",
            "Centena",
            "Milesima"});
            this.tipoRom.Location = new System.Drawing.Point(271, 58);
            this.tipoRom.Name = "tipoRom";
            this.tipoRom.Size = new System.Drawing.Size(121, 23);
            this.tipoRom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Romano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // dataGridAdd
            // 
            this.dataGridAdd.AllowUserToDeleteRows = false;
            this.dataGridAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unidades,
            this.Valor,
            this.Tipo,
            this.ID});
            this.dataGridAdd.Location = new System.Drawing.Point(12, 105);
            this.dataGridAdd.Name = "dataGridAdd";
            this.dataGridAdd.ReadOnly = true;
            this.dataGridAdd.RowTemplate.Height = 25;
            this.dataGridAdd.Size = new System.Drawing.Size(380, 215);
            this.dataGridAdd.TabIndex = 6;
            this.dataGridAdd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAdd_CellDoubleClick);
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(398, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(398, 214);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(413, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(40, 23);
            this.txtID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AgregarRomano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 358);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoRom);
            this.Controls.Add(this.valorRom);
            this.Controls.Add(this.noRomanoTxt);
            this.Name = "AgregarRomano";
            this.Text = "AgregarRomano";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox noRomanoTxt;
        private ComboBox valorRom;
        private ComboBox tipoRom;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridAdd;
        private Button btnAdd;
        private DataGridViewTextBoxColumn Unidades;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Tipo;
        private Button btnEdit;
        private DataGridViewTextBoxColumn ID;
        private TextBox txtID;
        private Label label4;
        private Button btnDelete;
    }
}
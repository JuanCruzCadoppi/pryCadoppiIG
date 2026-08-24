namespace pryCadoppiIG
{
    partial class frmConversor
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
            lblValor = new Label();
            lblDesde = new Label();
            lblHacia = new Label();
            btnConvertir = new Button();
            cmbDesde = new ComboBox();
            cmbHacia = new ComboBox();
            txtValor = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(32, 38);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(32, 87);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde:";
            // 
            // lblHacia
            // 
            lblHacia.AutoSize = true;
            lblHacia.Location = new Point(32, 121);
            lblHacia.Name = "lblHacia";
            lblHacia.Size = new Size(40, 15);
            lblHacia.TabIndex = 2;
            lblHacia.Text = "Hacia:";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(89, 165);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            // 
            // cmbDesde
            // 
            cmbDesde.FormattingEnabled = true;
            cmbDesde.Location = new Point(89, 84);
            cmbDesde.Name = "cmbDesde";
            cmbDesde.Size = new Size(121, 23);
            cmbDesde.TabIndex = 4;
            // 
            // cmbHacia
            // 
            cmbHacia.FormattingEnabled = true;
            cmbHacia.Location = new Point(89, 118);
            cmbHacia.Name = "cmbHacia";
            cmbHacia.Size = new Size(121, 23);
            cmbHacia.TabIndex = 5;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(89, 35);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(32, 214);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado: ";
            // 
            // frmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 256);
            Controls.Add(lblResultado);
            Controls.Add(txtValor);
            Controls.Add(cmbHacia);
            Controls.Add(cmbDesde);
            Controls.Add(btnConvertir);
            Controls.Add(lblHacia);
            Controls.Add(lblDesde);
            Controls.Add(lblValor);
            Name = "frmConversor";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private Label lblDesde;
        private Label lblHacia;
        private Button btnConvertir;
        private ComboBox cmbDesde;
        private ComboBox cmbHacia;
        private TextBox txtValor;
        private Label lblResultado;
    }
}
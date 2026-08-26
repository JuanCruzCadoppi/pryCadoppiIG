namespace pryCadoppiIG
{
    partial class frmRegistroAlum
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
            lblNom = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblSexo = new Label();
            lblTurno = new Label();
            lblCarrera = new Label();
            btnRegistrar = new Button();
            txtNom = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            optMasculino = new RadioButton();
            optFemenino = new RadioButton();
            chkMañana = new CheckBox();
            chkTarde = new CheckBox();
            cmbCarrera = new ComboBox();
            chkNoche = new CheckBox();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(29, 36);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(54, 15);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(29, 60);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(29, 85);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(29, 126);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(34, 15);
            lblSexo.TabIndex = 3;
            lblSexo.Text = "Sexo:";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(29, 167);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 4;
            lblTurno.Text = "Turno:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(29, 208);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(48, 15);
            lblCarrera.TabIndex = 5;
            lblCarrera.Text = "Carrera:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(125, 244);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(125, 33);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(130, 23);
            txtNom.TabIndex = 7;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(125, 57);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtDni
            // 
            txtDni.Enabled = false;
            txtDni.Location = new Point(125, 82);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(130, 23);
            txtDni.TabIndex = 9;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(106, 124);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(80, 19);
            optMasculino.TabIndex = 10;
            optMasculino.TabStop = true;
            optMasculino.Text = "Masculino";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(206, 124);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(78, 19);
            optFemenino.TabIndex = 11;
            optFemenino.TabStop = true;
            optFemenino.Text = "Femenino";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // chkMañana
            // 
            chkMañana.AutoSize = true;
            chkMañana.Location = new Point(106, 163);
            chkMañana.Name = "chkMañana";
            chkMañana.Size = new Size(69, 19);
            chkMañana.TabIndex = 12;
            chkMañana.Text = "Mañana";
            chkMañana.UseVisualStyleBackColor = true;
            // 
            // chkTarde
            // 
            chkTarde.AutoSize = true;
            chkTarde.Location = new Point(181, 163);
            chkTarde.Name = "chkTarde";
            chkTarde.Size = new Size(55, 19);
            chkTarde.TabIndex = 13;
            chkTarde.Text = "Tarde";
            chkTarde.UseVisualStyleBackColor = true;
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(106, 205);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(149, 23);
            cmbCarrera.TabIndex = 14;
            // 
            // chkNoche
            // 
            chkNoche.AutoSize = true;
            chkNoche.Location = new Point(241, 163);
            chkNoche.Name = "chkNoche";
            chkNoche.Size = new Size(61, 19);
            chkNoche.TabIndex = 15;
            chkNoche.Text = "Noche";
            chkNoche.UseVisualStyleBackColor = true;
            // 
            // frmRegistroAlum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 279);
            Controls.Add(chkNoche);
            Controls.Add(cmbCarrera);
            Controls.Add(chkTarde);
            Controls.Add(chkMañana);
            Controls.Add(optFemenino);
            Controls.Add(optMasculino);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNom);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCarrera);
            Controls.Add(lblTurno);
            Controls.Add(lblSexo);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistroAlum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Alumnos";
            Load += frmRegistroAlum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private Label lblApellido;
        private Label lblDni;
        private Label lblSexo;
        private Label lblTurno;
        private Label lblCarrera;
        private Button btnRegistrar;
        private TextBox txtNom;
        private TextBox txtApellido;
        private TextBox txtDni;
        private RadioButton optMasculino;
        private RadioButton optFemenino;
        private CheckBox chkMañana;
        private CheckBox chkTarde;
        private ComboBox cmbCarrera;
        private CheckBox chkNoche;
    }
}
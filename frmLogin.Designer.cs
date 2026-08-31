namespace pryCadoppiIG
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            lblUsuario = new Label();
            lblClave = new Label();
            lblBienvenida = new Label();
            label1 = new Label();
            lblIncorrecto = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Coral;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(44, 234);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(256, 30);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Menu;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(44, 122);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(256, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.MenuBar;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Location = new Point(44, 186);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = 'x';
            txtClave.Size = new Size(256, 23);
            txtClave.TabIndex = 2;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(44, 94);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(44, 158);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(67, 15);
            lblClave.TabIndex = 4;
            lblClave.Text = "Contraseña";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(83, 29);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(186, 23);
            lblBienvenida.TabIndex = 5;
            lblBienvenida.Text = "Bienvenido de nuevo\r";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 8F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(104, 62);
            label1.Name = "label1";
            label1.Size = new Size(145, 13);
            label1.TabIndex = 6;
            label1.Text = "Inicia sesión para continuar";
            // 
            // lblIncorrecto
            // 
            lblIncorrecto.AutoSize = true;
            lblIncorrecto.Location = new Point(44, 278);
            lblIncorrecto.Name = "lblIncorrecto";
            lblIncorrecto.Size = new Size(0, 15);
            lblIncorrecto.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(347, 326);
            Controls.Add(lblIncorrecto);
            Controls.Add(label1);
            Controls.Add(lblBienvenida);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label lblUsuario;
        private Label lblClave;
        private Label lblBienvenida;
        private Label label1;
        private Label lblIncorrecto;
    }
}
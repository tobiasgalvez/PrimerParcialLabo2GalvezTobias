namespace Vista
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.lbl_mensajeError = new System.Windows.Forms.Label();
            this.btn_autocompletar = new System.Windows.Forms.Button();
            this.pic_mostrarContraseña = new System.Windows.Forms.PictureBox();
            this.pic_ocultarContraseña = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mostrarContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ocultarContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(12, 75);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Ingrese usuario";
            this.txt_usuario.Size = new System.Drawing.Size(244, 30);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_contraseña.Location = new System.Drawing.Point(12, 131);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PlaceholderText = "Ingrese contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(244, 30);
            this.txt_contraseña.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.Location = new System.Drawing.Point(12, 55);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(89, 19);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_contraseña.Location = new System.Drawing.Point(12, 109);
            this.lbl_contraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(119, 19);
            this.lbl_contraseña.TabIndex = 3;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.Location = new System.Drawing.Point(55, 212);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(184, 27);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenido.Location = new System.Drawing.Point(90, 24);
            this.lbl_bienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(130, 23);
            this.lbl_bienvenido.TabIndex = 5;
            this.lbl_bienvenido.Text = "Bienvenido";
            // 
            // lbl_mensajeError
            // 
            this.lbl_mensajeError.AutoSize = true;
            this.lbl_mensajeError.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_mensajeError.Location = new System.Drawing.Point(12, 272);
            this.lbl_mensajeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mensajeError.Name = "lbl_mensajeError";
            this.lbl_mensajeError.Size = new System.Drawing.Size(31, 15);
            this.lbl_mensajeError.TabIndex = 6;
            this.lbl_mensajeError.Text = "...";
            this.lbl_mensajeError.Visible = false;
            // 
            // btn_autocompletar
            // 
            this.btn_autocompletar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_autocompletar.Location = new System.Drawing.Point(55, 177);
            this.btn_autocompletar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.btn_autocompletar.Size = new System.Drawing.Size(184, 29);
            this.btn_autocompletar.TabIndex = 7;
            this.btn_autocompletar.Text = "Autocompletar";
            this.btn_autocompletar.UseVisualStyleBackColor = true;
            this.btn_autocompletar.Click += new System.EventHandler(this.Btn_autocompletar_Click);
            // 
            // pic_mostrarContraseña
            // 
            this.pic_mostrarContraseña.Image = global::Vista.Properties.Resources.mostrar_contraseña;
            this.pic_mostrarContraseña.Location = new System.Drawing.Point(264, 131);
            this.pic_mostrarContraseña.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic_mostrarContraseña.Name = "pic_mostrarContraseña";
            this.pic_mostrarContraseña.Size = new System.Drawing.Size(34, 28);
            this.pic_mostrarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mostrarContraseña.TabIndex = 8;
            this.pic_mostrarContraseña.TabStop = false;
            this.pic_mostrarContraseña.Click += new System.EventHandler(this.Pic_mostrarContraseña_Click);
            // 
            // pic_ocultarContraseña
            // 
            this.pic_ocultarContraseña.Image = global::Vista.Properties.Resources.ocultarContraseña;
            this.pic_ocultarContraseña.Location = new System.Drawing.Point(264, 131);
            this.pic_ocultarContraseña.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pic_ocultarContraseña.Name = "pic_ocultarContraseña";
            this.pic_ocultarContraseña.Size = new System.Drawing.Size(34, 28);
            this.pic_ocultarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ocultarContraseña.TabIndex = 9;
            this.pic_ocultarContraseña.TabStop = false;
            this.pic_ocultarContraseña.Click += new System.EventHandler(this.Pic_ocultarContraseña_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(234, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(62, 21);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(304, 318);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.pic_mostrarContraseña);
            this.Controls.Add(this.pic_ocultarContraseña);
            this.Controls.Add(this.btn_autocompletar);
            this.Controls.Add(this.lbl_mensajeError);
            this.Controls.Add(this.lbl_bienvenido);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_mostrarContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ocultarContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_contraseña;
        private Label lbl_usuario;
        private Label lbl_contraseña;
        private Button btn_ingresar;
        private Label lbl_bienvenido;
        private Label lbl_mensajeError;
        private Button btn_autocompletar;
        private PictureBox pic_mostrarContraseña;
        private PictureBox pic_ocultarContraseña;
        private Button btn_salir;
    }
}
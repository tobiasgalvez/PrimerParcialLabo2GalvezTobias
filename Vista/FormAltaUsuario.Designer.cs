namespace Vista
{
    partial class FormAltaUsuario
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.monthCalendar_fechaNacimiento = new System.Windows.Forms.MonthCalendar();
            this.lbl_fechaDeNacimiento = new System.Windows.Forms.Label();
            this.cbo_roles = new System.Windows.Forms.ComboBox();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_altaDni = new System.Windows.Forms.TextBox();
            this.txt_altaApellido = new System.Windows.Forms.TextBox();
            this.txt_altaNombre = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_altaNombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_altaContraseña = new System.Windows.Forms.TextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_msjError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(287, 382);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(171, 35);
            this.btn_cancelar.TabIndex = 29;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar_fechaNacimiento
            // 
            this.monthCalendar_fechaNacimiento.Location = new System.Drawing.Point(210, 56);
            this.monthCalendar_fechaNacimiento.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.monthCalendar_fechaNacimiento.Name = "monthCalendar_fechaNacimiento";
            this.monthCalendar_fechaNacimiento.TabIndex = 28;
            // 
            // lbl_fechaDeNacimiento
            // 
            this.lbl_fechaDeNacimiento.AutoSize = true;
            this.lbl_fechaDeNacimiento.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechaDeNacimiento.Location = new System.Drawing.Point(210, 32);
            this.lbl_fechaDeNacimiento.Name = "lbl_fechaDeNacimiento";
            this.lbl_fechaDeNacimiento.Size = new System.Drawing.Size(159, 15);
            this.lbl_fechaDeNacimiento.TabIndex = 27;
            this.lbl_fechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // cbo_roles
            // 
            this.cbo_roles.FormattingEnabled = true;
            this.cbo_roles.Location = new System.Drawing.Point(39, 331);
            this.cbo_roles.Name = "cbo_roles";
            this.cbo_roles.Size = new System.Drawing.Size(138, 26);
            this.cbo_roles.TabIndex = 26;
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rol.Location = new System.Drawing.Point(42, 313);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(39, 15);
            this.lbl_rol.TabIndex = 25;
            this.lbl_rol.Text = "Rol:";
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(39, 196);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(127, 15);
            this.lbl_nombreUsuario.TabIndex = 23;
            this.lbl_nombreUsuario.Text = "Nombre Usuario:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.Location = new System.Drawing.Point(39, 143);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(39, 15);
            this.lbl_precio.TabIndex = 22;
            this.lbl_precio.Text = "Dni:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidad.Location = new System.Drawing.Point(39, 89);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(79, 15);
            this.lbl_cantidad.TabIndex = 21;
            this.lbl_cantidad.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(39, 32);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(63, 15);
            this.lbl_nombre.TabIndex = 20;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_altaDni
            // 
            this.txt_altaDni.Location = new System.Drawing.Point(39, 161);
            this.txt_altaDni.Name = "txt_altaDni";
            this.txt_altaDni.Size = new System.Drawing.Size(138, 25);
            this.txt_altaDni.TabIndex = 19;
            // 
            // txt_altaApellido
            // 
            this.txt_altaApellido.Location = new System.Drawing.Point(39, 107);
            this.txt_altaApellido.Name = "txt_altaApellido";
            this.txt_altaApellido.Size = new System.Drawing.Size(138, 25);
            this.txt_altaApellido.TabIndex = 18;
            // 
            // txt_altaNombre
            // 
            this.txt_altaNombre.Location = new System.Drawing.Point(39, 50);
            this.txt_altaNombre.Name = "txt_altaNombre";
            this.txt_altaNombre.Size = new System.Drawing.Size(138, 25);
            this.txt_altaNombre.TabIndex = 17;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(32, 382);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(171, 35);
            this.btn_confirmar.TabIndex = 16;
            this.btn_confirmar.Text = "Agregar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_altaNombreUsuario
            // 
            this.txt_altaNombreUsuario.Location = new System.Drawing.Point(39, 214);
            this.txt_altaNombreUsuario.Name = "txt_altaNombreUsuario";
            this.txt_altaNombreUsuario.Size = new System.Drawing.Size(138, 25);
            this.txt_altaNombreUsuario.TabIndex = 30;
            // 
            // txt_altaContraseña
            // 
            this.txt_altaContraseña.Location = new System.Drawing.Point(39, 269);
            this.txt_altaContraseña.Name = "txt_altaContraseña";
            this.txt_altaContraseña.Size = new System.Drawing.Size(138, 25);
            this.txt_altaContraseña.TabIndex = 32;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_contraseña.Location = new System.Drawing.Point(39, 251);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(95, 15);
            this.lbl_contraseña.TabIndex = 31;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(46, 479);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(35, 18);
            this.lbl_msjError.TabIndex = 33;
            this.lbl_msjError.Text = "...";
            this.lbl_msjError.Visible = false;
            // 
            // FormAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(515, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.txt_altaContraseña);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.txt_altaNombreUsuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.monthCalendar_fechaNacimiento);
            this.Controls.Add(this.lbl_fechaDeNacimiento);
            this.Controls.Add(this.cbo_roles);
            this.Controls.Add(this.lbl_rol);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_altaDni);
            this.Controls.Add(this.txt_altaApellido);
            this.Controls.Add(this.txt_altaNombre);
            this.Controls.Add(this.btn_confirmar);
            this.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAltaUsuario";
            this.Text = "FormAltaUsuario";
            this.Load += new System.EventHandler(this.FormAltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cancelar;
        private MonthCalendar monthCalendar_fechaNacimiento;
        private Label lbl_fechaDeNacimiento;
        private ComboBox cbo_roles;
        private Label lbl_rol;
        private Label lbl_nombreUsuario;
        private Label lbl_precio;
        private Label lbl_cantidad;
        private Label lbl_nombre;
        private TextBox txt_altaDni;
        private TextBox txt_altaApellido;
        private TextBox txt_altaNombre;
        private Button btn_confirmar;
        private TextBox txt_altaNombreUsuario;
        private TextBox txt_altaContraseña;
        private Label lbl_contraseña;
        private Label lbl_msjError;
    }
}
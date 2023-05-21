namespace Vista
{
    partial class AltaJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaJugador));
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_altaNombre = new System.Windows.Forms.TextBox();
            this.txt_altaApellido = new System.Windows.Forms.TextBox();
            this.txt_altaDni = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.cbo_altaEquipo = new System.Windows.Forms.ComboBox();
            this.lbl_posicion = new System.Windows.Forms.Label();
            this.cbo_posiciones = new System.Windows.Forms.ComboBox();
            this.lbl_fechaDeNacimiento = new System.Windows.Forms.Label();
            this.monthCalendar_fechaNacimiento = new System.Windows.Forms.MonthCalendar();
            this.lbl_msjError = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_jugadorAModificar = new System.Windows.Forms.Label();
            this.cbo_jugadoresModificar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(17, 326);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(171, 35);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Agregar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // txt_altaNombre
            // 
            this.txt_altaNombre.Location = new System.Drawing.Point(14, 37);
            this.txt_altaNombre.Name = "txt_altaNombre";
            this.txt_altaNombre.Size = new System.Drawing.Size(138, 23);
            this.txt_altaNombre.TabIndex = 1;
            // 
            // txt_altaApellido
            // 
            this.txt_altaApellido.Location = new System.Drawing.Point(14, 94);
            this.txt_altaApellido.Name = "txt_altaApellido";
            this.txt_altaApellido.Size = new System.Drawing.Size(138, 23);
            this.txt_altaApellido.TabIndex = 2;
            // 
            // txt_altaDni
            // 
            this.txt_altaDni.Location = new System.Drawing.Point(14, 148);
            this.txt_altaDni.Name = "txt_altaDni";
            this.txt_altaDni.Size = new System.Drawing.Size(138, 23);
            this.txt_altaDni.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(14, 19);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(63, 15);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidad.Location = new System.Drawing.Point(14, 76);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(79, 15);
            this.lbl_cantidad.TabIndex = 5;
            this.lbl_cantidad.Text = "Apellido:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.Location = new System.Drawing.Point(14, 130);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(39, 15);
            this.lbl_precio.TabIndex = 6;
            this.lbl_precio.Text = "Dni:";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_equipo.Location = new System.Drawing.Point(14, 183);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(63, 15);
            this.lbl_equipo.TabIndex = 7;
            this.lbl_equipo.Text = "Equipo:";
            // 
            // cbo_altaEquipo
            // 
            this.cbo_altaEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_altaEquipo.FormattingEnabled = true;
            this.cbo_altaEquipo.Location = new System.Drawing.Point(14, 201);
            this.cbo_altaEquipo.Name = "cbo_altaEquipo";
            this.cbo_altaEquipo.Size = new System.Drawing.Size(138, 23);
            this.cbo_altaEquipo.TabIndex = 8;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_posicion.Location = new System.Drawing.Point(17, 244);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(79, 15);
            this.lbl_posicion.TabIndex = 9;
            this.lbl_posicion.Text = "Posición:";
            // 
            // cbo_posiciones
            // 
            this.cbo_posiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_posiciones.FormattingEnabled = true;
            this.cbo_posiciones.Location = new System.Drawing.Point(14, 262);
            this.cbo_posiciones.Name = "cbo_posiciones";
            this.cbo_posiciones.Size = new System.Drawing.Size(138, 23);
            this.cbo_posiciones.TabIndex = 10;
            // 
            // lbl_fechaDeNacimiento
            // 
            this.lbl_fechaDeNacimiento.AutoSize = true;
            this.lbl_fechaDeNacimiento.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechaDeNacimiento.Location = new System.Drawing.Point(185, 19);
            this.lbl_fechaDeNacimiento.Name = "lbl_fechaDeNacimiento";
            this.lbl_fechaDeNacimiento.Size = new System.Drawing.Size(159, 15);
            this.lbl_fechaDeNacimiento.TabIndex = 12;
            this.lbl_fechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // monthCalendar_fechaNacimiento
            // 
            this.monthCalendar_fechaNacimiento.Location = new System.Drawing.Point(185, 43);
            this.monthCalendar_fechaNacimiento.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.monthCalendar_fechaNacimiento.Name = "monthCalendar_fechaNacimiento";
            this.monthCalendar_fechaNacimiento.TabIndex = 13;
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(22, 406);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(31, 15);
            this.lbl_msjError.TabIndex = 14;
            this.lbl_msjError.Text = "...";
            this.lbl_msjError.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(272, 326);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(171, 35);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_jugadorAModificar
            // 
            this.lbl_jugadorAModificar.AutoSize = true;
            this.lbl_jugadorAModificar.Location = new System.Drawing.Point(185, 233);
            this.lbl_jugadorAModificar.Name = "lbl_jugadorAModificar";
            this.lbl_jugadorAModificar.Size = new System.Drawing.Size(167, 15);
            this.lbl_jugadorAModificar.TabIndex = 16;
            this.lbl_jugadorAModificar.Text = "Jugador a modificar:";
            this.lbl_jugadorAModificar.Visible = false;
            // 
            // cbo_jugadoresModificar
            // 
            this.cbo_jugadoresModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_jugadoresModificar.FormattingEnabled = true;
            this.cbo_jugadoresModificar.Location = new System.Drawing.Point(185, 262);
            this.cbo_jugadoresModificar.Name = "cbo_jugadoresModificar";
            this.cbo_jugadoresModificar.Size = new System.Drawing.Size(258, 23);
            this.cbo_jugadoresModificar.TabIndex = 17;
            this.cbo_jugadoresModificar.Visible = false;
            this.cbo_jugadoresModificar.SelectionChangeCommitted += new System.EventHandler(this.cbo_jugadoresModificar_SelectionChangeCommitted);
            // 
            // AltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbo_jugadoresModificar);
            this.Controls.Add(this.lbl_jugadorAModificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.monthCalendar_fechaNacimiento);
            this.Controls.Add(this.lbl_fechaDeNacimiento);
            this.Controls.Add(this.cbo_posiciones);
            this.Controls.Add(this.lbl_posicion);
            this.Controls.Add(this.cbo_altaEquipo);
            this.Controls.Add(this.lbl_equipo);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_altaDni);
            this.Controls.Add(this.txt_altaApellido);
            this.Controls.Add(this.txt_altaNombre);
            this.Controls.Add(this.btn_confirmar);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AltaProducto";
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_confirmar;
        private TextBox txt_altaNombre;
        private TextBox txt_altaApellido;
        private TextBox txt_altaDni;
        private Label lbl_nombre;
        private Label lbl_cantidad;
        private Label lbl_precio;
        private Label lbl_equipo;
        private ComboBox cbo_altaEquipo;
        private Label lbl_posicion;
        private ComboBox cbo_posiciones;
        private Label lbl_fechaDeNacimiento;
        private MonthCalendar monthCalendar_fechaNacimiento;
        private Label lbl_msjError;
        private Button btn_cancelar;
        private Label lbl_jugadorAModificar;
        private ComboBox cbo_jugadoresModificar;
    }
}
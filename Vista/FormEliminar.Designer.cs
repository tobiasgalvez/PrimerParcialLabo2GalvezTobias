namespace Vista
{
    partial class FormEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            this.btn_eliminarJugador = new System.Windows.Forms.Button();
            this.cbo_jugadores = new System.Windows.Forms.ComboBox();
            this.cbo_equipos = new System.Windows.Forms.ComboBox();
            this.btn_eliminarEquipo = new System.Windows.Forms.Button();
            this.lbl_jugadores = new System.Windows.Forms.Label();
            this.lbl_equipos = new System.Windows.Forms.Label();
            this.lbl_usuarios = new System.Windows.Forms.Label();
            this.cbo_usuarios = new System.Windows.Forms.ComboBox();
            this.btn_eliminarUsuario = new System.Windows.Forms.Button();
            this.lbl_torneos = new System.Windows.Forms.Label();
            this.cbo_torneos = new System.Windows.Forms.ComboBox();
            this.btn_eliminarTorneo = new System.Windows.Forms.Button();
            this.lbl_partidos = new System.Windows.Forms.Label();
            this.cbo_partidos = new System.Windows.Forms.ComboBox();
            this.btn_eliminarPartido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_eliminarJugador
            // 
            this.btn_eliminarJugador.Location = new System.Drawing.Point(102, 66);
            this.btn_eliminarJugador.Name = "btn_eliminarJugador";
            this.btn_eliminarJugador.Size = new System.Drawing.Size(159, 31);
            this.btn_eliminarJugador.TabIndex = 0;
            this.btn_eliminarJugador.Text = "Eliminar jugador";
            this.btn_eliminarJugador.UseVisualStyleBackColor = true;
            this.btn_eliminarJugador.Click += new System.EventHandler(this.btn_eliminarJugador_Click);
            // 
            // cbo_jugadores
            // 
            this.cbo_jugadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_jugadores.FormattingEnabled = true;
            this.cbo_jugadores.Location = new System.Drawing.Point(12, 37);
            this.cbo_jugadores.Name = "cbo_jugadores";
            this.cbo_jugadores.Size = new System.Drawing.Size(342, 23);
            this.cbo_jugadores.TabIndex = 1;
            // 
            // cbo_equipos
            // 
            this.cbo_equipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_equipos.FormattingEnabled = true;
            this.cbo_equipos.Location = new System.Drawing.Point(405, 37);
            this.cbo_equipos.Name = "cbo_equipos";
            this.cbo_equipos.Size = new System.Drawing.Size(342, 23);
            this.cbo_equipos.TabIndex = 3;
            // 
            // btn_eliminarEquipo
            // 
            this.btn_eliminarEquipo.Location = new System.Drawing.Point(495, 66);
            this.btn_eliminarEquipo.Name = "btn_eliminarEquipo";
            this.btn_eliminarEquipo.Size = new System.Drawing.Size(159, 31);
            this.btn_eliminarEquipo.TabIndex = 2;
            this.btn_eliminarEquipo.Text = "Eliminar equipo";
            this.btn_eliminarEquipo.UseVisualStyleBackColor = true;
            this.btn_eliminarEquipo.Click += new System.EventHandler(this.btn_eliminarEquipo_Click);
            // 
            // lbl_jugadores
            // 
            this.lbl_jugadores.AutoSize = true;
            this.lbl_jugadores.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_jugadores.Location = new System.Drawing.Point(121, 9);
            this.lbl_jugadores.Name = "lbl_jugadores";
            this.lbl_jugadores.Size = new System.Drawing.Size(99, 19);
            this.lbl_jugadores.TabIndex = 4;
            this.lbl_jugadores.Text = "Jugadores";
            // 
            // lbl_equipos
            // 
            this.lbl_equipos.AutoSize = true;
            this.lbl_equipos.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_equipos.Location = new System.Drawing.Point(534, 15);
            this.lbl_equipos.Name = "lbl_equipos";
            this.lbl_equipos.Size = new System.Drawing.Size(79, 19);
            this.lbl_equipos.TabIndex = 5;
            this.lbl_equipos.Text = "Equipos";
            // 
            // lbl_usuarios
            // 
            this.lbl_usuarios.AutoSize = true;
            this.lbl_usuarios.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuarios.Location = new System.Drawing.Point(141, 115);
            this.lbl_usuarios.Name = "lbl_usuarios";
            this.lbl_usuarios.Size = new System.Drawing.Size(89, 19);
            this.lbl_usuarios.TabIndex = 8;
            this.lbl_usuarios.Text = "Usuarios";
            // 
            // cbo_usuarios
            // 
            this.cbo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_usuarios.FormattingEnabled = true;
            this.cbo_usuarios.Location = new System.Drawing.Point(12, 137);
            this.cbo_usuarios.Name = "cbo_usuarios";
            this.cbo_usuarios.Size = new System.Drawing.Size(342, 23);
            this.cbo_usuarios.TabIndex = 7;
            // 
            // btn_eliminarUsuario
            // 
            this.btn_eliminarUsuario.Location = new System.Drawing.Point(102, 166);
            this.btn_eliminarUsuario.Name = "btn_eliminarUsuario";
            this.btn_eliminarUsuario.Size = new System.Drawing.Size(159, 31);
            this.btn_eliminarUsuario.TabIndex = 6;
            this.btn_eliminarUsuario.Text = "Eliminar usuario";
            this.btn_eliminarUsuario.UseVisualStyleBackColor = true;
            this.btn_eliminarUsuario.Click += new System.EventHandler(this.btn_eliminarUsuario_Click);
            // 
            // lbl_torneos
            // 
            this.lbl_torneos.AutoSize = true;
            this.lbl_torneos.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_torneos.Location = new System.Drawing.Point(534, 115);
            this.lbl_torneos.Name = "lbl_torneos";
            this.lbl_torneos.Size = new System.Drawing.Size(79, 19);
            this.lbl_torneos.TabIndex = 11;
            this.lbl_torneos.Text = "Torneos";
            // 
            // cbo_torneos
            // 
            this.cbo_torneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_torneos.FormattingEnabled = true;
            this.cbo_torneos.Location = new System.Drawing.Point(405, 137);
            this.cbo_torneos.Name = "cbo_torneos";
            this.cbo_torneos.Size = new System.Drawing.Size(342, 23);
            this.cbo_torneos.TabIndex = 10;
            // 
            // btn_eliminarTorneo
            // 
            this.btn_eliminarTorneo.Location = new System.Drawing.Point(495, 166);
            this.btn_eliminarTorneo.Name = "btn_eliminarTorneo";
            this.btn_eliminarTorneo.Size = new System.Drawing.Size(159, 31);
            this.btn_eliminarTorneo.TabIndex = 9;
            this.btn_eliminarTorneo.Text = "Eliminar torneo";
            this.btn_eliminarTorneo.UseVisualStyleBackColor = true;
            this.btn_eliminarTorneo.Click += new System.EventHandler(this.btn_eliminarTorneo_Click);
            // 
            // lbl_partidos
            // 
            this.lbl_partidos.AutoSize = true;
            this.lbl_partidos.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_partidos.Location = new System.Drawing.Point(340, 228);
            this.lbl_partidos.Name = "lbl_partidos";
            this.lbl_partidos.Size = new System.Drawing.Size(89, 19);
            this.lbl_partidos.TabIndex = 14;
            this.lbl_partidos.Text = "Partidos";
            // 
            // cbo_partidos
            // 
            this.cbo_partidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_partidos.FormattingEnabled = true;
            this.cbo_partidos.Location = new System.Drawing.Point(12, 250);
            this.cbo_partidos.Name = "cbo_partidos";
            this.cbo_partidos.Size = new System.Drawing.Size(735, 23);
            this.cbo_partidos.TabIndex = 13;
            // 
            // btn_eliminarPartido
            // 
            this.btn_eliminarPartido.Location = new System.Drawing.Point(301, 279);
            this.btn_eliminarPartido.Name = "btn_eliminarPartido";
            this.btn_eliminarPartido.Size = new System.Drawing.Size(159, 31);
            this.btn_eliminarPartido.TabIndex = 12;
            this.btn_eliminarPartido.Text = "Eliminar Partido";
            this.btn_eliminarPartido.UseVisualStyleBackColor = true;
            this.btn_eliminarPartido.Click += new System.EventHandler(this.btn_eliminarPartido_Click);
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(828, 342);
            this.Controls.Add(this.lbl_partidos);
            this.Controls.Add(this.cbo_partidos);
            this.Controls.Add(this.btn_eliminarPartido);
            this.Controls.Add(this.lbl_torneos);
            this.Controls.Add(this.cbo_torneos);
            this.Controls.Add(this.btn_eliminarTorneo);
            this.Controls.Add(this.lbl_usuarios);
            this.Controls.Add(this.cbo_usuarios);
            this.Controls.Add(this.btn_eliminarUsuario);
            this.Controls.Add(this.lbl_equipos);
            this.Controls.Add(this.lbl_jugadores);
            this.Controls.Add(this.cbo_equipos);
            this.Controls.Add(this.btn_eliminarEquipo);
            this.Controls.Add(this.cbo_jugadores);
            this.Controls.Add(this.btn_eliminarJugador);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEliminar";
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_eliminarJugador;
        private ComboBox cbo_jugadores;
        private ComboBox cbo_equipos;
        private Button btn_eliminarEquipo;
        private Label lbl_jugadores;
        private Label lbl_equipos;
        private Label lbl_usuarios;
        private ComboBox cbo_usuarios;
        private Button btn_eliminarUsuario;
        private Label lbl_torneos;
        private ComboBox cbo_torneos;
        private Button btn_eliminarTorneo;
        private Label lbl_partidos;
        private ComboBox cbo_partidos;
        private Button btn_eliminarPartido;
    }
}
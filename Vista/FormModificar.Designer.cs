namespace Vista
{
    partial class FormModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificar));
            this.btn_modificarJugador = new System.Windows.Forms.Button();
            this.btn_modificarEquipo = new System.Windows.Forms.Button();
            this.btn_modificarUsuario = new System.Windows.Forms.Button();
            this.btn_modificarTorneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_modificarJugador
            // 
            this.btn_modificarJugador.Location = new System.Drawing.Point(114, 46);
            this.btn_modificarJugador.Name = "btn_modificarJugador";
            this.btn_modificarJugador.Size = new System.Drawing.Size(224, 87);
            this.btn_modificarJugador.TabIndex = 0;
            this.btn_modificarJugador.Text = "Jugador";
            this.btn_modificarJugador.UseVisualStyleBackColor = true;
            this.btn_modificarJugador.Click += new System.EventHandler(this.btn_modificarJugador_Click);
            // 
            // btn_modificarEquipo
            // 
            this.btn_modificarEquipo.Location = new System.Drawing.Point(461, 46);
            this.btn_modificarEquipo.Name = "btn_modificarEquipo";
            this.btn_modificarEquipo.Size = new System.Drawing.Size(220, 87);
            this.btn_modificarEquipo.TabIndex = 1;
            this.btn_modificarEquipo.Text = "Equipo";
            this.btn_modificarEquipo.UseVisualStyleBackColor = true;
            this.btn_modificarEquipo.Click += new System.EventHandler(this.btn_modificarEquipo_Click);
            // 
            // btn_modificarUsuario
            // 
            this.btn_modificarUsuario.Location = new System.Drawing.Point(114, 191);
            this.btn_modificarUsuario.Name = "btn_modificarUsuario";
            this.btn_modificarUsuario.Size = new System.Drawing.Size(224, 94);
            this.btn_modificarUsuario.TabIndex = 2;
            this.btn_modificarUsuario.Text = "Usuario";
            this.btn_modificarUsuario.UseVisualStyleBackColor = true;
            this.btn_modificarUsuario.Click += new System.EventHandler(this.btn_modificarUsuario_Click);
            // 
            // btn_modificarTorneo
            // 
            this.btn_modificarTorneo.Location = new System.Drawing.Point(468, 191);
            this.btn_modificarTorneo.Name = "btn_modificarTorneo";
            this.btn_modificarTorneo.Size = new System.Drawing.Size(213, 94);
            this.btn_modificarTorneo.TabIndex = 3;
            this.btn_modificarTorneo.Text = "Torneo";
            this.btn_modificarTorneo.UseVisualStyleBackColor = true;
            this.btn_modificarTorneo.Click += new System.EventHandler(this.btn_modificarTorneo_Click);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(789, 326);
            this.Controls.Add(this.btn_modificarTorneo);
            this.Controls.Add(this.btn_modificarUsuario);
            this.Controls.Add(this.btn_modificarEquipo);
            this.Controls.Add(this.btn_modificarJugador);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormModificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_modificarJugador;
        private Button btn_modificarEquipo;
        private Button btn_modificarUsuario;
        private Button btn_modificarTorneo;
    }
}
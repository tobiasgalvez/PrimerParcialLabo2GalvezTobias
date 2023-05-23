namespace Vista
{
    partial class FormContenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTorneosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verResultadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRankingHistoricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEquiposToolStripMenuItem,
            this.verPersonasToolStripMenuItem,
            this.verTorneosToolStripMenuItem1,
            this.verResultadosToolStripMenuItem1,
            this.verUsuariosToolStripMenuItem,
            this.verRankingHistoricoToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.listadoToolStripMenuItem.Text = "Listas";
            // 
            // verEquiposToolStripMenuItem
            // 
            this.verEquiposToolStripMenuItem.Name = "verEquiposToolStripMenuItem";
            this.verEquiposToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.verEquiposToolStripMenuItem.Text = "Ver equipos";
            this.verEquiposToolStripMenuItem.Click += new System.EventHandler(this.verEquiposToolStripMenuItem_Click);
            // 
            // verPersonasToolStripMenuItem
            // 
            this.verPersonasToolStripMenuItem.Name = "verPersonasToolStripMenuItem";
            this.verPersonasToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.verPersonasToolStripMenuItem.Text = "Ver Jugadores";
            this.verPersonasToolStripMenuItem.Click += new System.EventHandler(this.verPersonasToolStripMenuItem_Click);
            // 
            // verTorneosToolStripMenuItem1
            // 
            this.verTorneosToolStripMenuItem1.Name = "verTorneosToolStripMenuItem1";
            this.verTorneosToolStripMenuItem1.Size = new System.Drawing.Size(265, 22);
            this.verTorneosToolStripMenuItem1.Text = "Ver Torneos";
            this.verTorneosToolStripMenuItem1.Click += new System.EventHandler(this.verTorneosToolStripMenuItem1_Click);
            // 
            // verResultadosToolStripMenuItem1
            // 
            this.verResultadosToolStripMenuItem1.Name = "verResultadosToolStripMenuItem1";
            this.verResultadosToolStripMenuItem1.Size = new System.Drawing.Size(265, 22);
            this.verResultadosToolStripMenuItem1.Text = "Ver Resultados";
            this.verResultadosToolStripMenuItem1.Click += new System.EventHandler(this.verResultadosToolStripMenuItem1_Click);
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // verRankingHistoricoToolStripMenuItem
            // 
            this.verRankingHistoricoToolStripMenuItem.Name = "verRankingHistoricoToolStripMenuItem";
            this.verRankingHistoricoToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.verRankingHistoricoToolStripMenuItem.Text = "Ver Ranking Historico";
            this.verRankingHistoricoToolStripMenuItem.Click += new System.EventHandler(this.verRankingHistoricoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.aplicaciónToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // aplicaciónToolStripMenuItem
            // 
            this.aplicaciónToolStripMenuItem.Name = "aplicaciónToolStripMenuItem";
            this.aplicaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aplicaciónToolStripMenuItem.Text = "Aplicación";
            this.aplicaciónToolStripMenuItem.Click += new System.EventHandler(this.aplicaciónToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // FormContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vista.Properties.Resources._566722;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 510);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormContenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listadoToolStripMenuItem;
        private ToolStripMenuItem verPersonasToolStripMenuItem;
        private ToolStripMenuItem desconectarToolStripMenuItem;
        private ToolStripMenuItem verEquiposToolStripMenuItem;
        private ToolStripMenuItem verTorneosToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripMenuItem verResultadosToolStripMenuItem1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem aplicaciónToolStripMenuItem;
        private ToolStripMenuItem verRankingHistoricoToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
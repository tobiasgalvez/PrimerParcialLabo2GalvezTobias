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
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.resultadosToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEquiposToolStripMenuItem,
            this.verPersonasToolStripMenuItem,
            this.verTorneosToolStripMenuItem1,
            this.verUsuariosToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.listadoToolStripMenuItem.Text = "Listas";
            // 
            // verEquiposToolStripMenuItem
            // 
            this.verEquiposToolStripMenuItem.Name = "verEquiposToolStripMenuItem";
            this.verEquiposToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.verEquiposToolStripMenuItem.Text = "Ver equipos";
            this.verEquiposToolStripMenuItem.Click += new System.EventHandler(this.verEquiposToolStripMenuItem_Click);
            // 
            // verPersonasToolStripMenuItem
            // 
            this.verPersonasToolStripMenuItem.Name = "verPersonasToolStripMenuItem";
            this.verPersonasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.verPersonasToolStripMenuItem.Text = "Ver Jugadores";
            this.verPersonasToolStripMenuItem.Click += new System.EventHandler(this.verPersonasToolStripMenuItem_Click);
            // 
            // verTorneosToolStripMenuItem1
            // 
            this.verTorneosToolStripMenuItem1.Name = "verTorneosToolStripMenuItem1";
            this.verTorneosToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.verTorneosToolStripMenuItem1.Text = "Ver Torneos";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verResultadosToolStripMenuItem});
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.resultadosToolStripMenuItem.Text = "Resultados";
            // 
            // verResultadosToolStripMenuItem
            // 
            this.verResultadosToolStripMenuItem.Name = "verResultadosToolStripMenuItem";
            this.verResultadosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verResultadosToolStripMenuItem.Text = "Ver resultados";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugadoresToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.torneosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // torneosToolStripMenuItem
            // 
            this.torneosToolStripMenuItem.Name = "torneosToolStripMenuItem";
            this.torneosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.torneosToolStripMenuItem.Text = "Torneos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
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
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private ToolStripMenuItem resultadosToolStripMenuItem;
        private ToolStripMenuItem verResultadosToolStripMenuItem;
        private ToolStripMenuItem verTorneosToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem jugadoresToolStripMenuItem;
        private ToolStripMenuItem equiposToolStripMenuItem;
        private ToolStripMenuItem torneosToolStripMenuItem;
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
    }
}
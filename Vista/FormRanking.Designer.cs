namespace Vista
{
    partial class FormRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRanking));
            this.btn_másGoles = new System.Windows.Forms.Button();
            this.btn_masPartidos = new System.Windows.Forms.Button();
            this.btn_masTarjetasAmarillas = new System.Windows.Forms.Button();
            this.btn_masTarjetasRojas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_másGoles
            // 
            this.btn_másGoles.Location = new System.Drawing.Point(143, 48);
            this.btn_másGoles.Name = "btn_másGoles";
            this.btn_másGoles.Size = new System.Drawing.Size(228, 120);
            this.btn_másGoles.TabIndex = 0;
            this.btn_másGoles.Text = "Más goles convertidos";
            this.btn_másGoles.UseVisualStyleBackColor = true;
            this.btn_másGoles.Click += new System.EventHandler(this.btn_másGoles_Click);
            // 
            // btn_masPartidos
            // 
            this.btn_masPartidos.Location = new System.Drawing.Point(536, 48);
            this.btn_masPartidos.Name = "btn_masPartidos";
            this.btn_masPartidos.Size = new System.Drawing.Size(251, 120);
            this.btn_masPartidos.TabIndex = 1;
            this.btn_masPartidos.Text = "Más partidos jugados";
            this.btn_masPartidos.UseVisualStyleBackColor = true;
            this.btn_masPartidos.Click += new System.EventHandler(this.btn_masPartidos_Click);
            // 
            // btn_masTarjetasAmarillas
            // 
            this.btn_masTarjetasAmarillas.Location = new System.Drawing.Point(143, 205);
            this.btn_masTarjetasAmarillas.Name = "btn_masTarjetasAmarillas";
            this.btn_masTarjetasAmarillas.Size = new System.Drawing.Size(228, 120);
            this.btn_masTarjetasAmarillas.TabIndex = 2;
            this.btn_masTarjetasAmarillas.Text = "Más Tarjetas Amarillas";
            this.btn_masTarjetasAmarillas.UseVisualStyleBackColor = true;
            this.btn_masTarjetasAmarillas.Click += new System.EventHandler(this.btn_masTarjetasAmarillas_Click);
            // 
            // btn_masTarjetasRojas
            // 
            this.btn_masTarjetasRojas.Location = new System.Drawing.Point(536, 205);
            this.btn_masTarjetasRojas.Name = "btn_masTarjetasRojas";
            this.btn_masTarjetasRojas.Size = new System.Drawing.Size(251, 120);
            this.btn_masTarjetasRojas.TabIndex = 3;
            this.btn_masTarjetasRojas.Text = "Más Tarjetas Rojas";
            this.btn_masTarjetasRojas.UseVisualStyleBackColor = true;
            this.btn_masTarjetasRojas.Click += new System.EventHandler(this.btn_masTarjetasRojas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.tarjetaAmarilla;
            this.pictureBox1.Location = new System.Drawing.Point(12, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.tarjetaRoja;
            this.pictureBox2.Location = new System.Drawing.Point(391, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vista.Properties.Resources.messi;
            this.pictureBox3.Location = new System.Drawing.Point(12, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Vista.Properties.Resources.voetbal_soccer2;
            this.pictureBox4.Location = new System.Drawing.Point(389, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(116, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // FormRankingHistórico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(821, 337);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_masTarjetasRojas);
            this.Controls.Add(this.btn_masTarjetasAmarillas);
            this.Controls.Add(this.btn_masPartidos);
            this.Controls.Add(this.btn_másGoles);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRankingHistórico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormRankingHistórico";
            this.Load += new System.EventHandler(this.FormRankingHistórico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_másGoles;
        private Button btn_masPartidos;
        private Button btn_masTarjetasAmarillas;
        private Button btn_masTarjetasRojas;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
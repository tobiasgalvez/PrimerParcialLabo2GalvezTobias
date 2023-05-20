namespace Vista
{
    partial class FormRankingHistórico
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
            this.btn_másGoles = new System.Windows.Forms.Button();
            this.btn_masPartidos = new System.Windows.Forms.Button();
            this.btn_masTarjetasAmarillas = new System.Windows.Forms.Button();
            this.btn_masTarjetasRojas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_másGoles
            // 
            this.btn_másGoles.Location = new System.Drawing.Point(124, 48);
            this.btn_másGoles.Name = "btn_másGoles";
            this.btn_másGoles.Size = new System.Drawing.Size(156, 57);
            this.btn_másGoles.TabIndex = 0;
            this.btn_másGoles.Text = "Más goles convertidos";
            this.btn_másGoles.UseVisualStyleBackColor = true;
            this.btn_másGoles.Click += new System.EventHandler(this.btn_másGoles_Click);
            // 
            // btn_masPartidos
            // 
            this.btn_masPartidos.Location = new System.Drawing.Point(463, 48);
            this.btn_masPartidos.Name = "btn_masPartidos";
            this.btn_masPartidos.Size = new System.Drawing.Size(159, 57);
            this.btn_masPartidos.TabIndex = 1;
            this.btn_masPartidos.Text = "Más partidos jugados";
            this.btn_masPartidos.UseVisualStyleBackColor = true;
            this.btn_masPartidos.Click += new System.EventHandler(this.btn_masPartidos_Click);
            // 
            // btn_masTarjetasAmarillas
            // 
            this.btn_masTarjetasAmarillas.Location = new System.Drawing.Point(124, 148);
            this.btn_masTarjetasAmarillas.Name = "btn_masTarjetasAmarillas";
            this.btn_masTarjetasAmarillas.Size = new System.Drawing.Size(159, 57);
            this.btn_masTarjetasAmarillas.TabIndex = 2;
            this.btn_masTarjetasAmarillas.Text = "Más Tarjetas Amarillas";
            this.btn_masTarjetasAmarillas.UseVisualStyleBackColor = true;
            this.btn_masTarjetasAmarillas.Click += new System.EventHandler(this.btn_masTarjetasAmarillas_Click);
            // 
            // btn_masTarjetasRojas
            // 
            this.btn_masTarjetasRojas.Location = new System.Drawing.Point(463, 148);
            this.btn_masTarjetasRojas.Name = "btn_masTarjetasRojas";
            this.btn_masTarjetasRojas.Size = new System.Drawing.Size(159, 57);
            this.btn_masTarjetasRojas.TabIndex = 3;
            this.btn_masTarjetasRojas.Text = "Más Tarjetas Rojas";
            this.btn_masTarjetasRojas.UseVisualStyleBackColor = true;
            this.btn_masTarjetasRojas.Click += new System.EventHandler(this.btn_masTarjetasRojas_Click);
            // 
            // FormRankingHistórico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(821, 337);
            this.Controls.Add(this.btn_masTarjetasRojas);
            this.Controls.Add(this.btn_masTarjetasAmarillas);
            this.Controls.Add(this.btn_masPartidos);
            this.Controls.Add(this.btn_másGoles);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormRankingHistórico";
            this.Text = "FormRankingHistórico";
            this.Load += new System.EventHandler(this.FormRankingHistórico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_másGoles;
        private Button btn_masPartidos;
        private Button btn_masTarjetasAmarillas;
        private Button btn_masTarjetasRojas;
    }
}
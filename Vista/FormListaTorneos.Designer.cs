namespace Vista
{
    partial class FormListaTorneos
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
            this.btn_agregarTorneo = new System.Windows.Forms.Button();
            this.lbl_listadoTorneos = new System.Windows.Forms.Label();
            this.dgv_listadoTorneos = new System.Windows.Forms.DataGridView();
            this.btn_agregarResultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoTorneos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarTorneo
            // 
            this.btn_agregarTorneo.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarTorneo.Location = new System.Drawing.Point(137, 12);
            this.btn_agregarTorneo.Name = "btn_agregarTorneo";
            this.btn_agregarTorneo.Size = new System.Drawing.Size(217, 33);
            this.btn_agregarTorneo.TabIndex = 5;
            this.btn_agregarTorneo.Text = "Agregar torneo";
            this.btn_agregarTorneo.UseVisualStyleBackColor = true;
            // 
            // lbl_listadoTorneos
            // 
            this.lbl_listadoTorneos.AutoSize = true;
            this.lbl_listadoTorneos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listadoTorneos.Location = new System.Drawing.Point(18, 24);
            this.lbl_listadoTorneos.Name = "lbl_listadoTorneos";
            this.lbl_listadoTorneos.Size = new System.Drawing.Size(111, 15);
            this.lbl_listadoTorneos.TabIndex = 4;
            this.lbl_listadoTorneos.Text = "Lista Torneos";
            // 
            // dgv_listadoTorneos
            // 
            this.dgv_listadoTorneos.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_listadoTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoTorneos.Location = new System.Drawing.Point(13, 53);
            this.dgv_listadoTorneos.Name = "dgv_listadoTorneos";
            this.dgv_listadoTorneos.RowTemplate.Height = 25;
            this.dgv_listadoTorneos.Size = new System.Drawing.Size(769, 321);
            this.dgv_listadoTorneos.TabIndex = 3;
            // 
            // btn_agregarResultado
            // 
            this.btn_agregarResultado.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarResultado.Location = new System.Drawing.Point(394, 12);
            this.btn_agregarResultado.Name = "btn_agregarResultado";
            this.btn_agregarResultado.Size = new System.Drawing.Size(217, 33);
            this.btn_agregarResultado.TabIndex = 6;
            this.btn_agregarResultado.Text = "Agregar Resultado";
            this.btn_agregarResultado.UseVisualStyleBackColor = true;
            this.btn_agregarResultado.Click += new System.EventHandler(this.btn_agregarResultado_Click);
            // 
            // ListaTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_agregarResultado);
            this.Controls.Add(this.btn_agregarTorneo);
            this.Controls.Add(this.lbl_listadoTorneos);
            this.Controls.Add(this.dgv_listadoTorneos);
            this.Name = "ListaTorneos";
            this.Text = "ListaTorneos";
            this.Load += new System.EventHandler(this.ListaTorneos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoTorneos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_agregarTorneo;
        private Label lbl_listadoTorneos;
        private DataGridView dgv_listadoTorneos;
        private Button btn_agregarResultado;
    }
}
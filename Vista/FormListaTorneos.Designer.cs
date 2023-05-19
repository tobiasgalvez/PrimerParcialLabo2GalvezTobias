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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaTorneos));
            this.btn_agregarTorneo = new System.Windows.Forms.Button();
            this.lbl_listadoTorneos = new System.Windows.Forms.Label();
            this.dgv_listadoTorneos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoTorneos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarTorneo
            // 
            this.btn_agregarTorneo.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarTorneo.Location = new System.Drawing.Point(157, 12);
            this.btn_agregarTorneo.Name = "btn_agregarTorneo";
            this.btn_agregarTorneo.Size = new System.Drawing.Size(248, 33);
            this.btn_agregarTorneo.TabIndex = 5;
            this.btn_agregarTorneo.Text = "Agregar torneo";
            this.btn_agregarTorneo.UseVisualStyleBackColor = true;
            this.btn_agregarTorneo.Click += new System.EventHandler(this.btn_agregarTorneo_Click);
            // 
            // lbl_listadoTorneos
            // 
            this.lbl_listadoTorneos.AutoSize = true;
            this.lbl_listadoTorneos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listadoTorneos.Location = new System.Drawing.Point(21, 24);
            this.lbl_listadoTorneos.Name = "lbl_listadoTorneos";
            this.lbl_listadoTorneos.Size = new System.Drawing.Size(111, 15);
            this.lbl_listadoTorneos.TabIndex = 4;
            this.lbl_listadoTorneos.Text = "Lista Torneos";
            // 
            // dgv_listadoTorneos
            // 
            this.dgv_listadoTorneos.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_listadoTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoTorneos.Location = new System.Drawing.Point(15, 53);
            this.dgv_listadoTorneos.Name = "dgv_listadoTorneos";
            this.dgv_listadoTorneos.RowTemplate.Height = 25;
            this.dgv_listadoTorneos.Size = new System.Drawing.Size(738, 321);
            this.dgv_listadoTorneos.TabIndex = 3;
            // 
            // FormListaTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(791, 393);
            this.Controls.Add(this.btn_agregarTorneo);
            this.Controls.Add(this.lbl_listadoTorneos);
            this.Controls.Add(this.dgv_listadoTorneos);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaTorneos";
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
    }
}
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
            this.btn_exportar = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_exportarJson = new System.Windows.Forms.Button();
            this.btn_exportarCsv = new System.Windows.Forms.Button();
            this.lbl_msjError = new System.Windows.Forms.Label();
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
            this.dgv_listadoTorneos.Size = new System.Drawing.Size(764, 233);
            this.dgv_listadoTorneos.TabIndex = 3;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(670, 305);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(91, 23);
            this.btn_exportar.TabIndex = 10;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Visible = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(450, 305);
            this.txt_path.Name = "txt_path";
            this.txt_path.PlaceholderText = "Ingrese path";
            this.txt_path.Size = new System.Drawing.Size(182, 23);
            this.txt_path.TabIndex = 9;
            this.txt_path.Visible = false;
            // 
            // btn_exportarJson
            // 
            this.btn_exportarJson.Location = new System.Drawing.Point(224, 304);
            this.btn_exportarJson.Name = "btn_exportarJson";
            this.btn_exportarJson.Size = new System.Drawing.Size(183, 23);
            this.btn_exportarJson.TabIndex = 8;
            this.btn_exportarJson.Text = "Exportar json";
            this.btn_exportarJson.UseVisualStyleBackColor = true;
            this.btn_exportarJson.Visible = false;
            this.btn_exportarJson.Click += new System.EventHandler(this.btn_exportarJson_Click);
            // 
            // btn_exportarCsv
            // 
            this.btn_exportarCsv.Location = new System.Drawing.Point(21, 304);
            this.btn_exportarCsv.Name = "btn_exportarCsv";
            this.btn_exportarCsv.Size = new System.Drawing.Size(184, 23);
            this.btn_exportarCsv.TabIndex = 7;
            this.btn_exportarCsv.Text = "Exportar csv";
            this.btn_exportarCsv.UseVisualStyleBackColor = true;
            this.btn_exportarCsv.Visible = false;
            this.btn_exportarCsv.Click += new System.EventHandler(this.btn_exportarCsv_Click);
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(18, 356);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(55, 15);
            this.lbl_msjError.TabIndex = 11;
            this.lbl_msjError.Text = "label1";
            this.lbl_msjError.Visible = false;
            // 
            // FormListaTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(791, 393);
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_exportarJson);
            this.Controls.Add(this.btn_exportarCsv);
            this.Controls.Add(this.btn_agregarTorneo);
            this.Controls.Add(this.lbl_listadoTorneos);
            this.Controls.Add(this.dgv_listadoTorneos);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaTorneos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private Button btn_exportar;
        private TextBox txt_path;
        private Button btn_exportarJson;
        private Button btn_exportarCsv;
        private Label lbl_msjError;
    }
}
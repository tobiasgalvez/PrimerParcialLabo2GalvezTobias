namespace Vista
{
    partial class FormListaEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaEquipos));
            this.btn_agregarEquipo = new System.Windows.Forms.Button();
            this.lbl_listadoEquipos = new System.Windows.Forms.Label();
            this.dgv_listadoEquipos = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_exportarJson = new System.Windows.Forms.Button();
            this.btn_exportarCsv = new System.Windows.Forms.Button();
            this.lbl_msjError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarEquipo
            // 
            this.btn_agregarEquipo.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarEquipo.Location = new System.Drawing.Point(131, 14);
            this.btn_agregarEquipo.Name = "btn_agregarEquipo";
            this.btn_agregarEquipo.Size = new System.Drawing.Size(217, 31);
            this.btn_agregarEquipo.TabIndex = 5;
            this.btn_agregarEquipo.Text = "Agregar equipo";
            this.btn_agregarEquipo.UseVisualStyleBackColor = true;
            this.btn_agregarEquipo.Click += new System.EventHandler(this.btn_agregarEquipo_Click);
            // 
            // lbl_listadoEquipos
            // 
            this.lbl_listadoEquipos.AutoSize = true;
            this.lbl_listadoEquipos.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listadoEquipos.Location = new System.Drawing.Point(12, 25);
            this.lbl_listadoEquipos.Name = "lbl_listadoEquipos";
            this.lbl_listadoEquipos.Size = new System.Drawing.Size(111, 15);
            this.lbl_listadoEquipos.TabIndex = 4;
            this.lbl_listadoEquipos.Text = "Lista Equipos";
            // 
            // dgv_listadoEquipos
            // 
            this.dgv_listadoEquipos.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_listadoEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoEquipos.Location = new System.Drawing.Point(7, 52);
            this.dgv_listadoEquipos.Name = "dgv_listadoEquipos";
            this.dgv_listadoEquipos.RowTemplate.Height = 25;
            this.dgv_listadoEquipos.Size = new System.Drawing.Size(772, 245);
            this.dgv_listadoEquipos.TabIndex = 3;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(662, 330);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(91, 23);
            this.btn_exportar.TabIndex = 14;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Visible = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(442, 330);
            this.txt_path.Name = "txt_path";
            this.txt_path.PlaceholderText = "Ingrese path";
            this.txt_path.Size = new System.Drawing.Size(182, 22);
            this.txt_path.TabIndex = 13;
            this.txt_path.Visible = false;
            // 
            // btn_exportarJson
            // 
            this.btn_exportarJson.Location = new System.Drawing.Point(216, 329);
            this.btn_exportarJson.Name = "btn_exportarJson";
            this.btn_exportarJson.Size = new System.Drawing.Size(183, 23);
            this.btn_exportarJson.TabIndex = 12;
            this.btn_exportarJson.Text = "Exportar json";
            this.btn_exportarJson.UseVisualStyleBackColor = true;
            this.btn_exportarJson.Visible = false;
            this.btn_exportarJson.Click += new System.EventHandler(this.btn_exportarJson_Click);
            // 
            // btn_exportarCsv
            // 
            this.btn_exportarCsv.Location = new System.Drawing.Point(13, 329);
            this.btn_exportarCsv.Name = "btn_exportarCsv";
            this.btn_exportarCsv.Size = new System.Drawing.Size(184, 23);
            this.btn_exportarCsv.TabIndex = 11;
            this.btn_exportarCsv.Text = "Exportar csv";
            this.btn_exportarCsv.UseVisualStyleBackColor = true;
            this.btn_exportarCsv.Visible = false;
            this.btn_exportarCsv.Click += new System.EventHandler(this.btn_exportarCsv_Click);
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(13, 385);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(49, 14);
            this.lbl_msjError.TabIndex = 15;
            this.lbl_msjError.Text = "label1";
            this.lbl_msjError.Visible = false;
            // 
            // FormListaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_exportarJson);
            this.Controls.Add(this.btn_exportarCsv);
            this.Controls.Add(this.btn_agregarEquipo);
            this.Controls.Add(this.lbl_listadoEquipos);
            this.Controls.Add(this.dgv_listadoEquipos);
            this.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormListaEquipos";
            this.Load += new System.EventHandler(this.FormListaEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_agregarEquipo;
        private Label lbl_listadoEquipos;
        private DataGridView dgv_listadoEquipos;
        private Button btn_exportar;
        private TextBox txt_path;
        private Button btn_exportarJson;
        private Button btn_exportarCsv;
        private Label lbl_msjError;
    }
}
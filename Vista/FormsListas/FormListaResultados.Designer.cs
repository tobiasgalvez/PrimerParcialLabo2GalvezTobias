namespace Vista
{
    partial class FormListaResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaResultados));
            this.btn_agregarResultado = new System.Windows.Forms.Button();
            this.lbl_listadoResultados = new System.Windows.Forms.Label();
            this.dgv_listadoResultados = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_exportarJson = new System.Windows.Forms.Button();
            this.btn_exportarCsv = new System.Windows.Forms.Button();
            this.lbl_msjError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarResultado
            // 
            this.btn_agregarResultado.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarResultado.Location = new System.Drawing.Point(155, 22);
            this.btn_agregarResultado.Name = "btn_agregarResultado";
            this.btn_agregarResultado.Size = new System.Drawing.Size(248, 33);
            this.btn_agregarResultado.TabIndex = 8;
            this.btn_agregarResultado.Text = "Agregar Resultado";
            this.btn_agregarResultado.UseVisualStyleBackColor = true;
            this.btn_agregarResultado.Click += new System.EventHandler(this.btn_agregarResultado_Click);
            // 
            // lbl_listadoResultados
            // 
            this.lbl_listadoResultados.AutoSize = true;
            this.lbl_listadoResultados.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listadoResultados.Location = new System.Drawing.Point(19, 34);
            this.lbl_listadoResultados.Name = "lbl_listadoResultados";
            this.lbl_listadoResultados.Size = new System.Drawing.Size(135, 15);
            this.lbl_listadoResultados.TabIndex = 7;
            this.lbl_listadoResultados.Text = "Lista Resultados";
            // 
            // dgv_listadoResultados
            // 
            this.dgv_listadoResultados.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_listadoResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoResultados.Location = new System.Drawing.Point(19, 80);
            this.dgv_listadoResultados.Name = "dgv_listadoResultados";
            this.dgv_listadoResultados.RowTemplate.Height = 25;
            this.dgv_listadoResultados.Size = new System.Drawing.Size(789, 169);
            this.dgv_listadoResultados.TabIndex = 6;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(680, 275);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(91, 23);
            this.btn_exportar.TabIndex = 12;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Visible = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(460, 275);
            this.txt_path.Name = "txt_path";
            this.txt_path.PlaceholderText = "Ingrese path";
            this.txt_path.Size = new System.Drawing.Size(182, 23);
            this.txt_path.TabIndex = 11;
            this.txt_path.Visible = false;
            // 
            // btn_exportarJson
            // 
            this.btn_exportarJson.Location = new System.Drawing.Point(234, 274);
            this.btn_exportarJson.Name = "btn_exportarJson";
            this.btn_exportarJson.Size = new System.Drawing.Size(183, 23);
            this.btn_exportarJson.TabIndex = 10;
            this.btn_exportarJson.Text = "Exportar json";
            this.btn_exportarJson.UseVisualStyleBackColor = true;
            this.btn_exportarJson.Visible = false;
            this.btn_exportarJson.Click += new System.EventHandler(this.btn_exportarJson_Click);
            // 
            // btn_exportarCsv
            // 
            this.btn_exportarCsv.Location = new System.Drawing.Point(31, 274);
            this.btn_exportarCsv.Name = "btn_exportarCsv";
            this.btn_exportarCsv.Size = new System.Drawing.Size(184, 23);
            this.btn_exportarCsv.TabIndex = 9;
            this.btn_exportarCsv.Text = "Exportar csv";
            this.btn_exportarCsv.UseVisualStyleBackColor = true;
            this.btn_exportarCsv.Visible = false;
            this.btn_exportarCsv.Click += new System.EventHandler(this.btn_exportarCsv_Click);
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(16, 322);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(55, 15);
            this.lbl_msjError.TabIndex = 13;
            this.lbl_msjError.Text = "label1";
            this.lbl_msjError.Visible = false;
            // 
            // FormListaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(820, 351);
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_exportarJson);
            this.Controls.Add(this.btn_exportarCsv);
            this.Controls.Add(this.btn_agregarResultado);
            this.Controls.Add(this.lbl_listadoResultados);
            this.Controls.Add(this.dgv_listadoResultados);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormListaResultados";
            this.Load += new System.EventHandler(this.FormListaResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_agregarResultado;
        private Label lbl_listadoResultados;
        private DataGridView dgv_listadoResultados;
        private Button btn_exportar;
        private TextBox txt_path;
        private Button btn_exportarJson;
        private Button btn_exportarCsv;
        private Label lbl_msjError;
    }
}
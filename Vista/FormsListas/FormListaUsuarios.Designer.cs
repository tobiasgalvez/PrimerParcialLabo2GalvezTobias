namespace Vista
{
    partial class FormListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaUsuarios));
            this.btn_agregarUsuario = new System.Windows.Forms.Button();
            this.lbl_listado = new System.Windows.Forms.Label();
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_exportarJson = new System.Windows.Forms.Button();
            this.btn_exportarCsv = new System.Windows.Forms.Button();
            this.lbl_msjError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregarUsuario
            // 
            this.btn_agregarUsuario.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarUsuario.Location = new System.Drawing.Point(164, 22);
            this.btn_agregarUsuario.Name = "btn_agregarUsuario";
            this.btn_agregarUsuario.Size = new System.Drawing.Size(217, 31);
            this.btn_agregarUsuario.TabIndex = 5;
            this.btn_agregarUsuario.Text = "Agregar Usuario";
            this.btn_agregarUsuario.UseVisualStyleBackColor = true;
            this.btn_agregarUsuario.Click += new System.EventHandler(this.btn_agregarUsuario_Click);
            // 
            // lbl_listado
            // 
            this.lbl_listado.AutoSize = true;
            this.lbl_listado.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listado.Location = new System.Drawing.Point(22, 31);
            this.lbl_listado.Name = "lbl_listado";
            this.lbl_listado.Size = new System.Drawing.Size(119, 15);
            this.lbl_listado.TabIndex = 4;
            this.lbl_listado.Text = "Lista Usuarios";
            // 
            // dgv_listado
            // 
            this.dgv_listado.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Location = new System.Drawing.Point(12, 73);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.RowTemplate.Height = 25;
            this.dgv_listado.Size = new System.Drawing.Size(763, 215);
            this.dgv_listado.TabIndex = 3;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(667, 329);
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
            this.txt_path.Location = new System.Drawing.Point(447, 329);
            this.txt_path.Name = "txt_path";
            this.txt_path.PlaceholderText = "Ingrese path";
            this.txt_path.Size = new System.Drawing.Size(182, 22);
            this.txt_path.TabIndex = 9;
            this.txt_path.Visible = false;
            // 
            // btn_exportarJson
            // 
            this.btn_exportarJson.Location = new System.Drawing.Point(221, 328);
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
            this.btn_exportarCsv.Location = new System.Drawing.Point(18, 328);
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
            this.lbl_msjError.Location = new System.Drawing.Point(12, 388);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(49, 14);
            this.lbl_msjError.TabIndex = 11;
            this.lbl_msjError.Text = "label1";
            this.lbl_msjError.Visible = false;
            // 
            // FormListaUsuarios
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
            this.Controls.Add(this.btn_agregarUsuario);
            this.Controls.Add(this.lbl_listado);
            this.Controls.Add(this.dgv_listado);
            this.Font = new System.Drawing.Font("Unispace", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormListaUsuarios";
            this.Load += new System.EventHandler(this.FormListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_agregarUsuario;
        private Label lbl_listado;
        private DataGridView dgv_listado;
        private Button btn_exportar;
        private TextBox txt_path;
        private Button btn_exportarJson;
        private Button btn_exportarCsv;
        private Label lbl_msjError;
    }
}
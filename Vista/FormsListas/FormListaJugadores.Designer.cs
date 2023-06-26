namespace Vista
{
    partial class FormListaJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaJugadores));
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.lbl_listado = new System.Windows.Forms.Label();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.btn_exportarCsv = new System.Windows.Forms.Button();
            this.btn_exportarJson = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.lbl_msjError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listado
            // 
            this.dgv_listado.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Location = new System.Drawing.Point(7, 49);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.RowTemplate.Height = 25;
            this.dgv_listado.Size = new System.Drawing.Size(781, 238);
            this.dgv_listado.TabIndex = 0;
            // 
            // lbl_listado
            // 
            this.lbl_listado.AutoSize = true;
            this.lbl_listado.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_listado.Location = new System.Drawing.Point(12, 22);
            this.lbl_listado.Name = "lbl_listado";
            this.lbl_listado.Size = new System.Drawing.Size(127, 15);
            this.lbl_listado.TabIndex = 1;
            this.lbl_listado.Text = "Lista Jugadores";
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.Location = new System.Drawing.Point(161, 13);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(217, 31);
            this.btn_agregarProducto.TabIndex = 2;
            this.btn_agregarProducto.Text = "Agregar jugador";
            this.btn_agregarProducto.UseVisualStyleBackColor = true;
            this.btn_agregarProducto.Click += new System.EventHandler(this.Btn_agregarProducto_Click);
            // 
            // btn_exportarCsv
            // 
            this.btn_exportarCsv.Location = new System.Drawing.Point(7, 314);
            this.btn_exportarCsv.Name = "btn_exportarCsv";
            this.btn_exportarCsv.Size = new System.Drawing.Size(184, 23);
            this.btn_exportarCsv.TabIndex = 3;
            this.btn_exportarCsv.Text = "Exportar csv";
            this.btn_exportarCsv.UseVisualStyleBackColor = true;
            this.btn_exportarCsv.Visible = false;
            this.btn_exportarCsv.Click += new System.EventHandler(this.btn_exportarCsv_Click);
            // 
            // btn_exportarJson
            // 
            this.btn_exportarJson.Location = new System.Drawing.Point(210, 314);
            this.btn_exportarJson.Name = "btn_exportarJson";
            this.btn_exportarJson.Size = new System.Drawing.Size(183, 23);
            this.btn_exportarJson.TabIndex = 4;
            this.btn_exportarJson.Text = "Exportar json";
            this.btn_exportarJson.UseVisualStyleBackColor = true;
            this.btn_exportarJson.Visible = false;
            this.btn_exportarJson.Click += new System.EventHandler(this.btn_exportarJson_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(436, 315);
            this.txt_path.Name = "txt_path";
            this.txt_path.PlaceholderText = "Ingrese path";
            this.txt_path.Size = new System.Drawing.Size(182, 22);
            this.txt_path.TabIndex = 5;
            this.txt_path.Visible = false;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(656, 315);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(91, 23);
            this.btn_exportar.TabIndex = 6;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Visible = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(18, 385);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(49, 14);
            this.lbl_msjError.TabIndex = 7;
            this.lbl_msjError.Text = "label1";
            this.lbl_msjError.Visible = false;
            // 
            // FormListaJugadores
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
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.lbl_listado);
            this.Controls.Add(this.dgv_listado);
            this.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormListado";
            this.Load += new System.EventHandler(this.FormListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_listado;
        private Label lbl_listado;
        private Button btn_agregarProducto;
        private Button btn_exportarCsv;
        private Button btn_exportarJson;
        private TextBox txt_path;
        private Button btn_exportar;
        private Label lbl_msjError;
    }
}
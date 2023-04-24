namespace Vista
{
    partial class FormListado
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
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.lbl_listado = new System.Windows.Forms.Label();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listado
            // 
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Location = new System.Drawing.Point(7, 53);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.RowTemplate.Height = 25;
            this.dgv_listado.Size = new System.Drawing.Size(769, 321);
            this.dgv_listado.TabIndex = 0;
            // 
            // lbl_listado
            // 
            this.lbl_listado.AutoSize = true;
            this.lbl_listado.Location = new System.Drawing.Point(12, 24);
            this.lbl_listado.Name = "lbl_listado";
            this.lbl_listado.Size = new System.Drawing.Size(31, 15);
            this.lbl_listado.TabIndex = 1;
            this.lbl_listado.Text = "Lista";
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.Location = new System.Drawing.Point(131, 22);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(217, 23);
            this.btn_agregarProducto.TabIndex = 2;
            this.btn_agregarProducto.Text = "Agregar jugador";
            this.btn_agregarProducto.UseVisualStyleBackColor = true;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.lbl_listado);
            this.Controls.Add(this.dgv_listado);
            this.Name = "FormListado";
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
    }
}
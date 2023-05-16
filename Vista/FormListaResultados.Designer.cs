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
            this.btn_agregarResultado = new System.Windows.Forms.Button();
            this.lbl_listadoResultados = new System.Windows.Forms.Label();
            this.dgv_listadoEquipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoEquipos)).BeginInit();
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
            // dgv_listadoEquipos
            // 
            this.dgv_listadoEquipos.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_listadoEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoEquipos.Location = new System.Drawing.Point(14, 63);
            this.dgv_listadoEquipos.Name = "dgv_listadoEquipos";
            this.dgv_listadoEquipos.RowTemplate.Height = 25;
            this.dgv_listadoEquipos.Size = new System.Drawing.Size(765, 321);
            this.dgv_listadoEquipos.TabIndex = 6;
            // 
            // FormListaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.btn_agregarResultado);
            this.Controls.Add(this.lbl_listadoResultados);
            this.Controls.Add(this.dgv_listadoEquipos);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "FormListaResultados";
            this.Text = "FormListaResultados";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_agregarResultado;
        private Label lbl_listadoResultados;
        private DataGridView dgv_listadoEquipos;
    }
}
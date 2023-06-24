namespace Vista
{
    partial class FormAltaEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaEquipo));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_altaNombre = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_msjError = new System.Windows.Forms.Label();
            this.lbl_torneoAJugar = new System.Windows.Forms.Label();
            this.cbo_torneos = new System.Windows.Forms.ComboBox();
            this.lbl_equipoModificar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(94, 117);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(63, 15);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_altaNombre
            // 
            this.txt_altaNombre.Location = new System.Drawing.Point(94, 135);
            this.txt_altaNombre.Name = "txt_altaNombre";
            this.txt_altaNombre.Size = new System.Drawing.Size(335, 22);
            this.txt_altaNombre.TabIndex = 5;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(286, 233);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(171, 35);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(50, 233);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(171, 35);
            this.btn_confirmar.TabIndex = 16;
            this.btn_confirmar.Text = "Agregar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(12, 326);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(0, 19);
            this.lbl_msjError.TabIndex = 18;
            // 
            // lbl_torneoAJugar
            // 
            this.lbl_torneoAJugar.AutoSize = true;
            this.lbl_torneoAJugar.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_torneoAJugar.Location = new System.Drawing.Point(94, 171);
            this.lbl_torneoAJugar.Name = "lbl_torneoAJugar";
            this.lbl_torneoAJugar.Size = new System.Drawing.Size(127, 15);
            this.lbl_torneoAJugar.TabIndex = 20;
            this.lbl_torneoAJugar.Text = "Torneo a jugar:";
            // 
            // cbo_torneos
            // 
            this.cbo_torneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_torneos.FormattingEnabled = true;
            this.cbo_torneos.Location = new System.Drawing.Point(94, 189);
            this.cbo_torneos.Name = "cbo_torneos";
            this.cbo_torneos.Size = new System.Drawing.Size(335, 22);
            this.cbo_torneos.TabIndex = 21;
            // 
            // lbl_equipoModificar
            // 
            this.lbl_equipoModificar.AutoSize = true;
            this.lbl_equipoModificar.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_equipoModificar.Location = new System.Drawing.Point(94, 28);
            this.lbl_equipoModificar.Name = "lbl_equipoModificar";
            this.lbl_equipoModificar.Size = new System.Drawing.Size(159, 15);
            this.lbl_equipoModificar.TabIndex = 22;
            this.lbl_equipoModificar.Text = "Equipo a modificar:";
            this.lbl_equipoModificar.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 22);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // FormAltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(509, 354);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_equipoModificar);
            this.Controls.Add(this.cbo_torneos);
            this.Controls.Add(this.lbl_torneoAJugar);
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_altaNombre);
            this.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAltaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAltaEquipo";
            this.Load += new System.EventHandler(this.FormAltaEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nombre;
        private TextBox txt_altaNombre;
        private Button btn_cancelar;
        private Button btn_confirmar;
        private Label lbl_msjError;
        private Label lbl_torneoAJugar;
        private ComboBox cbo_torneos;
        private Label lbl_equipoModificar;
        private ComboBox comboBox1;
    }
}
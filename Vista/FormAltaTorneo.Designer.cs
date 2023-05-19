namespace Vista
{
    partial class FormAltaTorneo
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_altaNombreTorneo = new System.Windows.Forms.TextBox();
            this.lbl_msjError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(241, 108);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(171, 35);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(64, 108);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(171, 35);
            this.btn_confirmar.TabIndex = 20;
            this.btn_confirmar.Text = "Agregar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(77, 43);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(279, 15);
            this.lbl_nombre.TabIndex = 19;
            this.lbl_nombre.Text = "Ingrese nombre del torneo a crear:";
            // 
            // txt_altaNombreTorneo
            // 
            this.txt_altaNombreTorneo.Location = new System.Drawing.Point(77, 61);
            this.txt_altaNombreTorneo.Name = "txt_altaNombreTorneo";
            this.txt_altaNombreTorneo.Size = new System.Drawing.Size(335, 23);
            this.txt_altaNombreTorneo.TabIndex = 18;
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(52, 163);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(0, 15);
            this.lbl_msjError.TabIndex = 22;
            // 
            // FormAltaTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(494, 194);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_altaNombreTorneo);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormAltaTorneo";
            this.Text = "FormAltaTorneo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cancelar;
        private Button btn_confirmar;
        private Label lbl_nombre;
        private TextBox txt_altaNombreTorneo;
        private Label lbl_msjError;
    }
}
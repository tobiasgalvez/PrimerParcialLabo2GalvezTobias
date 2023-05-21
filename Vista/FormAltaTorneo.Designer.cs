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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaTorneo));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_altaNombreTorneo = new System.Windows.Forms.TextBox();
            this.lbl_msjError = new System.Windows.Forms.Label();
            this.lbl_torneoAModificar = new System.Windows.Forms.Label();
            this.cbo_torneosModificar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(241, 192);
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
            this.btn_confirmar.Location = new System.Drawing.Point(64, 192);
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
            this.lbl_nombre.Location = new System.Drawing.Point(106, 110);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(279, 15);
            this.lbl_nombre.TabIndex = 19;
            this.lbl_nombre.Text = "Ingrese nombre del torneo a crear:";
            // 
            // txt_altaNombreTorneo
            // 
            this.txt_altaNombreTorneo.Location = new System.Drawing.Point(77, 128);
            this.txt_altaNombreTorneo.Name = "txt_altaNombreTorneo";
            this.txt_altaNombreTorneo.Size = new System.Drawing.Size(335, 23);
            this.txt_altaNombreTorneo.TabIndex = 18;
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(21, 272);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(0, 15);
            this.lbl_msjError.TabIndex = 22;
            // 
            // lbl_torneoAModificar
            // 
            this.lbl_torneoAModificar.AutoSize = true;
            this.lbl_torneoAModificar.Location = new System.Drawing.Point(125, 26);
            this.lbl_torneoAModificar.Name = "lbl_torneoAModificar";
            this.lbl_torneoAModificar.Size = new System.Drawing.Size(239, 15);
            this.lbl_torneoAModificar.TabIndex = 23;
            this.lbl_torneoAModificar.Text = "Nombre de torneo a modificar:";
            this.lbl_torneoAModificar.Visible = false;
            // 
            // cbo_torneosModificar
            // 
            this.cbo_torneosModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_torneosModificar.FormattingEnabled = true;
            this.cbo_torneosModificar.Location = new System.Drawing.Point(129, 58);
            this.cbo_torneosModificar.Name = "cbo_torneosModificar";
            this.cbo_torneosModificar.Size = new System.Drawing.Size(235, 23);
            this.cbo_torneosModificar.TabIndex = 24;
            this.cbo_torneosModificar.Visible = false;
            this.cbo_torneosModificar.SelectionChangeCommitted += new System.EventHandler(this.cbo_torneosModificar_SelectionChangeCommitted);
            // 
            // FormAltaTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(504, 306);
            this.ControlBox = false;
            this.Controls.Add(this.cbo_torneosModificar);
            this.Controls.Add(this.lbl_torneoAModificar);
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_altaNombreTorneo);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAltaTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAltaTorneo";
            this.Load += new System.EventHandler(this.FormAltaTorneo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cancelar;
        private Button btn_confirmar;
        private Label lbl_nombre;
        private TextBox txt_altaNombreTorneo;
        private Label lbl_msjError;
        private Label lbl_torneoAModificar;
        private ComboBox cbo_torneosModificar;
    }
}
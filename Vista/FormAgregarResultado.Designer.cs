namespace Vista
{
    partial class FormAgregarResultado
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
            this.lbl_equipo1 = new System.Windows.Forms.Label();
            this.lbl_equipo2 = new System.Windows.Forms.Label();
            this.cbo_equipo1 = new System.Windows.Forms.ComboBox();
            this.cbo_equipo2 = new System.Windows.Forms.ComboBox();
            this.btn_generarResultado = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cbo_torneo = new System.Windows.Forms.ComboBox();
            this.lbl_torneo = new System.Windows.Forms.Label();
            this.lbl_mensajeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_equipo1
            // 
            this.lbl_equipo1.AutoSize = true;
            this.lbl_equipo1.Location = new System.Drawing.Point(177, 116);
            this.lbl_equipo1.Name = "lbl_equipo1";
            this.lbl_equipo1.Size = new System.Drawing.Size(179, 19);
            this.lbl_equipo1.TabIndex = 0;
            this.lbl_equipo1.Text = "Equipo 1 (Local):";
            // 
            // lbl_equipo2
            // 
            this.lbl_equipo2.AutoSize = true;
            this.lbl_equipo2.Location = new System.Drawing.Point(463, 116);
            this.lbl_equipo2.Name = "lbl_equipo2";
            this.lbl_equipo2.Size = new System.Drawing.Size(219, 19);
            this.lbl_equipo2.TabIndex = 1;
            this.lbl_equipo2.Text = "Equipo 2 (Visitante):";
            // 
            // cbo_equipo1
            // 
            this.cbo_equipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_equipo1.FormattingEnabled = true;
            this.cbo_equipo1.Location = new System.Drawing.Point(177, 149);
            this.cbo_equipo1.Name = "cbo_equipo1";
            this.cbo_equipo1.Size = new System.Drawing.Size(223, 27);
            this.cbo_equipo1.TabIndex = 2;
            // 
            // cbo_equipo2
            // 
            this.cbo_equipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_equipo2.FormattingEnabled = true;
            this.cbo_equipo2.Location = new System.Drawing.Point(463, 149);
            this.cbo_equipo2.Name = "cbo_equipo2";
            this.cbo_equipo2.Size = new System.Drawing.Size(217, 27);
            this.cbo_equipo2.TabIndex = 3;
            // 
            // btn_generarResultado
            // 
            this.btn_generarResultado.Location = new System.Drawing.Point(226, 217);
            this.btn_generarResultado.Name = "btn_generarResultado";
            this.btn_generarResultado.Size = new System.Drawing.Size(187, 48);
            this.btn_generarResultado.TabIndex = 4;
            this.btn_generarResultado.Text = "Generar Resultado";
            this.btn_generarResultado.UseVisualStyleBackColor = true;
            this.btn_generarResultado.Click += new System.EventHandler(this.btn_generarResultado_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(463, 219);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(187, 46);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cbo_torneo
            // 
            this.cbo_torneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_torneo.FormattingEnabled = true;
            this.cbo_torneo.Location = new System.Drawing.Point(329, 50);
            this.cbo_torneo.Name = "cbo_torneo";
            this.cbo_torneo.Size = new System.Drawing.Size(223, 27);
            this.cbo_torneo.TabIndex = 7;
            this.cbo_torneo.SelectionChangeCommitted += new System.EventHandler(this.cbo_torneo_SelectionChangeCommitted);
            // 
            // lbl_torneo
            // 
            this.lbl_torneo.AutoSize = true;
            this.lbl_torneo.Location = new System.Drawing.Point(329, 16);
            this.lbl_torneo.Name = "lbl_torneo";
            this.lbl_torneo.Size = new System.Drawing.Size(79, 19);
            this.lbl_torneo.TabIndex = 6;
            this.lbl_torneo.Text = "Torneo:";
            // 
            // lbl_mensajeError
            // 
            this.lbl_mensajeError.AutoSize = true;
            this.lbl_mensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_mensajeError.Location = new System.Drawing.Point(12, 301);
            this.lbl_mensajeError.Name = "lbl_mensajeError";
            this.lbl_mensajeError.Size = new System.Drawing.Size(0, 19);
            this.lbl_mensajeError.TabIndex = 8;
            // 
            // FormAgregarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(881, 329);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_mensajeError);
            this.Controls.Add(this.cbo_torneo);
            this.Controls.Add(this.lbl_torneo);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_generarResultado);
            this.Controls.Add(this.cbo_equipo2);
            this.Controls.Add(this.cbo_equipo1);
            this.Controls.Add(this.lbl_equipo2);
            this.Controls.Add(this.lbl_equipo1);
            this.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAgregarResultado";
            this.Text = "FormAgregarResultado";
            this.Load += new System.EventHandler(this.FormAgregarResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_equipo1;
        private Label lbl_equipo2;
        private ComboBox cbo_equipo1;
        private ComboBox cbo_equipo2;
        private Button btn_generarResultado;
        private Button btn_cancel;
        private ComboBox cbo_torneo;
        private Label lbl_torneo;
        private Label lbl_mensajeError;
    }
}
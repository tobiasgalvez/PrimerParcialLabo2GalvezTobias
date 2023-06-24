namespace Vista
{
    partial class FormRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistros));
            this.lst_registros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_registros
            // 
            this.lst_registros.BackColor = System.Drawing.Color.Silver;
            this.lst_registros.FormattingEnabled = true;
            this.lst_registros.ItemHeight = 15;
            this.lst_registros.Location = new System.Drawing.Point(69, 36);
            this.lst_registros.Name = "lst_registros";
            this.lst_registros.Size = new System.Drawing.Size(753, 289);
            this.lst_registros.TabIndex = 0;
            // 
            // FormRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.lst_registros);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistros";
            this.Text = "FormRegistros";
            this.Load += new System.EventHandler(this.FormRegistros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lst_registros;
    }
}
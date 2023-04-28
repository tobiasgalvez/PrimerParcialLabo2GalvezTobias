namespace Vista
{
    partial class AltaProducto
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
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_posicion = new System.Windows.Forms.Label();
            this.cbo_posiciones = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.Location = new System.Drawing.Point(71, 327);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(150, 35);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Agregar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 23);
            this.textBox3.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(12, 19);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(63, 15);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 76);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(79, 15);
            this.lbl_cantidad.TabIndex = 5;
            this.lbl_cantidad.Text = "Apellido:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.Location = new System.Drawing.Point(12, 130);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(39, 15);
            this.lbl_precio.TabIndex = 6;
            this.lbl_precio.Text = "Dni:";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_equipo.Location = new System.Drawing.Point(12, 183);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(63, 15);
            this.lbl_equipo.TabIndex = 7;
            this.lbl_equipo.Text = "Equipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "El Rejunte",
            "Los mismos de siempre"});
            this.comboBox1.Location = new System.Drawing.Point(12, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_posicion.Location = new System.Drawing.Point(15, 244);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(79, 15);
            this.lbl_posicion.TabIndex = 9;
            this.lbl_posicion.Text = "Posición:";
            // 
            // cbo_posiciones
            // 
            this.cbo_posiciones.FormattingEnabled = true;
            this.cbo_posiciones.Location = new System.Drawing.Point(12, 262);
            this.cbo_posiciones.Name = "cbo_posiciones";
            this.cbo_posiciones.Size = new System.Drawing.Size(121, 23);
            this.cbo_posiciones.TabIndex = 10;
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.cbo_posiciones);
            this.Controls.Add(this.lbl_posicion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_equipo);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_confirmar);
            this.Name = "AltaProducto";
            this.Text = "AltaProducto";
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_confirmar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbl_nombre;
        private Label lbl_cantidad;
        private Label lbl_precio;
        private Label lbl_equipo;
        private ComboBox comboBox1;
        private Label lbl_posicion;
        private ComboBox cbo_posiciones;
    }
}
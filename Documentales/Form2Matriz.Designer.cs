namespace Documentales
{
    partial class Form2Matriz
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
            this.txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.txtBoxGenero = new System.Windows.Forms.TextBox();
            this.txtBoxAñoL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_ordenardesc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUD_Longitud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_aggLogitud = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Longitud)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTitulo
            // 
            this.txtBoxTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxTitulo.Location = new System.Drawing.Point(155, 86);
            this.txtBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtBoxTitulo.Name = "txtBoxTitulo";
            this.txtBoxTitulo.Size = new System.Drawing.Size(119, 20);
            this.txtBoxTitulo.TabIndex = 0;
            this.txtBoxTitulo.TextChanged += new System.EventHandler(this.txtBoxTitulo_TextChanged);
            // 
            // txtBoxGenero
            // 
            this.txtBoxGenero.Location = new System.Drawing.Point(155, 135);
            this.txtBoxGenero.Name = "txtBoxGenero";
            this.txtBoxGenero.Size = new System.Drawing.Size(119, 20);
            this.txtBoxGenero.TabIndex = 1;
            this.txtBoxGenero.TextChanged += new System.EventHandler(this.txtBoxGenero_TextChanged);
            // 
            // txtBoxAñoL
            // 
            this.txtBoxAñoL.Location = new System.Drawing.Point(155, 178);
            this.txtBoxAñoL.Name = "txtBoxAñoL";
            this.txtBoxAñoL.Size = new System.Drawing.Size(119, 20);
            this.txtBoxAñoL.TabIndex = 2;
            this.txtBoxAñoL.TextChanged += new System.EventHandler(this.txtBoxAñoL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(98, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(89, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(31, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año de lanzamiento";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(155, 215);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(119, 22);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_ordenardesc
            // 
            this.btn_ordenardesc.Location = new System.Drawing.Point(588, 244);
            this.btn_ordenardesc.Name = "btn_ordenardesc";
            this.btn_ordenardesc.Size = new System.Drawing.Size(122, 22);
            this.btn_ordenardesc.TabIndex = 7;
            this.btn_ordenardesc.Text = "Ordenar desc";
            this.btn_ordenardesc.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 20);
            this.textBox1.TabIndex = 8;
            // 
            // numericUD_Longitud
            // 
            this.numericUD_Longitud.Location = new System.Drawing.Point(159, 39);
            this.numericUD_Longitud.Name = "numericUD_Longitud";
            this.numericUD_Longitud.Size = new System.Drawing.Size(115, 20);
            this.numericUD_Longitud.TabIndex = 9;
            this.numericUD_Longitud.ValueChanged += new System.EventHandler(this.numericUD_Longitud_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(83, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Longitud";
            // 
            // btn_aggLogitud
            // 
            this.btn_aggLogitud.Location = new System.Drawing.Point(307, 34);
            this.btn_aggLogitud.Name = "btn_aggLogitud";
            this.btn_aggLogitud.Size = new System.Drawing.Size(119, 23);
            this.btn_aggLogitud.TabIndex = 11;
            this.btn_aggLogitud.Text = "Agg Logitud";
            this.btn_aggLogitud.UseVisualStyleBackColor = true;
            this.btn_aggLogitud.Click += new System.EventHandler(this.btn_aggLogitud_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(364, 243);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(119, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_aggLogitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUD_Longitud);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ordenardesc);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAñoL);
            this.Controls.Add(this.txtBoxGenero);
            this.Controls.Add(this.txtBoxTitulo);
            this.Name = "Form2Matriz";
            this.Text = "Form2Matriz";
            this.Load += new System.EventHandler(this.Form2Matriz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Longitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTitulo;
        private System.Windows.Forms.TextBox txtBoxGenero;
        private System.Windows.Forms.TextBox txtBoxAñoL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_ordenardesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUD_Longitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_aggLogitud;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}
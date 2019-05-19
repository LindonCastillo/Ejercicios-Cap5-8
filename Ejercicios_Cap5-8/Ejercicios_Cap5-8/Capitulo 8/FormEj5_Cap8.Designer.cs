namespace Ejercicios_Cap5_8.Capitulo_8
{
    partial class FormEj5_Cap8
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
            this.MostrarOrden_button = new System.Windows.Forms.Button();
            this.Cadena1_textBox = new System.Windows.Forms.TextBox();
            this.Cadena2_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdenCadena2_textBox = new System.Windows.Forms.TextBox();
            this.OrdenCadena1_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MostrarOrden_button
            // 
            this.MostrarOrden_button.Location = new System.Drawing.Point(107, 130);
            this.MostrarOrden_button.Name = "MostrarOrden_button";
            this.MostrarOrden_button.Size = new System.Drawing.Size(137, 23);
            this.MostrarOrden_button.TabIndex = 0;
            this.MostrarOrden_button.Text = "Mostrar En Orden";
            this.MostrarOrden_button.UseVisualStyleBackColor = true;
            this.MostrarOrden_button.Click += new System.EventHandler(this.MostrarOrden_button_Click);
            // 
            // Cadena1_textBox
            // 
            this.Cadena1_textBox.Location = new System.Drawing.Point(83, 31);
            this.Cadena1_textBox.Name = "Cadena1_textBox";
            this.Cadena1_textBox.Size = new System.Drawing.Size(192, 20);
            this.Cadena1_textBox.TabIndex = 1;
            // 
            // Cadena2_textBox
            // 
            this.Cadena2_textBox.Location = new System.Drawing.Point(83, 78);
            this.Cadena2_textBox.Name = "Cadena2_textBox";
            this.Cadena2_textBox.Size = new System.Drawing.Size(192, 20);
            this.Cadena2_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadena 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadena 2";
            // 
            // OrdenCadena2_textBox
            // 
            this.OrdenCadena2_textBox.Location = new System.Drawing.Point(83, 226);
            this.OrdenCadena2_textBox.Name = "OrdenCadena2_textBox";
            this.OrdenCadena2_textBox.Size = new System.Drawing.Size(192, 20);
            this.OrdenCadena2_textBox.TabIndex = 6;
            // 
            // OrdenCadena1_textBox
            // 
            this.OrdenCadena1_textBox.Location = new System.Drawing.Point(83, 179);
            this.OrdenCadena1_textBox.Name = "OrdenCadena1_textBox";
            this.OrdenCadena1_textBox.Size = new System.Drawing.Size(192, 20);
            this.OrdenCadena1_textBox.TabIndex = 5;
            // 
            // FormEj5_Cap8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 281);
            this.Controls.Add(this.OrdenCadena2_textBox);
            this.Controls.Add(this.OrdenCadena1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cadena2_textBox);
            this.Controls.Add(this.Cadena1_textBox);
            this.Controls.Add(this.MostrarOrden_button);
            this.Name = "FormEj5_Cap8";
            this.Text = "Ejercicio 5 - Capitulo 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarOrden_button;
        private System.Windows.Forms.TextBox Cadena1_textBox;
        private System.Windows.Forms.TextBox Cadena2_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrdenCadena2_textBox;
        private System.Windows.Forms.TextBox OrdenCadena1_textBox;
    }
}
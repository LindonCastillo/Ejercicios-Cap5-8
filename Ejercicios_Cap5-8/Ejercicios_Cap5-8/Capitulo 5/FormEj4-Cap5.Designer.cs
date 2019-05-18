namespace Ejercicios_Cap5_8.Capitulo_5
{
    partial class FormEj4_Cap5
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
            this.Calcular_button = new System.Windows.Forms.Button();
            this.Numero_textBox = new System.Windows.Forms.TextBox();
            this.Resultado_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular_button
            // 
            this.Calcular_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular_button.Location = new System.Drawing.Point(88, 124);
            this.Calcular_button.Name = "Calcular_button";
            this.Calcular_button.Size = new System.Drawing.Size(99, 30);
            this.Calcular_button.TabIndex = 0;
            this.Calcular_button.Text = "Calcular";
            this.Calcular_button.UseVisualStyleBackColor = true;
            this.Calcular_button.Click += new System.EventHandler(this.Calcular_button_Click);
            // 
            // Numero_textBox
            // 
            this.Numero_textBox.Location = new System.Drawing.Point(118, 30);
            this.Numero_textBox.Name = "Numero_textBox";
            this.Numero_textBox.Size = new System.Drawing.Size(131, 20);
            this.Numero_textBox.TabIndex = 1;
            // 
            // Resultado_textBox
            // 
            this.Resultado_textBox.Location = new System.Drawing.Point(118, 73);
            this.Resultado_textBox.Name = "Resultado_textBox";
            this.Resultado_textBox.Size = new System.Drawing.Size(131, 20);
            this.Resultado_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factorial";
            // 
            // FormEj4_Cap5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado_textBox);
            this.Controls.Add(this.Numero_textBox);
            this.Controls.Add(this.Calcular_button);
            this.Name = "FormEj4_Cap5";
            this.Text = "Ejercicio 4 - Capitulo 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular_button;
        private System.Windows.Forms.TextBox Numero_textBox;
        private System.Windows.Forms.TextBox Resultado_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
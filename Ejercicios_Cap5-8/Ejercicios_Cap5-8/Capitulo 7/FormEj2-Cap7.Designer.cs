namespace Ejercicios_Cap5_8.Capitulo_7
{
    partial class FormEj2_Cap7
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
            this.label1 = new System.Windows.Forms.Label();
            this.Palabra_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Definicion_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Agregar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra";
            // 
            // Palabra_textBox
            // 
            this.Palabra_textBox.Location = new System.Drawing.Point(111, 18);
            this.Palabra_textBox.Name = "Palabra_textBox";
            this.Palabra_textBox.Size = new System.Drawing.Size(245, 20);
            this.Palabra_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Definición";
            // 
            // Definicion_richTextBox
            // 
            this.Definicion_richTextBox.Location = new System.Drawing.Point(15, 98);
            this.Definicion_richTextBox.Name = "Definicion_richTextBox";
            this.Definicion_richTextBox.Size = new System.Drawing.Size(341, 163);
            this.Definicion_richTextBox.TabIndex = 3;
            this.Definicion_richTextBox.Text = "";
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_button.Image = global::Ejercicios_Cap5_8.Properties.Resources.delete_icon;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar_button.Location = new System.Drawing.Point(362, 180);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(97, 65);
            this.Eliminar_button.TabIndex = 7;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Buscar_button
            // 
            this.Buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_button.Image = global::Ejercicios_Cap5_8.Properties.Resources.icono;
            this.Buscar_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar_button.Location = new System.Drawing.Point(362, 23);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(97, 65);
            this.Buscar_button.TabIndex = 6;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Agregar_button
            // 
            this.Agregar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_button.Image = global::Ejercicios_Cap5_8.Properties.Resources.Save_black_512_icon;
            this.Agregar_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregar_button.Location = new System.Drawing.Point(362, 98);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(97, 65);
            this.Agregar_button.TabIndex = 5;
            this.Agregar_button.Text = "Agregar";
            this.Agregar_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // FormEj2_Cap7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 273);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Agregar_button);
            this.Controls.Add(this.Definicion_richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Palabra_textBox);
            this.Controls.Add(this.label1);
            this.Name = "FormEj2_Cap7";
            this.Text = "Ejercicio 2 - Capitulo 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Palabra_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Definicion_richTextBox;
        private System.Windows.Forms.Button Agregar_button;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Button Eliminar_button;
    }
}
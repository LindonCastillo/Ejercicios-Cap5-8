namespace Ejercicios_Cap5_8.Capitulo_7
{
    partial class FormEj5_Cap7
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
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Borrar_button = new System.Windows.Forms.Button();
            this.Telefono_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Limpiar_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar_button
            // 
            this.Guardar_button.Location = new System.Drawing.Point(342, 76);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(75, 23);
            this.Guardar_button.TabIndex = 0;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Buscar_button
            // 
            this.Buscar_button.Location = new System.Drawing.Point(342, 105);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(75, 23);
            this.Buscar_button.TabIndex = 1;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(117, 95);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(219, 20);
            this.Nombre_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefono";
            // 
            // Borrar_button
            // 
            this.Borrar_button.Location = new System.Drawing.Point(342, 163);
            this.Borrar_button.Name = "Borrar_button";
            this.Borrar_button.Size = new System.Drawing.Size(75, 23);
            this.Borrar_button.TabIndex = 6;
            this.Borrar_button.Text = "Borrar";
            this.Borrar_button.UseVisualStyleBackColor = true;
            this.Borrar_button.Click += new System.EventHandler(this.Borrar_button_Click);
            // 
            // Telefono_maskedTextBox
            // 
            this.Telefono_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_maskedTextBox.Location = new System.Drawing.Point(117, 143);
            this.Telefono_maskedTextBox.Mask = "999-999-9999";
            this.Telefono_maskedTextBox.Name = "Telefono_maskedTextBox";
            this.Telefono_maskedTextBox.Size = new System.Drawing.Size(219, 22);
            this.Telefono_maskedTextBox.TabIndex = 7;
            // 
            // Limpiar_button
            // 
            this.Limpiar_button.Location = new System.Drawing.Point(342, 134);
            this.Limpiar_button.Name = "Limpiar_button";
            this.Limpiar_button.Size = new System.Drawing.Size(75, 23);
            this.Limpiar_button.TabIndex = 8;
            this.Limpiar_button.Text = "Limpiar";
            this.Limpiar_button.UseVisualStyleBackColor = true;
            this.Limpiar_button.Click += new System.EventHandler(this.Limpiar_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mi Agenda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicios_Cap5_8.Properties.Resources.User_icon;
            this.pictureBox1.Location = new System.Drawing.Point(72, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormEj5_Cap7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Limpiar_button);
            this.Controls.Add(this.Telefono_maskedTextBox);
            this.Controls.Add(this.Borrar_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Guardar_button);
            this.Name = "FormEj5_Cap7";
            this.Text = "Ejercicio 5 - Capitulo 7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Borrar_button;
        private System.Windows.Forms.MaskedTextBox Telefono_maskedTextBox;
        private System.Windows.Forms.Button Limpiar_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
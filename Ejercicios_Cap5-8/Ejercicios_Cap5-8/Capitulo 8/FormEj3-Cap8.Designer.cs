namespace Ejercicios_Cap5_8.Capitulo_8
{
    partial class FormEj3_Cap8
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
            this.components = new System.ComponentModel.Container();
            this.Hora_label = new System.Windows.Forms.Label();
            this.Fecha_label = new System.Windows.Forms.Label();
            this.HoraFehca_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Hora_label
            // 
            this.Hora_label.AutoSize = true;
            this.Hora_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_label.ForeColor = System.Drawing.Color.Lime;
            this.Hora_label.Location = new System.Drawing.Point(27, 56);
            this.Hora_label.Name = "Hora_label";
            this.Hora_label.Size = new System.Drawing.Size(212, 91);
            this.Hora_label.TabIndex = 0;
            this.Hora_label.Text = "Hora";
            // 
            // Fecha_label
            // 
            this.Fecha_label.AutoSize = true;
            this.Fecha_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Fecha_label.Location = new System.Drawing.Point(61, 147);
            this.Fecha_label.Name = "Fecha_label";
            this.Fecha_label.Size = new System.Drawing.Size(131, 46);
            this.Fecha_label.TabIndex = 1;
            this.Fecha_label.Text = "Fecha";
            // 
            // HoraFehca_timer
            // 
            this.HoraFehca_timer.Enabled = true;
            this.HoraFehca_timer.Tick += new System.EventHandler(this.HoraFehca_timer_Tick);
            // 
            // FormEj3_Cap8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 233);
            this.Controls.Add(this.Fecha_label);
            this.Controls.Add(this.Hora_label);
            this.Name = "FormEj3_Cap8";
            this.Text = "Ejercicio 3 - Capitulo 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hora_label;
        private System.Windows.Forms.Label Fecha_label;
        private System.Windows.Forms.Timer HoraFehca_timer;
    }
}
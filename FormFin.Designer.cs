namespace Juego
{
    partial class FormFin
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
            System.Windows.Forms.Label labelPuntajeText;
            this.LabelPuntajeNum = new System.Windows.Forms.Label();
            this.LabelNivelNum = new System.Windows.Forms.Label();
            this.LabelNivelText = new System.Windows.Forms.Label();
            this.LabelGracias = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            labelPuntajeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPuntajeText
            // 
            labelPuntajeText.AutoSize = true;
            labelPuntajeText.BackColor = System.Drawing.Color.Cyan;
            labelPuntajeText.Location = new System.Drawing.Point(26, 31);
            labelPuntajeText.Name = "labelPuntajeText";
            labelPuntajeText.Size = new System.Drawing.Size(46, 13);
            labelPuntajeText.TabIndex = 0;
            labelPuntajeText.Text = "Puntaje:";
            // 
            // LabelPuntajeNum
            // 
            this.LabelPuntajeNum.AutoSize = true;
            this.LabelPuntajeNum.BackColor = System.Drawing.Color.Moccasin;
            this.LabelPuntajeNum.Location = new System.Drawing.Point(78, 31);
            this.LabelPuntajeNum.Name = "LabelPuntajeNum";
            this.LabelPuntajeNum.Size = new System.Drawing.Size(13, 13);
            this.LabelPuntajeNum.TabIndex = 1;
            this.LabelPuntajeNum.Text = "0";
            // 
            // LabelNivelNum
            // 
            this.LabelNivelNum.AutoSize = true;
            this.LabelNivelNum.BackColor = System.Drawing.Color.Moccasin;
            this.LabelNivelNum.Location = new System.Drawing.Point(78, 54);
            this.LabelNivelNum.Name = "LabelNivelNum";
            this.LabelNivelNum.Size = new System.Drawing.Size(13, 13);
            this.LabelNivelNum.TabIndex = 3;
            this.LabelNivelNum.Text = "0";
            // 
            // LabelNivelText
            // 
            this.LabelNivelText.AutoSize = true;
            this.LabelNivelText.BackColor = System.Drawing.Color.Cyan;
            this.LabelNivelText.Location = new System.Drawing.Point(26, 54);
            this.LabelNivelText.Name = "LabelNivelText";
            this.LabelNivelText.Size = new System.Drawing.Size(34, 13);
            this.LabelNivelText.TabIndex = 2;
            this.LabelNivelText.Text = "Nivel:";
            // 
            // LabelGracias
            // 
            this.LabelGracias.AutoSize = true;
            this.LabelGracias.BackColor = System.Drawing.Color.LawnGreen;
            this.LabelGracias.Location = new System.Drawing.Point(48, 77);
            this.LabelGracias.Name = "LabelGracias";
            this.LabelGracias.Size = new System.Drawing.Size(119, 13);
            this.LabelGracias.TabIndex = 4;
            this.LabelGracias.Text = ":) Gracias por participar!";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.BackColor = System.Drawing.Color.Lime;
            this.LabelNombre.Location = new System.Drawing.Point(26, 9);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(45, 13);
            this.LabelNombre.TabIndex = 5;
            this.LabelNombre.Text = "Jugador";
            // 
            // FormFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(207, 112);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.LabelGracias);
            this.Controls.Add(this.LabelNivelNum);
            this.Controls.Add(this.LabelNivelText);
            this.Controls.Add(this.LabelPuntajeNum);
            this.Controls.Add(labelPuntajeText);
            this.Name = "FormFin";
            this.Text = "Fin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelPuntajeNum;
        private System.Windows.Forms.Label LabelNivelNum;
        private System.Windows.Forms.Label LabelNivelText;
        private System.Windows.Forms.Label LabelGracias;
        private System.Windows.Forms.Label LabelNombre;
    }
}
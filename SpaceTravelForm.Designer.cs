namespace Juego
{
    partial class SpaceTravelForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BotonComenzar = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.LabelPuntaje = new System.Windows.Forms.Label();
            this.LabelNivel = new System.Windows.Forms.Label();
            this.LabelPuntajeNombre = new System.Windows.Forms.Label();
            this.Espacio = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabelNivelNombre = new System.Windows.Forms.Label();
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.LabelAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Espacio)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonComenzar
            // 
            this.BotonComenzar.BackColor = System.Drawing.Color.Cyan;
            this.BotonComenzar.Location = new System.Drawing.Point(452, 53);
            this.BotonComenzar.Name = "BotonComenzar";
            this.BotonComenzar.Size = new System.Drawing.Size(75, 23);
            this.BotonComenzar.TabIndex = 1;
            this.BotonComenzar.Text = "Comenzar";
            this.BotonComenzar.UseVisualStyleBackColor = false;
            this.BotonComenzar.Click += new System.EventHandler(this.BotonComenzar_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.Cyan;
            this.BotonSalir.Location = new System.Drawing.Point(450, 365);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(75, 23);
            this.BotonSalir.TabIndex = 2;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = false;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // LabelPuntaje
            // 
            this.LabelPuntaje.AutoSize = true;
            this.LabelPuntaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPuntaje.Location = new System.Drawing.Point(470, 149);
            this.LabelPuntaje.Name = "LabelPuntaje";
            this.LabelPuntaje.Size = new System.Drawing.Size(55, 13);
            this.LabelPuntaje.TabIndex = 3;
            this.LabelPuntaje.Text = "Puntaje: 0";
            // 
            // LabelNivel
            // 
            this.LabelNivel.AutoSize = true;
            this.LabelNivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelNivel.Location = new System.Drawing.Point(470, 209);
            this.LabelNivel.Name = "LabelNivel";
            this.LabelNivel.Size = new System.Drawing.Size(43, 13);
            this.LabelNivel.TabIndex = 4;
            this.LabelNivel.Text = "Nivel: 0";
            // 
            // LabelPuntajeNombre
            // 
            this.LabelPuntajeNombre.AutoSize = true;
            this.LabelPuntajeNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPuntajeNombre.Location = new System.Drawing.Point(449, 120);
            this.LabelPuntajeNombre.Name = "LabelPuntajeNombre";
            this.LabelPuntajeNombre.Size = new System.Drawing.Size(46, 13);
            this.LabelPuntajeNombre.TabIndex = 5;
            this.LabelPuntajeNombre.Text = "Puntaje:";
            // 
            // Espacio
            // 
            this.Espacio.Location = new System.Drawing.Point(13, 13);
            this.Espacio.Name = "Espacio";
            this.Espacio.Size = new System.Drawing.Size(406, 375);
            this.Espacio.TabIndex = 0;
            this.Espacio.TabStop = false;
            this.Espacio.Paint += new System.Windows.Forms.PaintEventHandler(this.Espacio_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelNivelNombre
            // 
            this.LabelNivelNombre.AutoSize = true;
            this.LabelNivelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelNivelNombre.Location = new System.Drawing.Point(449, 179);
            this.LabelNivelNombre.Name = "LabelNivelNombre";
            this.LabelNivelNombre.Size = new System.Drawing.Size(34, 13);
            this.LabelNivelNombre.TabIndex = 6;
            this.LabelNivelNombre.Text = "Nivel:";
            // 
            // textboxNombre
            // 
            this.textboxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textboxNombre.Location = new System.Drawing.Point(441, 13);
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(100, 20);
            this.textboxNombre.TabIndex = 7;
            this.textboxNombre.Text = "Nombre:";
            // 
            // LabelAviso
            // 
            this.LabelAviso.AutoSize = true;
            this.LabelAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAviso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelAviso.Location = new System.Drawing.Point(447, 92);
            this.LabelAviso.Name = "LabelAviso";
            this.LabelAviso.Size = new System.Drawing.Size(47, 15);
            this.LabelAviso.TabIndex = 8;
            this.LabelAviso.Text = "Jugador";
            // 
            // SpaceTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(553, 400);
            this.Controls.Add(this.LabelAviso);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(this.LabelNivelNombre);
            this.Controls.Add(this.LabelPuntajeNombre);
            this.Controls.Add(this.LabelNivel);
            this.Controls.Add(this.LabelPuntaje);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.BotonComenzar);
            this.Controls.Add(this.Espacio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpaceTravelForm";
            this.Text = "Space Travel";
            ((System.ComponentModel.ISupportInitialize)(this.Espacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Espacio;
        private System.Windows.Forms.Label LabelPuntajeNombre;
        private System.Windows.Forms.Label LabelNivel;
        private System.Windows.Forms.Label LabelPuntaje;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.Button BotonComenzar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelNivelNombre;
        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.Label LabelAviso;
    }
}


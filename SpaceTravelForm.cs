using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Juego
{

    public partial class SpaceTravelForm : Form
    {
        private Cohete cohete;
        private Meteoritos meteoritos;
        private bool estado;
        public SpaceTravelForm()//CONSTRUCTOR del formulario Space Travel  
        {
            InitializeComponent();
            cohete = new Cohete(Espacio.Width, Espacio.Height);
            meteoritos = new Meteoritos(10, Espacio.Width, Espacio.Height);
            Espacio.BackgroundImage = Image.FromFile(@"..\..\img\areaGalaxia.gif");
            this.estado = false;
        }
        private void BotonSalir_Click(object sender, EventArgs e)//Asigna un evento al boton Salir
        {
            Application.Exit();
        }
        private void Espacio_Paint(object sender, PaintEventArgs e)//Se dibuja el cohete y los meteoritos dentro el area de juego(Espacio)
        {
            cohete.Dibujar(e.Graphics);
            meteoritos.Dibujar(e.Graphics);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (meteoritos.Perder(cohete))//En caso de que pierda el cohete
            {
                meteoritos.CambiaEstado();//inmoviliza los meteoritos
                cohete.CambiaEstado();//inmoviliza el cohete
                estado = true;
            }
            else
            {
                cohete.Mover();//se mueve el cohete
                meteoritos.Mover(cohete);//se mueven los meteoritos
                Espacio.Invalidate();
                LabelPuntaje.Text = meteoritos.getPuntaje().ToString();//se muestra el puntaje actual
                LabelNivel.Text = meteoritos.getNivel().ToString();//se muestra el nivel actual
            }
            if (estado)
            {
                timer1.Enabled = false;//se para el timer
                FormFin FormFin = new FormFin(meteoritos.getPuntaje(), meteoritos.getNivel(), textboxNombre.Text);
                FormFin.ShowDialog();//se muestra el segundo formulario
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)//otroga el poder a ciertas teclas de controlar el movimiento del cohete 
        {
            switch (keyData)
            {
                case Keys.Left:
                case Keys.J:
                    cohete.CambiarDir(-10);
                    Espacio.Invalidate();
                    return true;
                case Keys.Right:
                case Keys.L:
                    cohete.CambiarDir(10);
                    Espacio.Invalidate();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BotonComenzar_Click(object sender, EventArgs e)//Asigna el comienzo deel juego al boton comenzar 
        {
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\img\DanceMonkey.wav");
            simpleSound.Play();
            LabelAviso.Text = textboxNombre.Text;
            if (meteoritos.GetEstado() && cohete.GetEstado())
                BotonComenzar.Text = "Comenzar";
            else
                BotonComenzar.Text = "Pausar";//cambia el boton por el boton pausar 

            meteoritos.CambiaEstado();
            cohete.CambiaEstado();
        }

        }
}

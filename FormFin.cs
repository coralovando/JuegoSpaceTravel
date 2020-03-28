using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class FormFin : Form//Formulario del fin del juego
    {
        public FormFin(int puntaje,int nivel,string nombre)//muestra los datos del jugador(nombre, puntaje y nivel)
        {
            InitializeComponent();
            LabelNombre.Text = nombre;
            LabelPuntajeNum.Text = puntaje.ToString();
            LabelNivelNum.Text = nivel.ToString();
            
        }

        
    }
}

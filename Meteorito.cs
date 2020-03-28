using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Juego
{
    class Meteorito
    {
        private int x, y;
        private int ancho, alto;
        private int radio;
        private Image i;

        private int retraso;
        private int puntaje;

        private Random r;
        public Meteorito(int ancho, int alto, Random r)//CONSTRUCTOR de un meteorito
        {
            this.ancho = ancho;
            this.alto = alto;
            this.r = r;
            Inicializar();
            i = Image.FromFile(@"..\..\img\meteorito.png");


        }
        private void Inicializar()//Inicialiacion del radio, la posicion y el retraso de un meteorito
        {
            radio = r.Next(1, 10) * 5;//Inicializa el radio basandose en un valor aleatorio
            x = r.Next(radio, ancho - radio);//inicializa la posicion en x basandose en un valor aleatorio
            y = -radio;//posiciona el meteorito arriba del area de juego
            retraso = r.Next(1, 5);//genera un retrase de valor aleatorio entre 1 y 5
        }
        public void Dibujar(Graphics g)//dibuja el meteorito
        {
            g.DrawImage(i,
                 (int)(x - radio), (int)(y - radio),
                 (int)(2 * radio), (int)(2 * radio));
        }
        public void Mover()//mueve cada meteorito hacia abajo desde la parte superior del area de juego
        {

            if (retraso <= 0)
            {
                if (y - radio >= alto)
                {
                    Inicializar();
                    puntaje += 1;//aumenta un punto por cada meteorito que logra pasar la parte inferior del area de juego
                }

                else
                    y += (puntaje+10);//acelera la caida en el eje y proporcionalmente a la cantidad de puntaje acumulado 
            }
            else
                retraso--;
        }
        public Rectangle GetRectangle()// devuelve el rectangulo en el que esta inscrito un meteorito 
        {
            return new Rectangle((int)(x - radio), (int)(y - radio),
                (int)(1.9 * radio), (int)(1.9 * radio));
        }
        public int getPuntaje()//devuelve el puntaje
        {
            return puntaje;
        }
    }
}

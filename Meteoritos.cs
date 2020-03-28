using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Meteoritos
    {
        private Meteorito[] meteoritos;
        private Random r;
        private bool estado;
        private bool perder;
        private int puntaje;
        private int nivel;

        public Meteoritos(int n, int ancho, int alto)//CONSTRUCTOR de los meteoritos
        {
            meteoritos = new Meteorito[2];
            r = new Random();
            estado = false;
            perder = false;
            for (int i = 0; i <= 1; i++)
            {
                meteoritos[i] = new Meteorito(alto, ancho, r);
            }
        }
        public void Dibujar(Graphics graphics)//dibuja los meteoritos
        {
            for (int i = 0; i <= 1; i++)
            {
                meteoritos[i].Dibujar(graphics);
            }

        }
        public void Mover(Cohete cohete)//mueve a cada uno de los meteoritos
        {
            if (estado)
            {
                for (int i = 0; i <= 1; i++)
                    meteoritos[i].Mover();
            }
        }
        public void CambiaEstado()//cambia el estado de los meteoritos
        {
            estado = !estado;
        }
        public bool GetEstado()//devuelve el estado de los meteoritos
        {
            return estado;
        }
        public bool Perder(Cohete c)//se lleva a cabo cuando pierde el usuario
        {
            perder = false;
            for (int i = 0; i <= 1; i++)
            {
                if (meteoritos[i].GetRectangle().IntersectsWith(c.GetRectangle()))//establece una interseccion entre el cohete y un meteorito
                {
                    perder = true;
                }

            }

            return perder;

        }
        public int getPuntaje()//suma el puntaje de cada uno de los meteoritos y devuelve el puntaje final
        {
            int puntaje1 = meteoritos[0].getPuntaje();
            int puntaje2 = meteoritos[1].getPuntaje();
            puntaje = puntaje1 + puntaje2;


            return puntaje;
        }
        public int getNivel()//calcula el nivel basandose en el puntaje
        {
            nivel = puntaje / 10;//cada 10 puntos se sube de nivel
            return nivel;
        }
    }
}

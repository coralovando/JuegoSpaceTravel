using System.Drawing;

namespace Juego
{
    class Cohete
    {
        private double x;
        private double y;
        private double ancho;
        private double alto;
        private double radio;

        private bool estado;
        private Image i;
        private int dir;

        public Cohete(double ancho, double alto)//CONSTRUCTOR del cohete
        {
            this.ancho = ancho;
            this.alto = alto;
            radio = 40;
            this.dir = 10;


            this.x = ancho / 2;
            this.y = alto - 1.5 * radio;
            this.estado = false;
            i = Image.FromFile(@"..\..\img\cohete.png");
        }
        public void Mover()//mueve el cohete 
        {
            if (estado)
            {
                if (x + radio+dir <= ancho && x-radio+dir >= 0)//se establece los limites dentro los cuales se mueve el cohete
                {
                    x += dir;
                }

            }
        }
        public void Dibujar(Graphics graphics)//dibuja el cohete
        {
            graphics.DrawImage(i,
                (int)(x - radio), (int)(y - (2 * radio)),
                (int)(2 * radio), (int)(4 * radio));
        }
        public void CambiaEstado()//Metodo que cambia el estado del cohete
        {
            estado = !estado;
        }
        public bool GetEstado()//devuelve el estado del cohete
        {
            return estado;
        }
        public Rectangle GetRectangle()//devuelve el rectangulo en el que esta inscrito el cohete 
        {
            return new Rectangle((int)(x - radio), (int)(y - (2 * radio)),
                (int)(2 * radio), (int)(2 * radio));
        }
        public void CambiarDir(int dir)//cambia el valor de la direccion
        {
            this.dir = dir;
        }
           }
}

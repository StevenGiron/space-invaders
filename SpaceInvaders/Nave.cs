using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Nave : SpaceComponent
    {
        public static PictureBox pbNave;
        public Nave(int vida, int velocidad, string imagen, int[] posicion, int[] tamaño) : base(vida, velocidad, imagen, posicion, tamaño)
        {
        }

        public static int[] generarPosicionNave(int x, int y)
        {
            int[] posicion = new int[2];
            posicion[0] = x;
            posicion[1] = y;
            return posicion;
        }

        public void MoverNave(string sentido, PictureBox pictureBox, Nave nave)
        {
            switch (sentido)
            {
                case "derecha":
                    if (pictureBox.Location.X <= 950)
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X + velocidad, pictureBox.Location.Y);
                    }
                    break;
                case "izquierda":
                    if(pictureBox.Location.X >= 150)
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X - velocidad, pictureBox.Location.Y);
                    }
                    break;
            }
        }


    }
}

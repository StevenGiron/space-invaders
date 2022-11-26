using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SpaceInvaders
{
    internal class Boss : SpaceComponent
    {
        public Boss(int vida, int velocidad, string imagen, int[] posicion, int[] tamaño) : base(vida, velocidad, imagen, posicion, tamaño)
        {
        }
        public static int[] generarPosicionBoss(int x, int y)
        {
            int[] posicion = new int[2];
            posicion[0] = x;
            posicion[1] = y;
            return posicion;
        }
    }
}

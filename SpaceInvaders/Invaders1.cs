﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Invaders1 : SpaceComponent
    {
        public Invaders1(int vida, int velocidad, string imagen, int[] posicion, int[] tamaño) : base(vida, velocidad, imagen, posicion, tamaño)
        {
        }
    }
}

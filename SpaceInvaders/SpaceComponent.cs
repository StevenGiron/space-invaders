using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms.VisualStyles;

namespace SpaceInvaders
{
    internal class SpaceComponent
    {
        public static int  contador = 0;
        public static List<SpaceComponent> listaInvaders = new List<SpaceComponent>();
        public PictureBox pictureBox = new ();

        private static System.Timers.Timer timer;
        private bool movimiento = true;

        private string basepath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/";
        public int id { get; set; } 
        public int vida { get; set; } 
        public int velocidad { get; set; }
        public int[] posicion { get; set; }
        public int[] tamaño { get; set; }
        public string imagen { get; set; }

        public SpaceComponent(int vida, int velocidad, string imagen, int[] posicion, int[] tamaño)
        {
            this.id = id;
            this.vida = vida;
            this.velocidad = velocidad;
            this.posicion = posicion;
            this.tamaño = tamaño;
            this.imagen = Path.GetFullPath(relativePath + imagen ,basepath);
        }
        public PictureBox crearComponente()
        {
            pictureBox.Image = Image.FromFile(imagen);
            pictureBox.Location = new System.Drawing.Point(posicion[0], posicion[1]);
            pictureBox.Size = new System.Drawing.Size(tamaño[0], tamaño[1]);

            return pictureBox;
        }
        public static int[] generarPosicion(int index, int y)
        {
            int[] posicion = new int[2];
            posicion[0] = (index + 1) * 180;
            posicion[1] = y;

            return posicion;
        }
        public static int[] generarTamaño(int x, int y)
        {
            int[] tamaño = new int[2];
            tamaño[0] = x;
            tamaño[1] = y;

            return tamaño;
        }
        private void moverBoss(Object source, ElapsedEventArgs e)
        {
            moverBoss(pictureBox.Location.X, pictureBox.Location.Y);
        }

        private void moverBoss(int x, int y)
        {
            if (movimiento == true)
            {
                pictureBox.Location = new Point(x + 15, y);
            }

            if (x >= 887)
            {
                movimiento = false;
            }

            if (movimiento == false)
            {
                pictureBox.Location = new Point(x - 15, y);
            }
            if (x <= 180)
            {
                movimiento = true;
            }
        }
        public void crearTimer()
        {
            timer = new(200);
            timer.Elapsed += moverBoss;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
    }
}

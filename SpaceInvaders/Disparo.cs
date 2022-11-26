using System.Timers;

namespace SpaceInvaders
{
    internal class Disparo
    {
        private bool esAlien = true;
        private static System.Timers.Timer timer;
        private PictureBox pictureBox = new PictureBox();
        private PictureBox pictureBoxAlien = new PictureBox();

        private PictureBox pbNave;
        private ProgressBar vida;



        private string basepath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/";
        public int daño { get; set; }
        public string imagen { get; set; }
        public int[] posicion { get; set; }
        public int[] tamaño { get; set; }

        public Disparo(int daño, string imagen, int[] posicion, int[] tamaño, bool esAlien)
        {
            this.esAlien = esAlien;
            this.daño = daño;
            this.imagen = Path.GetFullPath(relativePath + imagen, basepath);
            this.posicion = posicion;
            this.tamaño = tamaño;
        }
        
        public PictureBox crearDisparo(PictureBox pbNave, ProgressBar pbVida)
        {
            pictureBox.Image = Image.FromFile(imagen);
            pictureBox.Location = new System.Drawing.Point(posicion[0], posicion[1]);
            pictureBox.Size = new System.Drawing.Size(tamaño[0], tamaño[1]);
            this.pbNave = pbNave;
            this.vida = pbVida;
            this.crearTimer();

            return pictureBox;
        }

        private void disparar()
        {
            if (!esAlien)
            {
                pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y - 10);
            }
            else
            {
                pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + 10);
                matarNave();
            }

        }
        private void disparar(Object source, ElapsedEventArgs e)
        {
            disparar();
        }

        private void matarNave()
        {
            if (pictureBox.Bounds.IntersectsWith(this.pbNave.Bounds)){
                pictureBox.Visible = false;

                this.vida.Value -= 50;
                this.pictureBox.Location = new Point(0, 0);


                if (this.vida.Value <= 0)
                {
                    MessageBox.Show("Has sido eliminado");
                }
            }
           
        }

        public void crearTimer()
        {
            timer = new(40);

            timer.Elapsed += disparar;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
    }
}

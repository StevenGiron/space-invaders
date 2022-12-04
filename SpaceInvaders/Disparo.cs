using System.Timers;

namespace SpaceInvaders
{
    internal class Disparo
    {
        private bool esAlien = true;
        private System.Timers.Timer timer;

        private PictureBox pictureBox = new PictureBox();

        private PictureBox pbNave;
        private ProgressBar vida;
        private Form form2;

        private string basepath = Environment.CurrentDirectory;
        private const string relativePath = "../../../assets/";
        public int daño { get; set; }
        public string imagen { get; set; }
        public int[] posicion { get; set; }
        public int[] tamaño { get; set; }

        public Disparo(int daño, string imagen, int[] posicion, int[] tamaño, bool esAlien, Form form2)
        {
            this.esAlien = esAlien;
            this.daño = daño;
            this.imagen = Path.GetFullPath(relativePath + imagen, basepath);
            this.posicion = posicion;
            this.tamaño = tamaño;
            this.form2 = form2;
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
                matarInvader();
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
                this.pictureBox.Location = new Point(0, 0);
                this.vida.Value -= 50;
                timer.Stop();


                if (this.vida.Value <= 0)
                {
                    this.pictureBox.Location = new Point(0, 0);
                    this.vida.Value = 100;
                    SpaceComponent.contador = 0;
                    form2.Close();
                    Form3 form3 = new Form3();
                    form3.BackgroundImage = Image.FromFile(Path.GetFullPath(relativePath + "gameOver.jpg", basepath));
                    form3.ShowDialog();
                }
            }
           
        }
        private void matarInvader()
        {
            foreach(SpaceComponent invader in SpaceComponent.listaInvaders)
            {
                if (pictureBox.Bounds.IntersectsWith(invader.pictureBox.Bounds))
                {
                    if(SpaceComponent.contador < SpaceComponent.listaInvaders.Count - 1)
                    {
                        pictureBox.Visible = false;
                        invader.pictureBox.Visible = false;
                        invader.pictureBox.Location = new Point(0, 0);
                        SpaceComponent.contador += 1;
                    }
                    else
                    {
                        pictureBox.Visible = false;
                        invader.pictureBox.Visible = false;
                        invader.pictureBox.Location = new Point(0, 0);
                        this.vida.Value = 100;
                        SpaceComponent.contador = 0;
                        SpaceComponent.listaInvaders.Clear();
                        form2.Close();
                        Form3 form3 = new Form3();
                        form3.BackgroundImage = Image.FromFile(Path.GetFullPath(relativePath + "win.jpg", basepath));
                        form3.ShowDialog();
                    }
                    timer.Stop();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form2 : Form
    {
        PictureBox pbNave;
        Nave nave;
        public Form2()
        {
            InitializeComponent();
            generarNave();
            generarInvaders1();
            generarInvaders2();
            generarInvaders3();
            generarBoss();
        }
        private void generarInvaders1()
        {
            for (int i = 0; i < 5; i++)
            {
                Invaders1 invaders1 = new(3, 0, "invader3.gif", Invaders1.generarPosicion(i, 137), Invaders1.generarTamaño(87, 80));
                Controls.Add(invaders1.crearComponente());
                SpaceComponent.listaInvaders.Add(invaders1);
                System.Diagnostics.Debug.WriteLine("URL INVADER11" + invaders1.imagen);
            }
        }
        private void generarInvaders2()
        {
            for (int i = 0; i < 5; i++)
            {
                Invaders2 invaders2 = new(3, 0, "invader2.gif", Invaders2.generarPosicion(i, 244), Invaders2.generarTamaño(88, 80));
                Controls.Add(invaders2.crearComponente());
                SpaceComponent.listaInvaders.Add(invaders2);
            }
        }
        private void generarInvaders3()
        {
            for (int i = 0; i < 5; i++)
            {
                Invaders3 invaders3 = new(3, 0, "invader1.gif", Invaders3.generarPosicion(i, 351), Invaders2.generarTamaño(121, 80));
                Controls.Add(invaders3.crearComponente());
                SpaceComponent.listaInvaders.Add(invaders3);
            }
        }
        private void generarBoss()
        {
            Boss boss = new(3, 15, "boss.gif", Boss.generarPosicionBoss(160, 12), Boss.generarTamaño(100, 102));
            boss.crearTimer();
            Controls.Add(boss.crearComponente());
            SpaceComponent.listaInvaders.Add(boss);
        }

        private void generarNave()
        {
            nave = new(100, 15, "nave.gif", Nave.generarPosicionNave(533, 799), Nave.generarTamaño(100, 100));
            pbNave = nave.crearComponente();
            Controls.Add(pbNave);
        }

        private void generarDisparo()
        {
            int[] posicionDisparo = new int[2];
            posicionDisparo[0] = pbNave.Location.X + 40;
            posicionDisparo[1] = 738;
            Disparo disparo = new(1, "disparo.png", posicionDisparo, SpaceComponent.generarTamaño(20, 55), false, this);
            Controls.Add(disparo.crearDisparo(pbNave, pbarSalud));
        }
        private void generarDisparoAlien()
        {
            int[] posicionDisparo = new int[2];
            posicionDisparo[0] = new Random().Next(150, 950);
            posicionDisparo[1] = 120;
            Disparo disparoAlien = new(1, "disparoAlien.png", posicionDisparo, SpaceComponent.generarTamaño(32, 62), true, this);
            Controls.Add(disparoAlien.crearDisparo(pbNave, pbarSalud));
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    nave.MoverNave("derecha", pbNave, nave);
                    break;
                case Keys.Left:
                    nave.MoverNave("izquierda", pbNave, nave);
                    break;
                case Keys.Space:
                    generarDisparo();
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            generarDisparoAlien();
        }

    }
}

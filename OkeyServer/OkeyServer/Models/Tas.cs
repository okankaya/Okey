using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OkeyServer
{
    class Tas
    {
        private int id = -1;
        private Color renk;
        private int sayi;
        private bool sahteOkey = false;

        /// <summary>
        /// Public contructor for tas
        /// </summary>
        /// <param name="id"></param>
        public Tas(int id)
        {
            this.id = id;

            if (id < 104)
            {
                int rem = id % 52;
                if (rem < 13)
                {
                    this.renk = Color.Red;
                }
                else if (rem < 26)
                {
                    this.renk = Color.Blue;
                }
                else if (rem < 39)
                {
                    this.renk = Color.Black;
                }
                else if (rem < 52)
                {
                    this.renk = Color.Green;
                }

                this.sayi = (rem % 13) + 1;
            }
            else
            {
                sahteOkey = true;
                this.renk = Color.White;
                this.sayi = 0;
            }
        }
    }
}

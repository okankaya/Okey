using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class Tas
    {
        public int id = -1;
        public int renk;
        public int sayi;
        public bool sahteOkey = false;

        public Tas(int id)
        {
            this.id = id;

            if (id < 104)
            {
                int rem = id % 52;
                if (rem < 13)
                {
                    this.renk = 0xBB2222;
                }
                else if (rem < 26)
                {
                    this.renk = 0x2288BB;
                }
                else if (rem < 39)
                {
                    this.renk = 0x444444;
                }
                else if (rem < 52)
                {
                    this.renk = 0x88BB22;
                }

                this.sayi = (rem % 13) + 1;
            }
            else
            {
                sahteOkey = true;
                this.renk = 0;
                this.sayi = 0;
            }
        }
    }
}

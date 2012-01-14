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
            this.id = id % 52;

            if (id < 104)
            {
                int tas = id % 52;
                if (tas < 13)
                {
                    this.renk = 0xBB2222;
                }
                else if (tas < 26)
                {
                    this.renk = 0x2288BB;
                }
                else if (tas < 39)
                {
                    this.renk = 0x444444;
                }
                else if (tas < 52)
                {
                    this.renk = 0x88BB22;
                }

                this.sayi = (tas % 13) + 1;
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

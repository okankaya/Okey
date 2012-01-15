using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer
{
    class TasContainer
    {
        public List<Tas> tas = new List<Tas>();
        public int okeyCount = 0;
        public int validCount = 1;

        public TasContainer(JSONArray tc, byte okey)
        {
            for (int i = 0; i < tc.length(); i++)
            {
                int tasId = tc.getInt(i);
                if (tasId % 52 == okey)
                {
                    okeyCount++;
                }
                else
                {
                    if (tasId > 103) tasId = okey;
                    tas.Add(new Tas(tasId));
                }
            }
        }
    }
}

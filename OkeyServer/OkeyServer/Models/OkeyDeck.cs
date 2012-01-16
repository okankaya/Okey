using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OkeyServer.Models {
    class OkeyDeck {
	    private List<int> ortadakiTas;                      // Ortadan cekilen arkasi donuk tas A.K.A. aslan
        private Dictionary<int, List<int>> yerdekiTas;      // Sagdan soldan cekilen tas
	    private int lastUsedThrownList;
	
	    private int gosterge;
	    private int okey;
        
        /// <summary>
        /// Taslari karistir, oyunu hazirla, jokeri sec, gostergeyi sec
        /// </summary>
        /// <param name="playerCount"></param>
        /// <returns></returns>
	    public List<List<int>> prepareDeck(int playerCount) 
        {
		    List<List<int>> hands = new List<List<int>>();
		    Random rand = new Random();
		    
            // Gostergeyi sec
            gosterge = rand.Next(104);

            // Birden fazla okey var buna gerek neden var ???
            okey = (((gosterge % 13 == 12)?gosterge-12:gosterge+1) % 52);

             /*
             * 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 
             * 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51
             * 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77,
             * 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103,
             * 104, 105 
             */
            
            // Taslari koyalim
            for (int i = 0; i < 106; i++)
			{
			     if (i != gosterge)
                 {
                     ortadakiTas.Add(i);
                 }
			}

            // Taslari karistir
            for (int i = ortadakiTas.Count; i > 1; i--) 
            {
                int pos = rand.Next(i);
                var x = ortadakiTas[i - 1];
                ortadakiTas[i - 1] = ortadakiTas[pos];
                ortadakiTas[pos] = x;
            }
		
            // Yerdeki taslari ayarla
		    yerdekiTas = new Dictionary<int, List<int>>();
            yerdekiTas.Add(0, new List<int>());
            yerdekiTas.Add(1, new List<int>());
            yerdekiTas.Add(2, new List<int>());
            yerdekiTas.Add(3, new List<int>());

            // Ilk oyuncunun elini dagit
            hands.Add(new List<int>(ortadakiTas.Take(15)));
            ortadakiTas.RemoveRange(0, 15);
            
            // Geriye kalan oyunculara da ellerini dagit
            for (int i = 1; i < playerCount; i++) {
			    hands.Add(new List<int>(ortadakiTas.Take(14)));
                ortadakiTas.RemoveRange(0, 14);
		    }
			
		    return hands;
	    }

        /// <summary>
        /// Show the gosterge
        /// </summary>
        /// <returns></returns>
	    public int getGosterge() {
		    return gosterge;
	    }

        /// <summary>
        /// Tasi yere at
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool throwToken(int pos, int token) 
        {
		    lastUsedThrownList = pos;
		    if (token==null) {
			    //logger.error("Token Null nasil geldi buraya?!");
			    return false;
		    }

            yerdekiTas[pos].Add(token);
            return true;
	    }
	
        /// <summary>
        /// Tas ceker
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
	    public int drawTile(int from) {
            int tempTas;
            // yandan
            if (from == 0) 
            {
			    if (yerdekiTas[lastUsedThrownList].Count() == 0) return -1;
                tempTas = yerdekiTas[lastUsedThrownList][0];
                yerdekiTas[lastUsedThrownList].RemoveAt(0);
		    }
            // yerden
            else 
            {
                if (ortadakiTas == null) return -1;
			    if (ortadakiTas.Count == 0) return -1;
                tempTas = ortadakiTas[0];
                ortadakiTas.RemoveAt(0);  
		    }

            // Tasi dondur
            return tempTas;
	    }

        /// <summary>
        /// Ortada bulunan tas sayisini soyler
        /// </summary>
        /// <returns></returns>
	    public int getPileCount() {
		    if( ortadakiTas != null ) {
			    return ortadakiTas.Count();
		    } else {
			    return 0;
		    }
	    }

        /// <summary>
        /// Okeyi dondurur
        /// </summary>
        /// <returns></returns>
	    public int getOkey() {
		    return okey;
	    }


        /// <summary>
        /// Send piles to player
        /// </summary>
        /// <returns></returns>
	    public string getPiles() {
            /*
		    JSONArray piles = new JSONArray();
		    for (int i=0;i<4;i++) {
			    piles.put(thrown.get(i));
		    }
		    return piles;
             */
            return "todo";
	    }

    }
}

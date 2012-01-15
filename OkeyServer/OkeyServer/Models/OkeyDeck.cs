using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer.Models {
    class OkeyDeck {
        private static final Logger logger = Logger.getLogger(OkeyDeck.class);
	    private List<Byte> pile;
	    private HashMap<Integer, List<Byte>> thrown;
	    private int lastUsedThrownList;
	
	    private byte gosterge;
	    private byte okey;

	    public List<List<Byte>> prepareDeck(int playerCount) throws JSONException {
		    List<List<Byte>> hands = new ArrayList<List<Byte>>();
		    Random rand = new Random();
		
		
		byte[] raw = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
				41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81,
				82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 };
		
		
		for (int i = 0; i < 104; i++) {
			int j = rand.nextInt(104);
			byte temp = raw[i];
			raw[i] = raw[j];
			raw[j] = temp;
		}

		// Sahte okeyleri de desteye karistir ama !! raw[0]'a dokunmadan !!
		for (int i = 104; i < 106; i++) {
			int j = rand.nextInt(105) + 1;
			byte temp = raw[i];
			raw[i] = raw[j];
			raw[j] = temp;
		}
		
		// raw[0]'da olani destenin ardina cekerek (yani dagitilan tas sayisinin ustune), onu okey belirteci gosterge yap
		byte temp = raw[0];
		raw[0] = raw[14 * playerCount + 1];
		raw[14 * playerCount + 1] = temp;
		
		gosterge = raw[14 * playerCount + 1];
		
        //		raw = new byte[]{ 0, 1, 53, 2, 54, 3, 55, 4, 56, 5, 57, 6, 58, 7, 59, 8, 60, 18, 69, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
        //				41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81,
        //				82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 0 };
        //		gosterge = raw[51];
		
		
		okey = (byte) (((gosterge % 13 == 12)?gosterge-12:gosterge+1) % 52);
		thrown = new HashMap<Integer, List<Byte>>();
		thrown.put(0, new ArrayList<Byte>());
		thrown.put(2, new ArrayList<Byte>());
		thrown.put(1, new ArrayList<Byte>());
		thrown.put(3, new ArrayList<Byte>());

		for (int i = 0; i < playerCount; i++) {
			List<Byte> hand = new ArrayList<Byte>();
			for (int j = 0; j < 14; j++) {
				hand.add(raw[i*14+j]);
			}
			
			// Ilk el +1 tas alir
			if (i==0) hand.add(raw[14 * playerCount]);
			hands.add(hand);
		}
		
		// Kalani pile'a at
		pile = new ArrayList<Byte>();
		for (int i = 14 * playerCount + 2; i < 106; i++) {
			pile.add(raw[i]);
		}
				
		return hands;
	    }

	    public byte getGosterge() {
		    return gosterge;
	    }

	    public boolean throwToken(int pos, Byte token) throws JSONException {
		    lastUsedThrownList = pos;
		    if (token==null) {
			    logger.error("Token Null nasil geldi buraya?!");
			    return false;
		    }
		    return thrown.get(pos).add(token);
	    }
	
	    public Byte pickToken(int from) {
		    if (from==0) {
			    // yandan
			    if (thrown.get(lastUsedThrownList).size()==0) return null;
			    return thrown.get(lastUsedThrownList).remove(thrown.get(lastUsedThrownList).size()-1);
		    } else {
			    // yerden
			    if (pile==null) return null;
			    if (pile.size()==0) return null;
			    return pile.remove(0);
		    }
	    }

	    public int getPileCount() {
		    if( pile != null ) {
			    return pile.size();
		    } else {
			    return 0;
		    }
	    }

	    public byte getOkey() {
		    return okey;
	    }

	    public JSONArray getPiles() {
		    JSONArray piles = new JSONArray();
		    for (int i=0;i<4;i++) {
			    piles.put(thrown.get(i));
		    }
		    return piles;
	    }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OkeyServer.Models {
    class Hand {
        public List<TasContainer> tasContainer = new List<TasContainer>();

        /// <summary>
        /// Read the string hand and add the tas into list
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="okey"></param>
        public Hand(string hand, byte okey)
        {
            //TODO: Add deserializer for hand???

            //TextReader textReader = new StreamReader();
            //JsonTextReader jasonReader = new JsonTextReader(textReader);
		    for (int i=0; i < hand.Length; i++) {
			 //   tc.Add(new TasContainer(hand.getJSONArray(i), okey));
		    }
	    }

        /// <summary>
        /// Converts the hand into a json string array
        /// </summary>
        /// <returns></returns>
	    public string toString() {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
 
            JsonWriter jsonWriter;
            using (jsonWriter = new JsonTextWriter(sw))
            {
                jsonWriter.Formatting = Formatting.Indented;
                jsonWriter.WriteStartObject();
                jsonWriter.WritePropertyName("Hand");
                jsonWriter.WriteStartArray();
                foreach (var item in tasContainer)
	            {
		            jsonWriter.WriteValue(item.ToString());
                }
                jsonWriter.WriteEnd();
                jsonWriter.WriteEndObject();
            }

            return jsonWriter.ToString();
	    }
    }
}

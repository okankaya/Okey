using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OkeyServer {
    class Program {
        static void Main(string[] args) {
            using (dbModelsContainer entities = new dbModelsContainer()) {
                try {
                    foreach (var user in entities.users) {
                        Console.WriteLine(user.name);
	                }
                }
                catch (Exception myException) {
                    Console.WriteLine("damn dawg \nErr:" + myException.Message + "\n");
                    //throw;
                }
                    
            } 
            

            var i = 1;
            i = Console.Read();

        }
    }
}

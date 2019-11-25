using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;


namespace FightSim
{
    class Arena
    {

        Fighter A = new Fighter();
        Fighter B = new Fighter();

        public Arena() //Konstruktor med REst klient
        {
            Console.WriteLine("Loading...");
            RestClient client = new RestClient("https://swapi.co/api/");
            RestRequest request = new RestRequest("planets/10");
            IRestResponse response = client.Get(request);
            string content = response.Content;
            //Console.WriteLine(content); skriver ut all innehåll från json filen, behöver itne printas ut´till programmet.

            // Arena kamino = JsonConvert.DeserializeObject<Arena>(response.Content);
            Planet planet10 = JsonConvert.DeserializeObject<Planet>(response.Content);
            Console.WriteLine(planet10.name + "det borde stå kamino");
            Console.ReadKey();
        }
        
       

        public void Battle()
        {
            Console.WriteLine("Fighter A: " + A.AssignName() + " Health:" + A.GetHp() + " \n Fighter B: " + B.AssignName() + " Health: " + B.GetHp());
            Console.Clear();
            // så länge båda lever..
            while (true)
            {                            
                A.TakeTurn(B); // A slår B               
                B.TakeTurn(A); // B slår A

                if (A.GetHp() <= 0)
                {
                    Console.WriteLine("Grattis" + B.PresentName());
                    Console.ReadKey();
                    
                    break;
                }
                else if(B.GetHp() <= 0)
                {
                    Console.WriteLine("Grattis" + A.PresentName());
                    Console.ReadKey();
                    
                    break;
                    
                }

                
            }


        }
        
    }
}

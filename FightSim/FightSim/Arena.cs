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
        //Nya instanser av fighters A och B
        Fighter A = new Fighter();
        Fighter B = new Fighter();
        
        public Arena() //Konstruktor med REST klient
        {
            Console.WriteLine("Loading...");
           
        }
        public Planet PlanetValues() {

            RestClient client = new RestClient("https://swapi.co/api/");
            RestRequest request = new RestRequest("planets/10");
            IRestResponse response = client.Get(request);
            string content = response.Content;
            //Console.WriteLine(content); skriver ut all innehåll från json filen, behöver inte printas uttill programmet.

            Planet planet10 = JsonConvert.DeserializeObject<Planet>(response.Content);
            //Console.WriteLine("Current planet: " + planet10.gravity //+ "\n Press enter to initiate fighting sequence");
            return planet10;
        }
        public void Battle() //Instansen där självaste strideb sker mellan A och B
        {

            Planet new_planet = PlanetValues();
            Console.WriteLine("Fighter A: " + A.AssignName() + " Health:" + A.GetHp() + " \n Fighter B: " + B.AssignName() + " Health: " + B.GetHp());
            Console.Clear();
            // så länge båda lever..
            while (true)
            {     
                
                A.TakeTurn(B); // A slår B               
                B.TakeTurn(A); // B slår A

                if (A.GetHp() <= 0) // B vinner då A dör
                {
                    Console.WriteLine("Grattis" + B.PresentName()+ " Du vinner en resa till " + new_planet.name );
                    Console.ReadKey();
                    
                    break;
                }
                else if(C.GetHp() <= 0) // A vinner då B dör
                {
                    Console.WriteLine("Grattis " + A.PresentName() + " Du vinner en resa till " + new_planet.name);
                    Console.ReadKey();
                    
                    break;
                    
                }

                
            }


        }
        
    }
}

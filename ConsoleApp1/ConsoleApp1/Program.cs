using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class AvailabilityObject
        {

            //properties from JSON object
            public string Date { get; set; }

            public string[] Partner { get; set; }

            //constructor
            public void simpleapp1(string date, string[] partner)
            {
                Date = date;
                Partner = partner;
            }

        }



        static void Main(string[] args)
        {
            string fetchURL = Utils.getURL();   //Get endpoint: https://api.filtered.ai/q/get-partner-availability
            string postURL = "https://api.filtered.ai/q/save-partner-availability";

            Console.WriteLine("This is where your output will go");
        }




        //public Task<List<string>> GetAvailability()
        public void GetAvailability()
        {
            //Client client = new HttpClient();
            string fetchURL = Utils.getURL();

            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaulRequestHeaders.Add(
            //new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
            //);

            var response = fetchURL;   //await client.GetStringAsync(${ fetchURL });

            foreach (var item in response)
            {
                Console.WriteLine(item);
            }


        }

        public async Task<AvailabilityObject> AddAvailability(AvailabilityObject availability)
        {
            string postURL = "https://api.filtered.ai/q/save-partner-availability";

            return availability;
        }
    }
}

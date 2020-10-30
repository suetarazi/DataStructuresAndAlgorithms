using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Utils
    {
        // this function helps candidates to read the JSON input.
        public static string getURL()
        {
            using (StreamReader r = new StreamReader("userInput.json"))
            {
                string json = r.ReadToEnd();
                List<string> items = JsonConvert.DeserializeObject<List<string>>(json);
                return items[0];
            }

        }
    }
}

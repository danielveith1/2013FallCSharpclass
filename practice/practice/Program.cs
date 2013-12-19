using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


namespace practice
{
    class Program
    {
        static void Main()
        {
            MainAsync().Wait();
        }
        static async Task<string[]> MainAsync()
        {


            var client = new HttpClient();
            String[] output = new String[50];

            Console.WriteLine("letter");
            String input = "http://cs.newpaltz.edu/~plotkinm/2012Grad/Final/api/Cities.php?term=" + Console.ReadLine();
            try
            {
                HttpResponseMessage response = await client.GetAsync(input);
                response.EnsureSuccessStatusCode();
                
                var responseBody = await response.Content.ReadAsStringAsync();

                output = JsonConvert.DeserializeObject<string[]>(responseBody);
                
                
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return output;
            //client.Dispose(true);
            
            
        }
        
    }
}

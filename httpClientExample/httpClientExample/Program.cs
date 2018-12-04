using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;



namespace httpClientExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //#r "System.Net.Http"
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://www.microsoft.com/");
            var response = await client.GetAsync("about");
            System.Console.WriteLine(response.StatusCode);
            System.Console.WriteLine(response.Content.Headers.GetValues("Content-Type"));
            await response.Content.ReadAsStringAsync();

        }
    }
}

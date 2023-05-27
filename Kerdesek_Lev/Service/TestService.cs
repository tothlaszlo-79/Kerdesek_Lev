using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerdesek_Lev
{
    public class TestService
    {
        public static async Task<TestData> GetTest(string Url)
        {
            var query = $"{Url}/csharp.json";
            var json = await new HttpClient().GetStringAsync(query);
            var data = JsonConvert.DeserializeObject<TestData>(json);
            return data;

        }
    }
}

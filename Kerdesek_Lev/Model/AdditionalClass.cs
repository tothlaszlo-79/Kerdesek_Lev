using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerdesek_Lev
{
    public class Item
    {
        public string Question { get; set; }
        public string Answer_1 { get; set; }
        public string Answer_2 { get; set; }
        public string Answer_3 { get; set; }
        public string Answer_4 { get; set; }
        public int Key { get; set; }
        public string Category { get; set; }

    } 
    public class TestData
    {
        public List<Item> Items { get; set; }
    }
}

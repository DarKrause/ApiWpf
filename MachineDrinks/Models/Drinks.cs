using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineDrinks.Models
{
    public class Drinks
    {
        public int id { get; set; }
        public string Название { get; set; }
        public byte[] Фото { get; set; }
        public Nullable<decimal> Стоимость { get; set; }
    }
}

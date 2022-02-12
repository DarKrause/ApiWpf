using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineDrinks.Models
{
    internal class CoinsInMachine
    {
        public int id { get; set; }
        public Nullable<int> Id_торговый_автомат { get; set; }
        public Nullable<int> Id_монета { get; set; }
        public Nullable<int> Количество { get; set; }
        public Nullable<int> Активный { get; set; }
    }
}

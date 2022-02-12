using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineDrinks.Models
{
    internal class Coins
    {
        public int id { get; set; }
        public Nullable<int> Номинал { get; set; }

        //public virtual ICollection<Монета_в_торговом_автомате> Монета_в_торговом_автомате { get; set; }
    }
}

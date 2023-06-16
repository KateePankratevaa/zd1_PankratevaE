using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main (string[] args)
        {
            Cat murzik = new Cat("Мурзик", 12.1);
            Cat barsik = new Cat("Барсег", 0.1);
            murzik.Meow();
            barsik.Meow();
            barsik.Name = "Барсик";
            barsik.Meow();
            barsik.Name = "1234";
            barsik.Meow();
            murzik.Info();
            barsik.Info();
            Console.ReadKey();
        }
    }
}

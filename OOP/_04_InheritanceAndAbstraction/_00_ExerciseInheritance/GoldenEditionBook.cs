using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ExerciseInheritance
{
    class GoldenEditionBook : Book
    {
        public override double Price
        { 
            get
            {
                return price + (price * 0.3);
            }
        }
        public GoldenEditionBook(string title, string author, double price)
            :base(title, author, price)
        //:base(title, author, price+price*0.3)
        {

        }

    }
}

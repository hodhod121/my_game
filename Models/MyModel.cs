using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame.Models
{
    public class MyModel
    {
        public int MyNumber { get; set; }
        public void GetGuessNumber()
        {
            var random = new Random();
            this.MyNumber = random.Next(1, 100);
        }
    }
}

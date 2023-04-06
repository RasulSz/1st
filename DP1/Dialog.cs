using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1
{
    public abstract class Dialog : Button
    {
        public void Render()
        {
            Console.WriteLine("Render");
        }
        public void CreateButton()
        {
            Console.WriteLine("Button Created Successfully");
        }

        public void OnClick()
        {
            Console.WriteLine("Clicked");
        }
    }
}

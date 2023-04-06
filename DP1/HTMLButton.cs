using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1
{
    public class HTMLButton : Button
    {
        public void OnClick()
        {
            Console.WriteLine("HTML Activated");
        }

        public void Render()
        {
            Console.WriteLine("H Rendered");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1
{
    public class WindowsButton : Button
    {
        public void OnClick()
        {
            Console.WriteLine("Windows Activated"); ;
        }

        public void Render()
        {
            Console.WriteLine("W Rendered");
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.Width = 100; //text class usuing PresentationObject (Parent class) field
            text.Copy();
            text.Duplicate();
            text.AddHyperLink("www.test123.co.uk");
        }
    }
}

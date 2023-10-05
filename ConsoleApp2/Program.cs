using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApp2
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      Application.Run(new Form2());
      Console.ReadKey();
    }
  }
}

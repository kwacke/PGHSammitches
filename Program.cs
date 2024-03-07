using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
namespace PittsburghSammitches
{
    class Program
    {
        static void Main()
        {
            PittsburghSammitches app = new PittsburghSammitches();
            app.Run();
        }
    }
}

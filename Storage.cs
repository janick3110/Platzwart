using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vereinsmanager
{
    public class Storage
    {
        public static string players;

        public Storage()
        {
            players = Path.Combine(Environment.CurrentDirectory, @".Data\spielerliste.dat");
        }
    }
}

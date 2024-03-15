using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Concept
{
    public class FileLogger : ILogger
    {
        public void Log(string content)
        {
            File.WriteAllText(@"PathHere", content);
        }
    }
}

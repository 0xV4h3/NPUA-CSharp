using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class AppSettings
    {
        public string Environment { get; init; }
        public string Version { get; init; }

        public AppSettings(string environment, string version)
        {
            Environment = environment;
            Version = version;
        }

        public override string ToString()
        {
            return $"Environment={Environment}, Version={Version}";
        }
    }
}

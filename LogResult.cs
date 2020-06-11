using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstopper
{
    class LogResult
    {
        public string LastLogTime { get; set; }

        public List<Log> result { get; set; }
        public string status { get; set; }
        public string title { get; set; }
    }
}

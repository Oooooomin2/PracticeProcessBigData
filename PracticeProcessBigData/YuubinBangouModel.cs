using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProcessBigData
{
    public class YuubinBangouModel
    {
        [Index(2)]
        public string YuubinBangou { get; set; }
        [Index(6)]
        public string Ken { get; set; }
        [Index(7)]
        public string Shi_Choson { get; set; }
        [Index(8)]
        public string Gou { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class DataManager
    {
        public static string DATA_FILE_NAME = "data.xml";
        public static readonly object _lock = new object();
    }
}

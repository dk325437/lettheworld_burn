using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lettheworld_burn
{
    public class GetPath
    {
        public static string path
        {
            get
            {
                Assembly? entryAssembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
           
                string directory = Path.GetDirectoryName(entryAssembly.Location)!;

                string dataPath = Path.Combine(directory, "DATA");

                if (!Directory.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);
                }
                return dataPath;
            }
        }
    }
}

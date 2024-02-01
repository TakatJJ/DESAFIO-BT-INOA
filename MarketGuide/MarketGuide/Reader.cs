using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarketGuide
{
    internal class Reader
    {
        public List<string> GetContent (string pathToFile) 
        { 
            List<string> content = new List<string>();
            StreamReader streamReader = new StreamReader(pathToFile);
            string line = streamReader.ReadLine();
            while (line !=  null) 
            {
                content.Add(line);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return content;
        }

    }
}

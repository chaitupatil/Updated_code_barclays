using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools
{
    public class FileUtilities
    {
        public FileUtilities()
        {

        }

        public string ProcessCommand(string FileName, string Command)
        {
            FileDetails fileDetails = new FileDetails(FileName);

            if (Array.Exists(Constants.objArrVersion, element => element.Equals(Command)))
            {
                Console.WriteLine("File Version: {0}", fileDetails.Version());

            }
            else if (Array.Exists(Constants.objArrSize, element => element.Equals(Command)))
            {
                Console.WriteLine("File Size: {0}", fileDetails.Size());
            }
            else
            {
                Console.WriteLine("Invalid command parameter.");
            }

            return String.Empty;
        }
    }
}

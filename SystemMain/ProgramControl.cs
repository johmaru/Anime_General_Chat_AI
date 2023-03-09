using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_AI.SystemMain
{
    public class ProgramControl
    {
        public void Main()
        {
            
        }

        public void Initilize()
        {
            string folderName = @"./dll";

            System.IO.Directory.CreateDirectory(folderName);
        }
    }
}

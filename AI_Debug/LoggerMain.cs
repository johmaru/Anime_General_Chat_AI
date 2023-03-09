using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_AI.AI_Debug
{
    public class LoggerMain
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public void Main()
        {
            try
            {
                Logger.Info("Hello World");
            }
            catch (Exception e)
            {
                Logger.Error(e, "Catched Error. GoodBye");
            }
        }

    }
}

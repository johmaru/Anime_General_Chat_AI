using Chat_AI.AI_CONSOLE;
using Chat_AI.AI_CORE;
using Chat_AI.AI_Debug;
using Chat_AI.SystemMain;
using Newtonsoft.Json;

namespace Chat_AI;

internal class Program
{
    static void Main(string[] args)
    {
        ProgramControl pgControl = new ProgramControl();

        pgControl.Initilize();

        LoggerMain lgm = new LoggerMain();

        lgm.Main();

        JsonCore jsc = new JsonCore();

        jsc.Main();

        gptCore gpt = new gptCore();

        gpt.InitilizeAsync();

    }

}

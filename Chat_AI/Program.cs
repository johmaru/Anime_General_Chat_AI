using Microsoft.Extensions.DependencyInjection;
using OpenAI.GPT3;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.Managers;
using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using OpenAI.GPT3.Extensions;
using AI_CONSOLE;

namespace Chat_AI;

internal class Program
{
    static void Main(string[] args)
    {
        JsonMain jsm = new JsonMain();

        jsm.Initilize();
    }

}

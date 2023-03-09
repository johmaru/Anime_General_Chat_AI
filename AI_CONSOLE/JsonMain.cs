/*
using System.Reflection;
using Newtonsoft.Json;

namespace Chat_AI.AI_CONSOLE
{


    public class JsonMain{


    public void Initilize(){

        JsonSettings jsonSettings = new JsonSettings();

        using (var sr = new StreamReader("./Settings.Json", System.Text.Encoding.UTF8))
        {
            var JsonData = sr.ReadToEnd();

            jsonSettings = JsonConvert.DeserializeObject<JsonSettings>(JsonData);
        }

        var FileDir = Directory.GetParent(Assembly.GetExecutingAssembly().Location);

            if (File.Exists("Settings.json") == false)
{

    Console.WriteLine($"APIキーが設定されていません{FileDir}にあるJsonファイルを編集してください");

    var jsonsettings = new JsonSettings
    {
        APIKEY = "YourAPI-KEY",

        Organization = "Your-ID"
    };

    jsonsettings.SerializeToFile("Settings.json");
}

else if (jsonSettings.APIKEY == "YourAPI-KEY")
{
    Console.WriteLine($"APIキーが変更されていません。OpenAIのAPIを取得して{FileDir}にあるJsonファイルを編集してください");
}

else
{
   

    string Key = jsonSettings.APIKEY;

    Console.WriteLine($"APIKEY[{Key}]でAIを起動します。");
}
    }
}
}
*/
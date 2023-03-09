using System;
using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;

namespace Chat_AI.AI_CONSOLE
{
    public class JsonCore
    {
      
        
           public void Main()
            {
                //現在のファイル位置確認
                var FileDir = Directory.GetParent(Assembly.GetExecutingAssembly().Location);

                JsonSettings jsettings = new JsonSettings();



                var JsonFile = jsettings;



                if (File.Exists(@"./Settings.json") == false)
                {
                    // データを設定
                    jsettings.APIKEY = "Your API KEY";
                    jsettings.Organization = "Your ID";
                // JSON データにシリアライズ
                var jsonData = JsonConvert.SerializeObject(jsettings);

                using (var sw = new StreamWriter(@"./Settings.Json", false, System.Text.Encoding.UTF8))
                    {
                        // JSON データをファイルに書き込み
                        sw.Write(jsonData);
                    }

                    // シリアライズされたデータを表示
                    Console.WriteLine($"{FileDir}に移動してSettings.jsonファイルを編集してください");

                    Console.ReadKey();
                }

                else
                {
                    //デシリアライズ
                    using (var sr = new StreamReader(@"./Settings.Json", System.Text.Encoding.UTF8))
                    {
                        var JsonData = sr.ReadToEnd();

                        jsettings = JsonConvert.DeserializeObject<JsonSettings>(JsonData);

                        if (jsettings.APIKEY == "Your API KEY")
                        {
                            Console.WriteLine($"APIキーが変更されていません。OpenAIのAPIを取得して{FileDir}にあるJsonファイルを編集してください");

                            Console.ReadKey();
                        
                            return;
                        }

                        else
                        {
                            string Key = jsettings.APIKEY;

                            Console.WriteLine($"APIKEY[{Key}]でAIを起動します。");

                            Console.ReadKey();
                        }

                    }

                }

               
            }
        }
    }


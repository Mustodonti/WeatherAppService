using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace WeatherAppService
{
    public static class DataInJSON
    {
        object RootObject;
        public static async void WriteToFile(string path, object RootObject)
        {
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                string p = JsonConvert.SerializeObject(RootObject, Formatting.Indented);
                await sw.WriteAsync(p);
            }
        }
        public static async void ReadFromFile(string path, ref RootObject)
        {
            using (StreamReader sw = new StreamReader(path, Encoding.Default))
            {
                var pds = JsonConvert.DeserializeObject(sw.ReadToEnd,Type );
                await sw.WriteAsync(p);
            }
        }
    }
}

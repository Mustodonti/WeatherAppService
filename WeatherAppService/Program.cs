using RestSharp;
using System;
using System.Net;
using System.IO;

namespace WeatherAppService
{
    class Program
    {
        static void Main(string[] args)
        {
            string city_name="London", API_key= "2d6d053b6a777cd0fe236dd2c0d9aa22";

            Console.WriteLine("Hello World!");
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", city_name, API_key);
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
        }
    }
}

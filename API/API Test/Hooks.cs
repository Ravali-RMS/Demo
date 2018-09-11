using Newtonsoft.Json;
using RestSharp;
using System;

namespace API_Test
{
   public class Hooks
    {   // Request
            private static string makeRequest()
        {
            var client = new RestClient(
                 "https://raw.githubusercontent.com/DylanCh/AlexaJobSearch/master/Indeed.json");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("accept", "application/json");
            return client.Execute(request).Content; //the Content (body) of the response
        }

//        string response = null;
//try {
//    response = makeRequest();
//    }
//catch (Exception e){
//    Console.WriteLine(e.Message);
//}
////Response
//var data = JsonConvert.DeserializeObject<DataModel>(response);
//        Console.WriteLine(string.Format("{0} coordinates: {1}, {2}",
//                   data.results[0].jobtitle,
//                   data.results[0].latitude,
//                   data.results[0].longitude));
    }
}

using HackHeroesApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HackHeroesApp.Services
{
    public class RestService
    {
        static string baseUrl = "http://localhost:5000/api/";

        public static async Task<ObservableCollection<QuestionModel>> GetQuestions()
        {
            string url = baseUrl + "questions";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<ObservableCollection<QuestionModel>>(result);
                return json;
            }

            return null;
        }

    }
}

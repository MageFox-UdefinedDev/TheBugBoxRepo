using BugBox.Core;
using BugBox.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BugBox.Services
{
    internal class BugServices : IServices
    {
        private HttpClient client;

        public BugServices()
        {
            client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000,
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Person> FindPerson(int id)
        {
            string uri = string.Format(Endpoints.FIND_PERSON, id);
            var responseJson = await GetUrl(uri);
            return JsonConvert.DeserializeObject<Person>(responseJson);
        }

        public async Task<Trap> FindTrap(int id)
        {
            string uri = string.Format(Endpoints.FIND_TRAP, id);
            var responseJson = await GetUrl(uri);
            return JsonConvert.DeserializeObject<Trap>(responseJson);
        }

        public async Task<List<Person>> GetAllPerson()
        {
            string uri = Endpoints.GET_PEOPLE;
            var responseJson = await GetUrl(uri);
            return JsonConvert.DeserializeObject<List<Person>>(responseJson);
        }

        public async Task<List<Trap>> GetAllTraps()
        {
            string uri = Endpoints.GET_TRAPS;
            var responseJson = await GetUrl(uri);
            return JsonConvert.DeserializeObject<List<Trap>>(responseJson);
        }

        public async Task<Person> AddPerson(Person person)
        {
            string uri = Endpoints.ADD_PERSON;
            HttpContent content = CreateHTTPContent(person);
            var responseJson = await PostForm(uri, content);
            return JsonConvert.DeserializeObject<Person>(responseJson);
        }

        public async Task<Trap> AddTrap(Trap trap)
        {
            string uri = Endpoints.ADD_PERSON;
            HttpContent content = CreateHTTPContent(trap);
            var responseJson = await PostForm(uri, content);
            return JsonConvert.DeserializeObject<Trap>(responseJson);
        }

        #region BASE SERVICES

        async public Task<string> PostForm(string endpoint, HttpContent content)
        {
            string responseContent = string.Empty;

            try
            {
                HttpResponseMessage response = null;
                response = await client.PostAsync(endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    responseContent = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrEmpty(responseContent))
                    {
                        throw new Exception("El objeto de salida del servicio es nulo o vacio");
                    }
                }
                else
                {
                    //ToDo Manage error
                }
            }
            catch (Exception)
            {
                //ToDo Manage error
            }

            return responseContent;
        }

        async public Task<string> GetUrl(string endpoint)
        {
            HttpResponseMessage response = null;

            string responseContent = string.Empty;
            try
            {
                response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    responseContent = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    //ToDo Manage error
                }
            }
            catch (Exception)
            {
                //ToDo Manage error
            }

            return responseContent;
        }

        private static HttpContent CreateHTTPContent(Object loginRequest)
        {
            string requestJson = JsonConvert.SerializeObject(loginRequest);
            return new StringContent(requestJson, Encoding.UTF8, "application/json");
        }

        #endregion BASE SERVICES
    }
}
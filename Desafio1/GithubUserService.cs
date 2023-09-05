using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Authenticators;

namespace Desafio1
{
    internal class GithubUserService
    {
        public GithubUserModel getGithubUser()
        {
            string url = "https://api.github.com/users/vini404";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            var response = client.Get(request);
            var user = JsonConvert.DeserializeObject<GithubUserModel>(response.Content.ToString());

            return user;
        }
    }
}

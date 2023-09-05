using RestSharp;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            GithubUserService githubUserService = new GithubUserService();
            var user = githubUserService.getGithubUser();
            Console.WriteLine(user);
            Console.Read();
        }

    }
}

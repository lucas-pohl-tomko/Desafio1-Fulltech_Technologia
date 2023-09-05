namespace Desafio1
{
    [Serializable]
    internal class GithubUserModel
    {
        public int id { get; set; }
        public string login { get; set; }
        public string avatar_url { get; set; }
        public bool site_admin { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}

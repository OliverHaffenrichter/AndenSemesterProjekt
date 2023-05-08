namespace AndenSemesterProjekt.Models
{
    public class Admin
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public Admin(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public Admin() { }

    }
}

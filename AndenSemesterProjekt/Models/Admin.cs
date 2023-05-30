namespace AndenSemesterProjekt.Models
{
    /// <summary>
    /// Only the admin needs to be able to login in our current model, therefore this class is used to contain the admin login information
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// Property to hold the username of the admin
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Property to hold the password of the admin
        /// </summary>
        public string Password { get; set; }

        public Admin(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public Admin() { }

    }
}

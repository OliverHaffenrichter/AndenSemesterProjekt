using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Mock
{
    public class MockAdmin
    {
        private static List<Admin> admins = new List<Admin>() {
            new Admin("admin","admin"),
           
        };


        public static List<Admin> GetMockAdmin()
        {
            return admins;
        }
    }
}

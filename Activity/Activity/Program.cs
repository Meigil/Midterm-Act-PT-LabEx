using System;
namespace UserNmaespace
{
    public class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;  
        }
        public bool verifyLogin (string id, string pass)
        {
            return this.user_id.Equals(id) && this.user_password.Equals(pass);
        }
        public void updatePassword (string newPassword)
        {
            this.user_password = newPassword;
            Console.WriteLine("Password updated successfully.");

        }

    }
    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
        }

        public void updatePassword(string newPassword)
        {
            base.updatePassword(newPassword);
            Console.WriteLine("Admin password updated.");

        }
        public void updateAdminName(string name) { 
          this.admin_name = name;
            Console.WriteLine($"Admin name updated: {this.admin_name}");

        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            User user = new User("user1", "password123");
            Console.WriteLine(user.verifyLogin("user1", "password123") ? "Login successful" : "Login failed");

            
            Administrator admin = new Administrator("Admin1", "admin1", "adminPass");
            admin.updatePassword("newAdminPass");
            admin.updateAdminName("whshshs");
        }
    }

}

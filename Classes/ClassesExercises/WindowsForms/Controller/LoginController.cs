using System.Windows.Forms;
using WindowsForms.Model;

namespace WindowsForms.Controller
{
    public class LoginController
    {
        public bool IsAvailable(User user)
        {
            return (user.Login == "admin" && user.Password == "123");

        }
    }
}

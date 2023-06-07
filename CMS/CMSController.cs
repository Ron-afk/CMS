// See https://aka.ms/new-console-template for more information
namespace CMS
{
    partial class Program
    {
        public class CMSController : ICMSController
        {
            private readonly IUser _user;
            private readonly IMenu _menu;

            public CMSController(IUser user, IMenu menu)
            {
                _user = user;
                _menu = menu;
            }
            public void Start()
            {
                do
                {
                    _user.Login();
                } while (!_user.IsUserLogin);

                _menu.ShowMenu();

            }
        }
    }
}

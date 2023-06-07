// See https://aka.ms/new-console-template for more information
namespace CMS
{
    public interface IUser
    {
        bool IsUserLogin { get; set; }

        void Login();
    }
}
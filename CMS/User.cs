// See https://aka.ms/new-console-template for more information
namespace CMS
{
    partial class Program
    {
        public class User : IUser
        {
            public bool IsUserLogin { get; set; }

            public void Login()
            {
                string username;
                string password;
                username = CmdReader("请输入用户名:");
                if (username != "Ron")
                {
                    Console.WriteLine("查无此人");
                    return;
                }

                password = CmdReader("请输入密码：");
                if (password != "123456")
                {
                    Console.WriteLine("密码错误");
                    return;
                }
                IsUserLogin = true;
            }
        }
    }
}

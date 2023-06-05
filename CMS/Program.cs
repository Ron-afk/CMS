// See https://aka.ms/new-console-template for more information
namespace CMS
{
    class Program
    {
        static string CmdReader(string instruction)
        {
            Console.WriteLine(instruction);
            return Console.ReadLine();
        }

        public class User
        {
            public bool isUserLogin;

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
                isUserLogin = true;
            }
        }

        public class Menu
        {
            public void ShowMenu()
            {
                bool isExist = false;
                while (!isExist)
                {

                    string choise = CmdReader("1.客户管理\n2.预约管理\n3.系统设置\n4.退出");
                    switch (choise)
                    {
                        case "1":
                            Console.WriteLine("客户管理");
                            break;
                        case "2":
                            Console.WriteLine("预约管理");
                            break;
                        case "3":
                            Console.WriteLine("系统设置");
                            break;
                        case "4":
                            isExist = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public class CMSController
        {
            public void Start(User user, Menu menu)
            {
                do
                {
                    user.Login();
                } while (!user.isUserLogin);

                menu.ShowMenu();
                
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=====客户管理系统=====");
            Console.WriteLine("请登录");
            bool isExist = false;
            
            // initialize user
            User user = new User();

            // initialize menu
            Menu menu = new Menu();

            CMSController controller = new CMSController();

            controller.Start(user, menu);

            
            Console.WriteLine("再见！");
            Console.Read();
        }        
    }
}

// See https://aka.ms/new-console-template for more information
namespace CMS
{
    partial class Program
    {
        public class Menu : IMenu
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
    }
}

// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
namespace CMS
{
    public partial class Program
    {
        static string CmdReader(string instruction)
        {
            Console.WriteLine(instruction);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            ServiceCollection collection = new ServiceCollection();
            collection.AddScoped<IUser, User>();
            collection.AddScoped<IMenu, Menu>();
            collection.AddScoped<ICMSController, CMSController>();

            var serviceProvider = collection.BuildServiceProvider();

            var cmsController = serviceProvider.GetService<ICMSController>();

            cmsController.Start();
            
            Console.WriteLine("再见！");
            Console.Read();
        }        
    }
}

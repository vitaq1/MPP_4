using System;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        public static async Task Main()
        {
            await new Pipeline().Generate(2,
                @"C:\Users\User\Desktop\СПП4\GeneratedTests",
                @"C:\Users\User\Desktop\СПП4\TestProject\TestClass.cs",
                @"C:\Users\User\Desktop\СПП4\TestProject\AnotherTestClass.cs"); 
        }
    }
}

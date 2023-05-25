using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();

            foreach(Type type in types)
            {
                Console.WriteLine("Full name: {0}", type.FullName);
                Console.WriteLine($"Class name: {type.Name}");

                MethodInfo[] methods = type.GetMethods();
                foreach(var method in methods)
                {
                    Console.WriteLine($"Method name: {method.Name}");

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach(var param in parameters)
                    {
                        Console.WriteLine($"Parameter: {param.Name},{param.ParameterType}");
                    }

                    ConstructorInfo[] constructors = type.GetConstructors(); ;
                    foreach (var constructor in constructors)
                    {
                        Console.WriteLine($"Constructor name: {constructor.Name}");
                    }
                }
            }
            Console.ReadLine();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            var assembly = typeof(Humano).Assembly;
            Type humanType = typeof(Humano);
            var humanType2 = Type.GetType("ConsoleApplication1.Humano");
            object newHuman = Activator.CreateInstance(humanType);

            Console.WriteLine("\n==========================CAPTURANDO ASSEMBLY DA CLASSE=========================\n");
            Console.WriteLine(assembly/*.ToString()*/);
            Console.WriteLine("\n==========================CAPTURANDO TYPE DA CLASSE=========================\n");
            Console.WriteLine(humanType);
            Console.WriteLine("\n==========================CAPTURANDO Classe dentro do namespace=========================\n");
            Console.WriteLine(humanType2);
            Console.WriteLine("\n==========================Activator gerando nova instancia=========================\n");
            Console.WriteLine(newHuman);
            Console.WriteLine("\n===========================Capturando Propriedades========================\n");
            PropertyInfo[] properties = humanType.GetProperties();
            foreach (var propertyInfo in properties)
            {
                Console.WriteLine(propertyInfo.Name);
            }
            Console.WriteLine("\n=========================Capturando propriedade publica==========================\n");
            PropertyInfo property = humanType.GetProperty("Idade");
            Console.WriteLine(property.GetValue(newHuman, null));
            Console.WriteLine("\n=========================Atribuindo valores usando SetValue==========================\n");
            PropertyInfo propertySet = humanType.GetProperty("Idade");
            propertySet.SetValue(newHuman, 23, null);
            Console.WriteLine(propertySet.GetValue(newHuman, null));
            Console.WriteLine("\n=========================Executando Métodos==========================\n");
            humanType.InvokeMember("Respirar", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, newHuman, null);
            humanType.InvokeMember("Piscar", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, newHuman, null);
            humanType.InvokeMember("SentirFome", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance, null, newHuman, null);
            Console.WriteLine("\n=========================Executando Métodos não publicos(private)==========================\n");
            humanType.InvokeMember("CantarNoBanheiro", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic, null, newHuman, null);
            Console.WriteLine("\n=========================Executando Métodos com parametros==========================\n");
            humanType.InvokeMember("PensarAlgo", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, newHuman, new object[] { "em viajar.", DateTime.Now });

            Console.ReadKey();
        }
    }
}

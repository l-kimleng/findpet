using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPet
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solver();
            s.Mock();

            var formatedData = TransformResult(s.Houses);
            Console.WriteLine("House\t\t1\t\t2\t\t3\t\t4\t\t5");
            foreach(var data in formatedData)
            {
                var str = (data.Key.Length >= 9) ? data.Key.Substring(0, 4) + "..." : data.Key;
                foreach(var ele in data.Value)
                {
                    var value = ele;
                    if (ele.Length >= 9)
                    {
                        value = value.Substring(0, 4) + "...";
                    }
                    
                    str += "\t\t" + value;
                }
                Console.WriteLine(str);                    
            }
            Console.ReadLine();
        }

        private static Dictionary<string, List<string>> TransformResult(House[] houses)       
        {
            var result = new Dictionary<string, List<string>>();
            for (int index = 0; index < houses.Length; index++)
            {
                var obj = houses[index];
                foreach (var prop in obj.GetType().GetProperties())
                {
                    var key = prop.Name;
                    if (!result.ContainsKey(key))
                    {
                        result[key] = new List<string>();
                    }
                    result[key].Add((string)prop.GetValue(obj, null));
                }
            }
            return result;
        }
    }
}

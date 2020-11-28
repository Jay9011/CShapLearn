using System;
using System.Collections.Generic;

namespace GenericClass
{
    class Collections
    {
        static void Main(string[] args)
        {
            var list = new List<string> {
                "test1"
                ,"test2"
                ,"test3"
                ,"test4"
            };

            var dictionary = new Dictionary<int, string>
            {
                {1, "test1" }
                ,{2, "test2"}
                ,{3, "test3"}
                ,{4, "test4"}
            };

            var people = new List<Person>
            {
                new Person{Name = "윤종섭", Age = 31, Phone = "010-5258-2736", No = 0}
            };

            var temp_person = new Person();
            temp_person.No = people.Count;
            temp_person.Name = "테스터1";
            temp_person.Age = 25;
            temp_person.Phone = "000-0000-0000";

            people.Add(temp_person);

            temp_person = new Person()
            {
                No = people.Count,
                Name = "테스터2",
                Age = 31,
                Phone = "010-1234-5678"
            };
            people.Add(temp_person);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

        }
    }
}

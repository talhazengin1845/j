using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Person
    {
        public Person()
        {
            Persons= new List<Person>();
        }

        // iki tane constructor kurdum çünkü farklı initializion'lar istedim.
        // this() sayesinde üsteki constructor'ın içeriğini alttakine ekledik. Eğer üsttekinin arg'ları olsaydı this'in içine eklerdik.
        public Person(string lastName, int id) : this() 
        {
            this.LastName = lastName;
            this.Id = id;
        }

        public string Name;
        public string LastName;
        public int Id;
        public List<Person> Persons;


        /* person adındaki object'e bir name attribute'u kaydediyoruz ve return edip başka bir object'e aktarıyoruz.
           yani aslında Person class'ının içinde küçük yeni bir class'ımsı object oluşturuluyor. Böylece spesifik
           bir kod dizini direk console'daki object type olan bir variable'a aktarılabiliyor.
        */
        // static keyword'lü method'lar object yaratılmadan direk class aracılığı ile kullanılırlar.
        public static Person GetPersonNameList(string name)
        {
            Person person = new Person();
            person.Name = name;
            return person;
        }

        public void Introduce(string toSomeone)
        {
            Console.WriteLine("Hello " + toSomeone + ", my name is " + Name);
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            // person.Name = "Talha"; bunu console'da tanımlamak yerine class'ın kendinde tanımlayarak cleanCode yaptık.
            Person personFirst = Person.GetPersonNameList("Talha"); // dikkat et burda bir daha new Person() demedik.
            personFirst.Introduce("Abdürrrezzak Kıllıbacak");

            Person personSecond = new Person("ZENGIN", 2146);
            Console.WriteLine(personSecond.LastName + " - " + personSecond.Id);


            // eğer yukardaki gibi karmaşık ve kalabalık constructor yığını istemiyorsan
            Person personThird = new Person()
            {
                LastName = "ZENGIN",
                Id = 2146
            };

            Console.WriteLine(personThird.Id + " - " + personThird.LastName);



        }
    }
}

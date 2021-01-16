using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazirMEtotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcı adı tanımalama kontrolü. 

            Console.WriteLine("Kullanıcı adınızı oluşturun");
            string username = Console.ReadLine();
            username.ToLower();

            if (username.StartsWith("j"))
            {
                Console.WriteLine("Kullanıcı adı J ile başlayamaz.");
            }
            else if (username.Contains("j"))
            {
                Console.WriteLine("Kullanıcı adı j içeremez.");
            }
            else
            {
                char[] usernameArray = username.ToCharArray(0, 3);

                Console.WriteLine(" Kullanıcı adınızın ilk 3 karakterini ilk şirfeniz olarak kullanabilirsiniz, giriş yaptıktan sonra sifrenizi değiştirme ekranı gelecektir.");
                Console.Write("İlk şifreniz:");
                foreach (char ch in usernameArray)
                {
                    Console.Write(ch);
                }

            }

            Console.ReadLine();
        }

    }
}

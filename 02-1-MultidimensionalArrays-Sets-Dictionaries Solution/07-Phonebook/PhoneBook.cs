using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Phonebook
{
    internal class PhoneBook
    {
        private static void Main(string[] args)
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

            string contactInformation = Console.ReadLine();
            string name = String.Empty;
            string number = String.Empty;

            while (contactInformation != "search")
            {
                string[] contacts = contactInformation.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                name = contacts[0];
                number = contacts[1];
                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = new List<string>();

                }
                phonebook[name].Add(number);

                contactInformation = Console.ReadLine();
            }

            string contactNameToSearch = Console.ReadLine();
            while (!String.IsNullOrEmpty(contactNameToSearch))
            {
                if (phonebook.ContainsKey(contactNameToSearch))
                {
                    Console.Write("{0} -> {1}", contactNameToSearch, String.Join(", ", phonebook[contactNameToSearch]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", contactNameToSearch);
                }

                contactNameToSearch = Console.ReadLine();
            }
        }
    }
}

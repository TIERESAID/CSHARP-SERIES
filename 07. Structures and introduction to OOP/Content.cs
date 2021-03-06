using System ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Structures_and_introduction_to_OOP
{
    struct Content
    {
        public string Date { get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public string Org {get; set;}
        public string Position {get; set;}

        public string Print()
        {
            return $"{Date} {Name, 10} {Surname, 10} {Org, 15}, {Position, 15}";
        }
        
        /// <summary>
        ///  Create a Notebook Entry 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="org"></param>
        /// <param name="positon"></param>
        public Content(string date , string name , string  surname , string org, string positon)
        {
            Date = date ;
            Name = name ;
            Surname = surname;
            Org = org ;
            Position = positon;
        }


    }
}
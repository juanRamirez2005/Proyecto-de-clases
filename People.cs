using Constructores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class People: IEnumerable<Person>
    {
        private List<Person> people;

        public People() 
        {
            people = new List<Person>();
        }

        public People(List<Person> people)
        {
            people = new List<Person>(people);
        }
        public IEnumerator<Person> GetEnumerator()
        {
            return people.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

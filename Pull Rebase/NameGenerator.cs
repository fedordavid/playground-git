using System;
using System.Linq;

namespace Pull_Rebase
{
    public class NameGenerator : INameGenerator
    {
        private string[] _names;
        public string Name { get; set; }

        public NameGenerator()
        {
            _names = new[] {"David", "Tomas", "Peter", "Pavol", "Juraj", "Martin"};
        }
        
        public string NewName()
        {
            return _names[new Random().Next(0, _names.Length)] + new Random().Next(_names.Length, 10000 * _names.Length);
        }
    }
}
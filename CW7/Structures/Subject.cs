using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CW7.Structures
{
    public class Subject
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            var toCheck = obj as Subject;
            return toCheck.Name == Name;
        }
    }
}
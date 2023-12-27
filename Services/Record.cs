using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algolia_search.Classes
{
    public class Record
    {
        public string Name { get; set; } = string.Empty;
        public string ObjectID { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"Name: {Name}, ObjectID: {ObjectID}";
        }
    }
}
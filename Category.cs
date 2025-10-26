using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lettheworld_burn
{
    public class Category
    {
        public string Name { get; set; }

        public Category()
        {
            this.Name = string.Empty;
        }

        public Category(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Category: {Name}";
        }
    }
}

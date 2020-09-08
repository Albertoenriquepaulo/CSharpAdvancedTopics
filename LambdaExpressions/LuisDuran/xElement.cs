using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions.LuisDuran
{
    public class xElement : IGroupElement, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int GetIdModified()
        {
            return Id * 100;
        }

        public string GetNameModified()
        {
            return $"ELEMENT_{Name}";
        }
    }
}

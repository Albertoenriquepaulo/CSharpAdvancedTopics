using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions.LuisDuran
{
    public interface IGroupElement
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GetIdModified();
        public string GetNameModified();

        public string GetContext(string contextName)
        {
            return "Context_" + contextName;
        }
    }
}

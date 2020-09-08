using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions.LuisDuran
{
    public class xGroup : IGroupElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public string mode { get; set; }


        ////private ObservableCollection<IGroupElement> groups1 = new ObservableCollection<xGroup>();
        ////private ObservableCollection<IGroupElement> element1 = new ObservableCollection<xElement>();

        ////public ObservableCollection<IGroupElement> Groups1
        ////{
        ////    get
        ////    {
        ////        switch (mode)
        ////        {
        ////            case "2":
        ////                return element1;
        ////            case "3":
        ////                return groups1;
        ////        }
        ////        return null;
        ////    }
        ////    // set { myVar = value; }
        ////}




        public int GetIdModified()
        {
            return Id * 10;
        }

        public string GetNameModified()
        {
            return $"GROUP_{Name}";
        }
    }
}

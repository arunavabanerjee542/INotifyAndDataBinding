using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyAndDataBinding
{
    public class ShowName: Observer
    {

        private string _name;

        public string Name
        {
            get
            {
                if(_name == null)
                {
                    return "UNKNOWN";
                }
                return _name;
            }

            set
            {
                _name = value;
                OnChange("Name");
            }


        }



    }
}

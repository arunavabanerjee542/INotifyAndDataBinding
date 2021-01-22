using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyAndDataBinding
{
    public class View
    {

        public ShowName Show { get; set; }
        public BackGround bg { get; set; }

        public View()
        {
            Show = new ShowName();
            bg = new BackGround();
        }

      


    }
}

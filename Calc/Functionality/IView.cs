using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Functionality
{
    public interface IView
    {

        void Show();
        object GetData();
        void UpdateData(object data);
    }
}

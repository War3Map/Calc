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
        (string, string) GetData();
        void UpdateData(object data);
    }
}

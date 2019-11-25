using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorCore;
using Calc.Functionality;
using Ninject.Modules;
using Ninject;


namespace Calc.Presenters
{   
    class CalcPresenter : NinjectModule
    {
        IView calcView;
        Calculator calc;

        public override void Load()
        {
            Bind<IView>().To<MainView>();
        }

        void Compute()
        {           
            calcView.UpdateData(AnalyzeData(calcView.GetData()));
        }

        object AnalyzeData(object data)
        {
            IKernel iocContainer = new StandardKernel();
            MainView gui = iocContainer.Get<MainView>();
            data = gui.GetData();
            

            return 0;
        }

        public CalcPresenter(IView calcView)
        {
            this.calcView = calcView;
            calc = new Calculator();
        }


    }
}

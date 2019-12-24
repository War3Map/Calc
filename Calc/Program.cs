using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Calc.Functionality;
using Calc.Presenters;

namespace Calc
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IKernel kernel = new StandardKernel();
            //забиндим всё
            kernel.Bind<IView>().To<MainView>();
            kernel.Bind<IPresenter>().To<CalcPresenter>();



            //здесь дб IoC
           // Application.Run(kernel.Get<MainView>(kernel));
            Application.Run(new MainView(kernel));


        }
    }
}

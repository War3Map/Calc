using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Ninject.Parameters;
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
            kernel.Bind<IView>().To<MainView>().WithConstructorArgument("kernel",kernel); 
            //здесь дб IoC
            Application.Run(kernel.Get<MainView>());
            //Application.Run(new MainView(kernel));


        }
    }
}

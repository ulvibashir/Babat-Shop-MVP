using ShopMVP.Models;
using ShopMVP.Presenters;
using ShopMVP.Services;
using ShopMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

namespace ShopMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region IOC setting
            IoC.Register<ShopForm, IShopView>();
            IoC.Register<ProductForm, IProductView>();
            IoC.Register<ProductPresenter>();
            IoC.Register<ShopPresenter>();
            IoC.Register<LocalProductService, IProductService>();
            IoC.Build();



            #endregion

            ShopPresenter shopPresenter = IoC.Resolve<ShopPresenter>();

            Application.Run((Form)shopPresenter.View);
        }
    }
}

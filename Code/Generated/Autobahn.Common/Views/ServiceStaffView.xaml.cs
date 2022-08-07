//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceStaffView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServiceStaffView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceStaffView : ContentPage
    {
        /// <summary>
        /// Inject the IServiceStaffViewModel as the data context for the view
        /// </summary>
        public ServiceStaffView(IServiceStaffViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

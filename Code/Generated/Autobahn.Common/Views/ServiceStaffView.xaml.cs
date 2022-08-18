//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceStaffView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServiceStaffView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceStaffView : ContentPage
    {
        /// <summary>
        /// Inject the IServiceStaff View Model as the data context for the view
        /// </summary>
        public ServiceStaffView(Interfaces.IServiceStaff vm)
        {
            BindingContext  = vm;
        }
    }
}

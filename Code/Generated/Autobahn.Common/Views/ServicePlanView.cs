//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServicePlanView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ServicePlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicePlanView : ContentPage
    {
        /// <summary>
        /// Inject the ServicePlanViewModel as the data context for the view
        /// </summary>
        public ServicePlanView(ServicePlanViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

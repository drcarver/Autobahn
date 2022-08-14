//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServicePlanView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The ServicePlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicePlanView : ContentPage
    {
        /// <summary>
        /// Inject the IServicePlan View Model as the data context for the view
        /// </summary>
        public ServicePlanView(Interfaces.IServicePlan vm)
        {
            BindingContext  = vm;
        }
    }
}

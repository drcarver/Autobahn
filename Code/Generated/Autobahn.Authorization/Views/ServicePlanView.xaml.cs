//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ServicePlanView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
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

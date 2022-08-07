//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RequiredImmunizationView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RequiredImmunizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequiredImmunizationView : ContentPage
    {
        /// <summary>
        /// Inject the IRequiredImmunizationViewModel as the data context for the view
        /// </summary>
        public RequiredImmunizationView(IRequiredImmunizationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

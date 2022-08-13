//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   RequiredImmunizationView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The RequiredImmunizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequiredImmunizationView : ContentPage
    {
        /// <summary>
        /// Inject the IRequiredImmunization View Model as the data context for the view
        /// </summary>
        public RequiredImmunizationView(Interfaces.IRequiredImmunization vm)
        {
            BindingContext  = vm;
        }
    }
}

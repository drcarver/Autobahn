//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonImmunizationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonImmunizationView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonImmunization View Model as the data context for the view
        /// </summary>
        public PersonImmunizationView(Interfaces.IPersonImmunization vm)
        {
            BindingContext  = vm;
        }
    }
}

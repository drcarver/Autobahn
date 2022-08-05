//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAllergyView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonAllergyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAllergyView : ContentPage
    {
        /// <summary>
        /// Inject the PersonAllergyViewModel as the data context for the view
        /// </summary>
        public PersonAllergyView(PersonAllergyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

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
        /// Inject the IPersonAllergyViewModel as the data context for the view
        /// </summary>
        public PersonAllergyView(IPersonAllergyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

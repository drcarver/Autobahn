//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonAllergyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonAllergyView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonAllergy View Model as the data context for the view
        /// </summary>
        public PersonAllergyView(Interfaces.IPersonAllergy vm)
        {
            BindingContext  = vm;
        }
    }
}

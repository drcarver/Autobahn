//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonFamilyView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonFamilyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonFamilyView : ContentPage
    {
        /// <summary>
        /// Inject the PersonFamilyViewModel as the data context for the view
        /// </summary>
        public PersonFamilyView(PersonFamilyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

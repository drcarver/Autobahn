//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonBirthplaceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonBirthplaceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonBirthplaceView : ContentPage
    {
        /// <summary>
        /// Inject the PersonBirthplaceViewModel as the data context for the view
        /// </summary>
        public PersonBirthplaceView(PersonBirthplaceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

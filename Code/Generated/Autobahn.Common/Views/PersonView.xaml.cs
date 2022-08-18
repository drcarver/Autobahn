//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonView : ContentPage
    {
        /// <summary>
        /// Inject the IPerson View Model as the data context for the view
        /// </summary>
        public PersonView(Interfaces.IPerson vm)
        {
            BindingContext  = vm;
        }
    }
}

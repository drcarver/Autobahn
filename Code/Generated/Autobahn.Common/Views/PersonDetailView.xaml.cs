//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDetailView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDetailView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDetail View Model as the data context for the view
        /// </summary>
        public PersonDetailView(Interfaces.IPersonDetail vm)
        {
            BindingContext  = vm;
        }
    }
}

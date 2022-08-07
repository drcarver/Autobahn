//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDetailView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDetailView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDetailView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDetailViewModel as the data context for the view
        /// </summary>
        public PersonDetailView(IPersonDetailViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

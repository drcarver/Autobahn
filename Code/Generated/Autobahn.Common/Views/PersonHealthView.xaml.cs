//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHealthView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHealthView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonHealthViewModel as the data context for the view
        /// </summary>
        public PersonHealthView(IPersonHealthViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

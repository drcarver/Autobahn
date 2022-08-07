//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonStatusView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonStatusViewModel as the data context for the view
        /// </summary>
        public PersonStatusView(IPersonStatusViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

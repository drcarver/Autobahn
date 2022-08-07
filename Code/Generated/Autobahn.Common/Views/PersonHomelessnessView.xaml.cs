//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHomelessnessView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHomelessnessView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHomelessnessView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonHomelessnessViewModel as the data context for the view
        /// </summary>
        public PersonHomelessnessView(IPersonHomelessnessViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

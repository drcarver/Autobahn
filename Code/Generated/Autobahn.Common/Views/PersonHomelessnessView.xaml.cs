//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHomelessnessView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHomelessnessView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHomelessnessView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonHomelessness View Model as the data context for the view
        /// </summary>
        public PersonHomelessnessView(Interfaces.IPersonHomelessness vm)
        {
            BindingContext  = vm;
        }
    }
}

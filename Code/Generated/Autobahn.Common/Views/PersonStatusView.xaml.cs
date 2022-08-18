//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonStatusView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonStatusView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonStatus View Model as the data context for the view
        /// </summary>
        public PersonStatusView(Interfaces.IPersonStatus vm)
        {
            BindingContext  = vm;
        }
    }
}

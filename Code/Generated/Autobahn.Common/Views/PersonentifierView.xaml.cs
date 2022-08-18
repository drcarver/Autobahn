//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonentifierView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonentifierView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonentifier View Model as the data context for the view
        /// </summary>
        public PersonentifierView(Interfaces.IPersonentifier vm)
        {
            BindingContext  = vm;
        }
    }
}

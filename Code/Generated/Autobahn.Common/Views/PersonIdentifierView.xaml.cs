//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonIdentifierView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonIdentifierView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonIdentifier View Model as the data context for the view
        /// </summary>
        public PersonIdentifierView(Interfaces.IPersonIdentifier vm)
        {
            BindingContext  = vm;
        }
    }
}

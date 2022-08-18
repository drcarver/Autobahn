//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDigitalAccessView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDigitalAccessView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDigitalAccess View Model as the data context for the view
        /// </summary>
        public PersonDigitalAccessView(Interfaces.IPersonDigitalAccess vm)
        {
            BindingContext  = vm;
        }
    }
}

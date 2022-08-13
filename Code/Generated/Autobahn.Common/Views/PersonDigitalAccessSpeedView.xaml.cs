//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDigitalAccessSpeedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDigitalAccessSpeedView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDigitalAccessSpeed View Model as the data context for the view
        /// </summary>
        public PersonDigitalAccessSpeedView(Interfaces.IPersonDigitalAccessSpeed vm)
        {
            BindingContext  = vm;
        }
    }
}

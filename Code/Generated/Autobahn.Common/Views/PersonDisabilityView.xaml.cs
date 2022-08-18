//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonDisabilityView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDisabilityView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonDisability View Model as the data context for the view
        /// </summary>
        public PersonDisabilityView(Interfaces.IPersonDisability vm)
        {
            BindingContext  = vm;
        }
    }
}

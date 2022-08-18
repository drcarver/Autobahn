//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonMilitaryView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonMilitaryView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonMilitary View Model as the data context for the view
        /// </summary>
        public PersonMilitaryView(Interfaces.IPersonMilitary vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonFamilyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonFamilyView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonFamily View Model as the data context for the view
        /// </summary>
        public PersonFamilyView(Interfaces.IPersonFamily vm)
        {
            BindingContext  = vm;
        }
    }
}

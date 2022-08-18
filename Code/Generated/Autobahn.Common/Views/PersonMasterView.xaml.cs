//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMasterView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonMasterView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonMasterView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonMaster View Model as the data context for the view
        /// </summary>
        public PersonMasterView(Interfaces.IPersonMaster vm)
        {
            BindingContext  = vm;
        }
    }
}

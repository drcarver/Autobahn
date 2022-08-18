//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonHealthView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonHealthView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonHealth View Model as the data context for the view
        /// </summary>
        public PersonHealthView(Interfaces.IPersonHealth vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   RubricView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The RubricView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RubricView : ContentPage
    {
        /// <summary>
        /// Inject the IRubric View Model as the data context for the view
        /// </summary>
        public RubricView(Interfaces.IRubric vm)
        {
            BindingContext  = vm;
        }
    }
}

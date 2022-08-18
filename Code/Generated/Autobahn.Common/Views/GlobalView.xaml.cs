//**********************************************************
//* DomainName: Common Models
//* FileName:   GlobalView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The GlobalView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlobalView : ContentPage
    {
        /// <summary>
        /// Inject the IGlobal View Model as the data context for the view
        /// </summary>
        public GlobalView(Interfaces.IGlobal vm)
        {
            BindingContext  = vm;
        }
    }
}

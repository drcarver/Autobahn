//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildHealthView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildHealthView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildHealthView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildHealth View Model as the data context for the view
        /// </summary>
        public ELChildHealthView(Interfaces.IELChildHealth vm)
        {
            BindingContext  = vm;
        }
    }
}

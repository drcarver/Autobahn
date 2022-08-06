//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildHealthView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildHealthView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildHealthView : ContentPage
    {
        /// <summary>
        /// Inject the ELChildHealthViewModel as the data context for the view
        /// </summary>
        public ELChildHealthView(ELChildHealthViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

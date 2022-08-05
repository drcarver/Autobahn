//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildServiceView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildServiceView : ContentPage
    {
        /// <summary>
        /// Inject the ELChildServiceViewModel as the data context for the view
        /// </summary>
        public ELChildServiceView(ELChildServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

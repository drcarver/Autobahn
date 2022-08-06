//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffView : ContentPage
    {
        /// <summary>
        /// Inject the ELStaffViewModel as the data context for the view
        /// </summary>
        public ELStaffView(ELStaffViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

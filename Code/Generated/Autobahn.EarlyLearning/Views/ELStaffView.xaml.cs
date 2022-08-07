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
        /// Inject the IELStaffViewModel as the data context for the view
        /// </summary>
        public ELStaffView(IELStaffViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

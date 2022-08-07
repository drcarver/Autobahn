//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffEmploymentView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IELStaffEmploymentViewModel as the data context for the view
        /// </summary>
        public ELStaffEmploymentView(IELStaffEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

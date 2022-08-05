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
        /// Inject the ELStaffEmploymentViewModel as the data context for the view
        /// </summary>
        public ELStaffEmploymentView(ELStaffEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

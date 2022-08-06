//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELEnrollmentOtherFundingView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELEnrollmentOtherFundingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELEnrollmentOtherFundingView : ContentPage
    {
        /// <summary>
        /// Inject the ELEnrollmentOtherFundingViewModel as the data context for the view
        /// </summary>
        public ELEnrollmentOtherFundingView(ELEnrollmentOtherFundingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

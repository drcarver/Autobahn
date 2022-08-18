//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentOtherFundingView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELEnrollmentOtherFundingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELEnrollmentOtherFundingView : ContentPage
    {
        /// <summary>
        /// Inject the IELEnrollmentOtherFunding View Model as the data context for the view
        /// </summary>
        public ELEnrollmentOtherFundingView(Interfaces.IELEnrollmentOtherFunding vm)
        {
            BindingContext  = vm;
        }
    }
}

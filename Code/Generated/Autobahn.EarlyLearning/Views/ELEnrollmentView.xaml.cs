//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELEnrollmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELEnrollmentView : ContentPage
    {
        /// <summary>
        /// Inject the IELEnrollment View Model as the data context for the view
        /// </summary>
        public ELEnrollmentView(Interfaces.IELEnrollment vm)
        {
            BindingContext  = vm;
        }
    }
}

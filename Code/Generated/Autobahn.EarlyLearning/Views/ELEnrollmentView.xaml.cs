//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELEnrollmentView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELEnrollmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELEnrollmentView : ContentPage
    {
        /// <summary>
        /// Inject the IELEnrollmentViewModel as the data context for the view
        /// </summary>
        public ELEnrollmentView(IELEnrollmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

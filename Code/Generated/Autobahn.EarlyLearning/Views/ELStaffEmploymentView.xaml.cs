//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEmploymentView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IELStaffEmployment View Model as the data context for the view
        /// </summary>
        public ELStaffEmploymentView(Interfaces.IELStaffEmployment vm)
        {
            BindingContext  = vm;
        }
    }
}

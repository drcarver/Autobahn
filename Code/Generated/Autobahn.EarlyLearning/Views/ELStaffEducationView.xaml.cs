//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEducationView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffEducationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffEducationView : ContentPage
    {
        /// <summary>
        /// Inject the IELStaffEducation View Model as the data context for the view
        /// </summary>
        public ELStaffEducationView(Interfaces.IELStaffEducation vm)
        {
            BindingContext  = vm;
        }
    }
}

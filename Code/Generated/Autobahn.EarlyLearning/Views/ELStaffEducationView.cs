//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffEducationView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELStaffEducationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELStaffEducationView : ContentPage
    {
        /// <summary>
        /// Inject the ELStaffEducationViewModel as the data context for the view
        /// </summary>
        public ELStaffEducationView(ELStaffEducationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

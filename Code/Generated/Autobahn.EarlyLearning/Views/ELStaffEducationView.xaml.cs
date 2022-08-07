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
        /// Inject the IELStaffEducationViewModel as the data context for the view
        /// </summary>
        public ELStaffEducationView(IELStaffEducationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

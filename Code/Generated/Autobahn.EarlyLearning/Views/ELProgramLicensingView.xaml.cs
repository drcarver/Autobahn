//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELProgramLicensingView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELProgramLicensingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELProgramLicensingView : ContentPage
    {
        /// <summary>
        /// Inject the IELProgramLicensing View Model as the data context for the view
        /// </summary>
        public ELProgramLicensingView(Interfaces.IELProgramLicensing vm)
        {
            BindingContext  = vm;
        }
    }
}

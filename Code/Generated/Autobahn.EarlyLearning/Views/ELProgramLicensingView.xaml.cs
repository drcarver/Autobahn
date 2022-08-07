//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELProgramLicensingView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELProgramLicensingView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELProgramLicensingView : ContentPage
    {
        /// <summary>
        /// Inject the IELProgramLicensingViewModel as the data context for the view
        /// </summary>
        public ELProgramLicensingView(IELProgramLicensingViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

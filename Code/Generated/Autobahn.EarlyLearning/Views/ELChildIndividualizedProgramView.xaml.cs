//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildIndividualizedProgramView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildIndividualizedProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildIndividualizedProgramView : ContentPage
    {
        /// <summary>
        /// Inject the ELChildIndividualizedProgramViewModel as the data context for the view
        /// </summary>
        public ELChildIndividualizedProgramView(ELChildIndividualizedProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

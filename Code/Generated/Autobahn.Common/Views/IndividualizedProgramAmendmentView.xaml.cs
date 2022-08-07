//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramAmendmentView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramAmendmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAmendmentView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramAmendmentViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAmendmentView(IIndividualizedProgramAmendmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

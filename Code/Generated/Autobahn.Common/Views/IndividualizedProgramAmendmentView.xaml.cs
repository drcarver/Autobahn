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
        /// Inject the IndividualizedProgramAmendmentViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramAmendmentView(IndividualizedProgramAmendmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

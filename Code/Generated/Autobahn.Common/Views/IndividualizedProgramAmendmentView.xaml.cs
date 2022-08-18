//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAmendmentView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramAmendmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramAmendmentView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramAmendment View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramAmendmentView(Interfaces.IIndividualizedProgramAmendment vm)
        {
            BindingContext  = vm;
        }
    }
}

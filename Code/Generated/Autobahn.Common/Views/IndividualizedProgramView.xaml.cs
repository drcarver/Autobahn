//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramView(IIndividualizedProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

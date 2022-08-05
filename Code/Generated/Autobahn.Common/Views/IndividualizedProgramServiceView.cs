//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramServiceView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IndividualizedProgramServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IndividualizedProgramServiceViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramServiceView(IndividualizedProgramServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

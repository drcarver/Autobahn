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
        /// Inject the IndividualizedProgramViewModel as the data context for the view
        /// </summary>
        public IndividualizedProgramView(IndividualizedProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

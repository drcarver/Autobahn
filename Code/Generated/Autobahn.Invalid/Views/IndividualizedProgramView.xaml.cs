//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IndividualizedProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgram View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramView(Interfaces.IIndividualizedProgram vm)
        {
            BindingContext  = vm;
        }
    }
}

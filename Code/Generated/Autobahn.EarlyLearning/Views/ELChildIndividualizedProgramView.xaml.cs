//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildIndividualizedProgramView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildIndividualizedProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildIndividualizedProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildIndividualizedProgram View Model as the data context for the view
        /// </summary>
        public ELChildIndividualizedProgramView(Interfaces.IELChildIndividualizedProgram vm)
        {
            BindingContext  = vm;
        }
    }
}

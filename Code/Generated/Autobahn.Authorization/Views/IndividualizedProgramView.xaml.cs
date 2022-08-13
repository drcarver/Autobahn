//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
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

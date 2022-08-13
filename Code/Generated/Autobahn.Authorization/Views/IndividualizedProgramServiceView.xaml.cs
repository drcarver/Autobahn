//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramServiceView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The IndividualizedProgramServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndividualizedProgramServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IIndividualizedProgramService View Model as the data context for the view
        /// </summary>
        public IndividualizedProgramServiceView(Interfaces.IIndividualizedProgramService vm)
        {
            BindingContext  = vm;
        }
    }
}

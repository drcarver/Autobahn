//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDevelopmentalAssessmentView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildDevelopmentalAssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildDevelopmentalAssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildDevelopmentalAssessment View Model as the data context for the view
        /// </summary>
        public ELChildDevelopmentalAssessmentView(Interfaces.IELChildDevelopmentalAssessment vm)
        {
            BindingContext  = vm;
        }
    }
}

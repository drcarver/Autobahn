//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildDevelopmentalAssessmentView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildDevelopmentalAssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildDevelopmentalAssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the ELChildDevelopmentalAssessmentViewModel as the data context for the view
        /// </summary>
        public ELChildDevelopmentalAssessmentView(ELChildDevelopmentalAssessmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedScreenEnhancementView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancementView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedScreenEnhancementView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentNeedScreenEnhancementViewModel as the data context for the view
        /// </summary>
        public AssessmentNeedScreenEnhancementView(IAssessmentNeedScreenEnhancementViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

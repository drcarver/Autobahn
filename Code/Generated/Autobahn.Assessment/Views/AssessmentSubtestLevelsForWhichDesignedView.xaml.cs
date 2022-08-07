//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestLevelsForWhichDesignedView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesignedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestLevelsForWhichDesignedView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtestLevelsForWhichDesignedViewModel as the data context for the view
        /// </summary>
        public AssessmentSubtestLevelsForWhichDesignedView(IAssessmentSubtestLevelsForWhichDesignedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLevelsForWhichDesignedView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesignedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentLevelsForWhichDesignedView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentLevelsForWhichDesigned View Model as the data context for the view
        /// </summary>
        public AssessmentLevelsForWhichDesignedView(Interfaces.IAssessmentLevelsForWhichDesigned vm)
        {
            BindingContext  = vm;
        }
    }
}

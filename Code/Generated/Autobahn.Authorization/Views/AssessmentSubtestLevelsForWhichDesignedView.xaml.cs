//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSubtestLevelsForWhichDesignedView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The AssessmentSubtestLevelsForWhichDesignedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentSubtestLevelsForWhichDesignedView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentSubtestLevelsForWhichDesigned View Model as the data context for the view
        /// </summary>
        public AssessmentSubtestLevelsForWhichDesignedView(Interfaces.IAssessmentSubtestLevelsForWhichDesigned vm)
        {
            BindingContext  = vm;
        }
    }
}

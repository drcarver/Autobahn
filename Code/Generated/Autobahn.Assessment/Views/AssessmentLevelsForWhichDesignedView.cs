//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentLevelsForWhichDesignedView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentLevelsForWhichDesignedView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentLevelsForWhichDesignedView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentLevelsForWhichDesignedViewModel as the data context for the view
        /// </summary>
        public AssessmentLevelsForWhichDesignedView(AssessmentLevelsForWhichDesignedViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedBrailleView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentNeedBrailleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedBrailleView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentNeedBraille View Model as the data context for the view
        /// </summary>
        public AssessmentNeedBrailleView(Interfaces.IAssessmentNeedBraille vm)
        {
            BindingContext  = vm;
        }
    }
}

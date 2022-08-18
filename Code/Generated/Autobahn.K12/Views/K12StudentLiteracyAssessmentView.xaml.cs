//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentLiteracyAssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentLiteracyAssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentLiteracyAssessment View Model as the data context for the view
        /// </summary>
        public K12StudentLiteracyAssessmentView(Interfaces.IK12StudentLiteracyAssessment vm)
        {
            BindingContext  = vm;
        }
    }
}

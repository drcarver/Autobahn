//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentLiteracyAssessmentView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentLiteracyAssessmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentLiteracyAssessmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentLiteracyAssessmentViewModel as the data context for the view
        /// </summary>
        public K12StudentLiteracyAssessmentView(IK12StudentLiteracyAssessmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

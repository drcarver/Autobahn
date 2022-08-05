//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedBrailleView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentNeedBrailleView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentNeedBrailleView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentNeedBrailleViewModel as the data context for the view
        /// </summary>
        public AssessmentNeedBrailleView(AssessmentNeedBrailleViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

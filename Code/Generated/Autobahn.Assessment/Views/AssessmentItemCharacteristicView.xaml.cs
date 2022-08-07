//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemCharacteristicView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentItemCharacteristicView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemCharacteristicView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemCharacteristicViewModel as the data context for the view
        /// </summary>
        public AssessmentItemCharacteristicView(IAssessmentItemCharacteristicViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

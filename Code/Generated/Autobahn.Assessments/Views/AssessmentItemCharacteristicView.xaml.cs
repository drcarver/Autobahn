//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemCharacteristicView.cs
//**********************************************************

namespace Autobahn.Assessments.Views
{
     /// <summary>
     /// The AssessmentItemCharacteristicView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentItemCharacteristicView : ContentPage
    {
        /// <summary>
        /// Inject the IAssessmentItemCharacteristic View Model as the data context for the view
        /// </summary>
        public AssessmentItemCharacteristicView(Interfaces.IAssessmentItemCharacteristic vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedScreenReaderView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReaderView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentPersonalNeedScreenReaderView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentPersonalNeedScreenReaderViewModel as the data context for the view
        /// </summary>
        public AssessmentPersonalNeedScreenReaderView(AssessmentPersonalNeedScreenReaderViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

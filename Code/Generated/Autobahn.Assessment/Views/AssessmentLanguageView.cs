//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentLanguageView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The AssessmentLanguageView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentLanguageView : ContentPage
    {
        /// <summary>
        /// Inject the AssessmentLanguageViewModel as the data context for the view
        /// </summary>
        public AssessmentLanguageView(AssessmentLanguageViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

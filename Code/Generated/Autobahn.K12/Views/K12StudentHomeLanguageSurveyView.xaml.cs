//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentHomeLanguageSurveyView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentHomeLanguageSurveyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentHomeLanguageSurveyView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentHomeLanguageSurveyViewModel as the data context for the view
        /// </summary>
        public K12StudentHomeLanguageSurveyView(IK12StudentHomeLanguageSurveyViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

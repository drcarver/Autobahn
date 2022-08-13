//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentHomeLanguageSurveyView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentHomeLanguageSurveyView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentHomeLanguageSurveyView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentHomeLanguageSurvey View Model as the data context for the view
        /// </summary>
        public K12StudentHomeLanguageSurveyView(Interfaces.IK12StudentHomeLanguageSurvey vm)
        {
            BindingContext  = vm;
        }
    }
}

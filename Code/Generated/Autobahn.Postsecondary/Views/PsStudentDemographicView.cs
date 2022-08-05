//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentDemographicView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentDemographicView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentDemographicView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentDemographicViewModel as the data context for the view
        /// </summary>
        public PsStudentDemographicView(PsStudentDemographicViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

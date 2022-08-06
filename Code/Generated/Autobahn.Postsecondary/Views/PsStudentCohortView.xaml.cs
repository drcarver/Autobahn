//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentCohortView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentCohortView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentCohortView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentCohortViewModel as the data context for the view
        /// </summary>
        public PsStudentCohortView(PsStudentCohortViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

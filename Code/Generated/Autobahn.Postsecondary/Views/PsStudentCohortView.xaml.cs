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
        /// Inject the IPsStudentCohortViewModel as the data context for the view
        /// </summary>
        public PsStudentCohortView(IPsStudentCohortViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

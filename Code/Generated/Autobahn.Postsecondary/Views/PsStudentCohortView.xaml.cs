//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCohortView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentCohortView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentCohortView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentCohort View Model as the data context for the view
        /// </summary>
        public PsStudentCohortView(Interfaces.IPsStudentCohort vm)
        {
            BindingContext  = vm;
        }
    }
}

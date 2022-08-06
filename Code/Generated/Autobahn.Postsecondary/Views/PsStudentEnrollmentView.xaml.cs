//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentEnrollmentView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentEnrollmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentEnrollmentView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentEnrollmentViewModel as the data context for the view
        /// </summary>
        public PsStudentEnrollmentView(PsStudentEnrollmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

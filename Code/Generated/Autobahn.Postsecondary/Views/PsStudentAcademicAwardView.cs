//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicAwardView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentAcademicAwardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentAcademicAwardView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentAcademicAwardViewModel as the data context for the view
        /// </summary>
        public PsStudentAcademicAwardView(PsStudentAcademicAwardViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

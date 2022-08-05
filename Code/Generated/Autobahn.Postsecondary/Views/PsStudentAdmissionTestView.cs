//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAdmissionTestView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentAdmissionTestView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentAdmissionTestView : ContentPage
    {
        /// <summary>
        /// Inject the PsStudentAdmissionTestViewModel as the data context for the view
        /// </summary>
        public PsStudentAdmissionTestView(PsStudentAdmissionTestViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

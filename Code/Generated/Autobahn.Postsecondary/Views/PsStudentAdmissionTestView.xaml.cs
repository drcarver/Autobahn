//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentAdmissionTestView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentAdmissionTestView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentAdmissionTest View Model as the data context for the view
        /// </summary>
        public PsStudentAdmissionTestView(Interfaces.IPsStudentAdmissionTest vm)
        {
            BindingContext  = vm;
        }
    }
}

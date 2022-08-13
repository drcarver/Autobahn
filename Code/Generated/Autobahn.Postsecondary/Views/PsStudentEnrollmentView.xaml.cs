//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentEnrollmentView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PSStudentEnrollmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PSStudentEnrollmentView : ContentPage
    {
        /// <summary>
        /// Inject the IPSStudentEnrollment View Model as the data context for the view
        /// </summary>
        public PSStudentEnrollmentView(Interfaces.IPSStudentEnrollment vm)
        {
            BindingContext  = vm;
        }
    }
}

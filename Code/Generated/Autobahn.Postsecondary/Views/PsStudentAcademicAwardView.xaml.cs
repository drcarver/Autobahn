//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentAcademicAwardView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentAcademicAwardView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentAcademicAward View Model as the data context for the view
        /// </summary>
        public PsStudentAcademicAwardView(Interfaces.IPsStudentAcademicAward vm)
        {
            BindingContext  = vm;
        }
    }
}

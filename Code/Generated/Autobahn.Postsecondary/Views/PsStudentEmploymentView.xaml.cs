//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentEmploymentView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentEmployment View Model as the data context for the view
        /// </summary>
        public PsStudentEmploymentView(Interfaces.IPsStudentEmployment vm)
        {
            BindingContext  = vm;
        }
    }
}

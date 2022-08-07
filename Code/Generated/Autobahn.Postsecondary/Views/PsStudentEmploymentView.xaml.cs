//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentEmploymentView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStudentEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStudentEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStudentEmploymentViewModel as the data context for the view
        /// </summary>
        public PsStudentEmploymentView(IPsStudentEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

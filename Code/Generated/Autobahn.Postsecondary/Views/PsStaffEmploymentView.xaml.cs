//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStaffEmploymentView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the PsStaffEmploymentViewModel as the data context for the view
        /// </summary>
        public PsStaffEmploymentView(PsStaffEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsStaffEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsStaffEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the IPsStaffEmployment View Model as the data context for the view
        /// </summary>
        public PsStaffEmploymentView(Interfaces.IPsStaffEmployment vm)
        {
            BindingContext  = vm;
        }
    }
}

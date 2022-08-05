//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsInstitutionView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsInstitutionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsInstitutionView : ContentPage
    {
        /// <summary>
        /// Inject the PsInstitutionViewModel as the data context for the view
        /// </summary>
        public PsInstitutionView(PsInstitutionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

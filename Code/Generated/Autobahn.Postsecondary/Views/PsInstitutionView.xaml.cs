//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsInstitutionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsInstitutionView : ContentPage
    {
        /// <summary>
        /// Inject the IPsInstitution View Model as the data context for the view
        /// </summary>
        public PsInstitutionView(Interfaces.IPsInstitution vm)
        {
            BindingContext  = vm;
        }
    }
}

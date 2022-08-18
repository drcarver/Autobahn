//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsProgramView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IPsProgram View Model as the data context for the view
        /// </summary>
        public PsProgramView(Interfaces.IPsProgram vm)
        {
            BindingContext  = vm;
        }
    }
}

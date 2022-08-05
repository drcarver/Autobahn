//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsProgramView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsProgramView : ContentPage
    {
        /// <summary>
        /// Inject the PsProgramViewModel as the data context for the view
        /// </summary>
        public PsProgramView(PsProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

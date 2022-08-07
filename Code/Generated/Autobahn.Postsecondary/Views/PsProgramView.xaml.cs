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
        /// Inject the IPsProgramViewModel as the data context for the view
        /// </summary>
        public PsProgramView(IPsProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

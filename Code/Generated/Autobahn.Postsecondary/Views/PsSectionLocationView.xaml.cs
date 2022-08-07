//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsSectionLocationView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsSectionLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsSectionLocationView : ContentPage
    {
        /// <summary>
        /// Inject the IPsSectionLocationViewModel as the data context for the view
        /// </summary>
        public PsSectionLocationView(IPsSectionLocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

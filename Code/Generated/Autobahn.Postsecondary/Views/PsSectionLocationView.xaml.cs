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
        /// Inject the PsSectionLocationViewModel as the data context for the view
        /// </summary>
        public PsSectionLocationView(PsSectionLocationViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

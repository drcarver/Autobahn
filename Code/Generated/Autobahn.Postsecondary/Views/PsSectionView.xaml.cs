//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsSectionView.cs
//**********************************************************

using Autobahn.Postsecondary.ViewModels;

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IPsSectionViewModel as the data context for the view
        /// </summary>
        public PsSectionView(IPsSectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

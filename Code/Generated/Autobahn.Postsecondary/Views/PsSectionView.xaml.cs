//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsSectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsSectionView : ContentPage
    {
        /// <summary>
        /// Inject the IPsSection View Model as the data context for the view
        /// </summary>
        public PsSectionView(Interfaces.IPsSection vm)
        {
            BindingContext  = vm;
        }
    }
}

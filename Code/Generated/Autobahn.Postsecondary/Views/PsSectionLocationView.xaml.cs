//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationView.cs
//**********************************************************

namespace Autobahn.Postsecondary.Views
{
     /// <summary>
     /// The PsSectionLocationView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PsSectionLocationView : ContentPage
    {
        /// <summary>
        /// Inject the IPsSectionLocation View Model as the data context for the view
        /// </summary>
        public PsSectionLocationView(Interfaces.IPsSectionLocation vm)
        {
            BindingContext  = vm;
        }
    }
}

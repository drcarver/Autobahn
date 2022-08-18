//**********************************************************
//* DomainName: Common Models
//* FileName:   COSRatingAView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The COSRatingAView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class COSRatingAView : ContentPage
    {
        /// <summary>
        /// Inject the ICOSRatingA View Model as the data context for the view
        /// </summary>
        public COSRatingAView(Interfaces.ICOSRatingA vm)
        {
            BindingContext  = vm;
        }
    }
}

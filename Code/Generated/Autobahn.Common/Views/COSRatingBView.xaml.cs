//**********************************************************
//* DomainName: Common Models
//* FileName:   COSRatingBView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The COSRatingBView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class COSRatingBView : ContentPage
    {
        /// <summary>
        /// Inject the ICOSRatingB View Model as the data context for the view
        /// </summary>
        public COSRatingBView(Interfaces.ICOSRatingB vm)
        {
            BindingContext  = vm;
        }
    }
}

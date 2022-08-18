//**********************************************************
//* DomainName: Common Models
//* FileName:   COSRatingCView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The COSRatingCView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class COSRatingCView : ContentPage
    {
        /// <summary>
        /// Inject the ICOSRatingC View Model as the data context for the view
        /// </summary>
        public COSRatingCView(Interfaces.ICOSRatingC vm)
        {
            BindingContext  = vm;
        }
    }
}

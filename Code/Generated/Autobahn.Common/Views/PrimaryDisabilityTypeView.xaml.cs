//**********************************************************
//* DomainName: Common Models
//* FileName:   PrimaryDisabilityTypeView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PrimaryDisabilityTypeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimaryDisabilityTypeView : ContentPage
    {
        /// <summary>
        /// Inject the IPrimaryDisabilityType View Model as the data context for the view
        /// </summary>
        public PrimaryDisabilityTypeView(Interfaces.IPrimaryDisabilityType vm)
        {
            BindingContext  = vm;
        }
    }
}

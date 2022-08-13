//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDemographicView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildDemographicView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildDemographicView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildDemographic View Model as the data context for the view
        /// </summary>
        public ELChildDemographicView(Interfaces.IELChildDemographic vm)
        {
            BindingContext  = vm;
        }
    }
}

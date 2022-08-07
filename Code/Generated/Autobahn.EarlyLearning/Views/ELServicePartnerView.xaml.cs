//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELServicePartnerView.cs
//**********************************************************

using Autobahn.EarlyLearning.ViewModels;

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELServicePartnerView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELServicePartnerView : ContentPage
    {
        /// <summary>
        /// Inject the IELServicePartnerViewModel as the data context for the view
        /// </summary>
        public ELServicePartnerView(IELServicePartnerViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

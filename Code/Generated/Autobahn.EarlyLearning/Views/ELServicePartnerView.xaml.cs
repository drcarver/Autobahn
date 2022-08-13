//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELServicePartnerView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELServicePartnerView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELServicePartnerView : ContentPage
    {
        /// <summary>
        /// Inject the IELServicePartner View Model as the data context for the view
        /// </summary>
        public ELServicePartnerView(Interfaces.IELServicePartner vm)
        {
            BindingContext  = vm;
        }
    }
}

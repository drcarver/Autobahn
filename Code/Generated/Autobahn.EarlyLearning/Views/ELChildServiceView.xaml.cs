//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServiceView.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Views
{
     /// <summary>
     /// The ELChildServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ELChildServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IELChildService View Model as the data context for the view
        /// </summary>
        public ELChildServiceView(Interfaces.IELChildService vm)
        {
            BindingContext  = vm;
        }
    }
}

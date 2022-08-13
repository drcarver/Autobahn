//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaAlternateFundUseView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12SeaAlternateFundUseView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12SeaAlternateFundUseView : ContentPage
    {
        /// <summary>
        /// Inject the IK12SeaAlternateFundUse View Model as the data context for the view
        /// </summary>
        public K12SeaAlternateFundUseView(Interfaces.IK12SeaAlternateFundUse vm)
        {
            BindingContext  = vm;
        }
    }
}

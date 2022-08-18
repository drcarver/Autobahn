//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaSafeDrugFreeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaSafeDrugFreeView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaSafeDrugFree View Model as the data context for the view
        /// </summary>
        public K12LeaSafeDrugFreeView(Interfaces.IK12LeaSafeDrugFree vm)
        {
            BindingContext  = vm;
        }
    }
}

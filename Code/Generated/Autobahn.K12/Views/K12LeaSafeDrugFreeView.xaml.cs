//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaSafeDrugFreeView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaSafeDrugFreeView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaSafeDrugFreeView : ContentPage
    {
        /// <summary>
        /// Inject the K12LeaSafeDrugFreeViewModel as the data context for the view
        /// </summary>
        public K12LeaSafeDrugFreeView(K12LeaSafeDrugFreeViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

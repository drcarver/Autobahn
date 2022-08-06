//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   DataCollectionView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The DataCollectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataCollectionView : ContentPage
    {
        /// <summary>
        /// Inject the DataCollectionViewModel as the data context for the view
        /// </summary>
        public DataCollectionView(DataCollectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

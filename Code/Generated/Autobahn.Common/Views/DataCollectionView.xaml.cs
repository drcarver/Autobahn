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
        /// Inject the IDataCollectionViewModel as the data context for the view
        /// </summary>
        public DataCollectionView(IDataCollectionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}

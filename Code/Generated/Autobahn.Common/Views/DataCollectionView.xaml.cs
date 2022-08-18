//**********************************************************
//* DomainName: Common Models
//* FileName:   DataCollectionView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The DataCollectionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataCollectionView : ContentPage
    {
        /// <summary>
        /// Inject the IDataCollection View Model as the data context for the view
        /// </summary>
        public DataCollectionView(Interfaces.IDataCollection vm)
        {
            BindingContext  = vm;
        }
    }
}

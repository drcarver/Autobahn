//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ReferencePickListItemViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
    public class ReferencePickListItemViewModel : ViewModelBase 
    {
        // protected member variable for Selected Item
        private string _description;

        // protected member variable for Title
        private decimal _sortOrder;

        /// <summary>
        /// The description of the item in the list
        /// </summary>
        public string Description { 
            get => _description;
            set => SetProperty(ref _description, value);
        }

        /// <summary>
        /// The sort order of the item in the list
        /// </summary>
        public decimal SortOrder
        {
            get => _sortOrder;
            set => SetProperty(ref _sortOrder, value);
        }
    }
}

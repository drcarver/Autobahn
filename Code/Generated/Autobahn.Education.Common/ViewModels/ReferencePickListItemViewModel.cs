//**********************************************************
//* DomainName: Autobahn.Education.Common
//* FileName:   ReferencePickListItemViewModel.cs
//**********************************************************

using CommunityToolkit.Mvvm.ComponentModel;

namespace Autobahn.Education.Common.ViewModels
{
    public class ReferencePickListItemViewModel : ObservableObject
    {
        // protected member variable for Selected Item
        private string _description;

        // protected member variable for Title
        private decimal _sortOrder;

        /// <summary>
        /// The description of the item in the list
        /// </summary>
        public string Description
        {
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

//**********************************************************
//* DomainName: Autobahn.Education.Common
//* FileName:   ReferencePickerList.cs
//**********************************************************

namespace Autobahn.Education.Common.ViewModels
{
    public class ReferencePickerList
    {
        // protected member variable for Selected Item
        private ReferencePickListItemViewModel _selectedItem;

        // protected member variable for Title
        private string _title;

        // protected member variable for the list
        private List<ReferencePickListItemViewModel> _list;

        /// <summary>
        /// The selected item from the list
        /// </summary>
        public ReferencePickListItemViewModel SelectedItem { get => _selectedItem; set => _selectedItem = value; }

        /// <summary>
        /// The title of the list
        /// </summary>
        public string Title { get => _title; set => _title = value; }

        /// <summary>
        /// The List of ReferencePickListItemViewModel
        /// </summary>
        public List<ReferencePickListItemViewModel> List { get => _list; set => _list = value; }
    }
}

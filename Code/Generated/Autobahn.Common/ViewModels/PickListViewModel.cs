//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PickListViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
    public class PickListViewModel<T>  where T : ViewModelBase 
    {
        // protected member variable for Selected Item
        private T _selectedItem;

        // protected member variable for Title
        private string _title;

        // protected member variable for the list
        private List<T> _list;

        /// <summary>
        /// The selected item from the list
        /// </summary>
        public T SelectedItem { get => _selectedItem; set => _selectedItem = value; }

        /// <summary>
        /// The title of the list
        /// </summary>
        public string Title { get => _title; set => _title = value; }

        /// <summary>
        /// The List of T
        /// </summary>
        public List<T> List { get => _list; set => _list = value; }
    }
}

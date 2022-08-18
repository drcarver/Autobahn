//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApplicationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The Application View Model
     /// </summary>
    public partial class ApplicationViewModel : ViewModelBase, Interfaces.IApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Application";

        // Name -- (backing property for Authorization Application Name)
        private System.String _Name;

        // Uri -- (backing property for Authorization Application URI)
        private System.String _Uri;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Authorization Application Name
        /// <para>
        /// The name of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20127">Authorization Application Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Authorization Application URI
        /// <para>
        /// The Uniform Resource Identifier (URI) of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20128">Authorization Application URI</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Uri { get => _Uri; set => SetProperty(ref _Uri, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // Authorization Application Name
            Uri = model.Uri; // Authorization Application URI
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}

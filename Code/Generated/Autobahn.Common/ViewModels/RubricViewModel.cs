//**********************************************************
//* DomainName: Common Models
//* FileName:   RubricViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The Rubric View Model
     /// </summary>
    public partial class RubricViewModel : ViewModelBase, Interfaces.IRubric
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Rubric";

        // Identifier -- (backing property for Rubric Identifier)
        private System.String _Identifier;

        // Title -- (backing property for Rubric Title)
        private System.String _Title;

        // UrlReference -- (backing property for Rubric URL Reference)
        private System.String _UrlReference;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Rubric Identifier
        /// <para>
        /// An identifier assigned to a rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19412">Rubric Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Rubric Title
        /// <para>
        /// The title of the rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19411">Rubric Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// Rubric URL Reference
        /// <para>
        /// The URL location where the rubric may be found.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19413">Rubric URL Reference</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String UrlReference { get => _UrlReference; set => SetProperty(ref _UrlReference, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubric model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier; // Rubric Identifier
            Title = model.Title; // Rubric Title
            UrlReference = model.UrlReference; // Rubric URL Reference
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}

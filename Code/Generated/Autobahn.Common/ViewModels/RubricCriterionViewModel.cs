//**********************************************************
//* DomainName: Common Models
//* FileName:   RubricCriterionViewModel.cs
//* Name:       Rubric Criterion Category
//* Definition: A textual label for category by which Rubric Criterion may be grouped.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A textual label for category by which Rubric Criterion may be grouped.
     /// </summary>
    public partial class RubricCriterionViewModel : ViewModelBase, Interfaces.IRubricCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RubricCriterion";

        // Category -- (backing property for Rubric Criterion Category)
        private System.String _Category;

        // Position -- (backing property for Rubric Criterion Position)
        private System.Int32? _Position;

        // member variable for the RubricId property
        private Guid _RubricId;

        // Title -- (backing property for Rubric Criterion Title)
        private System.String _Title;

        // Weight -- (backing property for Rubric Criterion Weight)
        private System.Decimal? _Weight;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Rubric Criterion Category
        /// <para>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20441">Rubric Criterion Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Category { get => _Category; set => SetProperty(ref _Category, value); }

        /// <summary>
        /// Rubric Criterion Position
        /// <para>
        /// A numeric value representing this criterion's position in the criteria list for this rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20448">Rubric Criterion Position</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubric"/> model
        /// </summary>
        public Guid RubricId { get => _RubricId; set => SetProperty(ref _RubricId, value); }

        /// <summary>
        /// Rubric Criterion Title
        /// <para>
        /// The title of the rubric criterion.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20449">Rubric Criterion Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// Rubric Criterion Weight
        /// <para>
        /// A numeric weight assigned to this Rubric Criterion, used for scored rubrics.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20450">Rubric Criterion Weight</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category; // Rubric Criterion Category
            Position = model.Position; // Rubric Criterion Position
            RubricId = model.RubricId; // 
            Title = model.Title; // Rubric Criterion Title
            Weight = model.Weight; // Rubric Criterion Weight
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}

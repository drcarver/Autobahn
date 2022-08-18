//**********************************************************
//* DomainName: Common Models
//* FileName:   RubricCriterionLevelViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RubricCriterionLevel View Model
     /// </summary>
    public partial class RubricCriterionLevelViewModel : ViewModelBase, Interfaces.IRubricCriterionLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RubricCriterionLevel";

        // Feedback -- (backing property for Rubric Criterion Level Feedback)
        private System.String _Feedback;

        // Position -- (backing property for Rubric Criterion Level Position)
        private System.Int32? _Position;

        // Quality -- (backing property for Rubric Criterion Level Quality Label)
        private System.String _Quality;

        // member variable for the RubricCriterionId property
        private Guid _RubricCriterionId;

        // Score -- (backing property for Rubric Criterion Level Score)
        private System.Decimal? _Score;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Rubric Criterion Level Feedback
        /// <para>
        /// Pre-defined feedback text to be relayed to the person or organization being evaluated.  This may include guidance and suggestions for improvement or development.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20444">Rubric Criterion Level Feedback</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Feedback { get => _Feedback; set => SetProperty(ref _Feedback, value); }

        /// <summary>
        /// Rubric Criterion Level Position
        /// <para>
        /// A numeric value representing the level's position in the list of levels defined for the Rubric Criterion.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20445">Rubric Criterion Level Position</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Rubric Criterion Level Quality Label
        /// <para>
        /// A qualitative description of this degree of achievement used for column headers or row labels in tabular rubrics.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20446">Rubric Criterion Level Quality Label</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Quality { get => _Quality; set => SetProperty(ref _Quality, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
        /// </summary>
        public Guid RubricCriterionId { get => _RubricCriterionId; set => SetProperty(ref _RubricCriterionId, value); }

        /// <summary>
        /// Rubric Criterion Level Score
        /// <para>
        /// The points awarded for achieving this level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20447">Rubric Criterion Level Score</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Score { get => _Score; set => SetProperty(ref _Score, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            Feedback = model.Feedback; // Rubric Criterion Level Feedback
            Position = model.Position; // Rubric Criterion Level Position
            Quality = model.Quality; // Rubric Criterion Level Quality Label
            RubricCriterionId = model.RubricCriterionId; // 
            Score = model.Score; // Rubric Criterion Level Score
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}

//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationPart View Model
     /// </summary>
    public partial class StaffEvaluationPartViewModel : ViewModelBase, Interfaces.IStaffEvaluationPart
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluationPart";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // PartName -- (backing property for Staff Evaluation Part Name)
        private System.String _PartName;

        // Scale -- (backing property for Staff Evaluation Part Scale)
        private System.String _Scale;

        // ScoreOrRating -- (backing property for Staff Evaluation Part Score or Rating)
        private System.String _ScoreOrRating;

        // member variable for the StaffEvaluationId property
        private Guid? _StaffEvaluationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Staff Evaluation Part Name
        /// <para>
        /// The name of the component part that is being evaluated and scored.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20965">Staff Evaluation Part Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PartName { get => _PartName; set => SetProperty(ref _PartName, value); }

        /// <summary>
        /// Staff Evaluation Part Scale
        /// <para>
        /// The quantitative or qualitative range of possible scores/rating for a person's performance on a component part (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20966">Staff Evaluation Part Scale</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Scale { get => _Scale; set => SetProperty(ref _Scale, value); }

        /// <summary>
        /// Staff Evaluation Part Score or Rating
        /// <para>
        /// The actual quantitative or qualitative assessment of a person's performance on a component part that is being evaluated. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20967">Staff Evaluation Part Score or Rating</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ScoreOrRating { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IStaffEvaluation"/> model
        /// </summary>
        public Guid? StaffEvaluationId { get => _StaffEvaluationId; set => SetProperty(ref _StaffEvaluationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluationPart model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            PartName = model.PartName; // Staff Evaluation Part Name
            Scale = model.Scale; // Staff Evaluation Part Scale
            ScoreOrRating = model.ScoreOrRating; // Staff Evaluation Part Score or Rating
            StaffEvaluationId = model.StaffEvaluationId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}

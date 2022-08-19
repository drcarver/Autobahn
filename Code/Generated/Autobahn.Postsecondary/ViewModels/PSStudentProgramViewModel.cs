//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentProgramViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PSStudentProgram View Model
     /// </summary>
    public partial class PSStudentProgramViewModel : ViewModelBase, Interfaces.IPSStudentProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PSStudentProgram";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the PsProgramId property
        private Guid? _PsProgramId;

        // RefCareerClusterId -- (backing property for Career Cluster)
        private Guid? _RefCareerClusterId;

        // RefCipUseId -- (backing property for Classification of Instructional Program Use)
        private Guid? _RefCipUseId;

        // RefTransferOutIndicatorId -- (backing property for Transfer-out Indicator)
        private Guid? _RefTransferOutIndicatorId;

        // RefWorkbasedLearningOpportunityTypeId -- (backing property for Work-based Learning Opportunity Type)
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

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
        /// Reference to an optional instance of the <see cref="IPsProgram"/> model
        /// </summary>
        public Guid? PsProgramId { get => _PsProgramId; set => SetProperty(ref _PsProgramId, value); }

        /// <summary>
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Classification of Instructional Program Use
        /// <para>
        /// An indicator of whether the CIP Code is referencing an enrollment program or an award program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19044">Classification of Instructional Program Use</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCipUseId { get => _RefCipUseId; set => SetProperty(ref _RefCipUseId, value); }

        /// <summary>
        /// Transfer-out Indicator
        /// <para>
        /// An indicator of whether the student has transferred to another institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20610">Transfer-out Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTransferOutIndicatorId { get => _RefTransferOutIndicatorId; set => SetProperty(ref _RefTransferOutIndicatorId, value); }

        /// <summary>
        /// Work-based Learning Opportunity Type
        /// <para>
        /// The type of work-based learning opportunity a student participated in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPSStudentProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            PsProgramId = model.PsProgramId; // 
            RefCareerClusterId = model.RefCareerClusterId; // Career Cluster
            RefCipUseId = model.RefCipUseId; // Classification of Instructional Program Use
            RefTransferOutIndicatorId = model.RefTransferOutIndicatorId; // Transfer-out Indicator
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // Work-based Learning Opportunity Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefTransferOutIndicator List
        /// <summary>
        /// The complete <see cref="RefTransferOutIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTransferOutIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("99d9ca81-bb66-44b1-8ef6-129635906817"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("bd112d66-5c29-434f-8980-ced725ad48a8"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a049d1c0-82dc-4088-8475-b0f105f859b6"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}

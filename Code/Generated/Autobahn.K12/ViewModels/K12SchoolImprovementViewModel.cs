//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolImprovementViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolImprovement View Model
     /// </summary>
    public partial class K12SchoolImprovementViewModel : ViewModelBase, Interfaces.IK12SchoolImprovement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolImprovement";

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // RefSchoolImprovementFundsId -- (backing property for School Improvement Funds Status)
        private Guid? _RefSchoolImprovementFundsId;

        // RefSchoolImprovementStatusId -- (backing property for School Improvement Status)
        private Guid? _RefSchoolImprovementStatusId;

        // RefSigInterventionTypeId -- (backing property for School Improvement Grant Intervention Type)
        private Guid? _RefSigInterventionTypeId;

        // SchoolImprovementExitDate -- (backing property for School Improvement Exit Date)
        private System.DateTime? _SchoolImprovementExitDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12School"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// School Improvement Funds Status
        /// <para>
        /// An indication of whether the school received funds under Section 1003 of ESEA, as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19238">School Improvement Funds Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get => _RefSchoolImprovementFundsId; set => SetProperty(ref _RefSchoolImprovementFundsId, value); }

        /// <summary>
        /// School Improvement Status
        /// <para>
        /// An indication of the improvement stage of the school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19240">School Improvement Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get => _RefSchoolImprovementStatusId; set => SetProperty(ref _RefSchoolImprovementStatusId, value); }

        /// <summary>
        /// School Improvement Grant Intervention Type
        /// <para>
        /// The type of intervention used by the school under the School Improvement Grant (SIG).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19239">School Improvement Grant Intervention Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSigInterventionTypeId { get => _RefSigInterventionTypeId; set => SetProperty(ref _RefSigInterventionTypeId, value); }

        /// <summary>
        /// School Improvement Exit Date
        /// <para>
        /// Date the school exited school improvement status.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19472">School Improvement Exit Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? SchoolImprovementExitDate { get => _SchoolImprovementExitDate; set => SetProperty(ref _SchoolImprovementExitDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolImprovement model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId; // 
            RefSchoolImprovementFundsId = model.RefSchoolImprovementFundsId; // School Improvement Funds Status
            RefSchoolImprovementStatusId = model.RefSchoolImprovementStatusId; // School Improvement Status
            RefSigInterventionTypeId = model.RefSigInterventionTypeId; // School Improvement Grant Intervention Type
            SchoolImprovementExitDate = model.SchoolImprovementExitDate; // School Improvement Exit Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefSchoolImprovementFunds List
        /// <summary>
        /// The complete <see cref="RefSchoolImprovementFunds"> List
        /// </summary>
        private static List<ReferenceModelBase> RefSchoolImprovementFundsList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("86b20203-0574-406a-aee7-5f896ff4a2ae"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("103b0597-31d2-47d4-9aae-b83903febe58"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefSchoolImprovementStatus List
        /// <summary>
        /// The complete <see cref="RefSchoolImprovementStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefSchoolImprovementStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0bd1f361-e960-41a4-a546-42b38b13fea2"), Code="CorrectiveAction", Description="Corrective action", Definition="Corrective action is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("ead182f6-dee9-41c0-95cc-f072940a7a2b"), Code="Year1", Description="Improvement status Year 1", Definition="Improvement status Year 1 is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("66ee0baf-944d-4604-a9e0-3bc826973952"), Code="Year2", Description="Improvement status Year 2", Definition="Improvement status Year 2 is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad77408c-64ac-4ed9-8573-c114c7f5daeb"), Code="Planning", Description="Planning for restructuring", Definition="Planning for restructuring is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("23abcbb3-d594-4c72-807a-88bd72512915"), Code="Restructuring", Description="Restructuring", Definition="Restructuring is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("92da5eb1-3270-43ff-8217-45b6196909c9"), Code="NA", Description="Not applicable", Definition="The type of intervention used by the school under the School Improvement Grant (SIG) is not applicable.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion

        #region RefSigInterventionType List
        /// <summary>
        /// The complete <see cref="RefSigInterventionType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefSigInterventionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("55c300c0-2739-4c49-b3b3-0155073f989a"), Code="Turnaround", Description="Turnaround model", Definition="Turnaround model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c3f5ad37-91b8-4db5-9291-6cc25c202b11"), Code="Restart", Description="Restart model", Definition="Restart model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("50b91dcd-02f8-4c9b-9f78-67cfba5187dd"), Code="Closure", Description="School closure model", Definition="School closure model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("4fa42097-9bc1-4b76-9a21-de20a8ea4d20"), Code="Transformation", Description="Transformation model", Definition="Transformation model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}

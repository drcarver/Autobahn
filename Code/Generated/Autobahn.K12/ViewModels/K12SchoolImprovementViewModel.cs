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
            new ReferenceModelBase { Id=Guid.Parse("6afb7920-6cf7-4f44-9e69-c0b4aeca8eb6"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("4924e44e-282b-453a-b138-b5de9e10a9d2"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefSchoolImprovementStatus List
        /// <summary>
        /// The complete <see cref="RefSchoolImprovementStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefSchoolImprovementStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4bbe6417-5245-4674-b5dc-7487deffc606"), Code="CorrectiveAction", Description="Corrective action", Definition="Corrective action is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("5b26255f-d14e-4ee6-9b5f-433ba3254b0e"), Code="Year1", Description="Improvement status Year 1", Definition="Improvement status Year 1 is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a3da124-91eb-49ce-a59b-ecbb163951b7"), Code="Year2", Description="Improvement status Year 2", Definition="Improvement status Year 2 is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("972e4d44-6078-437d-a7be-222318848600"), Code="Planning", Description="Planning for restructuring", Definition="Planning for restructuring is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("bcf73ba9-3609-4f4f-8272-166ce900ab1a"), Code="Restructuring", Description="Restructuring", Definition="Restructuring is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("23d9aed3-1b16-43ce-87a6-eb36ad604c59"), Code="NA", Description="Not applicable", Definition="The type of intervention used by the school under the School Improvement Grant (SIG) is not applicable.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion

        #region RefSigInterventionType List
        /// <summary>
        /// The complete <see cref="RefSigInterventionType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefSigInterventionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("7f81e786-e83f-4ba9-b733-0be9646f2522"), Code="Turnaround", Description="Turnaround model", Definition="Turnaround model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("8bb096fe-a683-4a82-a21c-ca7584387def"), Code="Restart", Description="Restart model", Definition="Restart model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f8169b28-4e85-48da-81f1-316970771dfe"), Code="Closure", Description="School closure model", Definition="School closure model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e1543d48-d088-4f1f-940f-431bf4fa7d87"), Code="Transformation", Description="Transformation model", Definition="Transformation model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}

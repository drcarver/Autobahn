//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOffered View Model
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOfferedViewModel : ViewModelBase, Interfaces.IEarlyChildhoodProgramTypeOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EarlyChildhoodProgramTypeOffered";

        // InclusiveSettingIndicator -- (backing property for Inclusive Setting Indicator)
        private System.Boolean? _InclusiveSettingIndicator;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefCommunityBasedTypeId -- (backing property for Community-based Type)
        private Guid? _RefCommunityBasedTypeId;

        // RefEarlyChildhoodProgramEnrollmentTypeId -- (backing property for Early Childhood Program Enrollment Type)
        private Guid _RefEarlyChildhoodProgramEnrollmentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Inclusive Setting Indicator
        /// <para>
        /// Indicates that services are provided to the child in a place where children of all abilities learn together.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Community-based Type
        /// <para>
        /// Non domestic residence in which the early learning setting is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCommunityBasedTypeId { get => _RefCommunityBasedTypeId; set => SetProperty(ref _RefCommunityBasedTypeId, value); }

        /// <summary>
        /// Early Childhood Program Enrollment Type
        /// <para>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get => _RefEarlyChildhoodProgramEnrollmentTypeId; set => SetProperty(ref _RefEarlyChildhoodProgramEnrollmentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEarlyChildhoodProgramTypeOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            InclusiveSettingIndicator = model.InclusiveSettingIndicator; // Inclusive Setting Indicator
            OrganizationId = model.OrganizationId; // 
            RefCommunityBasedTypeId = model.RefCommunityBasedTypeId; // Community-based Type
            RefEarlyChildhoodProgramEnrollmentTypeId = model.RefEarlyChildhoodProgramEnrollmentTypeId; // Early Childhood Program Enrollment Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefEarlyChildhoodProgramEnrollmentType List
        /// <summary>
        /// The complete <see cref="RefEarlyChildhoodProgramEnrollmentType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefEarlyChildhoodProgramEnrollmentTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0aac1000-eeb4-4623-a523-e61af134c4de"), Code="HeadStart", Description="Head Start", Definition="Head Start is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b064a15-3c5b-4469-9da8-6a385a54dd52"), Code="EarlyHeadStart", Description="Early Head Start", Definition="Early Head Start is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b40f0e0-d178-4c7e-8b9a-896fdb08c26c"), Code="StatePreschool", Description="State Preschool", Definition="State Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd2df4f5-1218-44d9-930c-0117c8e585f1"), Code="PublicPreschool", Description="Public Preschool", Definition="Public Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("8d16f563-32d9-4c94-a223-cb246b56351b"), Code="PrivatePreschool", Description="Private Preschool", Definition="Private Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("0389c02c-d0de-43e9-b7fe-40de9b7edb92"), Code="EarlyChildhoodSpecialEducation", Description="Early Childhood Special Education (619)", Definition="Early Childhood Special Education (619) is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("106eb2c2-36a4-4296-abee-11703935ddc2"), Code="HomeVisiting", Description="Home Visiting", Definition="Home Visiting is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("5970197d-4f22-4225-8e4a-f3fbacd8a8d3"), Code="ChildCare", Description="Child Care", Definition="Child Care is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("e501e8ff-817c-488b-8dea-f6bb33269cbf"), Code="EarlyInterventionPartC", Description="Early Intervention Services Part C", Definition="Early Intervention Services Part C is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("334163f4-b687-4d13-a351-bf9e115ce49c"), Code="Other", Description="Other", Definition="The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("d0cb7ac7-0d1e-4305-bae6-e013bb462286"), Code="None", Description="None", Definition="The child is not enrolled in an early childhood program.", SortOrder=Convert.ToDecimal("21.00") },
        };
        #endregion
    }
}

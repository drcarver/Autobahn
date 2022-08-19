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
            new ReferenceModelBase { Id=Guid.Parse("fd35cdd1-f779-438a-af23-d8df5e42e2a5"), Code="HeadStart", Description="Head Start", Definition="Head Start is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("58276c85-6f85-406a-8b05-835bd71d6c77"), Code="EarlyHeadStart", Description="Early Head Start", Definition="Early Head Start is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e8b551b3-2012-4c51-864d-2ed5bd8371f9"), Code="StatePreschool", Description="State Preschool", Definition="State Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("33009e66-dd1a-430c-b68e-a5c4050a23ae"), Code="PublicPreschool", Description="Public Preschool", Definition="Public Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("29b17ff1-70db-4a75-83f6-7ef19303db56"), Code="PrivatePreschool", Description="Private Preschool", Definition="Private Preschool is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("91f5b036-293d-4bf6-8cb3-49658253cf82"), Code="EarlyChildhoodSpecialEducation", Description="Early Childhood Special Education (619)", Definition="Early Childhood Special Education (619) is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("e8a0b3b5-18cb-41cb-8063-f931d93ba11e"), Code="HomeVisiting", Description="Home Visiting", Definition="Home Visiting is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("cda64fbe-6ac7-43ea-b989-9649b967407e"), Code="ChildCare", Description="Child Care", Definition="Child Care is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("1af5835a-85d8-4462-8cab-9a1853577d5b"), Code="EarlyInterventionPartC", Description="Early Intervention Services Part C", Definition="Early Intervention Services Part C is the system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("2da423ba-69c7-4409-9036-8a261809c257"), Code="Other", Description="Other", Definition="The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("1bba219e-bd8a-4b06-a14d-e99f5ff8d738"), Code="None", Description="None", Definition="The child is not enrolled in an early childhood program.", SortOrder=Convert.ToDecimal("21.00") },
        };
        #endregion
    }
}

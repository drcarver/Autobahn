//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaViewModel.cs
//* Name:       Charter School Indicator
//* Definition: An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
     /// </summary>
    public partial class K12LeaViewModel : ViewModelBase, Interfaces.IK12Lea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Lea";

        // CharterSchoolIndicator -- (backing property for Charter School Indicator)
        private System.Boolean? _CharterSchoolIndicator;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefCharterLeaStatusId property
        private Guid? _RefCharterLeaStatusId;

        // member variable for the RefLeaImprovementStatusId property
        private Guid? _RefLeaImprovementStatusId;

        // RefLeaTypeId -- (backing property for Local Education Agency Type)
        private Guid? _RefLeaTypeId;

        // RefPublicSchoolChoiceStatusId -- (backing property for Public School Choice Implementation Status)
        private Guid? _RefPublicSchoolChoiceStatusId;

        // SupervisoryUnionIdentificationNumber -- (backing property for Local Education Agency Supervisory Union Identification Number)
        private System.String _SupervisoryUnionIdentificationNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
        /// </summary>
        public Guid? RefCharterLeaStatusId { get => _RefCharterLeaStatusId; set => SetProperty(ref _RefCharterLeaStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
        /// </summary>
        public Guid? RefLeaImprovementStatusId { get => _RefLeaImprovementStatusId; set => SetProperty(ref _RefLeaImprovementStatusId, value); }

        /// <summary>
        /// Local Education Agency Type
        /// <para>
        /// &#x0D;
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLeaTypeId { get => _RefLeaTypeId; set => SetProperty(ref _RefLeaTypeId, value); }

        /// <summary>
        /// Public School Choice Implementation Status
        /// <para>
        /// An indication of whether the LEA was able to implement the provisions for public school choice under Title I, Part A, Section 1116 of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19227">Public School Choice Implementation Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPublicSchoolChoiceStatusId { get => _RefPublicSchoolChoiceStatusId; set => SetProperty(ref _RefPublicSchoolChoiceStatusId, value); }

        /// <summary>
        /// Local Education Agency Supervisory Union Identification Number
        /// <para>
        /// The three-digit unique identifier assigned to the supervisory union by the state.  
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19175">Local Education Agency Supervisory Union Identification Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SupervisoryUnionIdentificationNumber { get => _SupervisoryUnionIdentificationNumber; set => SetProperty(ref _SupervisoryUnionIdentificationNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Lea model)
        {
            IsBusy = true;
            Id = model.Id;
            CharterSchoolIndicator = model.CharterSchoolIndicator; // Charter School Indicator
            OrganizationId = model.OrganizationId; // 
            RefCharterLeaStatusId = model.RefCharterLeaStatusId; // 
            RefLeaImprovementStatusId = model.RefLeaImprovementStatusId; // 
            RefLeaTypeId = model.RefLeaTypeId; // Local Education Agency Type
            RefPublicSchoolChoiceStatusId = model.RefPublicSchoolChoiceStatusId; // Public School Choice Implementation Status
            SupervisoryUnionIdentificationNumber = model.SupervisoryUnionIdentificationNumber; // Local Education Agency Supervisory Union Identification Number
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLEAImprovementStatus List
        /// <summary>
        /// The complete Charter School Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefLEAImprovementStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("fcf27bed-da3c-4af5-aea3-e84a0098e577"), Code="CorrectiveAction", Description="Corrective action", Definition="The improvement stage for AYP of the local education agency (LEA) is: Corrective Action.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("4de29bc6-1d09-4fa9-9961-59af9500a5da"), Code="Year1", Description="Improvement status Year 1", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 1", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("636f6c68-0cdb-4fef-914a-398d33822ffa"), Code="Year2", Description="Improvement status Year 2", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 2", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("9d5b048b-577e-409a-868f-5243670b77ea"), Code="NotIdentified", Description="Not identified for improvement", Definition="The improvement stage for AYP of the local education agency (LEA) is: Not identified for improvement", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefLeaImprovementStatus List
        /// <summary>
        /// The complete Charter School Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefLeaImprovementStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("b9e98149-5419-4fc5-a2c4-6cb43b507af9"), Code="CorrectiveAction", Description="Corrective action", Definition="The improvement stage for AYP of the local education agency (LEA) is: Corrective Action.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("4503d162-7f1e-4b1d-8f30-a55422b923b2"), Code="Year1", Description="Improvement status Year 1", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 1", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("40bf7b26-a49a-401f-a848-42c046862b24"), Code="Year2", Description="Improvement status Year 2", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 2", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("410c9773-9072-4617-9420-714b4cd09681"), Code="NotIdentified", Description="Not identified for improvement", Definition="The improvement stage for AYP of the local education agency (LEA) is: Not identified for improvement", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefLeaType List
        /// <summary>
        /// The complete Charter School Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefLeaTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("6438dbac-4d5e-427f-87b6-1e5ee92047a1"), Code="RegularNotInSupervisoryUnion", Description="Regular public school district that is NOT a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is NOT a component of a supervisory union.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("3695c310-37a5-4582-9675-302649eeb7a7"), Code="RegularInSupervisoryUnion", Description="Regular public school district that is a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is a component of a supervisory union.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("3c3669d1-1cd1-4c2a-9eca-c77bc801f84a"), Code="SupervisoryUnion", Description=" Supervisory Union", Definition="An administrative center or county superintendent's office serving as the administrative center.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("49267c01-0f12-4438-b6f3-4308e5a383b5"), Code="SpecializedPublicSchoolDistrict", Description="Specialized Public School District", Definition="A school district that operates one or more schools that are designed for a specific educational need or purpose.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("b20391f8-6c3f-4682-af3d-8b0df1cda30c"), Code="ServiceAgency", Description="Service Agency", Definition="An agency that does not operate schools, instead it provides specialized educational services (such as career and technical education) or related services (such as services in IEPs) to other education agencies that the agencies cannot readily provide for themselves.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("8d937686-5f1f-4aca-b1c4-2890a6a3c5f8"), Code="StateOperatedAgency", Description="State Operated Agency", Definition="An organization overseen by a state agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("f49d94ae-a6af-4ee6-935f-2df1526a5bbf"), Code="FederalOperatedAgency", Description="Federal Operated Agency", Definition="An organization overseen by a federal agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("d9bd4100-b4a5-4bba-8f43-a0ec0ed81608"), Code="IndependentCharterDistrict", Description="Independent Charter District", Definition="An independent charter district is an education unit created under the state charter legislation that is not under the administrative control of another local education agency and that operates one or more charter schools - and only charter schools.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("45dd834e-e902-4608-9b0d-73015e1f38ac"), Code="Other", Description="Other Local Education Agencies", Definition="Category for an agency providing elementary or secondary instruction or support services to use when one of the other types defined in CEDS is not appropriate.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPublicSchoolChoiceStatus List
        /// <summary>
        /// The complete Charter School Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefPublicSchoolChoiceStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("545edfdc-aafd-4410-9da2-499c2afa4650"), Code="ImplementedAllGrades", Description="Implemented at all grade levels", Definition="Public school choice was implemented at all grade levels.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("3437f1a0-1250-4be3-976a-19a57a9a5c65"), Code="ImplementedSomeGrades", Description="Implemented at some but not all grade levels", Definition="Public school choice was implemented at some but not all grade levels.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6543c0e-76e9-424c-945d-011456183099"), Code="UnableToImplement", Description="Unable to implement at any grades levels", Definition="Public school choice was unable to be  implemented at any grades levels.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("9d1f365c-6f03-4651-b49b-c8f02546f503"), Code="NotRequiredToImplement", Description="Not required to implement public school choice", Definition="The LEA was not required to implement public school choice.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}

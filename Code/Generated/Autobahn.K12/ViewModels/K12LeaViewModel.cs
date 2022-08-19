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
            new ReferenceModelBase { Id=Guid.Parse("95edf79d-51f3-44ae-b198-cad568da0bca"), Code="CorrectiveAction", Description="Corrective action", Definition="The improvement stage for AYP of the local education agency (LEA) is: Corrective Action.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("48c3664e-d8e1-4d27-9ccb-9a1f0606803f"), Code="Year1", Description="Improvement status Year 1", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 1", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("187d471d-b655-4e9c-b0bc-68579b750448"), Code="Year2", Description="Improvement status Year 2", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 2", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("093c3876-bc00-461a-9275-225aa9024ed0"), Code="NotIdentified", Description="Not identified for improvement", Definition="The improvement stage for AYP of the local education agency (LEA) is: Not identified for improvement", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefLeaImprovementStatus List
        /// <summary>
        /// The complete Charter School Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefLeaImprovementStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0b841661-5e6d-48b9-9018-f35f47e1e74d"), Code="CorrectiveAction", Description="Corrective action", Definition="The improvement stage for AYP of the local education agency (LEA) is: Corrective Action.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b1d86f9-cde3-467a-8d4d-7a2a22dc4a3f"), Code="Year1", Description="Improvement status Year 1", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 1", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("2dd4daeb-40e5-4da8-ae2d-d163e4a52fd1"), Code="Year2", Description="Improvement status Year 2", Definition="The improvement stage for AYP of the local education agency (LEA) is: Improvement status Year 2", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("0d469f43-258c-433c-9533-09ef16c86f25"), Code="NotIdentified", Description="Not identified for improvement", Definition="The improvement stage for AYP of the local education agency (LEA) is: Not identified for improvement", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefLeaType List
        /// <summary>
        /// The complete Charter School Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefLeaTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("357cf775-cf07-409b-aee0-c703044622ad"), Code="RegularNotInSupervisoryUnion", Description="Regular public school district that is NOT a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is NOT a component of a supervisory union.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("90ba40ac-3057-4b91-bf7f-f334d892f3e2"), Code="RegularInSupervisoryUnion", Description="Regular public school district that is a component of a supervisory union", Definition="A local government administrative authority which governs the education system at a specified local level on behalf of the public and the state and is a component of a supervisory union.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a5d662c4-6196-4849-96e5-bf4511c48155"), Code="SupervisoryUnion", Description=" Supervisory Union", Definition="An administrative center or county superintendent's office serving as the administrative center.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("70a49334-37a2-4b0e-8788-d0ac263dae7c"), Code="SpecializedPublicSchoolDistrict", Description="Specialized Public School District", Definition="A school district that operates one or more schools that are designed for a specific educational need or purpose.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("4de98266-c53f-48b4-a963-1a1c4461469a"), Code="ServiceAgency", Description="Service Agency", Definition="An agency that does not operate schools, instead it provides specialized educational services (such as career and technical education) or related services (such as services in IEPs) to other education agencies that the agencies cannot readily provide for themselves.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("8bc01727-7f28-4942-b6e4-92d8f4a9ae51"), Code="StateOperatedAgency", Description="State Operated Agency", Definition="An organization overseen by a state agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("caf79a5a-30e1-427d-81f9-eb588f8a2dab"), Code="FederalOperatedAgency", Description="Federal Operated Agency", Definition="An organization overseen by a federal agency that operates schools or programs that provide public elementary and/or secondary level instruction.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("6dcbe767-ab10-42bf-9367-c313a0160fa4"), Code="IndependentCharterDistrict", Description="Independent Charter District", Definition="An independent charter district is an education unit created under the state charter legislation that is not under the administrative control of another local education agency and that operates one or more charter schools - and only charter schools.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("ca84813c-c448-474f-a596-678fa624ea3a"), Code="Other", Description="Other Local Education Agencies", Definition="Category for an agency providing elementary or secondary instruction or support services to use when one of the other types defined in CEDS is not appropriate.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPublicSchoolChoiceStatus List
        /// <summary>
        /// The complete Charter School Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefPublicSchoolChoiceStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("077b029e-6701-4046-b980-7746c193e3cb"), Code="ImplementedAllGrades", Description="Implemented at all grade levels", Definition="Public school choice was implemented at all grade levels.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b32a3446-252c-4e0c-8686-d62bceeab298"), Code="ImplementedSomeGrades", Description="Implemented at some but not all grade levels", Definition="Public school choice was implemented at some but not all grade levels.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6c5c25e7-3289-4395-8002-14758057e228"), Code="UnableToImplement", Description="Unable to implement at any grades levels", Definition="Public school choice was unable to be  implemented at any grades levels.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("eb4b8f82-707f-469e-8835-29ce15d22214"), Code="NotRequiredToImplement", Description="Not required to implement public school choice", Definition="The LEA was not required to implement public school choice.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}

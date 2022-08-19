//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipViewModel.cs
//* Name:       Person Relationship to Learner Contact Priority Number
//* Definition: The numeric order in the preferred sequence and priority for contacting a person related to the learner.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The numeric order in the preferred sequence and priority for contacting a person related to the learner.
     /// </summary>
    public partial class PersonRelationshipViewModel : ViewModelBase, Interfaces.IPersonRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonRelationship";

        // ContactPriorityNumber -- (backing property for Person Relationship to Learner Contact Priority Number)
        private System.Int32? _ContactPriorityNumber;

        // ContactRestrictions -- (backing property for Person Relationship to Learner Contact Restrictions Description)
        private System.String _ContactRestrictions;

        // CustodialRelationshipIndicator -- (backing property for Custodial Parent or Guardian Indicator)
        private System.Boolean? _CustodialRelationshipIndicator;

        // EmergencyContactInd -- (backing property for Emergency Contact Indicator)
        private System.Boolean? _EmergencyContactInd;

        // LivesWithIndicator -- (backing property for Person Relationship to Learner Lives with Indicator)
        private System.Boolean? _LivesWithIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        // PrimaryContactIndicator -- (backing property for Primary Contact Indicator)
        private System.Boolean? _PrimaryContactIndicator;

        // RefPersonRelationshipTypeId -- (backing property for Person Relationship Type)
        private Guid _RefPersonRelationshipTypeId;

        // member variable for the RelatedPersonId property
        private Guid _RelatedPersonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Person Relationship to Learner Contact Priority Number
        /// <para>
        /// The numeric order in the preferred sequence and priority for contacting a person related to the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20392">Person Relationship to Learner Contact Priority Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? ContactPriorityNumber { get => _ContactPriorityNumber; set => SetProperty(ref _ContactPriorityNumber, value); }

        /// <summary>
        /// Person Relationship to Learner Contact Restrictions Description
        /// <para>
        /// Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20393">Person Relationship to Learner Contact Restrictions Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ContactRestrictions { get => _ContactRestrictions; set => SetProperty(ref _ContactRestrictions, value); }

        /// <summary>
        /// Custodial Parent or Guardian Indicator
        /// <para>
        /// An indication that a person has legal custody of a child.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19328">Custodial Parent or Guardian Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CustodialRelationshipIndicator { get => _CustodialRelationshipIndicator; set => SetProperty(ref _CustodialRelationshipIndicator, value); }

        /// <summary>
        /// Emergency Contact Indicator
        /// <para>
        /// Indicates whether or not the person is a designated emergency contact for the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20308">Emergency Contact Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? EmergencyContactInd { get => _EmergencyContactInd; set => SetProperty(ref _EmergencyContactInd, value); }

        /// <summary>
        /// Person Relationship to Learner Lives with Indicator
        /// <para>
        /// Indicates whether or not the learner lives with the related person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20394">Person Relationship to Learner Lives with Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? LivesWithIndicator { get => _LivesWithIndicator; set => SetProperty(ref _LivesWithIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Primary Contact Indicator
        /// <para>
        /// Indicates that a person is a primary contact within the specified context, such as a primary parental contact specified in Person Relationship to Learner or a primary administrative contact for an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20397">Primary Contact Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PrimaryContactIndicator { get => _PrimaryContactIndicator; set => SetProperty(ref _PrimaryContactIndicator, value); }

        /// <summary>
        /// Person Relationship Type
        /// <para>
        /// The nature of a person's relationship to another person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19415">Person Relationship Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefPersonRelationshipTypeId { get => _RefPersonRelationshipTypeId; set => SetProperty(ref _RefPersonRelationshipTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRelatedPerson"/> model
        /// </summary>
        public Guid RelatedPersonId { get => _RelatedPersonId; set => SetProperty(ref _RelatedPersonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            ContactPriorityNumber = model.ContactPriorityNumber; // Person Relationship to Learner Contact Priority Number
            ContactRestrictions = model.ContactRestrictions; // Person Relationship to Learner Contact Restrictions Description
            CustodialRelationshipIndicator = model.CustodialRelationshipIndicator; // Custodial Parent or Guardian Indicator
            EmergencyContactInd = model.EmergencyContactInd; // Emergency Contact Indicator
            LivesWithIndicator = model.LivesWithIndicator; // Person Relationship to Learner Lives with Indicator
            PersonId = model.PersonId; // 
            PrimaryContactIndicator = model.PrimaryContactIndicator; // Primary Contact Indicator
            RefPersonRelationshipTypeId = model.RefPersonRelationshipTypeId; // Person Relationship Type
            RelatedPersonId = model.RelatedPersonId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPersonRelationshipType List
        /// <summary>
        /// The complete Person Relationship to Learner Contact Priority Number List
        /// </summary>
        private static List<ReferenceModelBase> RefPersonRelationshipTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("24bd0870-1417-47c3-95c0-4f5a88d09575"), Code="Aunt", Description="Aunt", Definition="The person is the related person's Aunt.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("772df17e-85e9-4f9e-99b8-21cbc6df74fd"), Code="Brother", Description="Brother", Definition="The person is the related person's Brother.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("1efb49a2-d42c-45e2-9ebc-f024057cd302"), Code="BrotherInLaw", Description="Brother-in-law", Definition="The person is the related person's Brother-in-law.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("33cb069e-fc14-4088-88a2-19d6bd8dffcc"), Code="CourtAppointedGuardian", Description="Court appointed guardian", Definition="The person is the related person's court appointed guardian.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("40658310-8c50-43ec-8aec-21f0c15e4c47"), Code="Daughter", Description="Daughter", Definition="The person is the related person's Daughter.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("e29fa25b-8562-4098-ace6-19d34c32e37d"), Code="DaughterInLaw", Description="Daughter-in-law", Definition="The person is the related person's Aunt.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("b73ea535-c043-447b-98ae-657dbcc8207b"), Code="Employer", Description="Employer", Definition="The person is the related person's Employer.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("56eabd3f-9b35-47da-bdfa-e60bac0a4653"), Code="Father", Description="Father", Definition="The person is the related person's Father.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("afd967f8-417b-44a2-9593-61017d7967ce"), Code="FathersSignificantOther", Description="Father's significant other", Definition="The person is the significant other of the related person's Father.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("02d2fef6-10dc-482f-acc9-c0e1692b3f98"), Code="FathersCivilPartner", Description="Father's civil partner", Definition="The person is a legal partner of the related person's father, established by a civil union other than marriage.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("e1fdd340-5305-413c-a6b2-3467daff7352"), Code="FatherInLaw", Description="Father-in-law", Definition="The person is the father of the related person's spouse.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("6bd456eb-a255-44e1-9805-da564d75f12e"), Code="Fiance", Description="Fiance", Definition="The person is a man who is engaged to be married to the related person.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("54332628-26cb-4cbd-8720-2ee1c07862d5"), Code="Fiancee", Description="Fiancee", Definition="The person is a woman who is engaged to be married to the related person.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("5c029cfa-e802-47ba-88c3-9321501722f6"), Code="Friend", Description="Friend", Definition="The person is the related person's Friend.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("58cd4b8c-376b-4ec2-b1fc-73cbd7832259"), Code="Grandfather", Description="Grandfather", Definition="The person is the related person's Grandfather.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("26bbd99b-35f4-4c67-9b85-ae92c3eef805"), Code="Grandmother", Description="Grandmother", Definition="The person is the related person's Grandmother.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("a144da76-294e-4381-9b34-fb6e7040ffa6"), Code="Husband", Description="Husband", Definition="The person is the related person's Husband.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("2624de93-f6a6-4a27-9d12-4728b6fd6495"), Code="MothersSignificantOther", Description="Mother's significant other", Definition="The person is the significant other of the related person's Mother.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("e73d6053-8957-4c5d-9f96-42b37c945b91"), Code="Mother", Description="Mother", Definition="The person is the related person's Mother", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("ccfac4f1-9c7a-4c49-8d16-24c0eb369f66"), Code="MothersCivilPartner", Description="Mother's civil partner", Definition="The person is a legal partner of the related person's mother, established by a civil union other than marriage.", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("6c9f4799-a373-4951-a720-2c5fe112842a"), Code="Nephew", Description="Nephew", Definition="The person is the related person's Nephew.", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("27526e69-9c54-4a16-ab2f-212337ef68c4"), Code="Niece", Description="Niece", Definition="The person is the related person's Niece.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("b36ab09e-061a-4c17-81ed-34baeaca246d"), Code="Other", Description="Other", Definition="The person is related to the related person in a way not represented by other standard options.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("03e28e39-8511-4e12-9074-5bf90a843604"), Code="SignificantOther", Description="Significant other", Definition="The person is the Significant other of the related person.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("5fac4f77-7492-4894-aa69-e663dfbc6a3c"), Code="Sister", Description="Sister", Definition="The person is the related person's Sister.", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("2eba0ad2-c5b4-4389-b7da-02b261c0b62b"), Code="Son", Description="Son", Definition="The person is the related person's Son.", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("8cbf9a2b-34bd-4a83-b5dd-c411b23e31d6"), Code="Unknown", Description="Unknown", Definition="The person is the related person's Unknown.", SortOrder=Convert.ToDecimal("61.00") },
            new ReferenceModelBase { Id=Guid.Parse("d029ae9b-b93b-493c-9d6e-df5aa7c15af8"), Code="Uncle", Description="Uncle", Definition="The person is the related person's Uncle.", SortOrder=Convert.ToDecimal("62.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee48e5a8-0be1-4d4c-bb48-fa78eb4e4b95"), Code="Ward", Description="Ward", Definition="The person is the related person's Ward.", SortOrder=Convert.ToDecimal("63.00") },
            new ReferenceModelBase { Id=Guid.Parse("2a241b35-a4a5-47d0-ae3e-5be6be6b36d5"), Code="Wife", Description="Wife", Definition="The person is the related person's Wife.", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("a1d4828a-bff0-47ad-bd3d-07b374ec9ba9"), Code="AdoptedDaughter", Description="Adopted Daughter", Definition="The person is the related person's Adopted Daughter.", SortOrder=Convert.ToDecimal("65.00") },
            new ReferenceModelBase { Id=Guid.Parse("a259739c-920f-4402-a9aa-c6f98d7a3f48"), Code="AdoptedSon", Description="Adopted son", Definition="The person is the related person's Adopted son.", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("0415cf5e-cfb4-4239-8626-03b9fb7c5025"), Code="AdoptiveParent", Description="Adoptive parent", Definition="The person is the related person's Adoptive parent.", SortOrder=Convert.ToDecimal("67.00") },
            new ReferenceModelBase { Id=Guid.Parse("4030dd08-26b9-4a0f-a97a-dc7195413000"), Code="Advisor", Description="Advisor", Definition="The person is the related person's Advisor.", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("84451b98-2e8e-4521-b225-07f560b38510"), Code="AgencyRepresentative", Description="Agency representative", Definition="The person is the related person's Agency representative.", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("95767387-71e6-4ba8-a69d-6b6021d636ec"), Code="Cousin", Description="Cousin", Definition="The person is the related person's Cousin.", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("4f744db7-ea15-4d16-ab1a-00c0cae20c10"), Code="Dependent", Description="Dependent", Definition="The person is the related person's Dependent.", SortOrder=Convert.ToDecimal("71.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6996990-e84e-4ed4-b085-2937761010d4"), Code="FamilyMember", Description="Family member", Definition="The person is the related person's Family member.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("80d8659e-b284-4101-8384-d7ebf5177f55"), Code="FormerHusband", Description="Former husband", Definition="The person is the related person's Former husband.", SortOrder=Convert.ToDecimal("73.00") },
            new ReferenceModelBase { Id=Guid.Parse("a366fff5-2741-4293-83d2-3fc06ccb29aa"), Code="FormerWife", Description="Former wife", Definition="The person is the related person's Former wife.", SortOrder=Convert.ToDecimal("74.00") },
            new ReferenceModelBase { Id=Guid.Parse("811a25f0-7af6-4772-b2af-3b0fc88e82f8"), Code="FosterDaughter", Description="Foster daughter", Definition="The person is the related person's Foster daughter.", SortOrder=Convert.ToDecimal("75.00") },
            new ReferenceModelBase { Id=Guid.Parse("c145205c-83ad-489f-80aa-a0a62caccf19"), Code="FosterFather", Description="Foster father", Definition="The person is the related person's Foster father.", SortOrder=Convert.ToDecimal("76.00") },
            new ReferenceModelBase { Id=Guid.Parse("8c54896f-ff12-4fdc-8d5d-ae54434190de"), Code="FosterMother", Description="Foster mother", Definition="The person is the related person's Foster mother.", SortOrder=Convert.ToDecimal("77.00") },
            new ReferenceModelBase { Id=Guid.Parse("6e8fdebd-5f67-4537-8827-b9b56b3d8440"), Code="FosterParent", Description="Foster Parent", Definition="The person is the related person's Foster Parent.", SortOrder=Convert.ToDecimal("78.00") },
            new ReferenceModelBase { Id=Guid.Parse("fb67f607-6aa9-45a5-8d2c-2824e756d606"), Code="FosterSon", Description="Foster son", Definition="The person is the related person's Foster son.", SortOrder=Convert.ToDecimal("79.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad64d6e7-5edb-488b-9316-cd28c709e262"), Code="Godparent", Description="Godparent", Definition="The person is the related person's Godparent.", SortOrder=Convert.ToDecimal("80.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d0b36d0-3b2c-437a-9875-475a4dd2505c"), Code="Granddaughter", Description="Granddaughter", Definition="The person is the related person's Granddaughter.", SortOrder=Convert.ToDecimal("81.00") },
            new ReferenceModelBase { Id=Guid.Parse("7eaf40be-dad1-447c-9b60-6de376689513"), Code="Grandparent", Description="Grandparent", Definition="The person is the related person's Grandparent.", SortOrder=Convert.ToDecimal("82.00") },
            new ReferenceModelBase { Id=Guid.Parse("b0dec1f5-8d34-45b0-b17a-bc5e741e0df8"), Code="Grandson", Description="Grandson", Definition="The person is the related person's Grandson.", SortOrder=Convert.ToDecimal("83.00") },
            new ReferenceModelBase { Id=Guid.Parse("09e39f1a-ba71-4cd3-a304-8c0a88bb2284"), Code="GreatAunt", Description="Great aunt", Definition="The person is the related person's Great aunt.", SortOrder=Convert.ToDecimal("84.00") },
            new ReferenceModelBase { Id=Guid.Parse("4b4a6991-41de-4c3f-8785-9afeec6f1560"), Code="GreatGrandparent", Description="Great grandparent", Definition="The person is the related person's Great grandparent.", SortOrder=Convert.ToDecimal("85.00") },
            new ReferenceModelBase { Id=Guid.Parse("19fd79dd-6758-4dfd-af97-b798c4a37764"), Code="GreatUncle", Description="Great uncle", Definition="The person is the related person's Great uncle.", SortOrder=Convert.ToDecimal("86.00") },
            new ReferenceModelBase { Id=Guid.Parse("32609d1c-9298-46ff-a253-e22b6ebb851e"), Code="HalfBrother", Description="Half-brother", Definition="The person is the related person's Half-brother.", SortOrder=Convert.ToDecimal("87.00") },
            new ReferenceModelBase { Id=Guid.Parse("f60d1b40-c1e3-415a-b5cd-62ec8697f5b3"), Code="HalfSister", Description="Half-sister", Definition="The person is the related person's Half-sister.", SortOrder=Convert.ToDecimal("88.00") },
            new ReferenceModelBase { Id=Guid.Parse("ebb50561-7042-41e4-8d2b-6717a2e19208"), Code="LifePartner", Description="Life partner", Definition="The person is the related person's Life partner.", SortOrder=Convert.ToDecimal("89.00") },
            new ReferenceModelBase { Id=Guid.Parse("3227b092-cea5-4bfd-bb9b-5a16475c2ba4"), Code="LifePartnerOfParent", Description="Life partner of parent", Definition="The person is the related person's Life partner of parent.", SortOrder=Convert.ToDecimal("90.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d182554-1934-44ff-9c31-386a3fd59a0a"), Code="MotherInLaw", Description="Mother-in-law", Definition="The person is the related person's Mother-in-law", SortOrder=Convert.ToDecimal("91.00") },
            new ReferenceModelBase { Id=Guid.Parse("d70595f2-5e43-4dcd-a72e-386d020f4090"), Code="Neighbor", Description="Neighbor", Definition="The person is the related person's Neighbor.", SortOrder=Convert.ToDecimal("92.00") },
            new ReferenceModelBase { Id=Guid.Parse("4d176b83-2c33-413f-a576-884ad4102c7e"), Code="Parent", Description="Parent", Definition="The person is the related person's Parent.", SortOrder=Convert.ToDecimal("93.00") },
            new ReferenceModelBase { Id=Guid.Parse("1173e5c9-8a74-43ed-9056-4d6609e95474"), Code="Partner", Description="Partner", Definition="The person is the related person's Partner.", SortOrder=Convert.ToDecimal("94.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a4e36e9-d800-4941-8c45-22e2820acc89"), Code="PartnerOfParent", Description="Partner of parent", Definition="The person is the related person's Partner of parent.", SortOrder=Convert.ToDecimal("95.00") },
            new ReferenceModelBase { Id=Guid.Parse("821ff014-4e13-4c35-bb26-f5a30df66ab8"), Code="ProbationOfficer", Description="Probation officer", Definition="The person is the related person's Probation officer.", SortOrder=Convert.ToDecimal("96.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a37d0f0-cb16-424f-a534-b3bb3be8fc4c"), Code="Relative", Description="Relative", Definition="The person is the related person's Relative.", SortOrder=Convert.ToDecimal("97.00") },
            new ReferenceModelBase { Id=Guid.Parse("f57b6cc8-3a63-4567-ae33-c85a25b04fbb"), Code="Sibling", Description="Sibling", Definition="The person is the related person's Sibling.", SortOrder=Convert.ToDecimal("98.00") },
            new ReferenceModelBase { Id=Guid.Parse("a11e30d3-5a2f-404e-9041-5d7a99d600a8"), Code="SisterInLaw", Description="Sister-in-law", Definition="The person is the related person's Sister-in-law", SortOrder=Convert.ToDecimal("99.00") },
            new ReferenceModelBase { Id=Guid.Parse("f960f836-ee3e-420e-b0a2-92b362e048fc"), Code="SonInLaw", Description="Son-in-law", Definition="The person is the related person's Son-in-law", SortOrder=Convert.ToDecimal("100.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff48a236-4a66-4c7b-bad1-6eff296ecb56"), Code="Spouse", Description="Spouse", Definition="The person is the related person's Spouse.", SortOrder=Convert.ToDecimal("101.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd64cb9e-63fb-49b0-a0f3-b593cda3d0a0"), Code="Stepbrother", Description="Stepbrother", Definition="The person is the related person's Stepbrother.", SortOrder=Convert.ToDecimal("102.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f7fc178-1077-4eb0-90be-35430ccd9b9e"), Code="Stepdaughter", Description="Stepdaughter", Definition="The person is the related person's Stepdaughter.", SortOrder=Convert.ToDecimal("103.00") },
            new ReferenceModelBase { Id=Guid.Parse("47d84464-847d-437d-82ed-098f7ef8809b"), Code="Stepfather", Description="Stepfather", Definition="The person is the related person's Stepfather.", SortOrder=Convert.ToDecimal("104.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a421c83-4c63-41f3-9e13-ff04f721d1b8"), Code="Stepmother", Description="Stepmother", Definition="The person is the related person's Stepmother.", SortOrder=Convert.ToDecimal("105.00") },
            new ReferenceModelBase { Id=Guid.Parse("e9e5c2f5-efa4-4bba-8cf7-df47955dca40"), Code="Stepparent", Description="Stepparent", Definition="The person is the related person's Stepparent.", SortOrder=Convert.ToDecimal("106.00") },
            new ReferenceModelBase { Id=Guid.Parse("b138b418-ec92-4b85-9605-412e4278f7bd"), Code="Stepsister", Description="Stepsister", Definition="The person is the related person's Stepsister.", SortOrder=Convert.ToDecimal("107.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d510606-e603-4797-872b-b9c6f9015d7f"), Code="Stepson", Description="Stepson", Definition="The person is the related person's Stepson.", SortOrder=Convert.ToDecimal("108.00") },
        };
        #endregion
    }
}

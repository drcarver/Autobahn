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
            new ReferenceModelBase { Id=Guid.Parse("86112e5e-40c6-41ab-8f29-eab8941e0323"), Code="Aunt", Description="Aunt", Definition="The person is the related person's Aunt.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("0bf08b5c-05d8-4d32-aa31-f7c16d44b797"), Code="Brother", Description="Brother", Definition="The person is the related person's Brother.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("c320e343-a567-4329-b8a8-eb595725c564"), Code="BrotherInLaw", Description="Brother-in-law", Definition="The person is the related person's Brother-in-law.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("65485249-cf44-43ba-b4e1-c7ff8eb0bc0a"), Code="CourtAppointedGuardian", Description="Court appointed guardian", Definition="The person is the related person's court appointed guardian.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("a93f4343-cccb-4e1e-808e-0f55a4c214d8"), Code="Daughter", Description="Daughter", Definition="The person is the related person's Daughter.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee6b9815-f426-43c8-95f8-6a04be766f0b"), Code="DaughterInLaw", Description="Daughter-in-law", Definition="The person is the related person's Aunt.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6953404-2bd6-4a8f-989d-5e5bf888c610"), Code="Employer", Description="Employer", Definition="The person is the related person's Employer.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("63421dd3-e4bc-4d89-82b1-b81289876816"), Code="Father", Description="Father", Definition="The person is the related person's Father.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("327cb6e0-2702-4407-91f3-119bcc56f4c8"), Code="FathersSignificantOther", Description="Father's significant other", Definition="The person is the significant other of the related person's Father.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("03ef60da-ee6c-461f-9c48-698ee9a0c0c6"), Code="FathersCivilPartner", Description="Father's civil partner", Definition="The person is a legal partner of the related person's father, established by a civil union other than marriage.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("0394cf45-6048-4e10-bffc-d6d1298cdb04"), Code="FatherInLaw", Description="Father-in-law", Definition="The person is the father of the related person's spouse.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("a007dbfb-ad7e-457e-953a-a34771207bad"), Code="Fiance", Description="Fiance", Definition="The person is a man who is engaged to be married to the related person.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("592c3f73-ba1f-4134-acd1-511d3f1857b1"), Code="Fiancee", Description="Fiancee", Definition="The person is a woman who is engaged to be married to the related person.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("e355c966-1b65-4fbc-a2be-3daf316cffae"), Code="Friend", Description="Friend", Definition="The person is the related person's Friend.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("a5fff7a6-5ae1-43d6-9fec-7518900388e8"), Code="Grandfather", Description="Grandfather", Definition="The person is the related person's Grandfather.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("40a6452c-15cf-4c82-a486-6204792d3a91"), Code="Grandmother", Description="Grandmother", Definition="The person is the related person's Grandmother.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("569eadbc-8883-45cf-9cbc-c38976e48694"), Code="Husband", Description="Husband", Definition="The person is the related person's Husband.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("fc80f078-417e-458f-b67c-c753061e24ed"), Code="MothersSignificantOther", Description="Mother's significant other", Definition="The person is the significant other of the related person's Mother.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("7e989cec-3979-4a2d-81ff-c1be8f0f373b"), Code="Mother", Description="Mother", Definition="The person is the related person's Mother", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("c4877f50-8dc8-4df1-8d9f-3f0389305499"), Code="MothersCivilPartner", Description="Mother's civil partner", Definition="The person is a legal partner of the related person's mother, established by a civil union other than marriage.", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("88537a8e-a6dc-42d8-9dbf-ed5c5fe5a331"), Code="Nephew", Description="Nephew", Definition="The person is the related person's Nephew.", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("46b58b93-c77a-4103-9d39-2324adb5cbe8"), Code="Niece", Description="Niece", Definition="The person is the related person's Niece.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d24f4bc-829e-42f5-acb9-1df581dc71df"), Code="Other", Description="Other", Definition="The person is related to the related person in a way not represented by other standard options.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("5dc7a301-3130-4e44-83c1-0c395fe3adaf"), Code="SignificantOther", Description="Significant other", Definition="The person is the Significant other of the related person.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("c97e139a-a326-4d3b-85eb-d7dd1a17d306"), Code="Sister", Description="Sister", Definition="The person is the related person's Sister.", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("b147131e-934c-4835-aa4f-c45329f02ef8"), Code="Son", Description="Son", Definition="The person is the related person's Son.", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("469fb396-4579-46f2-8a04-abf08efbca19"), Code="Unknown", Description="Unknown", Definition="The person is the related person's Unknown.", SortOrder=Convert.ToDecimal("61.00") },
            new ReferenceModelBase { Id=Guid.Parse("75ffe586-b86a-4fa2-9dcd-d51758ffcd6b"), Code="Uncle", Description="Uncle", Definition="The person is the related person's Uncle.", SortOrder=Convert.ToDecimal("62.00") },
            new ReferenceModelBase { Id=Guid.Parse("8bb2c22e-0ef7-417c-b58e-4d3fae3f2e86"), Code="Ward", Description="Ward", Definition="The person is the related person's Ward.", SortOrder=Convert.ToDecimal("63.00") },
            new ReferenceModelBase { Id=Guid.Parse("02df1835-43cd-4e1b-94a2-5375a146ad2d"), Code="Wife", Description="Wife", Definition="The person is the related person's Wife.", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("99446855-3a8a-440a-9a80-2a1fe4803396"), Code="AdoptedDaughter", Description="Adopted Daughter", Definition="The person is the related person's Adopted Daughter.", SortOrder=Convert.ToDecimal("65.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6f8e82c-e230-4f23-ae70-5d91022f24c0"), Code="AdoptedSon", Description="Adopted son", Definition="The person is the related person's Adopted son.", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("84c38cc5-5cda-40e3-8879-a1001b0260cf"), Code="AdoptiveParent", Description="Adoptive parent", Definition="The person is the related person's Adoptive parent.", SortOrder=Convert.ToDecimal("67.00") },
            new ReferenceModelBase { Id=Guid.Parse("052932cb-c796-4e51-9d69-1a8e61ef6e14"), Code="Advisor", Description="Advisor", Definition="The person is the related person's Advisor.", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("fbedd56e-08c1-4593-b2fa-224b35638518"), Code="AgencyRepresentative", Description="Agency representative", Definition="The person is the related person's Agency representative.", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("5bc3257e-c21f-4874-92a8-91b0a153488d"), Code="Cousin", Description="Cousin", Definition="The person is the related person's Cousin.", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("aa72a485-1487-4b0b-9cbe-baf2042894b3"), Code="Dependent", Description="Dependent", Definition="The person is the related person's Dependent.", SortOrder=Convert.ToDecimal("71.00") },
            new ReferenceModelBase { Id=Guid.Parse("b62af05d-b6e6-4ac3-bf23-d093fd9eef51"), Code="FamilyMember", Description="Family member", Definition="The person is the related person's Family member.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("b5a9947a-5d7e-4a36-b845-a9ad708af4cf"), Code="FormerHusband", Description="Former husband", Definition="The person is the related person's Former husband.", SortOrder=Convert.ToDecimal("73.00") },
            new ReferenceModelBase { Id=Guid.Parse("6112e749-e4ff-43bf-a576-aa385f0c6bc3"), Code="FormerWife", Description="Former wife", Definition="The person is the related person's Former wife.", SortOrder=Convert.ToDecimal("74.00") },
            new ReferenceModelBase { Id=Guid.Parse("7b9a7b37-099b-4526-b09a-35b468141658"), Code="FosterDaughter", Description="Foster daughter", Definition="The person is the related person's Foster daughter.", SortOrder=Convert.ToDecimal("75.00") },
            new ReferenceModelBase { Id=Guid.Parse("78bd747c-0554-47b8-9404-b094e1c24a1e"), Code="FosterFather", Description="Foster father", Definition="The person is the related person's Foster father.", SortOrder=Convert.ToDecimal("76.00") },
            new ReferenceModelBase { Id=Guid.Parse("7079954b-443d-4a47-a5cd-73baf1cf0409"), Code="FosterMother", Description="Foster mother", Definition="The person is the related person's Foster mother.", SortOrder=Convert.ToDecimal("77.00") },
            new ReferenceModelBase { Id=Guid.Parse("57ad1383-d8b1-4d7a-9792-802a325c50a0"), Code="FosterParent", Description="Foster Parent", Definition="The person is the related person's Foster Parent.", SortOrder=Convert.ToDecimal("78.00") },
            new ReferenceModelBase { Id=Guid.Parse("f62f61f8-1c0e-4d4b-9df6-be9fc746f549"), Code="FosterSon", Description="Foster son", Definition="The person is the related person's Foster son.", SortOrder=Convert.ToDecimal("79.00") },
            new ReferenceModelBase { Id=Guid.Parse("f635f8fa-a5a3-4240-a1a1-1c6f58d88c60"), Code="Godparent", Description="Godparent", Definition="The person is the related person's Godparent.", SortOrder=Convert.ToDecimal("80.00") },
            new ReferenceModelBase { Id=Guid.Parse("4090bf3c-9194-4030-8972-51e7171234b9"), Code="Granddaughter", Description="Granddaughter", Definition="The person is the related person's Granddaughter.", SortOrder=Convert.ToDecimal("81.00") },
            new ReferenceModelBase { Id=Guid.Parse("6143e4a3-a5a8-4027-bac6-8b58b7976479"), Code="Grandparent", Description="Grandparent", Definition="The person is the related person's Grandparent.", SortOrder=Convert.ToDecimal("82.00") },
            new ReferenceModelBase { Id=Guid.Parse("527d64ac-42d5-4ffb-8a74-00312d135ec6"), Code="Grandson", Description="Grandson", Definition="The person is the related person's Grandson.", SortOrder=Convert.ToDecimal("83.00") },
            new ReferenceModelBase { Id=Guid.Parse("661e15eb-bf0c-4a92-80ad-8137144dd12a"), Code="GreatAunt", Description="Great aunt", Definition="The person is the related person's Great aunt.", SortOrder=Convert.ToDecimal("84.00") },
            new ReferenceModelBase { Id=Guid.Parse("c38d104d-c32f-40b9-9d0c-873a39f52e23"), Code="GreatGrandparent", Description="Great grandparent", Definition="The person is the related person's Great grandparent.", SortOrder=Convert.ToDecimal("85.00") },
            new ReferenceModelBase { Id=Guid.Parse("52350c40-4df9-482c-bd0c-fe86c0deb828"), Code="GreatUncle", Description="Great uncle", Definition="The person is the related person's Great uncle.", SortOrder=Convert.ToDecimal("86.00") },
            new ReferenceModelBase { Id=Guid.Parse("4d772a85-7ab4-4869-9916-96134b2312d5"), Code="HalfBrother", Description="Half-brother", Definition="The person is the related person's Half-brother.", SortOrder=Convert.ToDecimal("87.00") },
            new ReferenceModelBase { Id=Guid.Parse("d072f4bf-2aab-45e5-ba2d-c0e162aadf36"), Code="HalfSister", Description="Half-sister", Definition="The person is the related person's Half-sister.", SortOrder=Convert.ToDecimal("88.00") },
            new ReferenceModelBase { Id=Guid.Parse("45b2d077-4fec-4493-8885-136738616925"), Code="LifePartner", Description="Life partner", Definition="The person is the related person's Life partner.", SortOrder=Convert.ToDecimal("89.00") },
            new ReferenceModelBase { Id=Guid.Parse("1a708358-b142-433a-9186-1e7fbe142dde"), Code="LifePartnerOfParent", Description="Life partner of parent", Definition="The person is the related person's Life partner of parent.", SortOrder=Convert.ToDecimal("90.00") },
            new ReferenceModelBase { Id=Guid.Parse("830cc19b-7028-46e4-b020-da9fd99ce619"), Code="MotherInLaw", Description="Mother-in-law", Definition="The person is the related person's Mother-in-law", SortOrder=Convert.ToDecimal("91.00") },
            new ReferenceModelBase { Id=Guid.Parse("36b2822c-827e-485b-ae93-b72bfb79357c"), Code="Neighbor", Description="Neighbor", Definition="The person is the related person's Neighbor.", SortOrder=Convert.ToDecimal("92.00") },
            new ReferenceModelBase { Id=Guid.Parse("45f42b8f-7ad6-4c45-9f0a-f2bdc5e2d039"), Code="Parent", Description="Parent", Definition="The person is the related person's Parent.", SortOrder=Convert.ToDecimal("93.00") },
            new ReferenceModelBase { Id=Guid.Parse("8f586c55-7c93-4269-8ab1-969e305bc203"), Code="Partner", Description="Partner", Definition="The person is the related person's Partner.", SortOrder=Convert.ToDecimal("94.00") },
            new ReferenceModelBase { Id=Guid.Parse("452dccc9-8c96-420a-8bf5-e8ac9c00d69f"), Code="PartnerOfParent", Description="Partner of parent", Definition="The person is the related person's Partner of parent.", SortOrder=Convert.ToDecimal("95.00") },
            new ReferenceModelBase { Id=Guid.Parse("873ca01b-7780-4ede-992b-d66e92119a25"), Code="ProbationOfficer", Description="Probation officer", Definition="The person is the related person's Probation officer.", SortOrder=Convert.ToDecimal("96.00") },
            new ReferenceModelBase { Id=Guid.Parse("d205f229-eb10-4680-a1e5-80fd7b14b96b"), Code="Relative", Description="Relative", Definition="The person is the related person's Relative.", SortOrder=Convert.ToDecimal("97.00") },
            new ReferenceModelBase { Id=Guid.Parse("0ea0c6b3-32f6-4850-80bc-4e6120e7d3e8"), Code="Sibling", Description="Sibling", Definition="The person is the related person's Sibling.", SortOrder=Convert.ToDecimal("98.00") },
            new ReferenceModelBase { Id=Guid.Parse("57390267-6e39-454a-8310-d2e49146b2df"), Code="SisterInLaw", Description="Sister-in-law", Definition="The person is the related person's Sister-in-law", SortOrder=Convert.ToDecimal("99.00") },
            new ReferenceModelBase { Id=Guid.Parse("54755bad-47cf-430e-9982-be8f781d943f"), Code="SonInLaw", Description="Son-in-law", Definition="The person is the related person's Son-in-law", SortOrder=Convert.ToDecimal("100.00") },
            new ReferenceModelBase { Id=Guid.Parse("680e5f11-5e25-4ff4-a03e-338c2404c248"), Code="Spouse", Description="Spouse", Definition="The person is the related person's Spouse.", SortOrder=Convert.ToDecimal("101.00") },
            new ReferenceModelBase { Id=Guid.Parse("8998b1ce-2295-410d-9b6e-13665bc549f4"), Code="Stepbrother", Description="Stepbrother", Definition="The person is the related person's Stepbrother.", SortOrder=Convert.ToDecimal("102.00") },
            new ReferenceModelBase { Id=Guid.Parse("f08d1eda-75f6-4774-ae3d-fdc8e25988b9"), Code="Stepdaughter", Description="Stepdaughter", Definition="The person is the related person's Stepdaughter.", SortOrder=Convert.ToDecimal("103.00") },
            new ReferenceModelBase { Id=Guid.Parse("7778112a-73e3-4331-826b-be2c07baf42c"), Code="Stepfather", Description="Stepfather", Definition="The person is the related person's Stepfather.", SortOrder=Convert.ToDecimal("104.00") },
            new ReferenceModelBase { Id=Guid.Parse("2945138d-5f7a-4d26-a59c-6254c334d940"), Code="Stepmother", Description="Stepmother", Definition="The person is the related person's Stepmother.", SortOrder=Convert.ToDecimal("105.00") },
            new ReferenceModelBase { Id=Guid.Parse("81f3a369-58af-4119-b035-506f85e83c4a"), Code="Stepparent", Description="Stepparent", Definition="The person is the related person's Stepparent.", SortOrder=Convert.ToDecimal("106.00") },
            new ReferenceModelBase { Id=Guid.Parse("678b1800-ded5-440e-b757-453894b1cf1e"), Code="Stepsister", Description="Stepsister", Definition="The person is the related person's Stepsister.", SortOrder=Convert.ToDecimal("107.00") },
            new ReferenceModelBase { Id=Guid.Parse("4677d499-2047-489d-898c-681a8344462f"), Code="Stepson", Description="Stepson", Definition="The person is the related person's Stepson.", SortOrder=Convert.ToDecimal("108.00") },
        };
        #endregion
    }
}

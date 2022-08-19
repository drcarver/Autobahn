//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentViewModel.cs
//* Name:       Teaching Assignment Contribution Percentage
//* Definition: A percentage used to weight the educator's assigned responsibility for student learning in a Class Section, particularly when more than one educator is assigned to the class section.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// A percentage used to weight the educator's assigned responsibility for student learning in a Class Section, particularly when more than one educator is assigned to the class section.
     /// </summary>
    public partial class K12StaffAssignmentViewModel : ViewModelBase, Interfaces.IK12StaffAssignment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StaffAssignment";

        // ContributionPercentage -- (backing property for Teaching Assignment Contribution Percentage)
        private System.Decimal? _ContributionPercentage;

        // FullTimeEquivalency -- (backing property for Staff Full Time Equivalency)
        private System.Decimal? _FullTimeEquivalency;

        // HighlyQualifiedTeacherIndicator -- (backing property for Highly Qualified Teacher Indicator)
        private System.Boolean? _HighlyQualifiedTeacherIndicator;

        // ItinerantTeacher -- (backing property for Itinerant Teacher)
        private System.Boolean? _ItinerantTeacher;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // PrimaryAssignment -- (backing property for Primary Assignment Indicator)
        private System.Boolean? _PrimaryAssignment;

        // RefClassroomPositionTypeId -- (backing property for Classroom Position Type)
        private Guid? _RefClassroomPositionTypeId;

        // RefEDFactsTeacherInexperiencedStatusId -- (backing property for EDFacts Teacher Inexperienced Status)
        private Guid? _RefEDFactsTeacherInexperiencedStatusId;

        // member variable for the RefEmergencyOrProvisionalCredentialStatusId property
        private Guid? _RefEmergencyOrProvisionalCredentialStatusId;

        // RefK12StaffClassificationId -- (backing property for K12 Staff Classification)
        private Guid? _RefK12StaffClassificationId;

        // RefMepStaffCategoryId -- (backing property for Migrant Education Program Staff Category)
        private Guid? _RefMepStaffCategoryId;

        // RefOutOfFieldStatusId -- (backing property for EDFacts Teacher Out of Field Status)
        private Guid? _RefOutOfFieldStatusId;

        // RefProfessionalEducationJobClassificationId -- (backing property for Professional Educational Job Classification)
        private Guid? _RefProfessionalEducationJobClassificationId;

        // RefSpecialEducationAgeGroupTaughtId -- (backing property for Special Education Age Group Taught)
        private Guid? _RefSpecialEducationAgeGroupTaughtId;

        // RefSpecialEducationStaffCategoryId -- (backing property for Special Education Support Services Category)
        private Guid? _RefSpecialEducationStaffCategoryId;

        // RefTeachingAssignmentRoleId -- (backing property for Teaching Assignment Role)
        private Guid? _RefTeachingAssignmentRoleId;

        // RefTitleIProgramStaffCategoryId -- (backing property for Title I Program Staff Category)
        private Guid? _RefTitleIProgramStaffCategoryId;

        // SpecialEducationParaprofessional -- (backing property for Special Education Paraprofessional)
        private System.Boolean? _SpecialEducationParaprofessional;

        // SpecialEducationRelatedServicesPersonnel -- (backing property for Special Education Related Services Personnel)
        private System.Boolean? _SpecialEducationRelatedServicesPersonnel;

        // SpecialEducationTeacher -- (backing property for Special Education Teacher)
        private System.Boolean? _SpecialEducationTeacher;

        // TeacherOfRecord -- (backing property for Teacher of Record)
        private System.Boolean? _TeacherOfRecord;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Teaching Assignment Contribution Percentage
        /// <para>
        /// A percentage used to weight the educator's assigned responsibility for student learning in a Class Section, particularly when more than one educator is assigned to the class section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19651">Teaching Assignment Contribution Percentage</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? ContributionPercentage { get => _ContributionPercentage; set => SetProperty(ref _ContributionPercentage, value); }

        /// <summary>
        /// Staff Full Time Equivalency
        /// <para>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// Highly Qualified Teacher Indicator
        /// <para>
        /// An indication that the teacher has been classified as highly qualified based on assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19142">Highly Qualified Teacher Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? HighlyQualifiedTeacherIndicator { get => _HighlyQualifiedTeacherIndicator; set => SetProperty(ref _HighlyQualifiedTeacherIndicator, value); }

        /// <summary>
        /// Itinerant Teacher
        /// <para>
        /// An indication of whether a teacher provides instruction in more than one instructional site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19519">Itinerant Teacher</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ItinerantTeacher { get => _ItinerantTeacher; set => SetProperty(ref _ItinerantTeacher, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Primary Assignment Indicator
        /// <para>
        /// An indication of whether the assignment is the staff member's primary assignment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19516">Primary Assignment Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PrimaryAssignment { get => _PrimaryAssignment; set => SetProperty(ref _PrimaryAssignment, value); }

        /// <summary>
        /// Classroom Position Type
        /// <para>
        /// The type of position the staff member holds in the specific course section.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19615">Classroom Position Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefClassroomPositionTypeId { get => _RefClassroomPositionTypeId; set => SetProperty(ref _RefClassroomPositionTypeId, value); }

        /// <summary>
        /// EDFacts Teacher Inexperienced Status
        /// <para>
        /// An indication of whether teachers have been identified as inexperienced as defined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20929">EDFacts Teacher Inexperienced Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEDFactsTeacherInexperiencedStatusId { get => _RefEDFactsTeacherInexperiencedStatusId; set => SetProperty(ref _RefEDFactsTeacherInexperiencedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        public Guid? RefEmergencyOrProvisionalCredentialStatusId { get => _RefEmergencyOrProvisionalCredentialStatusId; set => SetProperty(ref _RefEmergencyOrProvisionalCredentialStatusId, value); }

        /// <summary>
        /// K12 Staff Classification
        /// <para>
        /// The titles of employment, official status, or rank of education staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19087">K12 Staff Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        /// <summary>
        /// Migrant Education Program Staff Category
        /// <para>
        /// Titles of employment, official status, or rank of staff working in the Migrant Education Program (MEP).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19188">Migrant Education Program Staff Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMepStaffCategoryId { get => _RefMepStaffCategoryId; set => SetProperty(ref _RefMepStaffCategoryId, value); }

        /// <summary>
        /// EDFacts Teacher Out of Field Status
        /// <para>
        /// An indication of whether teachers have been identified as teaching a subject or field for which they are not certified or licensed as defined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20930">EDFacts Teacher Out of Field Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefOutOfFieldStatusId { get => _RefOutOfFieldStatusId; set => SetProperty(ref _RefOutOfFieldStatusId, value); }

        /// <summary>
        /// Professional Educational Job Classification
        /// <para>
        /// A general job classification that describes staff that performs duties requiring a high degree of knowledge and skills generally acquired through at least a baccalaureate degree (or its equivalent obtained through special study and/or experience) including skills in the field of education, educational psychology, educational social work, or an education therapy field.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19220">Professional Educational Job Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProfessionalEducationJobClassificationId { get => _RefProfessionalEducationJobClassificationId; set => SetProperty(ref _RefProfessionalEducationJobClassificationId, value); }

        /// <summary>
        /// Special Education Age Group Taught
        /// <para>
        /// The age range of special education students taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19556">Special Education Age Group Taught</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSpecialEducationAgeGroupTaughtId { get => _RefSpecialEducationAgeGroupTaughtId; set => SetProperty(ref _RefSpecialEducationAgeGroupTaughtId, value); }

        /// <summary>
        /// Special Education Support Services Category
        /// <para>
        /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19549">Special Education Support Services Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get => _RefSpecialEducationStaffCategoryId; set => SetProperty(ref _RefSpecialEducationStaffCategoryId, value); }

        /// <summary>
        /// Teaching Assignment Role
        /// <para>
        /// The role that the Staff Member has been assigned for a Class Section.  (A teacher may have the lead responsibility for one section and serve a supporting role for another section of the same course.)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19650">Teaching Assignment Role</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeachingAssignmentRoleId { get => _RefTeachingAssignmentRoleId; set => SetProperty(ref _RefTeachingAssignmentRoleId, value); }

        /// <summary>
        /// Title I Program Staff Category
        /// <para>
        /// Titles of employment, official status, or rank for staff working in a Title I program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19283">Title I Program Staff Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTitleIProgramStaffCategoryId { get => _RefTitleIProgramStaffCategoryId; set => SetProperty(ref _RefTitleIProgramStaffCategoryId, value); }

        /// <summary>
        /// Special Education Paraprofessional
        /// <para>
        /// An indication of whether a paraprofessional is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19261">Special Education Paraprofessional</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? SpecialEducationParaprofessional { get => _SpecialEducationParaprofessional; set => SetProperty(ref _SpecialEducationParaprofessional, value); }

        /// <summary>
        /// Special Education Related Services Personnel
        /// <para>
        /// An indication of whether a related services person is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19262">Special Education Related Services Personnel</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? SpecialEducationRelatedServicesPersonnel { get => _SpecialEducationRelatedServicesPersonnel; set => SetProperty(ref _SpecialEducationRelatedServicesPersonnel, value); }

        /// <summary>
        /// Special Education Teacher
        /// <para>
        /// An indication of whether a teacher is employed or contracted to work with children with disabilities who are ages 3 through 21.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19264">Special Education Teacher</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? SpecialEducationTeacher { get => _SpecialEducationTeacher; set => SetProperty(ref _SpecialEducationTeacher, value); }

        /// <summary>
        /// Teacher of Record
        /// <para>
        /// Staff member who has a Teacher of Record responsibility for a Class Section based upon the state's definition of Teacher of Record.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19649">Teacher of Record</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TeacherOfRecord { get => _TeacherOfRecord; set => SetProperty(ref _TeacherOfRecord, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffAssignment model)
        {
            IsBusy = true;
            Id = model.Id;
            ContributionPercentage = model.ContributionPercentage; // Teaching Assignment Contribution Percentage
            FullTimeEquivalency = model.FullTimeEquivalency; // Staff Full Time Equivalency
            HighlyQualifiedTeacherIndicator = model.HighlyQualifiedTeacherIndicator; // Highly Qualified Teacher Indicator
            ItinerantTeacher = model.ItinerantTeacher; // Itinerant Teacher
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            PrimaryAssignment = model.PrimaryAssignment; // Primary Assignment Indicator
            RefClassroomPositionTypeId = model.RefClassroomPositionTypeId; // Classroom Position Type
            RefEDFactsTeacherInexperiencedStatusId = model.RefEDFactsTeacherInexperiencedStatusId; // EDFacts Teacher Inexperienced Status
            RefEmergencyOrProvisionalCredentialStatusId = model.RefEmergencyOrProvisionalCredentialStatusId; // 
            RefK12StaffClassificationId = model.RefK12StaffClassificationId; // K12 Staff Classification
            RefMepStaffCategoryId = model.RefMepStaffCategoryId; // Migrant Education Program Staff Category
            RefOutOfFieldStatusId = model.RefOutOfFieldStatusId; // EDFacts Teacher Out of Field Status
            RefProfessionalEducationJobClassificationId = model.RefProfessionalEducationJobClassificationId; // Professional Educational Job Classification
            RefSpecialEducationAgeGroupTaughtId = model.RefSpecialEducationAgeGroupTaughtId; // Special Education Age Group Taught
            RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId; // Special Education Support Services Category
            RefTeachingAssignmentRoleId = model.RefTeachingAssignmentRoleId; // Teaching Assignment Role
            RefTitleIProgramStaffCategoryId = model.RefTitleIProgramStaffCategoryId; // Title I Program Staff Category
            SpecialEducationParaprofessional = model.SpecialEducationParaprofessional; // Special Education Paraprofessional
            SpecialEducationRelatedServicesPersonnel = model.SpecialEducationRelatedServicesPersonnel; // Special Education Related Services Personnel
            SpecialEducationTeacher = model.SpecialEducationTeacher; // Special Education Teacher
            TeacherOfRecord = model.TeacherOfRecord; // Teacher of Record
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefK12StaffClassification List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefK12StaffClassificationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("c6d7c4db-9689-4264-907f-58093170e5c4"), Code="AdministrativeSupportStaff", Description="Administrative Support Staff", Definition="Staff members who provide direct support to administrators, business office support, data processing, or support of the teaching and administrative duties of the office of the principal or department chairpersons, including clerical staff and secretaries.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("562bd0b6-483a-4ab8-b85f-66094c624b8c"), Code="Administrators", Description="Administrators", Definition="Executive officers or managers of education agencies or institutions, including superintendents, deputies, and assistant superintendents; other persons with district-wide responsibilities: e.g., business managers, administrative assistants, and professional instructional support staff.   In addition, staff members whose activities are concerned with directing and managing the operation of a particular school including principals, assistant principals, and other assistants; persons who supervise school operations, assign duties to staff members, supervise and maintain the records of the school, and coordinate school instructional activities with those of the education agency, including department chairpersons.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b76b28b3-4f95-4ba3-9ac6-6b1288c39c6d"), Code="AllOtherSupportStaff", Description="All Other Support Staff ", Definition="Support staff not reported in instructional or student support. Other support staff includes employees such as data processing, health, plant and equipment maintenance, bus drivers, security, and food service workers.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("da88ef63-5a73-49d9-8a92-b6bb532ed6eb"), Code="BehavioralSpecialists", Description="Behavioral Specialists", Definition="Behavioral Specialists", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("1d55d041-a7f1-417b-acbf-182f76135de4"), Code="ELAssistantTeachers", Description="Early Learning Assistant Teachers", Definition="Assistant Teachers of general level instruction and/or services delivery classified by state and local practice from birth to Kindergarten.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("4e331e67-0634-4be7-b437-617ace09fab6"), Code="ELTeachers", Description="Early Learning Teachers", Definition="Teachers of general level instruction and/or service delivery classified by state and local practice from birth to Kindergarten.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("87f8b90f-47fb-4dc5-9f30-74c0a47ac013"), Code="ElementaryTeachers", Description="Elementary Teachers", Definition="Teachers of general level instruction classified by state and local practice as elementary and composed of any span of grades not above grade 8.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("e7586d4d-a879-4a7a-ad1c-2b96489dabe9"), Code="FamilyServiceWorkers", Description="Family Service Workers", Definition="Professional staff members assigned specific duties related to staff providing in-home and other services (including needs assessment, development of service plans, family advocacy, and coordination of service delivery) to families of children participating in early care and education programs.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("2c6ed75e-89c2-45ce-96b2-12d8d93f7cc2"), Code="HealthSpecialists", Description="Health Specialists", Definition="Professional staff members or supervisors assigned specific duties related to providing any Health services that are not specific to mental health.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("36724f4b-6fad-4c10-acda-76ae43b56284"), Code="HomeVisitors", Description="Home Visitors", Definition="Professional staff members assigned specific duties related to visiting a child or pregnant woman's home for the purpose of assisting parents in fostering the growth and development of their child.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("6efe1d11-c078-41ce-a995-0d393876d2ee"), Code="InstructionalCoordinators", Description="Instructional Coordinators", Definition="Staff supervising instruction programs including: professional staff members or supervisors in an early learning program assigned specific duties related to instruction; supervisors at a school district or sub-district level including curricular coordinators or supervisors; in-service training staff; Title I supervisors; home economics supervisors; educational television staff; coordinators and supervisors of audiovisual services; and staff engaged in development of computer-assisted instruction.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("d2403d3d-7043-41b6-ac29-357abdad4e16"), Code="KindergartenTeachers", Description="Kindergarten Teachers", Definition="Teachers of a group or class that is part of a public school program and is taught during the year preceding the first grade.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("9b57e14a-9a7e-4862-9b8e-68e15e8f5be0"), Code="LibraryMediaSpecialists", Description="Librarians/Media Specialists", Definition="A professional staff member or supervisor assigned specific duties and school time for professional library and media service activities. Activities include: selecting, acquiring, preparing, cataloging, and circulating books and other printed materials; planning the use of library and media services by students, teachers and other members of the instructional staff; and guiding individuals in their use of media services and library materials, (whether maintained separately or as part of an instructional materials center).", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("f52bf00a-dfd0-4baa-9978-e910718ec5ad"), Code="LibraryMediaSupportStaff", Description="Library/Media Support Staff", Definition="Staff members who render other library or media services, such as preparing, caring for, and making available to members of the instructional staff the equipment, films, filmstrips, transparencies, tapes, TV programs, and similar materials (whether maintained separately as part of an instructional materials center).", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("7b5efaff-8810-432e-8c1b-bf4719822ee5"), Code="MentalHealthSpecialists", Description="Mental Health Specialists", Definition="Professional staff members or supervisors assigned specific duties related to Mental Health.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("a72b6906-4ade-473a-b5e1-e835a1ab8aaf"), Code="NutritionSpecialists", Description="Nutrition Specialists", Definition="Professional staff members or supervisors assigned specific duties related to Nutrition.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b4f3774-f612-4d85-8c4b-3ed2b061d225"), Code="Paraprofessionals", Description="Paraprofessionals", Definition="Paraprofessionals are employees who provide instructional support, including those who: (1) provide one-on-one tutoring if such tutoring is scheduled at a time when a student would not otherwise receive instruction from a teacher, (2) assist with classroom management, such as organizing instructional and other materials, (3) provide instructional assistance in a computer laboratory, (4) conduct parental involvement activities, (5) provide support in a library or media center, (6) act as a translator, or (7) provide instructional support services under the direct supervision of a teacher.", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("095910ae-b0cd-4baf-a458-f4585a5f36ba"), Code="PartCEarlyInterventionists", Description="Part C Early Interventionists", Definition="Professional staff members employed to provide early intervention services to infants and toddlers with disabilities or at-risk of experiencing a substantial developmental delay as defined by Part C of the  Individuals with Disabilities Education Act (IDEA): The Early Intervention Program for Infants and Toddlers with Disabilities.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("e87e4b58-6265-40b5-a4f7-ffbb62477287"), Code="PartCServiceCoordinators", Description="Part C Service Coordinators", Definition="Professional staff members employed to coordinate early intervention services to infants and toddlers with disabilities or at-risk of experiencing a substantial developmental delay  as defined by Part C of the  Individuals with Disabilities Education Act (IDEA): The Early Intervention Program for Infants and Toddlers with Disabilities.", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("adf1ad4d-267b-41b9-8074-a2161128b229"), Code="SchoolCounselors", Description="School Counselors", Definition="Professional staff members assigned specific duties and school time for any of the following activities: counseling with students and parents, consulting with other staff members on learning problems, evaluating student abilities, assisting students in making education and career choices, assisting students in personal and social development, providing referral assistance, and/or working with other staff members in planning and conducting guidance programs for students. School counselors may be reported by elementary and secondary level when that information is available.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("ae00c6f6-3f16-4ac5-89c2-53c4e55d4305"), Code="SecondaryTeachers", Description="Secondary Teachers", Definition="Teachers of a general level of instruction classified by state and local practice as secondary and composed of any span of grades beginning with the next grade following the elementary grades and ending with or below grade 12.", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("c035e5c3-8af4-4e38-bbe7-20c755237d3c"), Code="SocialWorkers", Description="Social Workers", Definition="Social workers assist people by helping them cope with and solve issues in their everyday lives, such as family and personal problems and dealing with relationships. ", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("ef8445ca-336a-422d-8657-efe0f58478d6"), Code="SpecialEducationTeachers", Description="Special Education Teachers", Definition="Special Education teachers include teachers employed to provide special education services to children with disabilities, including preschool teachers, itinerant/consulting teachers, and home/hospital teachers.  This should include teachers of children with disabilities in separate schools and facilities.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("0d2f56c8-fcda-4d41-988f-775107124de1"), Code="SpecialNeedsSpecialists", Description="Special Needs Specialists", Definition="Professional staff members or supervisors assigned specific duties related to special needs learners.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("7304d95a-2577-4838-af09-367efc219972"), Code="StudentSupportServicesStaff", Description="Student Support Services Staff", Definition="Professional and supervisory staff providing non-instructional services to students and supervisors of the preceding staff and of health, transportation, and food service workers.", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("55c58d36-5be0-4e29-a22b-25bc6a04fce7"), Code="UngradedTeachers", Description="Ungraded Teachers", Definition="Teachers of classes or programs to which students are assigned without standard grade designation.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("2d3996b6-1862-4d66-84ca-afc4e5f22570"), Code="PrekindergartenTeachers", Description="Pre-kindergarten Teachers", Definition="Teachers of a group or class that is part of a public school program that is taught during the year or years preceding kindergarten.", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("17f9f6ee-7e25-45a1-8589-c3edb24d5fec"), Code="SchoolPsychologist", Description="School Psychologist", Definition="Professional staff member who provides direct and indirect support, including prevention and intervention, to evaluate and address student's intellectual development, academic success, social-emotional learning, and mental and behavioral health.", SortOrder=Convert.ToDecimal("55.00") },
        };
        #endregion

        #region RefMepStaffCategory List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefMepStaffCategoryList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("68ae9ceb-8586-4d18-8671-2869105e6629"), Code="Teachers", Description="Teachers", Definition="Teachers is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("cda78752-6156-403e-be79-921ea06e7845"), Code="Paraprofessionals", Description="Paraprofessionals", Definition="Paraprofessionals  is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("b28f50fb-b9eb-4140-a116-2f5fb01aa8eb"), Code="Counselors", Description="Counselors", Definition="Counselors is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("9cc137c9-b66b-4e74-a4f7-bcb369cf312b"), Code="Administrators", Description="Administrators", Definition="Administrators is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("69823d00-fed6-4355-9b28-469db19cc06d"), Code="Recruiters", Description="Recruiters", Definition="Recruiters is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("1f0647de-5064-4469-9c9c-c58ab2ae1e0b"), Code="RecordsTransferStaff", Description="Records Transfer Staff", Definition="Records Transfer Staff is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefOutOfFieldStatus List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefOutOfFieldStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("33633174-2077-4785-8d26-4bd2a7be600b"), Code="TCHOUTFLD", Description="Not teaching in field", Definition="The teacher has been identified as teaching in the subject or field for which they are not certified or licensed.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d888281-9f9f-4c94-9b6a-4517d00e8fef"), Code="TCHINFLD", Description="Teaching in field", Definition="The teacher has been identified as teaching in the subject or field for which they are certified or licensed.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefProfessionalEducationJobClassification List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefProfessionalEducationJobClassificationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("294c0890-c83a-417a-8246-8a75c970c560"), Code="04723", Description="Athletic coach", Definition="Athletic coach", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("518f73bd-86a9-49a0-993a-7857ee7b1f2b"), Code="04724", Description="Behavioral management specialist", Definition="Behavioral management specialist", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8465e47a-2e36-4e2b-96d3-4950110fe36a"), Code="04725", Description="Counselor", Definition="Counselor", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("d8dcfc3d-304c-4d4b-a28c-7b4f303309b0"), Code="04726", Description="Curriculum specialist", Definition="Curriculum specialist", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("0199f572-08d5-41dd-bbfe-1db5f7cee6c3"), Code="04727", Description="Education diagnostician", Definition="Education diagnostician", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("c2394b9d-de3c-4ce2-9481-5852afb22a3c"), Code="04728", Description="Librarian/media consultant", Definition="Librarian/media consultant", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("2ce8b6ba-d46f-40c1-a9a4-6f35623dbf90"), Code="04729", Description="Remedial specialist", Definition="Remedial specialist", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("14f6ce56-5ad2-43a1-b309-839c141f03d4"), Code="04730", Description="Student activity advisor/non athletic coach", Definition="Student activity advisor/non athletic coach", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("d179d17e-4681-4edd-a79a-9baf36091e14"), Code="04731", Description="Student teacher", Definition="Student teacher", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("79db378f-4af1-45b2-89a2-c815d6df471e"), Code="04732", Description="Teacher", Definition="Teacher", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("d23177d6-a15a-4b87-b050-24deea1e25c3"), Code="04733", Description="Teacher trainer", Definition="Teacher trainer", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("3a17843e-faa9-4e2f-ab42-46819078d4d0"), Code="04734", Description="Teaching intern", Definition="Teaching intern", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("99879ed7-ba62-42fe-b853-87ff994da647"), Code="04735", Description="Resource teacher", Definition="Resource teacher", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b6b6ede-7492-4120-915c-a183c2ed3669"), Code="09999", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("14.00") },
        };
        #endregion

        #region RefSpecialEducationAgeGroupTaught List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefSpecialEducationAgeGroupTaughtList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3291901b-8336-4b22-b1ed-c903b3e19d04"), Code="3TO5", Description="3 through 5", Definition="The age range of special education students taught is 3 through 5.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("d5b4b9d7-d05a-4048-bf5d-16e9266d621e"), Code="6TO21", Description="6 through 21", Definition="The age range of special education students taught is 6 through 21.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefTeachingAssignmentRole List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefTeachingAssignmentRoleList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1e08a69b-6a87-4e7d-a93e-12e83b5d905d"), Code="LeadTeacher", Description="Lead Teacher", Definition="Lead teacher with the primary responsibility for student learning in the assigned class section", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("667bbce6-0633-4264-812d-8bb580d28f4b"), Code="TeamTeacher", Description="Team Teacher", Definition=" Team teacher with shared responsibility for student learning within the assigned class section", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("42c703f9-9c90-4c04-acc2-3e5bacfd5a79"), Code="ContributingProfessional", Description="Contributing Professional", Definition="Contributing professional who has been assigned the responsibility to provide additional services that support and increase a student learning", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTitleIProgramStaffCategory List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIProgramStaffCategoryList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a2b9a3e1-05b8-457b-b0d8-afd3a9d7c9db"), Code="TitleITeacher", Description="Title I Teachers", Definition="Title I Teachers is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("8df033b7-86e1-46fe-a0f8-d2c8e2bf11b4"), Code="TitleIParaprofessional", Description="Title I Paraprofessionals ", Definition="Title I Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f9b74af0-1a14-40b3-9084-a13651482149"), Code="TitleISupportStaff", Description="Title I Clerical Support Staff", Definition="Title I Clerical Support Staff is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("1e7939a7-bf25-4286-8738-ca6073e55eb2"), Code="TitleIAdministrator", Description="Title I Administrators (non-clerical)", Definition="Title I Administrators (non-clerical) is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("019343dc-bea2-4ed9-8397-4fd9949a9960"), Code="TitleIOtherParaprofessional", Description="Title I Other Paraprofessionals", Definition="Title I Other Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}

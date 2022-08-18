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
            new ReferenceModelBase { Id=Guid.Parse("c0c59b2e-7398-4220-bc7c-8e7ba447aa06"), Code="AdministrativeSupportStaff", Description="Administrative Support Staff", Definition="Staff members who provide direct support to administrators, business office support, data processing, or support of the teaching and administrative duties of the office of the principal or department chairpersons, including clerical staff and secretaries.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2a6c68a5-e4a5-4a2c-8147-0b1b4bdecb7c"), Code="Administrators", Description="Administrators", Definition="Executive officers or managers of education agencies or institutions, including superintendents, deputies, and assistant superintendents; other persons with district-wide responsibilities: e.g., business managers, administrative assistants, and professional instructional support staff.   In addition, staff members whose activities are concerned with directing and managing the operation of a particular school including principals, assistant principals, and other assistants; persons who supervise school operations, assign duties to staff members, supervise and maintain the records of the school, and coordinate school instructional activities with those of the education agency, including department chairpersons.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("f03baa70-7473-427f-8df6-0699e10e5f62"), Code="AllOtherSupportStaff", Description="All Other Support Staff ", Definition="Support staff not reported in instructional or student support. Other support staff includes employees such as data processing, health, plant and equipment maintenance, bus drivers, security, and food service workers.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee5ab105-4cba-4d55-bea0-6e8ba9bacfe3"), Code="BehavioralSpecialists", Description="Behavioral Specialists", Definition="Behavioral Specialists", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("20c53b40-671c-4e88-9ab3-f3cd2772c750"), Code="ELAssistantTeachers", Description="Early Learning Assistant Teachers", Definition="Assistant Teachers of general level instruction and/or services delivery classified by state and local practice from birth to Kindergarten.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("b69a2cb0-9aea-42cf-acb8-56a7b51992ba"), Code="ELTeachers", Description="Early Learning Teachers", Definition="Teachers of general level instruction and/or service delivery classified by state and local practice from birth to Kindergarten.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("0ebce841-dc7d-41d1-b5be-8dc4c5680224"), Code="ElementaryTeachers", Description="Elementary Teachers", Definition="Teachers of general level instruction classified by state and local practice as elementary and composed of any span of grades not above grade 8.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("52b2d305-58ed-486a-be33-4ef6c6939329"), Code="FamilyServiceWorkers", Description="Family Service Workers", Definition="Professional staff members assigned specific duties related to staff providing in-home and other services (including needs assessment, development of service plans, family advocacy, and coordination of service delivery) to families of children participating in early care and education programs.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("15e929b8-20cd-4520-8c10-68845bf3c8d8"), Code="HealthSpecialists", Description="Health Specialists", Definition="Professional staff members or supervisors assigned specific duties related to providing any Health services that are not specific to mental health.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("614040da-c9a9-4a88-95ec-0388e2cc3e7f"), Code="HomeVisitors", Description="Home Visitors", Definition="Professional staff members assigned specific duties related to visiting a child or pregnant woman's home for the purpose of assisting parents in fostering the growth and development of their child.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("785ee6df-6045-4219-a8e1-4a7d5e357426"), Code="InstructionalCoordinators", Description="Instructional Coordinators", Definition="Staff supervising instruction programs including: professional staff members or supervisors in an early learning program assigned specific duties related to instruction; supervisors at a school district or sub-district level including curricular coordinators or supervisors; in-service training staff; Title I supervisors; home economics supervisors; educational television staff; coordinators and supervisors of audiovisual services; and staff engaged in development of computer-assisted instruction.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("b03ae0f8-6eea-43a9-86df-d2ea37b7b5a7"), Code="KindergartenTeachers", Description="Kindergarten Teachers", Definition="Teachers of a group or class that is part of a public school program and is taught during the year preceding the first grade.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("be28b0ef-289d-47d3-af14-597a5e730b9a"), Code="LibraryMediaSpecialists", Description="Librarians/Media Specialists", Definition="A professional staff member or supervisor assigned specific duties and school time for professional library and media service activities. Activities include: selecting, acquiring, preparing, cataloging, and circulating books and other printed materials; planning the use of library and media services by students, teachers and other members of the instructional staff; and guiding individuals in their use of media services and library materials, (whether maintained separately or as part of an instructional materials center).", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("275c682b-63fd-468b-8040-2c9502e08077"), Code="LibraryMediaSupportStaff", Description="Library/Media Support Staff", Definition="Staff members who render other library or media services, such as preparing, caring for, and making available to members of the instructional staff the equipment, films, filmstrips, transparencies, tapes, TV programs, and similar materials (whether maintained separately as part of an instructional materials center).", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("8d4d9d39-aa6a-40a3-b803-6d962e9df1bc"), Code="MentalHealthSpecialists", Description="Mental Health Specialists", Definition="Professional staff members or supervisors assigned specific duties related to Mental Health.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("162f294f-65fd-4716-a24a-1acddfc7cff4"), Code="NutritionSpecialists", Description="Nutrition Specialists", Definition="Professional staff members or supervisors assigned specific duties related to Nutrition.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("aff67de5-b7d9-47b1-b6b6-c4fa6237bdeb"), Code="Paraprofessionals", Description="Paraprofessionals", Definition="Paraprofessionals are employees who provide instructional support, including those who: (1) provide one-on-one tutoring if such tutoring is scheduled at a time when a student would not otherwise receive instruction from a teacher, (2) assist with classroom management, such as organizing instructional and other materials, (3) provide instructional assistance in a computer laboratory, (4) conduct parental involvement activities, (5) provide support in a library or media center, (6) act as a translator, or (7) provide instructional support services under the direct supervision of a teacher.", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("942d8fcd-a8a2-41f9-90d9-35ae47fed6d6"), Code="PartCEarlyInterventionists", Description="Part C Early Interventionists", Definition="Professional staff members employed to provide early intervention services to infants and toddlers with disabilities or at-risk of experiencing a substantial developmental delay as defined by Part C of the  Individuals with Disabilities Education Act (IDEA): The Early Intervention Program for Infants and Toddlers with Disabilities.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("97fbc209-d062-4bce-a3ce-5380b2e3d54e"), Code="PartCServiceCoordinators", Description="Part C Service Coordinators", Definition="Professional staff members employed to coordinate early intervention services to infants and toddlers with disabilities or at-risk of experiencing a substantial developmental delay  as defined by Part C of the  Individuals with Disabilities Education Act (IDEA): The Early Intervention Program for Infants and Toddlers with Disabilities.", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("24d25d3c-c74f-49be-ae1d-681ad3c9d74e"), Code="SchoolCounselors", Description="School Counselors", Definition="Professional staff members assigned specific duties and school time for any of the following activities: counseling with students and parents, consulting with other staff members on learning problems, evaluating student abilities, assisting students in making education and career choices, assisting students in personal and social development, providing referral assistance, and/or working with other staff members in planning and conducting guidance programs for students. School counselors may be reported by elementary and secondary level when that information is available.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("61d2efbc-48b8-43ae-a7a6-592391b3359e"), Code="SecondaryTeachers", Description="Secondary Teachers", Definition="Teachers of a general level of instruction classified by state and local practice as secondary and composed of any span of grades beginning with the next grade following the elementary grades and ending with or below grade 12.", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("080a12cd-e785-4cd3-bbe6-aed6daabe791"), Code="SocialWorkers", Description="Social Workers", Definition="Social workers assist people by helping them cope with and solve issues in their everyday lives, such as family and personal problems and dealing with relationships. ", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("074a0de3-068a-491f-a44c-3e94343a9ef0"), Code="SpecialEducationTeachers", Description="Special Education Teachers", Definition="Special Education teachers include teachers employed to provide special education services to children with disabilities, including preschool teachers, itinerant/consulting teachers, and home/hospital teachers.  This should include teachers of children with disabilities in separate schools and facilities.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("7e92bc64-5768-40ad-a05b-812916aee7d6"), Code="SpecialNeedsSpecialists", Description="Special Needs Specialists", Definition="Professional staff members or supervisors assigned specific duties related to special needs learners.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("28362548-dbf7-416a-bf6c-6ae30d02687e"), Code="StudentSupportServicesStaff", Description="Student Support Services Staff", Definition="Professional and supervisory staff providing non-instructional services to students and supervisors of the preceding staff and of health, transportation, and food service workers.", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("4a1cdd8b-16bf-4a0d-9a19-cc4a2d8a06f4"), Code="UngradedTeachers", Description="Ungraded Teachers", Definition="Teachers of classes or programs to which students are assigned without standard grade designation.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("e6462d57-41fb-4030-a315-6c0db855f418"), Code="PrekindergartenTeachers", Description="Pre-kindergarten Teachers", Definition="Teachers of a group or class that is part of a public school program that is taught during the year or years preceding kindergarten.", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("afeb8811-5b30-496d-8971-94f942090d0c"), Code="SchoolPsychologist", Description="School Psychologist", Definition="Professional staff member who provides direct and indirect support, including prevention and intervention, to evaluate and address student's intellectual development, academic success, social-emotional learning, and mental and behavioral health.", SortOrder=Convert.ToDecimal("55.00") },
        };
        #endregion

        #region RefMepStaffCategory List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefMepStaffCategoryList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f786a4d4-88bb-4b9d-9534-7a5ba062a8b4"), Code="Teachers", Description="Teachers", Definition="Teachers is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("22e2c669-559b-4741-8d1d-8027ad08bf9a"), Code="Paraprofessionals", Description="Paraprofessionals", Definition="Paraprofessionals  is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c5960432-cbdc-4506-a48c-8c9e97e24177"), Code="Counselors", Description="Counselors", Definition="Counselors is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("fab837ad-c995-4165-8d93-7b0811f74a14"), Code="Administrators", Description="Administrators", Definition="Administrators is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("d6c154c6-023b-4f8c-a7d5-db9f15d443d5"), Code="Recruiters", Description="Recruiters", Definition="Recruiters is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("b606641a-f511-4e66-9a82-96bcb19502c5"), Code="RecordsTransferStaff", Description="Records Transfer Staff", Definition="Records Transfer Staff is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefOutOfFieldStatus List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefOutOfFieldStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0ef893bb-24da-43a5-8e81-d7f6b4c5f30c"), Code="TCHOUTFLD", Description="Not teaching in field", Definition="The teacher has been identified as teaching in the subject or field for which they are not certified or licensed.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("8be72487-6949-49af-b7c0-50f7e093aec5"), Code="TCHINFLD", Description="Teaching in field", Definition="The teacher has been identified as teaching in the subject or field for which they are certified or licensed.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefProfessionalEducationJobClassification List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefProfessionalEducationJobClassificationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("649b39b4-04e7-4e96-b8c4-3d3bd21b1431"), Code="04723", Description="Athletic coach", Definition="Athletic coach", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("12368d32-cf37-40fe-80b5-259a70e5eeb6"), Code="04724", Description="Behavioral management specialist", Definition="Behavioral management specialist", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("9e18c4f9-1a5e-4763-8292-abfe819a0f9a"), Code="04725", Description="Counselor", Definition="Counselor", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("9db39f8c-6d07-4f0b-a24e-4ab7438b4de5"), Code="04726", Description="Curriculum specialist", Definition="Curriculum specialist", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("05cbff31-7343-464c-a60f-0367ece82a00"), Code="04727", Description="Education diagnostician", Definition="Education diagnostician", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("010abe69-9f10-441c-92b4-109bd5bfa521"), Code="04728", Description="Librarian/media consultant", Definition="Librarian/media consultant", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("199a2b0d-407a-442c-bc97-10d6e20e6c32"), Code="04729", Description="Remedial specialist", Definition="Remedial specialist", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("0132b2c5-6bea-4dbc-b830-93819e011c5e"), Code="04730", Description="Student activity advisor/non athletic coach", Definition="Student activity advisor/non athletic coach", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("58a97606-0da7-441f-9375-3d07ed063816"), Code="04731", Description="Student teacher", Definition="Student teacher", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("5015c34a-097a-4574-9a31-0842b5460de9"), Code="04732", Description="Teacher", Definition="Teacher", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("9b9fc492-7526-4e93-90ec-daaf4fe722d0"), Code="04733", Description="Teacher trainer", Definition="Teacher trainer", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("a763bf8c-eb47-4f2b-9166-ddbbe7672a5e"), Code="04734", Description="Teaching intern", Definition="Teaching intern", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("f9f62b14-b82d-4d8c-abf0-93d2bee437da"), Code="04735", Description="Resource teacher", Definition="Resource teacher", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("6036b196-b4a7-4e1b-9e23-3b40e11432b2"), Code="09999", Description="Other", Definition="Other", SortOrder=Convert.ToDecimal("14.00") },
        };
        #endregion

        #region RefSpecialEducationAgeGroupTaught List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefSpecialEducationAgeGroupTaughtList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("2ddade74-69a2-4a1e-80fb-537495fdae37"), Code="3TO5", Description="3 through 5", Definition="The age range of special education students taught is 3 through 5.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("3a82119c-865a-49ce-b785-b8d6ad3e7e4d"), Code="6TO21", Description="6 through 21", Definition="The age range of special education students taught is 6 through 21.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefTeachingAssignmentRole List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefTeachingAssignmentRoleList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9d6ef700-7e2c-4c03-bec7-97088f67662d"), Code="LeadTeacher", Description="Lead Teacher", Definition="Lead teacher with the primary responsibility for student learning in the assigned class section", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b390f219-d19d-4b5f-99a2-394ba74ef8ba"), Code="TeamTeacher", Description="Team Teacher", Definition=" Team teacher with shared responsibility for student learning within the assigned class section", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("5916f9a7-7692-4e66-80f7-e15747b76ae2"), Code="ContributingProfessional", Description="Contributing Professional", Definition="Contributing professional who has been assigned the responsibility to provide additional services that support and increase a student learning", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTitleIProgramStaffCategory List
        /// <summary>
        /// The complete Teaching Assignment Contribution Percentage List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIProgramStaffCategoryList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("e2030388-0123-4dec-80da-e855cb310ac5"), Code="TitleITeacher", Description="Title I Teachers", Definition="Title I Teachers is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2ff957e5-baa9-4196-8f61-ba9db68d87b5"), Code="TitleIParaprofessional", Description="Title I Paraprofessionals ", Definition="Title I Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("af31ff20-50f4-4322-92b9-9ea9743463c9"), Code="TitleISupportStaff", Description="Title I Clerical Support Staff", Definition="Title I Clerical Support Staff is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("5c63bb4b-8630-403b-b3b1-2419659179f2"), Code="TitleIAdministrator", Description="Title I Administrators (non-clerical)", Definition="Title I Administrators (non-clerical) is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("3dd4387a-8afb-46c5-b434-eb9eff978b4b"), Code="TitleIOtherParaprofessional", Description="Title I Other Paraprofessionals", Definition="Title I Other Paraprofessionals is the category of staff working in a Title I program.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}

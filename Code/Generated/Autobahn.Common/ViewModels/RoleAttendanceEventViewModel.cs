//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceEventViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceEvent View Model
     /// </summary>
    public partial class RoleAttendanceEventViewModel : ViewModelBase, Interfaces.IRoleAttendanceEvent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendanceEvent";

        // Date -- (backing property for Attendance Event Date)
        private System.DateTime _Date;

        // EndTime -- (backing property for End Time)
        private System.TimeSpan? _EndTime;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefAbsentAttendanceCategoryId -- (backing property for Absent Attendance Category)
        private Guid? _RefAbsentAttendanceCategoryId;

        // RefAttendanceEventTypeId -- (backing property for Attendance Event Type)
        private Guid? _RefAttendanceEventTypeId;

        // RefAttendanceStatusId -- (backing property for Attendance Status)
        private Guid? _RefAttendanceStatusId;

        // RefLeaveEventTypeId -- (backing property for Leave Event Type)
        private Guid? _RefLeaveEventTypeId;

        // RefPresentAttendanceCategoryId -- (backing property for Present Attendance Category)
        private Guid? _RefPresentAttendanceCategoryId;

        // StartTime -- (backing property for Start Time)
        private System.TimeSpan? _StartTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Attendance Event Date
        /// <para>
        /// The date on which an attendance event takes place.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20630">Attendance Event Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// End Time
        /// <para>
        /// The ending hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Absent Attendance Category
        /// <para>
        ///  The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19592">Absent Attendance Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAbsentAttendanceCategoryId { get => _RefAbsentAttendanceCategoryId; set => SetProperty(ref _RefAbsentAttendanceCategoryId, value); }

        /// <summary>
        /// Attendance Event Type
        /// <para>
        /// The type of attendance event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19594">Attendance Event Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAttendanceEventTypeId { get => _RefAttendanceEventTypeId; set => SetProperty(ref _RefAttendanceEventTypeId, value); }

        /// <summary>
        /// Attendance Status
        /// <para>
        /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19076">Attendance Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAttendanceStatusId { get => _RefAttendanceStatusId; set => SetProperty(ref _RefAttendanceStatusId, value); }

        /// <summary>
        /// Leave Event Type
        /// <para>
        /// The type of the leave event.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19617">Leave Event Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLeaveEventTypeId { get => _RefLeaveEventTypeId; set => SetProperty(ref _RefLeaveEventTypeId, value); }

        /// <summary>
        /// Present Attendance Category
        /// <para>
        /// The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19593">Present Attendance Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPresentAttendanceCategoryId { get => _RefPresentAttendanceCategoryId; set => SetProperty(ref _RefPresentAttendanceCategoryId, value); }

        /// <summary>
        /// Start Time
        /// <para>
        /// The starting hour, minute and second.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendanceEvent model)
        {
            IsBusy = true;
            Id = model.Id;
            Date = model.Date; // Attendance Event Date
            EndTime = model.EndTime; // End Time
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefAbsentAttendanceCategoryId = model.RefAbsentAttendanceCategoryId; // Absent Attendance Category
            RefAttendanceEventTypeId = model.RefAttendanceEventTypeId; // Attendance Event Type
            RefAttendanceStatusId = model.RefAttendanceStatusId; // Attendance Status
            RefLeaveEventTypeId = model.RefLeaveEventTypeId; // Leave Event Type
            RefPresentAttendanceCategoryId = model.RefPresentAttendanceCategoryId; // Present Attendance Category
            StartTime = model.StartTime; // Start Time
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefAttendanceEventType List
        /// <summary>
        /// The complete <see cref="RefAttendanceEventType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefAttendanceEventTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("480720fe-29b0-4011-9ecd-3a557d5d1c3b"), Code="DailyAttendance", Description="Daily attendance", Definition="Daily attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("7db63e39-0a7d-45c4-a97e-30b78e97abc2"), Code="ClassSectionAttendance", Description="Class/section attendance", Definition="Class/section attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("3c8cf542-1130-4db3-a894-8ebf0ece2805"), Code="ProgramAttendance", Description="Program attendance", Definition="Program attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f8567388-f2fa-44aa-8d85-43170fad3ff1"), Code="ExtracurricularAttendance", Description="Extracurricular attendance", Definition="Extracurricular attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefAttendanceStatus List
        /// <summary>
        /// The complete <see cref="RefAttendanceStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefAttendanceStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0f5b4ac3-de9b-4b4d-9c3f-6c57a3b018b7"), Code="Present", Description="Present", Definition="Present is specified as the status of a person's attendance associated with an Attendance Event Type, Calendar Event Date, in an organization-person-role context.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("adaff8d1-6746-4f65-a7dc-0a9f185fe71f"), Code="ExcusedAbsence", Description="Excused Absence", Definition="Not present but is temporarily excused from attendance because the person is: 1) is ill and attendance would endanger his or her health or the health of others; 2) has an immediate family member who is seriously ill or has died; 3) is observing a recognized religious holiday of his or her faith; or 4) is otherwise excused in accordance with policies.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("94bdcaad-6573-4fe6-914e-45cb38b4e0ee"), Code="UnexcusedAbsence", Description="Unexcused Absence", Definition="Not present without acceptable cause or authorization.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("6a0f2528-400a-4e34-b968-e546168ae54c"), Code="Tardy", Description="Tardy", Definition="Is absent at the time a given schedule when attendance begins but is present before the close of that time period.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("826e4358-a11d-4f7f-900d-b0a37e362b3b"), Code="EarlyDeparture", Description="Early Departure", Definition="Leaves before the official close of the daily session. Reasons may include a special activity for curricular enrichment, doctor's appointment, and family emergency. State, local, and school regulations may distinguish excused and unexcused early departures. When officially approved on a regular basis, early departures immediately prior to the close of the session are considered to be released time.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion

        #region RefLeaveEventType List
        /// <summary>
        /// The complete <see cref="RefLeaveEventType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLeaveEventTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("03418deb-29d1-4524-b819-a3ac89f00084"), Code="Administrative", Description="Administrative", Definition="Administrative is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("ddd108ef-5a00-492f-ad6e-469f6ffc5b50"), Code="AnnualLeave", Description="Annual leave", Definition="Annual leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("8741fe3e-6ad7-4719-9477-b35ff6fa622d"), Code="Bereavement", Description="Bereavement", Definition="Bereavement is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("433aa593-113f-43f1-85a6-9fb74b81ffa9"), Code="CompensatoryLeaveTime", Description="Compensatory leave time", Definition="Compensatory leave time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("55892150-fa3f-4073-a362-6781a87518d9"), Code="FamilyAndMedicalLeave", Description="Family and medical leave", Definition="Family and medical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("f29770a6-fa52-4248-ac04-916d29c870f2"), Code="FlexTime", Description="Flex time", Definition="Flex time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa3cc5c1-a49e-4167-879d-b80397167c59"), Code="GovernmentRequested", Description="Government-requested", Definition="Government-requested is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("03a1d859-bac8-4a64-bd48-90d7798b807c"), Code="JuryDuty", Description="Jury Duty", Definition="Jury Duty is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("450fef10-5f72-45e8-99ce-2657d79ded97"), Code="MilitaryLeave", Description="Military leave", Definition="Military leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdb39851-835b-473a-9e15-7c7e9c76cf88"), Code="Other", Description="Other", Definition="Other is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a3cda8c-5123-4807-8a81-33dbc43a5e13"), Code="Personal", Description="Personal", Definition="Personal is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("532d4c84-e189-4d6f-9d0e-805cd64aa7b5"), Code="ProfessionalDevelopment", Description="Professional development", Definition="Professional development is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("2704ce69-e358-4c36-8f67-f94f6dc7d977"), Code="ReleaseTime", Description="Release time", Definition="Release time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("d4987827-9f17-4561-9003-4f50c23a388d"), Code="SabbaticalLeave", Description="Sabbatical leave", Definition="Sabbatical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("1c34b01c-12a1-4b98-ba69-f124cc423db7"), Code="SickLeave", Description="Sick leave", Definition="Sick leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("35d14b3e-312c-4106-a47e-84c4cdffbdad"), Code="Suspension", Description="Suspension", Definition="Suspension is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("b71c3ef5-cc2c-49da-9a60-e2a1fb5162c6"), Code="WorkersCompensation", Description="Workers compensation", Definition="Workers compensation is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("32.00") },
        };
        #endregion

        #region RefPresentAttendanceCategory List
        /// <summary>
        /// The complete <see cref="RefPresentAttendanceCategory"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPresentAttendanceCategoryList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("5f0da89d-2a33-4ef3-9f3a-01960f721e41"), Code="13290", Description="Present - Disciplinary action, receiving instruction", Definition="The student has been removed from the regular instructional setting for disciplinary reasons and is receiving instruction. In-school suspension typically falls within this category, but it also includes out-of-school suspension if instructional services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2df39cac-e380-4c19-9658-cfbb8d1ae70e"), Code="13288", Description="Present - In school, regular instructional program", Definition="The student is in class. This includes attendance at sites other than the school of record if the site is part of the student's regular instructional program approved by the school, district, and/or state. Examples of other sites are institutions of higher education, vocational/technical centers, and special education centers.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("0dd40a24-c971-4a45-9969-9b17baa32fa0"), Code="13289", Description="Present - Nontraditional school setting, regular instructional program", Definition="The student is engaged in the regular instructional program in a nontraditional school setting. Examples include hospital- or homebound instruction, as well as off-campus distance education.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("3e9f6c48-60a1-4668-908f-c21b1afe00c0"), Code="13291", Description="Present - Out of school, regular instructional program activity", Definition="The student is involved in an activity outside of school that is part of the regular instructional program, such as a field trip or work-study. The student is under the direct supervision of school personnel or someone who has been designated to act in place of school personnel.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("2208a060-fd14-4fc0-9236-32791a71a8ad"), Code="13292", Description="Present - Out of school, school-approved extracurricular or cocurricular activity", Definition="The student is outside of school, participating in instruction that is related to, but not part of, the regular curriculum. Examples include school-approved extracurricular or cocurricular activities, such as a debate, an athletic competition, or a conference that has educational value.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}

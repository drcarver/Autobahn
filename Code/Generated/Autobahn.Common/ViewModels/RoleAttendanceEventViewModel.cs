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
            new ReferenceModelBase { Id=Guid.Parse("72b99327-81b8-4c99-b487-b9c8e1e8e11d"), Code="DailyAttendance", Description="Daily attendance", Definition="Daily attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("594fb204-4209-46ec-b01a-2fcd2cedce2c"), Code="ClassSectionAttendance", Description="Class/section attendance", Definition="Class/section attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1dbdd1ad-3642-47ef-a12c-2ff49f3e179d"), Code="ProgramAttendance", Description="Program attendance", Definition="Program attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("65f11aae-635d-41d1-a7d6-ef39caec665b"), Code="ExtracurricularAttendance", Description="Extracurricular attendance", Definition="Extracurricular attendance is specified as the type of attendance event.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion

        #region RefAttendanceStatus List
        /// <summary>
        /// The complete <see cref="RefAttendanceStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefAttendanceStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("10433d94-70dc-42a4-a59e-e07207b11329"), Code="Present", Description="Present", Definition="Present is specified as the status of a person's attendance associated with an Attendance Event Type, Calendar Event Date, in an organization-person-role context.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("99b2ce14-cea4-4798-805d-cfa282ed50b7"), Code="ExcusedAbsence", Description="Excused Absence", Definition="Not present but is temporarily excused from attendance because the person is: 1) is ill and attendance would endanger his or her health or the health of others; 2) has an immediate family member who is seriously ill or has died; 3) is observing a recognized religious holiday of his or her faith; or 4) is otherwise excused in accordance with policies.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("ccc039f1-23e9-425f-9513-174726df1003"), Code="UnexcusedAbsence", Description="Unexcused Absence", Definition="Not present without acceptable cause or authorization.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("27ac84d8-a094-47b9-8aea-9ec39aa81f3d"), Code="Tardy", Description="Tardy", Definition="Is absent at the time a given schedule when attendance begins but is present before the close of that time period.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("1e5e75b2-f9a4-4512-8bf7-33367a38fb89"), Code="EarlyDeparture", Description="Early Departure", Definition="Leaves before the official close of the daily session. Reasons may include a special activity for curricular enrichment, doctor's appointment, and family emergency. State, local, and school regulations may distinguish excused and unexcused early departures. When officially approved on a regular basis, early departures immediately prior to the close of the session are considered to be released time.", SortOrder=Convert.ToDecimal("10.00") },
        };
        #endregion

        #region RefLeaveEventType List
        /// <summary>
        /// The complete <see cref="RefLeaveEventType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLeaveEventTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("90950da3-9b3f-48a1-a5eb-3fb78d2445f1"), Code="Administrative", Description="Administrative", Definition="Administrative is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6e678baf-250e-4a97-96f7-8c2e9cd25786"), Code="AnnualLeave", Description="Annual leave", Definition="Annual leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("0238e34d-5b96-4161-a434-a99d494b245f"), Code="Bereavement", Description="Bereavement", Definition="Bereavement is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("c15923c8-8861-4e2a-9fce-06e607d9d55c"), Code="CompensatoryLeaveTime", Description="Compensatory leave time", Definition="Compensatory leave time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("2bc53f0d-e277-4628-86e2-53f5d676908e"), Code="FamilyAndMedicalLeave", Description="Family and medical leave", Definition="Family and medical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("afa6a288-4634-46db-b2c8-ca6e88b323b3"), Code="FlexTime", Description="Flex time", Definition="Flex time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("b8d01044-2770-48cd-973d-928dd6aacb62"), Code="GovernmentRequested", Description="Government-requested", Definition="Government-requested is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("dfecf8f5-7115-434c-b12b-a381ab0d8f42"), Code="JuryDuty", Description="Jury Duty", Definition="Jury Duty is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("018ea087-6d42-4396-9dc8-edfe77d8c4f7"), Code="MilitaryLeave", Description="Military leave", Definition="Military leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("41f201ae-5895-45ef-b02d-e12d96d7b5a2"), Code="Other", Description="Other", Definition="Other is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("bda3a2a9-b172-4fcf-a80c-136c3a5db7e4"), Code="Personal", Description="Personal", Definition="Personal is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("06c765b7-ba89-4b49-bcea-8022b6cb517c"), Code="ProfessionalDevelopment", Description="Professional development", Definition="Professional development is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("4ac63379-ca35-4b39-98f8-f66950b9a6e3"), Code="ReleaseTime", Description="Release time", Definition="Release time is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee785165-3861-4a9a-abf9-027212ece6e4"), Code="SabbaticalLeave", Description="Sabbatical leave", Definition="Sabbatical leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("89a79ee6-be62-418d-aef4-17d2e33fc0c3"), Code="SickLeave", Description="Sick leave", Definition="Sick leave is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("222db19d-3e23-495b-8d0f-6d9362745367"), Code="Suspension", Description="Suspension", Definition="Suspension is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("04a3d779-52ff-4759-8e25-062665850c0f"), Code="WorkersCompensation", Description="Workers compensation", Definition="Workers compensation is the  type of leave event for staff.", SortOrder=Convert.ToDecimal("32.00") },
        };
        #endregion

        #region RefPresentAttendanceCategory List
        /// <summary>
        /// The complete <see cref="RefPresentAttendanceCategory"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPresentAttendanceCategoryList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("63fd8af6-7598-454d-bdeb-3f0b71ea2db1"), Code="13290", Description="Present - Disciplinary action, receiving instruction", Definition="The student has been removed from the regular instructional setting for disciplinary reasons and is receiving instruction. In-school suspension typically falls within this category, but it also includes out-of-school suspension if instructional services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("fae223b6-bdd0-48f9-a8ef-8b01d299964e"), Code="13288", Description="Present - In school, regular instructional program", Definition="The student is in class. This includes attendance at sites other than the school of record if the site is part of the student's regular instructional program approved by the school, district, and/or state. Examples of other sites are institutions of higher education, vocational/technical centers, and special education centers.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("efced2bd-6756-4c86-a2c7-f7df7f322e29"), Code="13289", Description="Present - Nontraditional school setting, regular instructional program", Definition="The student is engaged in the regular instructional program in a nontraditional school setting. Examples include hospital- or homebound instruction, as well as off-campus distance education.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("30f09be1-dc0b-4773-b3b4-0cec64aa6aa9"), Code="13291", Description="Present - Out of school, regular instructional program activity", Definition="The student is involved in an activity outside of school that is part of the regular instructional program, such as a field trip or work-study. The student is under the direct supervision of school personnel or someone who has been designated to act in place of school personnel.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("568afb0d-dc67-414c-b7a0-49ddb250651b"), Code="13292", Description="Present - Out of school, school-approved extracurricular or cocurricular activity", Definition="The student is outside of school, participating in instruction that is related to, but not part of, the regular curriculum. Examples include school-approved extracurricular or cocurricular activities, such as a debate, an athletic competition, or a conference that has educational value.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}

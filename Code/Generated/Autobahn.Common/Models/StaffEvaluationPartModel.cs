//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEvaluationPart Model
     /// </summary>
    public partial class StaffEvaluationPartModel : AutobahnBase, Interfaces.IStaffEvaluationPart
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String PartName { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String Scale { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String ScoreOrRating { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? StaffEvaluationId { get; set; }

    }
}

//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefK12EndOfCourseRequirement.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefK12EndOfCourseRequirement
     /// </summary>
    public partial class RefK12EndOfCourseRequirement : IRefK12EndOfCourseRequirement
    {
        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}

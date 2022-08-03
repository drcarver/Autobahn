//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefK12EndOfCourseRequirement.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefK12EndOfCourseRequirement
     /// </summary>
    public partial interface IRefK12EndOfCourseRequirement
    {
        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefK12EndOfCourseRequirement.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}

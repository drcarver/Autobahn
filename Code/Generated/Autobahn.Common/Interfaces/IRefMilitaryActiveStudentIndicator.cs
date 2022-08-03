//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefMilitaryActiveStudentIndicator.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefMilitaryActiveStudentIndicator
     /// </summary>
    public partial interface IRefMilitaryActiveStudentIndicator
    {
        /// <summary>
        /// Defines the RefMilitaryActiveStudentIndicator.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefMilitaryActiveStudentIndicator.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefMilitaryActiveStudentIndicator.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefMilitaryActiveStudentIndicator.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefMilitaryActiveStudentIndicator.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefMilitaryActiveStudentIndicator.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}

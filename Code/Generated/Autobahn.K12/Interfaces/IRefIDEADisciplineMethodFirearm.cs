//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefIDEADisciplineMethodFirearm.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefIDEADisciplineMethodFirearm
     /// </summary>
    public partial interface IRefIDEADisciplineMethodFirearm
    {
        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}

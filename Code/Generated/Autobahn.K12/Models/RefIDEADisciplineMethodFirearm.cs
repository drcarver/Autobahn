//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefIDEADisciplineMethodFirearm.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefIDEADisciplineMethodFirearm
     /// </summary>
    public partial class RefIDEADisciplineMethodFirearm : IRefIDEADisciplineMethodFirearm
    {
        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEADisciplineMethodFirearm.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}

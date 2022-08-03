//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseSectionDeliveryMode.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCourseSectionDeliveryMode
     /// </summary>
    public partial class RefCourseSectionDeliveryMode : IRefCourseSectionDeliveryMode
    {
        /// <summary>
        /// Defines the RefCourseSectionDeliveryMode.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionDeliveryMode.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionDeliveryMode.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionDeliveryMode.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionDeliveryMode.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionDeliveryMode.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}

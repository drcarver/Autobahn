//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonImmunization.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonImmunization Interface
     /// </summary>
    public partial interface IPersonImmunization : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ImmunizationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefImmunizationTypeId { get; set; }

    }
}

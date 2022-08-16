//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonOtherName.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonOtherName Interface
     /// </summary>
    public partial interface IPersonOtherName : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? OtherName { get; set; }

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
         RefOtherNameTypeId { get; set; }

    }
}

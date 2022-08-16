//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonBirthplace.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonBirthplace Interface
     /// </summary>
    public partial interface IPersonBirthplace : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         City { get; set; }

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
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefStateId { get; set; }

    }
}

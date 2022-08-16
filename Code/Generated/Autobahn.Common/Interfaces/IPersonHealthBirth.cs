//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonHealthBirth.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealthBirth Interface
     /// </summary>
    public partial interface IPersonHealthBirth : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         MultipleBirthIndicator { get; set; }

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
         RefTrimesterWhenPrenatalCareBeganId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         WeeksOfGestation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? WeightAtBirth { get; set; }

    }
}

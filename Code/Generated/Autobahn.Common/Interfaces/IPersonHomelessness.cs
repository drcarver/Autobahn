//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonHomelessness.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHomelessness Interface
     /// </summary>
    public partial interface IPersonHomelessness : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         HomelessnessStatus { get; set; }

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
        Guid? RefHomelessNighttimeResidenceId { get; set; }

    }
}

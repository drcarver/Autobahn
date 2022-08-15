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
        /// The primary nighttime residence of the person at the time the person was identified as homeless.
        /// </summary>
        Guid RefHomelessNighttimeResidenceId { get; set; }

    }
}

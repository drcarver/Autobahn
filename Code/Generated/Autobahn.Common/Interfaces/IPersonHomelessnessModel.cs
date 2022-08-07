//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonHomelessnessModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHomelessnessModel Interface
     /// </summary>
    public partial interface IPersonHomelessnessModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonHomelessness.HomelessnessStatus non nullable property
        /// </summary>
        System.Boolean HomelessnessStatus { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefHomelessNighttimeResidence"/> model
        /// </summary>
        Guid RefHomelessNighttimeResidenceId { get; set; }

    }
}

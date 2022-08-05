//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefLearnerActivityMaximumTimeAllowedUnit.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefLearnerActivityMaximumTimeAllowedUnit Interface
     /// </summary>
    public partial interface IRefLearnerActivityMaximumTimeAllowedUnit : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
        /// </summary>
        Guid RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

    }
}

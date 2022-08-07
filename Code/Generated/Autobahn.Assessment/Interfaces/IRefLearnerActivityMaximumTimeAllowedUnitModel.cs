//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefLearnerActivityMaximumTimeAllowedUnitModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefLearnerActivityMaximumTimeAllowedUnit Interface Model
     /// </summary>
    public partial interface IRefLearnerActivityMaximumTimeAllowedUnitModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
        /// </summary>
        Guid RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

    }
}

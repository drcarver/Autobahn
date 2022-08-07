//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefLearnerActivityMaximumTimeAllowedUnitModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefLearnerActivityMaximumTimeAllowedUnit Model
     /// </summary>
    public partial class RefLearnerActivityMaximumTimeAllowedUnitModel : ReferenceModelBase, IRefLearnerActivityMaximumTimeAllowedUnitModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
        /// </summary>
        public Guid RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

    }
}

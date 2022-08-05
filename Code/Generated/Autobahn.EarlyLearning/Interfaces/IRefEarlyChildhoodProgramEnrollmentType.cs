//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefEarlyChildhoodProgramEnrollmentType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefEarlyChildhoodProgramEnrollmentType Interface
     /// </summary>
    public partial interface IRefEarlyChildhoodProgramEnrollmentType : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodProgramType"/> model
        /// </summary>
        Guid RefEarlyChildhoodProgramTypeId { get; set; }

    }
}

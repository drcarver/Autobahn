//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefEarlyChildhoodProgramEnrollmentTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefEarlyChildhoodProgramEnrollmentType Interface Model
     /// </summary>
    public partial interface IRefEarlyChildhoodProgramEnrollmentTypeModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodProgramType"/> model
        /// </summary>
        Guid RefEarlyChildhoodProgramTypeId { get; set; }

    }
}

//**********************************************************
//* DomainName: Common Models
//* FileName:   IRefEarlyChildhoodProgramEnrollmentType.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefEarlyChildhoodProgramEnrollmentType Interface Model
     /// </summary>
    public partial interface IRefEarlyChildhoodProgramEnrollmentType : IReferenceModel
    {
        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        Guid RefEarlyChildhoodProgramTypeId { get; set; }

    }
}

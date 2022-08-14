//**********************************************************
//* DomainName: Common Models
//* FileName:   RefEarlyChildhoodProgramEnrollmentTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefEarlyChildhoodProgramEnrollmentType Model
     /// </summary>
    public partial class RefEarlyChildhoodProgramEnrollmentType : ReferenceModelBase, Interfaces.IRefEarlyChildhoodProgramEnrollmentType
    {
        /// <summary>
        /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
        /// </summary>
        public Guid RefEarlyChildhoodProgramTypeId { get; set; }

    }
}

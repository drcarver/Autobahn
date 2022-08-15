//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonFamily Model
     /// </summary>
    public partial class PersonFamilyModel : AutobahnBase, Interfaces.IPersonFamily
    {
        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

    }
}

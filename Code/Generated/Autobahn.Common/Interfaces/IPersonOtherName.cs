//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonOtherName.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonOtherName
     /// </summary>
    public partial interface IPersonOtherName
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOtherNameType"/> model
        /// </summary>
        Guid? RefOtherNameTypeId { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.OtherName non nullable property
        /// </summary>
        System.String OtherName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.FirstName non nullable property
        /// </summary>
        System.String FirstName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.MiddleName non nullable property
        /// </summary>
        System.String MiddleName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.LastName non nullable property
        /// </summary>
        System.String LastName { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonOtherName.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}

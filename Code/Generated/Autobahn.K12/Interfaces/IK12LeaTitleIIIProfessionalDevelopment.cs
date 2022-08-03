//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaTitleIIIProfessionalDevelopment.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaTitleIIIProfessionalDevelopment
     /// </summary>
    public partial interface IK12LeaTitleIIIProfessionalDevelopment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEATitleIIIProfessionalDevelopment"/> model
        /// </summary>
        Guid K12LEATitleIIIProfessionalDevelopmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIIProfessionalDevelopmentType"/> model
        /// </summary>
        Guid RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

        /// <summary>
        /// Defines the K12LeaTitleIIIProfessionalDevelopment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12LeaTitleIIIProfessionalDevelopment.RecordEndDateTime nullable property
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

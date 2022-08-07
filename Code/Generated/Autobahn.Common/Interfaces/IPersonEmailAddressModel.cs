//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonEmailAddressModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonEmailAddressModel Interface
     /// </summary>
    public partial interface IPersonEmailAddressModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonEmailAddress.EmailAddress non nullable property
        /// </summary>
        System.String EmailAddress { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        Guid? RefEmailTypeId { get; set; }

        /// <summary>
        /// Defines the PersonEmailAddress.DoNotPublishIndicator nullable property
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

    }
}

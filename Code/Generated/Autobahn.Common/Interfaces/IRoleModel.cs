//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRoleModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleModel Interface
     /// </summary>
    public partial interface IRoleModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the Role.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRole"/> model
        /// </summary>
        Guid? RefRoleId { get; set; }

    }
}

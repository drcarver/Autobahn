//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The Role Model
     /// </summary>
    public partial class RoleModel : AutobahnBase, Interfaces.IRole
    {
        public System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefRole"/> model
        /// </summary>
        public Guid? RefRoleId { get; set; }

    }
}

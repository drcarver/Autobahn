//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   OrganizationPersonRoleModel.cs
//**********************************************************

public class OrganizationPersonRoleModel : AutobahnBaseModel, IOrganizationPersonRole
{
    /// <summary>
    /// Activity Involvement Begin Date
    /// <para>
    /// The year, month and day on which the person began
    /// to participate in the activity.
    /// </para>
    /// </summary>
    DateTime? EntryDate { get; set; }

    /// <summary>
    /// Activity Involvement End Date
    /// <para>
    /// The year, month and day on which the person ceased 
    /// to participate in the activity.
    /// </para>
    /// </summary>
    DateTime? ExitDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="EntityBase"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="IRole"/> model
    /// </summary>
    public Guid RoleId { get; set; }
}

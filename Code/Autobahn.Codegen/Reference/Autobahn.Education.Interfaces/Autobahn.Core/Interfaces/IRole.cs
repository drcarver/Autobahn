//**********************************************************
//* DomainName: Common models used in multiple domains.
//* FileName:   IRole.cs
//***************************************************************************

public interface IRole
{
    /// <summary>
    /// Role
    /// <para>
    /// A description of the way in which a person relates 
    /// to an organization.
    /// </para>
    /// </summary>
    public System.String Name { get; set; }
}
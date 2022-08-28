//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   IOrganization.cs
//**********************************************************

/// <summary>
/// An organization, is an entity—such as a company, an 
/// institution, or an association—comprising one or 
/// more people and having a particular purpose.
/// </summary>
public partial interface IOrganization
{
    /// <summary>
    /// The short name of the organization
    /// </summary>
    string ShortName { get; set; }
}

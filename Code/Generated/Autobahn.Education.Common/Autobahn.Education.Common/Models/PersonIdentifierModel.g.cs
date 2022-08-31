//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonIdentifier file
/// </summary>
public partial class PersonIdentifierModel : AutobahnBaseModel, IPersonIdentifier
{
    #region "IPersonIdentifier Properties"
    /// <summary>
    /// Staff Member Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to a staff member by a school, school system, a state, registry, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19156">Staff Member Identifier</a>
    /// </para>
    /// </summary>
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Personal Information Verification
    /// <para>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// </summary>
    public Guid? RefPersonalInformationVerificationId { get; set; }

    /// <summary>
    /// Staff Member Identification System
    /// <para>
    /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, registry, or other agencies to refer to a staff member.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19162">Staff Member Identification System</a>
    /// </para>
    /// </summary>
    public Guid RefPersonIdentificationSystemId { get; set; }

    #endregion
}

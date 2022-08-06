//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentBehaviorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentBehavior Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentBehavior"> List
         /// </summary>
        public static List<RefIncidentBehavior> RefIncidentBehaviorList = new List<RefIncidentBehavior>
        {
            new RefIncidentBehavior { Id=Guid.Parse("87d81854-1505-4dfa-aadb-388040404b67"), Code="04618", Description="Alcohol", Definition="Alcohol related behavior associated with the incident.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentBehavior { Id=Guid.Parse("28c8773a-d9c0-44ad-b9a6-b05b539371ba"), Code="04625", Description="Arson", Definition="Arson is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentBehavior { Id=Guid.Parse("ee694f8a-3286-44e0-a8e8-56976781b698"), Code="04626", Description="Attendance Policy Violation", Definition="Attendance Policy Violation is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentBehavior { Id=Guid.Parse("76aada66-1eea-464b-9b07-647a4616845e"), Code="04632", Description="Battery", Definition="Battery is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentBehavior { Id=Guid.Parse("35f9e253-688d-4fc4-9edd-ec66f855eb3f"), Code="04633", Description="Burglary/Breaking and Entering", Definition="Burglary/Breaking and Entering is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentBehavior { Id=Guid.Parse("c454b982-8800-470a-8ce6-e63a889b98fd"), Code="04634", Description="Disorderly Conduct", Definition="Disorderly Conduct is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentBehavior { Id=Guid.Parse("a5bcb22a-e390-474d-b4ca-958b32ddb732"), Code="04635", Description="Drugs Excluding Alcohol and Tobacco", Definition="Drugs Excluding Alcohol and Tobacco is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentBehavior { Id=Guid.Parse("7f74111b-516f-422a-937f-89acd6c29806"), Code="04645", Description="Fighting", Definition="Fighting is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentBehavior { Id=Guid.Parse("0a8a3164-3788-4cdb-8f02-0b5d06ed352b"), Code="13354", Description="Harassment or bullying on the basis of disability", Definition="Harassment or bullying on the basis of disability is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentBehavior { Id=Guid.Parse("41c1b6fc-2253-4348-917a-72cac30d9e57"), Code="13355", Description="Harassment or bullying on the basis of race, color, or national origin", Definition="Harassment or bullying on the basis of race, color, or national origin is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentBehavior { Id=Guid.Parse("c197c58c-6ff6-4cb6-a6e8-4b913e461a4b"), Code="13356", Description="Harassment or bullying on the basis of sex", Definition="Harassment or bullying on the basis of sex is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentBehavior { Id=Guid.Parse("45a08402-baa9-4d63-8baf-133768f1bde8"), Code="04646", Description="Harassment, Nonsexual", Definition="Harassment, Nonsexual is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("12.00") },
            new RefIncidentBehavior { Id=Guid.Parse("fadc1fae-690c-4221-bf0b-1846da35c9bd"), Code="04650", Description="Harassment, Sexual", Definition="Harassment, Sexual is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("13.00") },
            new RefIncidentBehavior { Id=Guid.Parse("914df6ad-efab-4f29-adae-7a12e420fcbd"), Code="04651", Description="Homicide", Definition="Homicide is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("14.00") },
            new RefIncidentBehavior { Id=Guid.Parse("37fb9791-d52c-4e9a-9c4b-bfb92997d1f4"), Code="04652", Description="Inappropriate Use of Medication", Definition="Inappropriate Use of Medication is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("15.00") },
            new RefIncidentBehavior { Id=Guid.Parse("1221a024-26c8-4876-835e-194701b7e5f6"), Code="04659", Description="Insubordination", Definition="Insubordination is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("16.00") },
            new RefIncidentBehavior { Id=Guid.Parse("9c7381b2-552e-41ba-883a-87f252574780"), Code="04660", Description="Kidnapping", Definition="Kidnapping is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("17.00") },
            new RefIncidentBehavior { Id=Guid.Parse("7295a17b-8025-4549-a991-08861d45e876"), Code="04661", Description="Obscene Behavior", Definition="Obscene Behavior is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("18.00") },
            new RefIncidentBehavior { Id=Guid.Parse("906e1cfb-7d5e-47cb-b5b9-31adc9efd2d0"), Code="04669", Description="Physical Altercation, Minor", Definition="Physical Altercation, Minor is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("19.00") },
            new RefIncidentBehavior { Id=Guid.Parse("ef9926be-3508-47fa-9220-1e9d541eb2ae"), Code="04670", Description="Robbery", Definition="Robbery is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("20.00") },
            new RefIncidentBehavior { Id=Guid.Parse("0aabe543-a6c1-432e-8e5a-f67b4fc0f7d1"), Code="04671", Description="School Threat", Definition="School Threat is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("21.00") },
            new RefIncidentBehavior { Id=Guid.Parse("c3a2e517-8f9d-4ec2-a0c4-57e48fa18436"), Code="04677", Description="Sexual Battery (sexual assault)", Definition="Sexual Battery (sexual assault) is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("22.00") },
            new RefIncidentBehavior { Id=Guid.Parse("d3bccb23-8192-4514-b201-3960ff9c4ec4"), Code="04678", Description="Sexual Offenses, Other (lewd behavior, indecent exposure)", Definition="Sexual Offenses, Other (lewd behavior, indecent exposure) is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("23.00") },
            new RefIncidentBehavior { Id=Guid.Parse("2132e1cc-ddb8-4c36-b090-a2b881561748"), Code="04682", Description="Theft", Definition="Theft is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("24.00") },
            new RefIncidentBehavior { Id=Guid.Parse("3e168e5b-d68d-404e-8362-ab555448deb6"), Code="04686", Description="Threat/Intimidation", Definition="Threat/Intimidation is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("25.00") },
            new RefIncidentBehavior { Id=Guid.Parse("285cd76a-6770-4337-b271-d3f1b31a843a"), Code="04692", Description="Tobacco Possession or Use", Definition="Tobacco Possession or Use is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("26.00") },
            new RefIncidentBehavior { Id=Guid.Parse("4f4330f9-f9ff-4f82-811e-f89c54696fcf"), Code="04699", Description="Trespassing", Definition="Trespassing is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("27.00") },
            new RefIncidentBehavior { Id=Guid.Parse("368d9fb2-9de5-4b4a-a9ea-f7b06feb421e"), Code="04700", Description="Vandalism", Definition="Vandalism is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("28.00") },
            new RefIncidentBehavior { Id=Guid.Parse("bd5be70f-8758-47bc-987b-28f46a673cd7"), Code="04704", Description="Violation of School Rules", Definition="Violation of School Rules is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("29.00") },
            new RefIncidentBehavior { Id=Guid.Parse("af45a64b-653e-405e-9394-f5be6f6b49e4"), Code="04705", Description="Weapons Possession", Definition="Weapons Possession is a behavior associated with the incident.", SortOrder=Convert.ToDecimal("30.00") },
        };

        /// <summary>
        /// The RefIncidentBehavior Pick List
         /// </summary>
        public static List<RefIncidentBehavior> RefIncidentBehaviorPickList = new List<RefIncidentBehavior>
        {
            new RefIncidentBehavior { Id=Guid.Parse("87d81854-1505-4dfa-aadb-388040404b67"), Code="04618", Description="Alcohol", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentBehavior { Id=Guid.Parse("28c8773a-d9c0-44ad-b9a6-b05b539371ba"), Code="04625", Description="Arson", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentBehavior { Id=Guid.Parse("ee694f8a-3286-44e0-a8e8-56976781b698"), Code="04626", Description="Attendance Policy Violation", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentBehavior { Id=Guid.Parse("76aada66-1eea-464b-9b07-647a4616845e"), Code="04632", Description="Battery", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentBehavior { Id=Guid.Parse("35f9e253-688d-4fc4-9edd-ec66f855eb3f"), Code="04633", Description="Burglary/Breaking and Entering", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentBehavior { Id=Guid.Parse("c454b982-8800-470a-8ce6-e63a889b98fd"), Code="04634", Description="Disorderly Conduct", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentBehavior { Id=Guid.Parse("a5bcb22a-e390-474d-b4ca-958b32ddb732"), Code="04635", Description="Drugs Excluding Alcohol and Tobacco", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentBehavior { Id=Guid.Parse("7f74111b-516f-422a-937f-89acd6c29806"), Code="04645", Description="Fighting", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentBehavior { Id=Guid.Parse("0a8a3164-3788-4cdb-8f02-0b5d06ed352b"), Code="13354", Description="Harassment or bullying on the basis of disability", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentBehavior { Id=Guid.Parse("41c1b6fc-2253-4348-917a-72cac30d9e57"), Code="13355", Description="Harassment or bullying on the basis of race, color, or national origin", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentBehavior { Id=Guid.Parse("c197c58c-6ff6-4cb6-a6e8-4b913e461a4b"), Code="13356", Description="Harassment or bullying on the basis of sex", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentBehavior { Id=Guid.Parse("45a08402-baa9-4d63-8baf-133768f1bde8"), Code="04646", Description="Harassment, Nonsexual", SortOrder=Convert.ToDecimal("12.00") },
            new RefIncidentBehavior { Id=Guid.Parse("fadc1fae-690c-4221-bf0b-1846da35c9bd"), Code="04650", Description="Harassment, Sexual", SortOrder=Convert.ToDecimal("13.00") },
            new RefIncidentBehavior { Id=Guid.Parse("914df6ad-efab-4f29-adae-7a12e420fcbd"), Code="04651", Description="Homicide", SortOrder=Convert.ToDecimal("14.00") },
            new RefIncidentBehavior { Id=Guid.Parse("37fb9791-d52c-4e9a-9c4b-bfb92997d1f4"), Code="04652", Description="Inappropriate Use of Medication", SortOrder=Convert.ToDecimal("15.00") },
            new RefIncidentBehavior { Id=Guid.Parse("1221a024-26c8-4876-835e-194701b7e5f6"), Code="04659", Description="Insubordination", SortOrder=Convert.ToDecimal("16.00") },
            new RefIncidentBehavior { Id=Guid.Parse("9c7381b2-552e-41ba-883a-87f252574780"), Code="04660", Description="Kidnapping", SortOrder=Convert.ToDecimal("17.00") },
            new RefIncidentBehavior { Id=Guid.Parse("7295a17b-8025-4549-a991-08861d45e876"), Code="04661", Description="Obscene Behavior", SortOrder=Convert.ToDecimal("18.00") },
            new RefIncidentBehavior { Id=Guid.Parse("906e1cfb-7d5e-47cb-b5b9-31adc9efd2d0"), Code="04669", Description="Physical Altercation, Minor", SortOrder=Convert.ToDecimal("19.00") },
            new RefIncidentBehavior { Id=Guid.Parse("ef9926be-3508-47fa-9220-1e9d541eb2ae"), Code="04670", Description="Robbery", SortOrder=Convert.ToDecimal("20.00") },
            new RefIncidentBehavior { Id=Guid.Parse("0aabe543-a6c1-432e-8e5a-f67b4fc0f7d1"), Code="04671", Description="School Threat", SortOrder=Convert.ToDecimal("21.00") },
            new RefIncidentBehavior { Id=Guid.Parse("c3a2e517-8f9d-4ec2-a0c4-57e48fa18436"), Code="04677", Description="Sexual Battery (sexual assault)", SortOrder=Convert.ToDecimal("22.00") },
            new RefIncidentBehavior { Id=Guid.Parse("d3bccb23-8192-4514-b201-3960ff9c4ec4"), Code="04678", Description="Sexual Offenses, Other (lewd behavior, indecent exposure)", SortOrder=Convert.ToDecimal("23.00") },
            new RefIncidentBehavior { Id=Guid.Parse("2132e1cc-ddb8-4c36-b090-a2b881561748"), Code="04682", Description="Theft", SortOrder=Convert.ToDecimal("24.00") },
            new RefIncidentBehavior { Id=Guid.Parse("3e168e5b-d68d-404e-8362-ab555448deb6"), Code="04686", Description="Threat/Intimidation", SortOrder=Convert.ToDecimal("25.00") },
            new RefIncidentBehavior { Id=Guid.Parse("285cd76a-6770-4337-b271-d3f1b31a843a"), Code="04692", Description="Tobacco Possession or Use", SortOrder=Convert.ToDecimal("26.00") },
            new RefIncidentBehavior { Id=Guid.Parse("4f4330f9-f9ff-4f82-811e-f89c54696fcf"), Code="04699", Description="Trespassing", SortOrder=Convert.ToDecimal("27.00") },
            new RefIncidentBehavior { Id=Guid.Parse("368d9fb2-9de5-4b4a-a9ea-f7b06feb421e"), Code="04700", Description="Vandalism", SortOrder=Convert.ToDecimal("28.00") },
            new RefIncidentBehavior { Id=Guid.Parse("bd5be70f-8758-47bc-987b-28f46a673cd7"), Code="04704", Description="Violation of School Rules", SortOrder=Convert.ToDecimal("29.00") },
            new RefIncidentBehavior { Id=Guid.Parse("af45a64b-653e-405e-9394-f5be6f6b49e4"), Code="04705", Description="Weapons Possession", SortOrder=Convert.ToDecimal("30.00") },
       };
   }
}

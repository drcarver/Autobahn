//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefPDActivityTargetAudienceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The list of RefPDActivityTargetAudience Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityTargetAudience"> List
         /// </summary>
        public static List<RefPDActivityTargetAudience> RefPDActivityTargetAudienceList = new List<RefPDActivityTargetAudience>
        {
            new RefPDActivityTargetAudience { Id=Guid.Parse("aa432eba-4c5f-476d-89ac-364bc6e661ee"), Code="AdministrativeSupportStaff", Description="Administrative Support Staff", Definition="Staff members who provide direct support to administrators, business office support, data processing, or support of the teaching and administrative duties of the office of the principal or department chairpersons, including clerical staff and secretaries.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("1562b972-6a3c-4929-8405-028912c3cf8a"), Code="Administrators", Description="Administrators", Definition="Executive officers or managers of education agencies or institutions, including superintendents, deputies, and assistant superintendents; other persons with district-wide responsibilities: e.g., business managers, administrative assistants, and professional instructional support staff.   In addition, staff members whose activities are concerned with directing and managing the operation of a particular school including principals, assistant principals, and other assistants; persons who supervise school operations, assign duties to staff members, supervise and maintain the records of the school, and coordinate school instructional activities with those of the education agency, including department chairpersons.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("93e8bdd0-511f-4749-910e-34dfa47596a2"), Code="AllOtherSupportStaff", Description="All Other Support Staff ", Definition="Support staff not reported in instructional or student support. Other support staff includes employees such as data processing, health, plant and equipment maintenance, bus drivers, security, and food service workers.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("932ed214-8ff2-4e1b-a745-39c870ee4543"), Code="BehavioralSpecialists", Description="Behavioral Specialists", Definition="Behavioral Specialists", SortOrder=Convert.ToDecimal("7.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("8a2f79ec-86bb-4f00-8c42-88c596dfac49"), Code="ELAssistantTeachers", Description="Early Leaning Assistant Teachers", Definition="Assistant Teachers of general level instruction and/or services delivery classified by state and local practice from birth to Kindergarten.", SortOrder=Convert.ToDecimal("9.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("51cd62ce-1411-468e-a744-3af74544babf"), Code="ELTeachers", Description="Early Learning Teachers", Definition="Teachers of general level instruction and/or service delivery classified by state and local practice from birth to Kindergarten.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("eab7f28d-abaf-4e95-97a1-b1e4534ecd13"), Code="ElementaryTeachers", Description="Elementary Teachers", Definition="Teachers of general level instruction classified by state and local practice as elementary and composed of any span of grades not above grade 8.", SortOrder=Convert.ToDecimal("11.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("836f6e7d-d377-431b-8f4e-92a58d608302"), Code="FamilyServiceWorkers", Description="Family Service Workers", Definition="Professional staff members assigned specific duties related to staff providing in-home and other services (including needs assessment, development of service plans, family advocacy, and coordination of service delivery) to families of children participating in early care and education programs.", SortOrder=Convert.ToDecimal("15.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("7557a620-6dc5-4e26-8ce8-3bc048aaa779"), Code="HealthSpecialists", Description="Health Specialists", Definition="Professional staff members or supervisors assigned specific duties related to providing any Health services that are not specific to mental health.", SortOrder=Convert.ToDecimal("17.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("555b03ba-f773-42ec-9d7b-db33e027bf13"), Code="HomeVisitors", Description="Home Visitors", Definition="Professional staff members assigned specific duties related to visiting a child or pregnant woman's home for the purpose of assisting parents in fostering the growth and development of their child.", SortOrder=Convert.ToDecimal("19.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("4cbc6dbb-8bf4-47c3-ab78-590c58c9f906"), Code="InstructionalCoordinators", Description="Instructional Coordinators", Definition="Staff supervising instructional programs including  professional staff members or supervisors in an early learning program assigned specific duties related to instruction ,  or supervisors at a school district or sub-district level including curriculum coordinators or supervisors; in-service training staff; Title I supervisors; home economics supervisors; educational television staff; coordinators and supervisors of audiovisual services; and staff engaged in development of computer-assisted instruction.", SortOrder=Convert.ToDecimal("21.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("ce7c0872-afa2-490a-bd3f-61519dc883cf"), Code="KindergartenTeachers", Description="Kindergarten Teachers", Definition="Teachers of a group or class that is part of a public school program and is taught during the year preceding the first grade.", SortOrder=Convert.ToDecimal("23.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("9b5190c2-a2d3-4e87-b90d-038a0bbf38b6"), Code="LibraryMediaSpecialists", Description="Librarians/Media Specialists", Definition="A professional staff member or supervisor assigned specific duties and school time for professional library and media service activities. Activities include: selecting, acquiring, preparing, cataloging, and circulating books and other printed materials; planning the use of library and media services by students, teachers and other members of the instructional staff; and guiding individuals in their use of media services and library materials, (whether maintained separately or as part of an instructional materials center).", SortOrder=Convert.ToDecimal("25.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("874b4992-09cf-4a36-b1fa-4f00facf09a0"), Code="LibraryMediaSupportStaff", Description="Library/Media Support Staff", Definition="Staff members who render other library or media services, such as preparing, caring for, and making available to members of the instructional staff the equipment, films, filmstrips, transparencies, tapes, TV programs, and similar materials (whether maintained separately as part of an instructional materials center).", SortOrder=Convert.ToDecimal("27.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("346277dd-dd57-4153-b2b1-6f7878d0dbcf"), Code="MentalHealthSpecialists", Description="Mental Health Specialists", Definition="Professional staff members or supervisors assigned specific duties related to Mental Health.", SortOrder=Convert.ToDecimal("29.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("0b7c0880-62e9-4ea1-a354-4390c1bf7a9d"), Code="NutritionSpecialists", Description="Nutrition Specialists", Definition="Professional staff members or supervisors assigned specific duties related to Nutrition.", SortOrder=Convert.ToDecimal("31.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("e2a57952-afb0-45a5-8e9e-521ee02ae855"), Code="Paraprofessionals", Description="Paraprofessionals", Definition="Paraprofessionals are employees who provide instructional support, including those who: (1) provide one-on-one tutoring if such tutoring is scheduled at a time when a student would not otherwise receive instruction from a teacher, (2) assist with classroom management, such as organizing instructional and other materials, (3) provide instructional assistance in a computer laboratory, (4) conduct parental involvement activities, (5) provide support in a library or media center, (6) act as a translator, or (7) provide instructional support services under the direct supervision of a teacher.", SortOrder=Convert.ToDecimal("35.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("cfc695ae-1fa2-4f77-a863-4ac1a59ddff9"), Code="PartCEarlyInterventionists", Description="Part C Early Interventionists", Definition="Professional staff members employed to provide early intervention services to infants and toddlers with disabilities or at-risk of experiencing a substantial developmental delay as defined by Part C of the  Individuals with Disabilities Education Act (IDEA): The Early Intervention Program for Infants and Toddlers with Disabilities.", SortOrder=Convert.ToDecimal("37.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("c604ea8d-c2dc-437e-8df6-b23c74a49d3d"), Code="PartCServiceCoordinators", Description="Part C Service Coordinators", Definition="Professional staff members employed to coordinate early intervention services to infants and toddlers with disabilities or at-risk of experiencing a substantial developmental delay  as defined by Part C of the  Individuals with Disabilities Education Act (IDEA): The Early Intervention Program for Infants and Toddlers with Disabilities.", SortOrder=Convert.ToDecimal("39.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("b7156ea7-8659-4c82-b406-acfa7f5b1b75"), Code="SchoolCounselors", Description="School Counselors", Definition="Professional staff members assigned specific duties and school time for any of the following activities: counseling with students and parents, consulting with other staff members on learning problems, evaluating student abilities, assisting students in making education and career choices, assisting students in personal and social development, providing referral assistance, and/or working with other staff members in planning and conducting guidance programs for students. School counselors may be reported by elementary and secondary level when that information is available.", SortOrder=Convert.ToDecimal("41.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("8664e126-bcac-4725-abb2-bd2dddb31450"), Code="SecondaryTeachers", Description="Secondary Teachers", Definition="Teachers of a general level of instruction classified by state and local practice as secondary and composed of any span of grades beginning with the next grade following the elementary grades and ending with or below grade 12.", SortOrder=Convert.ToDecimal("43.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("0d831b4a-39c6-4192-9383-ff6404ecb861"), Code="SocialWorkers", Description="Social Workers", Definition="Social workers assist people by helping them cope with and solve issues in their everyday lives, such as family and personal problems and dealing with relationships. ", SortOrder=Convert.ToDecimal("45.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("3f93352c-3dac-418c-beac-c1351fd70fdb"), Code="SpecialEducationTeachers", Description="Special Education Teachers", Definition="Special Education teachers include teachers employed to provide special education services to children with disabilities, including preschool teachers, itinerant/consulting teachers, and home/hospital teachers. This count should include teachers of children with disabilities in separate schools and facilities. ", SortOrder=Convert.ToDecimal("47.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("361da4f8-3006-4cf8-8cf1-ac58f61465ff"), Code="SpecialNeedsSpecialists", Description="Special Needs Specialists", Definition="Professional staff members or supervisors assigned specific duties related to special needs learners.", SortOrder=Convert.ToDecimal("49.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("5595b5b1-23f6-4de7-b4da-f31a9b084ea4"), Code="StudentSupportServicesStaff", Description="Student Support Services Staff", Definition="Professional and supervisory staff providing non-instructional services to students including attendance officers; staff providing health, psychology, speech pathology, audiology, or social services; and supervisors of the preceding staff and of health, transportation, and food service workers.", SortOrder=Convert.ToDecimal("51.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("e57ec282-1e35-438f-a0c3-3d58ab592004"), Code="UngradedTeachers", Description="Ungraded Teachers", Definition="Teachers of classes or programs to which students are assigned without standard grade designation.", SortOrder=Convert.ToDecimal("53.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("bdc934ce-e147-483a-833c-a6c41cd215a4"), Code="Other", Description="Other", Definition="The professional development activity is intended for an audience category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefPDActivityTargetAudience Pick List
         /// </summary>
        public static List<RefPDActivityTargetAudience> RefPDActivityTargetAudiencePickList = new List<RefPDActivityTargetAudience>
        {
            new RefPDActivityTargetAudience { Id=Guid.Parse("aa432eba-4c5f-476d-89ac-364bc6e661ee"), Code="AdministrativeSupportStaff", Description="Administrative Support Staff", SortOrder=Convert.ToDecimal("1.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("1562b972-6a3c-4929-8405-028912c3cf8a"), Code="Administrators", Description="Administrators", SortOrder=Convert.ToDecimal("3.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("93e8bdd0-511f-4749-910e-34dfa47596a2"), Code="AllOtherSupportStaff", Description="All Other Support Staff ", SortOrder=Convert.ToDecimal("5.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("932ed214-8ff2-4e1b-a745-39c870ee4543"), Code="BehavioralSpecialists", Description="Behavioral Specialists", SortOrder=Convert.ToDecimal("7.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("8a2f79ec-86bb-4f00-8c42-88c596dfac49"), Code="ELAssistantTeachers", Description="Early Leaning Assistant Teachers", SortOrder=Convert.ToDecimal("9.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("51cd62ce-1411-468e-a744-3af74544babf"), Code="ELTeachers", Description="Early Learning Teachers", SortOrder=Convert.ToDecimal("10.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("eab7f28d-abaf-4e95-97a1-b1e4534ecd13"), Code="ElementaryTeachers", Description="Elementary Teachers", SortOrder=Convert.ToDecimal("11.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("836f6e7d-d377-431b-8f4e-92a58d608302"), Code="FamilyServiceWorkers", Description="Family Service Workers", SortOrder=Convert.ToDecimal("15.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("7557a620-6dc5-4e26-8ce8-3bc048aaa779"), Code="HealthSpecialists", Description="Health Specialists", SortOrder=Convert.ToDecimal("17.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("555b03ba-f773-42ec-9d7b-db33e027bf13"), Code="HomeVisitors", Description="Home Visitors", SortOrder=Convert.ToDecimal("19.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("4cbc6dbb-8bf4-47c3-ab78-590c58c9f906"), Code="InstructionalCoordinators", Description="Instructional Coordinators", SortOrder=Convert.ToDecimal("21.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("ce7c0872-afa2-490a-bd3f-61519dc883cf"), Code="KindergartenTeachers", Description="Kindergarten Teachers", SortOrder=Convert.ToDecimal("23.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("9b5190c2-a2d3-4e87-b90d-038a0bbf38b6"), Code="LibraryMediaSpecialists", Description="Librarians/Media Specialists", SortOrder=Convert.ToDecimal("25.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("874b4992-09cf-4a36-b1fa-4f00facf09a0"), Code="LibraryMediaSupportStaff", Description="Library/Media Support Staff", SortOrder=Convert.ToDecimal("27.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("346277dd-dd57-4153-b2b1-6f7878d0dbcf"), Code="MentalHealthSpecialists", Description="Mental Health Specialists", SortOrder=Convert.ToDecimal("29.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("0b7c0880-62e9-4ea1-a354-4390c1bf7a9d"), Code="NutritionSpecialists", Description="Nutrition Specialists", SortOrder=Convert.ToDecimal("31.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("e2a57952-afb0-45a5-8e9e-521ee02ae855"), Code="Paraprofessionals", Description="Paraprofessionals", SortOrder=Convert.ToDecimal("35.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("cfc695ae-1fa2-4f77-a863-4ac1a59ddff9"), Code="PartCEarlyInterventionists", Description="Part C Early Interventionists", SortOrder=Convert.ToDecimal("37.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("c604ea8d-c2dc-437e-8df6-b23c74a49d3d"), Code="PartCServiceCoordinators", Description="Part C Service Coordinators", SortOrder=Convert.ToDecimal("39.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("b7156ea7-8659-4c82-b406-acfa7f5b1b75"), Code="SchoolCounselors", Description="School Counselors", SortOrder=Convert.ToDecimal("41.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("8664e126-bcac-4725-abb2-bd2dddb31450"), Code="SecondaryTeachers", Description="Secondary Teachers", SortOrder=Convert.ToDecimal("43.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("0d831b4a-39c6-4192-9383-ff6404ecb861"), Code="SocialWorkers", Description="Social Workers", SortOrder=Convert.ToDecimal("45.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("3f93352c-3dac-418c-beac-c1351fd70fdb"), Code="SpecialEducationTeachers", Description="Special Education Teachers", SortOrder=Convert.ToDecimal("47.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("361da4f8-3006-4cf8-8cf1-ac58f61465ff"), Code="SpecialNeedsSpecialists", Description="Special Needs Specialists", SortOrder=Convert.ToDecimal("49.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("5595b5b1-23f6-4de7-b4da-f31a9b084ea4"), Code="StudentSupportServicesStaff", Description="Student Support Services Staff", SortOrder=Convert.ToDecimal("51.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("e57ec282-1e35-438f-a0c3-3d58ab592004"), Code="UngradedTeachers", Description="Ungraded Teachers", SortOrder=Convert.ToDecimal("53.00") },
            new RefPDActivityTargetAudience { Id=Guid.Parse("bdc934ce-e147-483a-833c-a6c41cd215a4"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}

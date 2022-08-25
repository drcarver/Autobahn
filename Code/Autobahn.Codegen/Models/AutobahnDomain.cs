namespace Autobahn.Codegen.Models
{
    /// <summary>
    /// The Autobahn domain's and modules
    /// </summary>
    internal class AutobahnDomain
    {
        /// <summary>
        /// The unique Id for the domain
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The Name of the domain
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the domain's MAUI module
        /// </summary>
        public string Module { get; set; }

        /// <summary>
        /// The description of the domain
        /// </summary>
        public string Description { get; set; }
    }
}

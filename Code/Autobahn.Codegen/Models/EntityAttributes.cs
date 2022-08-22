using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Autobahn.Codegen.Models
{
    internal class EntityAttributes
    {
        internal EntityAttributes(Type type)
        {
            CommentAttribute = type.GetCustomAttributes<CommentAttribute>().FirstOrDefault();
            IndexAttribute = type.GetCustomAttributes<IndexAttribute>().FirstOrDefault();
            NotMappedAttribute = type.GetCustomAttributes<NotMappedAttribute>().FirstOrDefault();
            TableAttribute = type.GetCustomAttributes<TableAttribute>().FirstOrDefault();
        }
        internal CommentAttribute? CommentAttribute { get; set; }
        internal IndexAttribute? IndexAttribute { get; set; }
        internal NotMappedAttribute? NotMappedAttribute { get; set; }
        internal TableAttribute? TableAttribute { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Autobahn.Codegen.Models
{
    internal class EntityAttributes
    {
        internal EntityAttributes()
        {
        }

        internal EntityAttributes(Type? type)
        {
            if (type == null) 
            { 
                return; 
            }

            CommentAttribute = type.GetCustomAttributes<CommentAttribute>().FirstOrDefault();
            IndexAttribute = type.GetCustomAttributes<IndexAttribute>().FirstOrDefault();
            KeylessAttribute = type.GetCustomAttributes<KeylessAttribute>().FirstOrDefault();
            NotMappedAttribute = type.GetCustomAttributes<NotMappedAttribute>().FirstOrDefault();
            TableAttribute = type.GetCustomAttributes<TableAttribute>().FirstOrDefault();
            ObsoleteAttribute = type.GetCustomAttributes<ObsoleteAttribute>().FirstOrDefault();
        }
        internal CommentAttribute? CommentAttribute { get; set; }
        internal IndexAttribute? IndexAttribute { get; set; }
        internal KeylessAttribute? KeylessAttribute { get; set; }
        internal NotMappedAttribute? NotMappedAttribute { get; set; }
        internal TableAttribute? TableAttribute { get; set; }
        internal ObsoleteAttribute? ObsoleteAttribute { get; set; }
    }
}

using System.Data.Entity;

namespace MessManagement.Core.Models
{
    class Context : DbContext
    {
        public Context() : base("MesssManagement")
        {
            
        }
    }
}

using System;
using TestOdin.Data;

namespace TestOdin.Models
{
    public class Notification:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

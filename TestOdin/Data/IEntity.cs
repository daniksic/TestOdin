using System;

namespace TestOdin.Data
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime DateAdded { get; set; }
    }
}

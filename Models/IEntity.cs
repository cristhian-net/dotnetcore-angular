using System;

namespace dotnetcore.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime CreatedAt { get; set; }
    }

    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
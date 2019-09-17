using System;

namespace dotnetcore.Models
{
    public class State : IEntity
    {
        public Guid Id { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
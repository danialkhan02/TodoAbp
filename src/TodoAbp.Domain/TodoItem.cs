using System;
using Volo.Abp.Domain.Entities;

namespace TodoApp
{
    // will inherit from Basic AggregateRoot, and Guid is the primary key
    public class TodoItem : BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
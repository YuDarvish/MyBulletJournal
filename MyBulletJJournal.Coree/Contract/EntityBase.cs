using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulletJJournal.Coree.Contract
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public List<DomainEventBase> Events = new List<DomainEventBase>();
    }
}

using MyBulletJJournal.Coree.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBulletJJournal.Coree.Entities.Signifiers;

namespace MyBulletJournal.Coree.Entities
{
    public class Bullet : EntityBase
    {
        public string Title { get; set; }
        public Signifier signifiers { get; set; }
        public DateTime Date { get; set; }
    }
}

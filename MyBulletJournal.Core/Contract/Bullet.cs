using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulletJournal.Core.Contract
{
    public abstract class Bullet
    {
        public string Title { get; set; }
        public Signifiers signifiers { get; set; }
        public DateTime Date { get; set; }
    }

    public enum Signifiers
    {
        Priority = 1,
        Inspiration = 2,
    }
}

using MyBulletJournal.Coree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulletJJournal.Coree.Entities
{
    public class Day
    {
        public DateTime Date { get; set; }
        public List<Bullet> Bullets { get; set; }

        public Day(DateTime dateTime)
        {
            Date = dateTime;
        }
    }
}

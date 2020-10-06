using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulletJournal.Core.Entities
{
    public class Tasks : Bullet
    {
        public List<Bullet> SubTasks { get; private set; }

        public Tasks()
        {
            SubTasks = new List<Bullet>();
        }

        public void AddSubTask(Bullet bullet)
        {
            SubTasks.Add(bullet);
        }
    }
}

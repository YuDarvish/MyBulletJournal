using MyBulletJournal.Coree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulletJJournal.Coree.Contract
{
    public interface IBulletRepository
    {
        Bullet GetById(int id);
        bool Save(Bullet bullet);
        List<Bullet> GetAll();


    }
}

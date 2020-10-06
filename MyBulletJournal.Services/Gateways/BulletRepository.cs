using MyBulletJJournal.Coree.Contract;
using MyBulletJournal.Coree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBulletJJournal.Coree.Entities.Signifiers;

namespace MyBulletJournal.Services.Gateways
{
    public class BulletRepository : IBulletRepository
    {
        List<Bullet> _bullets = new List<Bullet>();


        //FAKE PERSISTENCE
        public BulletRepository()
        {
            Bullet bullet = new Tasks();
            bullet.Title = "Comprar Pão";
            bullet.signifiers = Signifier.Priority;
            bullet.Date = DateTime.Now.Date;

            _bullets.Add(bullet);

            bullet = new Tasks();
            bullet.Title = "Na padaria jardim não!";
            bullet.signifiers = Signifier.Inspiration;
            bullet.Date = DateTime.Now.Date;

            _bullets.Add(bullet);

            bullet = new Tasks();
            bullet.Title = "Comprar Cafeteira";
            bullet.signifiers = Signifier.Priority;
            bullet.Date = new DateTime(2020, 10, 3);

            _bullets.Add(bullet);

            bullet = new Tasks();
            bullet.Title = "Enviar Documentos";
            bullet.signifiers = Signifier.Inspiration;
            bullet.Date = new DateTime(2020, 10, 3);

            _bullets.Add(bullet);
        }

        public List<Bullet> GetAll()
        {
            return _bullets;
        }

        public Bullet GetById(int id)
        {
            return _bullets.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Save(Bullet bullet)
        {
            try
            {
                _bullets.Add(bullet);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

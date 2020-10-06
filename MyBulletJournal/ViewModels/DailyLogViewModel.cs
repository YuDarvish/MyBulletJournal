using MyBulletJJournal.Coree.Contract;
using MyBulletJJournal.Coree.Entities;
using MyBulletJournal.Coree.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBulletJJournal.Coree.Entities.Signifiers;

namespace MyBulletJournal.ViewModels
{
    public class DailyLogViewModel
    {
        private readonly IBulletRepository _bulletRepository;

        private ObservableCollection<Bullet> _bullets = new ObservableCollection<Bullet>();
        private ObservableCollection<Day> _days = new ObservableCollection<Day>();
        public ObservableCollection<Day> Days { get { return this._days; } }
        public ObservableCollection<Bullet> Bullets { get { return this._bullets; } }

        public DailyLogViewModel(IBulletRepository bulletRepository)
        {
            _bulletRepository = bulletRepository;
            LoadBullets();
        }

        public DailyLogViewModel(DateTime dateTime)
        {
            ObservableCollection<Bullet> bullets = new ObservableCollection<Bullet>();
            ObservableCollection<Day> days = new ObservableCollection<Day>();

            var day = bullets.GroupBy(x => x.Date);

            foreach (var item in day)
            {
                Day newDay = new Day(item.Key);
                newDay.Bullets = item.ToList();
                days.Add(newDay);
            }

            _bullets = bullets;
            _days = days;
        }

        public void LoadBullets()
        {
            ObservableCollection<Bullet> bullets = new ObservableCollection<Bullet>();
            ObservableCollection<Day> days = new ObservableCollection<Day>();

            var day = _bulletRepository.GetAll().GroupBy(x => x.Date);

            foreach (var item in day)
            {
                Day newDay = new Day(item.Key);
                newDay.Bullets = item.ToList();
                days.Add(newDay);
            }

            _bullets = bullets;
            _days = days;
        }
    }
}

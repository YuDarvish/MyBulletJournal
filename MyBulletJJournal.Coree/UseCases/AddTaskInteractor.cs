using MyBulletJJournal.Coree.Contract;
using MyBulletJJournal.Coree.Dto;
using MyBulletJournal.Coree.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyBulletJJournal.Coree.Entities.Signifiers;

namespace MyBulletJJournal.Coree.UseCases
{
    public class AddTaskInteractor : IRequestHandler<AddTaskRequestMessage, AddTaskResponseMessage>
    {
        private readonly IBulletRepository _bulletRepository;

        public AddTaskInteractor(IBulletRepository bulletRepository)
        {
            _bulletRepository = bulletRepository;
        }
        public AddTaskResponseMessage Handle(AddTaskRequestMessage message)
        {
            var errors = new List<string>();

            Bullet bullet = new Bullet();

            bullet.Date = message.Date;
            bullet.signifiers = (Signifier) message.SignifierCode;
            bullet.Title = message.Title;

            if (!_bulletRepository.Save(bullet))
            {
                errors.Add("it has occurred an error while saving");
            }

            return new AddTaskResponseMessage(!errors.Any(), errors);
        }
    }
}

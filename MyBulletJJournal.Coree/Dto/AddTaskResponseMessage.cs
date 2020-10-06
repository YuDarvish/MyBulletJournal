using MyBulletJJournal.Coree.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulletJJournal.Coree.Dto
{
    public class AddTaskResponseMessage : ResponseMessage
    {
        public List<string> Errors { get; private set; }
        public AddTaskResponseMessage(bool success, List<string> errors, string message = null) : base(success, message)
        {
            Errors = errors;
        }
    }
}

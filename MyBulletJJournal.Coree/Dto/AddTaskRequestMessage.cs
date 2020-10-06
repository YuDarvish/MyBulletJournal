using MyBulletJJournal.Coree.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBulletJJournal.Coree.Dto
{
    public class AddTaskRequestMessage : IRequest<AddTaskResponseMessage>
    {
        public string Title { get; set; }
        public int SignifierCode { get; set; }
        public DateTime Date { get; set; }
        
        public AddTaskRequestMessage(string title, int signifierCode, DateTime date)
        {
            Title = title;
            SignifierCode = signifierCode;
            Date = date;
        }
    }
}

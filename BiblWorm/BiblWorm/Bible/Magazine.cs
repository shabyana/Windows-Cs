using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblWorm.Bibl
{
    class Magazine : Item, IPubs
    {
        private int volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска
        private bool returnSrok;
        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(int volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


        public override void Return()    // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }

        public void Subs()
        {
            this.IfSubs = true;
        }


        public override string ToString()
        {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
        }
    }
}

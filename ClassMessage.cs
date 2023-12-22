﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerModel
{
   public class Message
    {
        public int Id { get; set; } //not null
        public DateTime Date_Time {  get; set; } //not null
        public int UserSenderId {  get; set; } //not null
        public int UserRecepientId { get; set; } //not null
        public string Mes {  get; set; } //not null

        public Message(string mes, DateTime date_Time)
        {
            Mes = mes;
            Date_Time = DateTime.Now;
        }
        public override string ToString()
        {
            return Date_Time + ": " + Mes;
        }
        public virtual ICollection<User> Users { get; set; }
    }
}

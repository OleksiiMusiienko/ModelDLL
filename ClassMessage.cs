﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace MessengerModel
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public int Id { get; set; } //not null
        [DataMember]
        public DateTime Date_Time {  get; set; } //not null
        [DataMember]
        public int UserSenderId {  get; set; } //not null
        [DataMember]
        public int UserRecepientId { get; set; } //not null
        [DataMember]
        public string Mes {  get; set; } //not null
        [DataMember]
        public byte[]? MesAudio { get; set; }
        [DataMember]
        public string? MesAudioUri { get; set; }

        public Message() { }
        public Message(string mes, DateTime date_Time)
        {
            Mes = mes;
            Date_Time = date_Time;           
        }
        public override string ToString()
        {
            return Date_Time + ": " + Mes;
        }
        public virtual ICollection<User> Users { get; set; }
    }
}

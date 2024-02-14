using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace MessengerModel
{
    [DataContract]
    public class Friends
    {
        public int Id { get; set; } //not null
        [DataMember]
        public int UserSenderId { get; set; } //not null
        [DataMember]
        public int UserRecepientId { get; set; } //not null
        public Friends() { }
        public Friends(int SenderId, int RecepientId) 
        {
            UserSenderId = SenderId;
            UserRecepientId = RecepientId;
        }
        public virtual ICollection<User> Users { get; set; }
    }
}

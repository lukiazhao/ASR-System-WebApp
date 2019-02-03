using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsrSystem.Models
{
    /// <summary>
    /// Room. 
    /// </summary>
    public class Room
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Room ID")]
        public string RoomID { get; set; }

        public virtual ICollection<Slot> Slots { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataConcentrator.Model
{
    public class AlarmDTO
    {
        public AlarmDTO()
        {

        }

        public AlarmDTO(string alarmId, string tagId, string message, DateTime time)
        {
            AlarmId = alarmId;
            TagId = tagId;
            Message = message;
            Time = time;
            Handled = false;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string AlarmId { get; set; }

        public string TagId { get; set; }

        public string Message { get; set; }

        public DateTime Time { get; set; }

        public bool Handled { get; set; }
    }
}

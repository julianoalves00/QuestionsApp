using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary.Entities
{
    [Table("Question")] 
    public class Question
    {
        public long ID { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
    }
}

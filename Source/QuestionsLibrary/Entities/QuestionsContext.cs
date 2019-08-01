using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using QuestionsLibrary.Entities;

namespace QuestionsLibrary.Entities
{
    internal class QuestionsContext : DbContext
    {
        public QuestionsContext()
            : base("name=QuestionsConnectionString")
            //: base()
        {
            //this.Database.Connection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuestionsAPI;Integrated Security=true";
        }

        public DbSet<Question> Questions { get; set; }
    }
}

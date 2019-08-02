using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsLibrary.General
{
    public class QuestionLibaryException : Exception
    {
        public QuestionLibaryException() : base() { }
        public QuestionLibaryException(string message) : base(message) { }
        public QuestionLibaryException(string message, Exception innerException) : base(message, innerException) { }
        public QuestionLibaryException(params string[] args) : base(string.Format(args[0], args.Skip(1).Take(args.Length - 1).ToArray())) { }
    }
}

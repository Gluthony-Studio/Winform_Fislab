using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fislab_Project
{
    class QnA
    {
        private string _title;
        private string _question;
        private string _answer;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string question
        {
            get { return _question; }
            set { _question = value; }
        }
        public string answer
        {
            get { return _answer; }
            set { _answer = value; }
        }
    }
}

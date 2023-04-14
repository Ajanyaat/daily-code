using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Mail_folder
{
    internal class Mail
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _from;
        public string From
        {
            get
            {
                return _from;
            }
            set { _from = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        private DateTime _receivedDate;
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }



        public double _size;
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }



        public Mail()
        {


        }
        public Mail(long Id, string to, string from, string subject, string content, DateTime receivedDate, double _size)
        {
            Id = Id;
            To = to;
            From = from;
            Subject = subject;
            Content = content;
            ReceivedDate = receivedDate;
            Size = _size; 


        }
        public override string ToString()
        {
            return string.Format("Id:{0}\n To:{1}\n From:{2}\n Subject {3}\n" + "Content:{4}\n ReceivedDate:{5}\n Size{6}\n", Id, To, From, Subject, Content, ReceivedDate.ToString("dd-MM-yyyy", null), Size.ToString("0.0"));
        }

    }

}

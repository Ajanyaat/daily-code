﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mail_folder2
{
    internal class Mail
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _from;
        public string From
        {
            get { return _from; }
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
        private double _size;
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail()
        {

        }
        public Mail(long _id, string _from, string _to, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            Id= _id;
            From= _from;
            Subject= _subject;
            Content= _content;
            ReceivedDate= _receivedDate;
            Size= _size;
        }
        public override string ToString()
        {
            return string.Format("Id:{0}\n To:{1}\n From:{2} \n Subject:{3} \n Content:{4} \n RecievedDate:{5} \n Size:{6}" );
        }
        public static Mail CreateMail(string detail)
        {
            string[] s = detail.Split(',');
            DateTime dt = DateTime.ParseExact(s[5], "dd-mm-yyyy",null);
            Mail m1 = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], dt, double.Parse(s[6]));
            return m1;
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }


    }
}

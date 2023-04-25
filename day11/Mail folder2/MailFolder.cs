using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mail_folder2
{
    internal class MailFolder
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        private List<Mail> _mailList;
        public List<Mail> MailList
        {
            get
            { return _mailList; }
            set { _mailList = value; }

        }
        public MailFolder()
        {

        }
        public MailFolder(string _name, List<Mail> _mailList)
        {

            Name = _name;
            MailList = _mailList;
        }
        public void AddMailToFolder(Mail mail)
        {
            MailList.Add(mail);// add mail to the maillist

        }

        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in MailList) // iterating n0 1 to lat
            {
                if (item.Id == id)
                {
                    MailList.Remove(item);
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                return false;

            }
            else
                return true;
        }
        public void DisplayMails()
        {

            if (MailList.Count > 0)
            {
                foreach (var item in MailList)
                {
                    Console.WriteLine("mail{0}", Name);
                    Console.WriteLine(item.ToString());

                }
            }
            else
            {
                Console.WriteLine("No mails to show");
            }
        }



    } }       


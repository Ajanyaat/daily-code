namespace BankLib
{
    public class Locker
    {
        int _number;
        public int Number

        {
            get { return _number; } 
            set { _number = value; }    
        }


        string _lockType;
        public string LockType
        {
            get { return _lockType; }
            set { LockType = value; }
        }
        string _password;
        double _amount;
        DateTime _lastOpened;


        public Locker()
        {

        }
        public Locker(int _number, string _lockType, string _password, double _amount, DateTime _lastOpened)
        {
            this._number = _number; 
            this._lockType= _lockType;  
            this._lockType = _lockType; 
            this._password = _password;
            this._amount= _amount;
            this._lastOpened = _lastOpened; 

        }


    }


}
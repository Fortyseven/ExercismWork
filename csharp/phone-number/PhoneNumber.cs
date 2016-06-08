using System;
using System.Text.RegularExpressions;

class PhoneNumber
{
    private string _num;

    public PhoneNumber(string num)
    {
        this._num = Regex.Replace(num, @"[^0-9]", "");

        if (this._num.StartsWith("1") && this._num.Length == 11) {
            this._num = this._num.Substring(1);
        }

        if (this._num.Length != 10) {
            this._num = "0000000000";
        }
    }

    public override string ToString()
    {
        return String.Format("({0}) {1}-{2}", AreaCode, Number.Substring(3, 3), Number.Substring(6));
    }

    public object AreaCode { get { return _num.Substring(0, 3); } }
    public string Number { get { return _num; } }
}

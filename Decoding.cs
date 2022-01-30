using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Decoding
    {
        private string _text;
        private int _position;

        public Decoding(string text)
        {
            _text = text;
        }

        public void GoTo(string text)
        {
            int p = _text.IndexOf(text, _position);

            if (p > -1)
                _position = p;
        }

        public void Skip(string text)
        {
            int p = _text.IndexOf(text, _position);

            if (p > -1)
                _position = p + text.Length;
        }

        public string ReadTo(string text)
        {
            int p = _text.IndexOf(text, _position);
            string result = "";
            if (p > -1)
            {
                result = _text.Substring(_position, p - _position);
                _position = p;
            }
            return result;
        }
    }
}

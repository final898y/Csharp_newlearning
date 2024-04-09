using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator02
{
    internal class MyData
    {
        private int _x;
        private int _y;

        public int X
        { 
            get { return _x; } 
            set {  _x = value; } 
        }
        /*屬性的真實樣貌
        public int GetX()
        {
            return _x;
        }
        public void SetX(int value)
        {
            _x = value;
        }
        */
        public int Y
        { 
            get { return _y; } 
            set {  _y = value; } 
        }
        /*
        當屬性沒有甚麼特別要求的時候，可以採用『自動實作屬性』的寫法，
        省略掉其儲存欄位以及getter 與setter 的內容。
        public int Y { get; set; }
        */

        public int Add() 
        { 
            return _x + _y; 
        }
        public int Less() 
        { 
            return _x - _y; 
        }


    }
}

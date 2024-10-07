using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Models
{
    internal class Rectangle
    {
        public int Length {  get; set; }
        public int Breadth { get; set; }
        public string Color { get; set; }

       /*
        private int _length;
        private int _breadth;
        private string _color;

        public Rectangle(int length, int breadth, string color) { 
            _length = length;
            _breadth = breadth;
            _color = color;
        }
        
          public void SetLength(int length)
        { 
            _length = length;
        }
        

        public void SetBreadth(int breadth)
        { 
            _breadth=breadth;
        }

        public void SetColor(string color)
        { 
            _color = color;
        }
        public int GetLength() 
        { 
            return _length; 
        }
        public int GetBreadth()
        {
            return _breadth;
        }

        public string GetColor()
        {
            return _color;
        }
       //3rd method
        public int Length
        {
            set { _length = value; }
            get { return _length; }

        }
        public int Breadth
        { 
            set { _breadth = value; }
            get { return _breadth; }
        }
        public string Color
        {
            set { _color = value; }
            get { return _color; }
        }
       */
        public int CalculateArea()
        {
                return Length*Breadth;
        }
        public string PrintDetails(string title)
        {
            string outputString = $"============={title} Rectangle ==============\n" +
                $"Length: {Length}\n" +
                $"Breadth: {Breadth}\n" +
                $"Area: {CalculateArea()}\n"+
                $"Color: {Color}";
            return outputString;


        }
    }
}

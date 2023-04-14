﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Interface

{

    interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();

    }

    class Circle : IFigure
    {
        private int _Radius;
        public int Dimension
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        public double Area()
        {
            return Math.PI * _Radius * _Radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * _Radius;
        }
    }
    
    class Square: IFigure
    {
        private int _Side;
        public int Dimension
        {
            get { return _Side; }
            set { _Side = value; }

        }
        public double Area()
        {
            return _Side* _Side;
        }
        public  double Perimeter() {
            return 4 * _Side;
        }
    }












}



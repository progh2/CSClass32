﻿using System;

namespace CSClass32
{
    class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set {
                if (value > 0) width = value;
                else Console.WriteLine("양수를 입력해주세요!");
            }
        }

        private int height;
        public int Height{
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else Console.WriteLine("양수를 입력해주세요!");
            }
        }

        public int Area
        {
            get { return this.Width * this.height; }
        }

        public Box(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }


    }
}
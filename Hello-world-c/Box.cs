using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world_c
{
    class Box
    {
        // member variables
        private int length = 3;
        private int height;
        // public int width = 3;
        public int volume;

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        // Setters and Getters
        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("length should be higher than 0");
            }
            else
            {
                this.length = length;
            }
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }

        public void displayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}, so the volume is {3}",length, height, width, volume = length*height*width);
        }
    }
}

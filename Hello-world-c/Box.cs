using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_world_c
{
    class Box
    {
        //member variables
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        // Setters and Getters
        public void setLength(int length)
        {
            this.length = length;
        }

        public int getLength()
        {
            return this.length;
        }

        public void displayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}, so the volume is {3}",length, height, width, volume = length*height*width);
        }
    }
}

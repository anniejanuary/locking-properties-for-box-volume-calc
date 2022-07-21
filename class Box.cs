using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPart1
{
    internal class Box
    {
        // member variables
        private int length = 3;
        private int height;
        public int width;
        private int volume;

        //SETTING A PROPERTY 'Height' THAT WILL ADJUST MEMBER VARIABLE 'height' above
        //and setting 'public int height' (above) to private so i cant change it in Program.cs anymore
        //now I'll need to go through the property 'Height' to change it, not through the variable
        public int Height //properties start with a capital letter
        {
            get //getter
            {
                return height;
            }
            set //setter
            {
               height = value; 
            }
        }

        //ADDING A CONSTRUCTOR
        public Box(int length, int width, int height)
        {
            this.length = length;
            this.height = height;
            Width = width; //refers to a property below not "width" variable, and doesn't need a "this'"
        }


        //SETTING A PROPERTY FASTER!: prop & doubleTab (like with cw)
        public int Width { get; set; } //automatically creates a getter and a setter, so now I get or set it it through box.Width

        //Challenge: Volume, shorter
        //public int Volume { get; set; }

        //Challenge: Volume, longer
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }


        // CREATING A "SETTING" METHOD TO CHANGE A LOCKED PRIVATE VARIABLE "LENGTH"
        private void SetLength(int length)
        {
            //CHANGING THE LENGTH OF 'PRIVATE INT length' above TO AN UPDATED VARIABLE 'length' I'll change in Program.cs
            this.length = length;
        }

        // CREATING A "GETTING" METHOD TO CHANGE A LOCKED PRIVATE VARIABLE "LENGTH"
        public int GetLength()
        {
            return this.length;
        }

        //FURTHER BLOCKING UNAUTHORIZED ACCESS TO CHANGING VOLUME PARAMETERS
        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }

        //a new method
        public void DisplayInfo()
        {
            Console.WriteLine($"Length: {length}, height: {height}, width: {Width}, volume: {volume = length*height*Width}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoByteStuff();
        }
        public static void DemoByteStuff() {
            Byte myByte = 0xff;         // Hex format. We are storing all 1's in the byte
            Console.WriteLine(myByte);

            // Explicit type conversion
            Byte aByte = 100;
            aByte = (Byte)(aByte + 1);
            Console.WriteLine(myByte);


            // Overflow? What is 0xff + 1 ?
            myByte = (Byte)(myByte + 1);
            Console.WriteLine(myByte);

            // Masking the bits
            Byte mask = 0x01;           // The low bit is set, all other bits are off
            Byte someData = 0x34;       // What bits are set? Figure it out.

            someData = (Byte)(someData | mask); // Turn on the low bit in someData, leave the other bits alone. What bits are set now? Figure it out.
            Console.WriteLine(someData);

            // Use a mask to turn a bit OFF
            mask = 0xfe;        // What bits are set? Figure it out
            someData = 0xff;    // All bits on
            someData = (Byte)(someData & mask); // What happened to someData? What bits are set now?

            // Bitmapped graphics
            Byte[] myPic;
            myPic = new Byte[]{ 0b00111000,  /* 64 bits in an 8X8 grid */
                                0b01000100,
                                0b10000010,
                                0b10000010,
                                0b11000011,
                                0b01000010,
                                0b00100100,
                                0b00111000 };

            // Bit shifting...
            Byte value = 8;
            // What's 8 divided by 2?
            value = (byte)(value >> 1);     // Shifting one bit to the right is dividing by 2
            Console.WriteLine(value);

            value = (byte)(value << 1);     // Shifting one bit to the left is multiplying by 2
            Console.WriteLine(value);

        }
    }
}

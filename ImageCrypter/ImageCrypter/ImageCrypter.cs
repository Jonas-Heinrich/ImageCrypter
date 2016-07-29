using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace ImageCrypter
{
    class ImageCrypter
    {
        string input;
        string output;
        string file;

        public ImageCrypter(string input, string output)
        {
            this.input = input;
            this.output = output;
            file = "";
        }

        public ImageCrypter(string input, string output, string file)
        {
            this.input = input;
            this.output = output;
            this.file = file;
        }

        //
        //  Encrypt/Decrypt Methods
        //

        public int Encrypt(int bits)
        {
            if (!System.IO.File.Exists(input) ||
                !System.IO.File.Exists(file)  ||
                !Directory.Exists(Path.GetDirectoryName(output)))
                return -1;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (Bitmap original = new Bitmap(input))
            {
                Bitmap encImg = new Bitmap(original.Width, original.Height);

                long maxSize = CalculateMaxSize(original.Width, original.Height, bits);
                int sizeLength = CalculateBitLength(maxSize);
                long actualCapacity = maxSize - sizeLength;

                long fileLength = new FileInfo(file).Length * 8;

                if (fileLength > actualCapacity)
                    return -2;

                BinaryReader br = new BinaryReader(System.IO.File.Open(file, FileMode.Open));

                string bin = Convert.ToString(fileLength, 2);
                while (bin.Length < sizeLength)
                    bin = '0' + bin;

                char[] data = bin.ToCharArray();
                char dataPointer = (char)0;

                bool stop = false;

                for (int pointerY = 0; pointerY < original.Height; pointerY++)
                {
                    for (int pointerX = 0; pointerX < original.Width; pointerX++)
                    {
                        Color color = original.GetPixel(pointerX, pointerY);

                        char[][] colorBits = new char[][]
                        {
                        GetBits((char)color.R),
                        GetBits((char)color.G),
                        GetBits((char)color.B)
                        };

                        if (!stop)
                        {
                            for (int segment = 0; segment < 3 && !stop; segment++)
                            {
                                for (int bit = 0; bit < bits; bit++)
                                {
                                    if (dataPointer >= data.Length)
                                    {
                                        if (br.PeekChar() == -1)
                                        {
                                            stop = true;
                                            break;
                                        }
                                        else
                                        {
                                            data = GetBits((char)br.Read());
                                            dataPointer = (char)0;
                                        }
                                    }

                                    colorBits[segment][7 - bit] = data[dataPointer++];
                                }
                            }
                        }

                        encImg.SetPixel(pointerX, pointerY, GetColor(colorBits));
                    }
                }
                br.Close();
                encImg.Save(output);
            }
            sw.Stop();
            return (int)sw.ElapsedMilliseconds;
        }

        public int Decrypt(int bits)
        {
            if (!System.IO.File.Exists(input) ||
                !Directory.Exists(Path.GetDirectoryName(output)))
                return -1;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (Bitmap bm = new Bitmap(input))
            {
                BinaryWriter bw = new BinaryWriter(System.IO.File.Open(output, FileMode.Create));
                
                long currSize = 0;
                long fileSize = 0;
                
                bool stopFlag = false;
                bool fileSizeDeclarationFlag = true;

                long currPointer = 0;
                long fileSizeDeclarationLength = CalculateBitLength(CalculateMaxSize(bm.Width, bm.Height, bits));
                char[] fileLength = new char[fileSizeDeclarationLength];

                char[] collector = new char[8];
                char collectorPointer = (char)0;

                for (int pointerY = 0; pointerY < bm.Height && !stopFlag; pointerY++)
                {
                    for (int pointerX = 0; pointerX < bm.Width && !stopFlag; pointerX++)
                    {
                        Color color = bm.GetPixel(pointerX, pointerY);

                        char[][] colorBits = new char[][]
                        {
                        GetBits((char)color.R),
                        GetBits((char)color.G),
                        GetBits((char)color.B)
                        };

                        for (int segment = 0; segment < 3 && !stopFlag; segment++)
                        {
                            for (int bit = 0; bit < bits && !stopFlag; bit++)
                            {
                                if(!fileSizeDeclarationFlag)
                                {
                                    collector[collectorPointer++] = colorBits[segment][7 - bit];
                                    if (collectorPointer > 7)
                                    {
                                        bw.Write((char)Convert.ToInt32(new string(collector), 2));
                                        collectorPointer = (char)0;
                                    }
                                    if (++currSize >= fileSize)
                                        stopFlag = true;
                                }
                                else
                                {
                                    fileLength[currPointer++] = colorBits[segment][7 - bit];
                                    if(currPointer >= fileSizeDeclarationLength)
                                    {
                                        fileSize = Convert.ToInt32(new string(fileLength), 2);
                                        fileSizeDeclarationFlag = false;
                                    }
                                }
                            }
                        }
                    }
                }
                bw.Close();
            }
            sw.Stop();
            return (int)sw.ElapsedMilliseconds;
        }

        //
        //  Helper Methods  
        //

        /// <summary>
        /// Calculate the number of bits needed to store the size of the file to be encrypted.
        /// </summary>
        /// <param name="maxSize"></param>
        /// <returns></returns>
        public int CalculateBitLength(long maxSize)
        {
            int i = 1;
            while(Math.Pow(2, i++) - 1 < maxSize) ;
            return i - 1;
        }

        /// <summary>
        /// Calculate the maximum amount of information (in bits) a bitmap with the area width * height can store.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="numberOfBits"></param>
        /// <returns></returns>
        public long CalculateMaxSize(int width, int height, int numberOfBits)
        {
            if (numberOfBits > 8 || numberOfBits < 1)
                throw new ArgumentException();
            return width * height * 3 * numberOfBits;       // All pixels * rgb * numberofBits
        }

        private char[] GetBits(char c)
        {
            string binary = Convert.ToString((int)c, 2);
            while(binary.Length < 8)
                binary = '0' + binary;
            return binary.ToCharArray();
        }

        private Color GetColor(char[][] c)
        {
            return Color.FromArgb(
                Convert.ToInt32(new string(c[0]), 2),
                Convert.ToInt32(new string(c[1]), 2),
                Convert.ToInt32(new string(c[2]), 2)
                );
        }

        //
        //  Properties
        //

        public string Input
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
            }
        }

        public string Output
        {
            get
            {
                return output;
            }
            set
            {
                output = value;
            }
        }

        public string File
        {
            get
            {
                return file;
            }
            set
            {
                file = value;
            }
        }
    }
}
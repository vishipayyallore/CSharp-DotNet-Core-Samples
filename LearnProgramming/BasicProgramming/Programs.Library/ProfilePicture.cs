using BasicProgramming.CoreLibrary;
using System.Linq;
using static System.Console;

namespace Programs.Library
{
    class ProfilePicture : IProgram
    {
        public void Run()
        {
            WriteLine("Sample Input {180 \n3 \n640 480 \n120 300 \n180 180");
            var pictureLength = int.Parse(ReadLine().Trim());
            var numberOfPictures = int.Parse(ReadLine().Trim());
            for (var iCtr = 0; iCtr < numberOfPictures; iCtr++)
            {
                var pictureDimension = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                if (pictureDimension[0] < pictureLength || pictureDimension[1] < pictureLength)
                {
                    WriteLine("UPLOAD ANOTHER");
                    continue;
                }
                WriteLine(((pictureDimension[0] == pictureLength && pictureDimension[1] == pictureLength) || (pictureDimension[0] == pictureDimension[1])) ? "ACCEPTED" : "CROP IT");
            }
        }
    }
}

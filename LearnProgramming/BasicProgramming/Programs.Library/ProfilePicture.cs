using BasicProgramming.CoreLibrary;
using static System.Console;

namespace Programs.Library
{
    class ProfilePicture : IProgram
    {
        public void Run()
        {
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

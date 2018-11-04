namespace CSharp7.Logic.Programs.StringsDemo
{
    public class AlternatingCharacters
    {

        public int Execute(string inputData)
        {
            var remove = 0;

            for (var iCtr = 0; iCtr < inputData.Length - 1; iCtr++)
            {
                if (inputData[iCtr] == inputData[iCtr + 1])
                {
                    remove++;
                }
            }

            return remove;
        }

    }

}

namespace CSharp7.Logic.Programs.StringsDemo
{
    public class MakeAnagrams
    {

        private int GetRemoveCount(string firstData, string secondData)
        {
            var count = 0;
            for (int iCtr = 0; iCtr < firstData.Length; iCtr++)
            {
                // Characters to be Removed
                if (secondData.IndexOf(firstData[iCtr]) < 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int Execute(string firstData, string secondData)
        {
            var tobeRemoved = GetRemoveCount(firstData, secondData);
            tobeRemoved += GetRemoveCount(secondData, firstData);

            return tobeRemoved;
        }

    }

}

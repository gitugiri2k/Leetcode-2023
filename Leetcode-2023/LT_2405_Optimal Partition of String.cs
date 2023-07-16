using System;
namespace Leetcode_2023
{
	public class LT_2405_Optimal_Partition_of_String
	{
		public LT_2405_Optimal_Partition_of_String()
		{

		}
        public int PartitionString(string s)
        {
			HashSet<char> stringSet = new HashSet<char>();
			int numOfSub = 0;
			foreach(char c in s)
			{
				if (!stringSet.Contains(c))
					stringSet.Add(c);
				else
				{
					numOfSub++;
					stringSet.Clear();
                    stringSet.Add(c);
                }
			}
			if (stringSet.Count > 0)
				numOfSub++;
			return numOfSub;
        }
    }
}


// See https://aka.ms/new-console-template for more information
using Leetcode_2023;

//Console.WriteLine("Hello, World!");
//int[] arr = {1,2,3,4};

//Console.WriteLine(_480_RunningSum.RunningSum(arr));

//_9_GroupAnagrams a = new _9_GroupAnagrams();
//a.GroupAnagrams(new string[] {"eat", "tea", "tan", "ate", "nat", "bat"});
//_47_TopKFrequentElements b = new _47_TopKFrequentElements();
//Console.WriteLine(b.TopKFrequent(new int[] { 3, 0, 1, 0 }, 1));
//Input: nums = [1,2,3,4]
//Output: [24,12,8,6]
//LT_238_Product_of_Array_Except_Self a = new LT_238_Product_of_Array_Except_Self();
//Console.WriteLine($"==>{string.Join("==>",a.ProductExceptSelf(new int[] {4,3,2,1,2}))}");
//Console.WriteLine($"==>{string.Join("==>", a.ProductExceptSelf(new int[] {1,2,3,4}))}");
//LT_659_Encode_Decode_Strings s = new LT_659_Encode_Decode_Strings();
//s.decode(s.encode(new List<string> { "we", "say", ":", "yes" }));
//LT_128_Longest_Consecutive_Sequence c = new LT_128_Longest_Consecutive_Sequence();
//c.LongestConsecutive(new int[] { 1, 2, 0, 1 });
//string s = "A man, a plan, a canal: Panama";
//char[] c = (from c1 in s
//                        where !char.IsWhiteSpace(c1)
//                        select c1).ToArray();
//c = (from c1 in c
//     where char.IsLetterOrDigit(c1)
//     select c1).ToArray();
//string s1 = new string(c).ToLower();
//Array.Reverse(c);
//string s2 = new string(c);
//Console.WriteLine("s1="+s1);
//Console.WriteLine("S2="+s2);
//Console.WriteLine(s1.Equals(s2,StringComparison.CurrentCultureIgnoreCase));

//LT_15_3Sum s = new LT_15_3Sum();
//Console.WriteLine(s.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }).ToArray());
//LT_11_Container_With_Most_Water a = new LT_11_Container_With_Most_Water();
//a.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
//LT_121_BestTimeto_Buy_and_Sell_Stock a = new LT_121_BestTimeto_Buy_and_Sell_Stock();
//Console.WriteLine(a.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
//LT_3_Longest_Substring_Without_Repeating_Characters a = new LT_3_Longest_Substring_Without_Repeating_Characters();
//a.LengthOfLongestSubstring(new string("abcabcbb"));

//LT_1_Two_Sum a = new LT_1_Two_Sum();
//Console.WriteLine(string.Join("--->",a.TwoSum(new int[] { 3, 2,1,3 }, 6).ToArray()));


//LT_49_Group_Anagrams a = new LT_49_Group_Anagrams();
//a.GroupAnagrams(new string[] {"eat", "tea", "tan", "ate", "nat", "bat"});

//LT_424_Longest_Repeating_Character_Replacement a = new LT_424_Longest_Repeating_Character_Replacement();
//a.CharacterReplacement("AABABBA", 1);

//LT_20_Valid_Parentheses a = new LT_20_Valid_Parentheses();
//Console.WriteLine(a.IsValid("()"));
//LT_153_Find_Minimum_in_Rotated_Sorted_Array a = new LT_153_Find_Minimum_in_Rotated_Sorted_Array();
//Console.WriteLine(a.FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 }));




//TreeNode l1 = new TreeNode(5, null, null);
//TreeNode l2 = new TreeNode(3, null, null);
//TreeNode l3 = new TreeNode(0, null, null);
//TreeNode l4 = new TreeNode(7, null, null);
//TreeNode l5 = new TreeNode(9, null, null);
//TreeNode l6 = new TreeNode(4, l2, l1);
//TreeNode l7 = new TreeNode(2, l3, l6);
//TreeNode l8 = new TreeNode(8, l4, l5);
//TreeNode l9 = new TreeNode(6, l7, l8);

//TreeNode l1 = new TreeNode(15, null, null);
//TreeNode l2 = new TreeNode(7, null, null);
//TreeNode l3 = new TreeNode(9, null, null);
//TreeNode l4 = new TreeNode(20, l1, l2);
//TreeNode l5 = new TreeNode(3, l3, l4);




//LT_235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree a = new LT_235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree();

//Console.WriteLine(a.LowestCommonAncestor(l12,l10,l11).val);
//LT_102_Binary_Tree_Level_Order_Traversal a = new LT_102_Binary_Tree_Level_Order_Traversal();
//Console.WriteLine(a.LevelOrder(l5));

//LT_211_Design_Add_and_Search_Words_Data_Structure.WordDictionary a = new LT_211_Design_Add_and_Search_Words_Data_Structure.WordDictionary();
//a.AddWord("at");
//a.AddWord("and");
//a.AddWord("an");
//a.AddWord("add");
//Console.WriteLine(a.Search("a"));
//Console.WriteLine(a.Search(".at"));
//a.AddWord("bat");
//Console.WriteLine(a.Search(".at"));
//Console.WriteLine(a.Search("an."));
//Console.WriteLine(a.Search("a.d."));
//Console.WriteLine(a.Search("b."));
//Console.WriteLine(a.Search("a.d"));
//Console.WriteLine(a.Search("."));


//a.AddWord("bad");
//a.AddWord("dad");
//a.AddWord("mad");

//Console.WriteLine(a.Search("pad"));
//Console.WriteLine(a.Search("bad"));
//Console.WriteLine(a.Search(".ad"));
//Console.WriteLine(a.Search("b.."));

//LT_39_Combination_Sum a = new LT_39_Combination_Sum();
//int[] a1 = {2,3,6,7 };
//Console.WriteLine(string.Join(", ", a.CombinationSum(a1, 7)));

//LT_79_Word_Search a = new LT_79_Word_Search();
//char[][] board = new char[][]
//{
//new char[] { 'A', 'B', 'C', 'E' },
//new char[] { 'S', 'F', 'C', 'S' },
//new char[] { 'A', 'D', 'E', 'E' }
//};
//Console.WriteLine(a.Exist(board, "SEE"));

//LT_200_Number_of_Islands a = new LT_200_Number_of_Islands();
//char[][] island = new char[][]
//{
//    new char[]{'1','1','1','1','0' },
//    new char[]{'1','1','0','1','0' },
//    new char[]{'1','1','0','0','0' },
//    new char[]{'0','0','0','0','0' }
//};
//Console.WriteLine(a.NumIslands(island)); ;

//LT_70_Climbing_Stairs a = new LT_70_Climbing_Stairs();
//Console.WriteLine(a.ClimbStairs(3));

//LT_2259_Remove_Digit_From_Number_to_Maximize_Result a = new LT_2259_Remove_Digit_From_Number_to_Maximize_Result();
//Console.WriteLine(a.RemoveDigit("551", '9'));
//LT_1492_The_kth_Factor_of_n a = new LT_1492_The_kth_Factor_of_n();
//Console.WriteLine(a.KthFactor(4,4));

//LT_191_Number_of_1_Bits a = new LT_191_Number_of_1_Bits();
//a.CountBits(5);

//LT_190_Reverse_Bits a = new LT_190_Reverse_Bits();
//a.reverseBits(43261596);

//LT_268_Missing_Number a = new LT_268_Missing_Number();
//Console.WriteLine(a.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));

LT_4_Median_of_Two_Sorted_Arrays a = new LT_4_Median_of_Two_Sorted_Arrays();
a.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
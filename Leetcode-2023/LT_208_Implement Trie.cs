using System;
namespace Leetcode_2023
{
    public class LT_208_Implement_Trie
    {
        public LT_208_Implement_Trie()
        {
        }
        public class Trie
        {
            public TrieNode Root { get; set; }
            public Trie()
            {
                this.Root = new TrieNode();
            }

            public void Insert(string word)
            {
                TrieNode curr = this.Root;
                foreach (char c in word)
                {
                    if (!curr.children.ContainsKey(c))
                    {
                        curr.children[c] = new TrieNode();
                    }
                    curr = curr.children[c];
                }
                curr.isEndOfWord = true;
            }

            public bool Search(string word)
            {
                TrieNode curr = this.Root;
                foreach (char c in word)
                {
                    if (!curr.children.ContainsKey(c))
                    {
                        return false;
                    }
                    curr = curr.children[c];
                }
                return curr.isEndOfWord;
            }

            public bool StartsWith(string prefix)
            {
                TrieNode curr = this.Root;
                foreach (char c in prefix)
                {
                    if (!curr.children.ContainsKey(c))
                    {
                        return false;
                    }
                    curr = curr.children[c];
                }
                return true;
            }
        }
        public class TrieNode
        {
            public Dictionary<char, TrieNode> children { get; set; }
            public bool isEndOfWord { get; set; }
            public TrieNode()
            {
                this.children = new Dictionary<char, TrieNode>();
                this.isEndOfWord = false;
            }
        }
    }
}


﻿using System;
namespace Leetcode_2023
{
    public class LT_211_Design_Add_and_Search_Words_Data_Structure
    {
        public LT_211_Design_Add_and_Search_Words_Data_Structure()
        {
        }
        public class WordDictionary
        {
            public TrieNode root { get; set; }
            public WordDictionary()
            {
                this.root = new TrieNode();
            }

            public void AddWord(string word)
            {
                TrieNode curr = this.root;
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
                return dfs(word, this.root);
            }
            public bool dfs(string word, TrieNode root)
            {
                TrieNode curr = root;
                char c;
                for(int i=0;i<word.Length;i++)
                {
                    c = word[i];
                    if (c == '.')
                    {
                        foreach (var t in curr.children)
                        {
                            if (dfs(word.Substring(i + 1), t.Value))
                                return true;
                        }
                        return false;
                    }
                    else if (!curr.children.ContainsKey(c))
                        return false;
                    curr = curr.children[c];
                }
                return curr.isEndOfWord;
            }
        }
        public class TrieNode
        {
            public bool isEndOfWord { get; set; }
            public Dictionary<char, TrieNode> children { get; set; }
            public TrieNode()
            {
                this.children = new Dictionary<char, TrieNode>();
                this.isEndOfWord = false;
            }
        }
    }
}


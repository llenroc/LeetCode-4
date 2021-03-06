// Source : https://leetcode.com/problems/anagrams/ 
// Author : codeyu 
// Date : Friday, November 11, 2016 11:50:18 PM 

/**********************************************************************************
*
* Given an array of strings, group anagrams together.
* 
* 
* For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
* Return:
* 
* [
*   ["ate", "eat","tea"],
*   ["nat","tan"],
*   ["bat"]
* ]
* 
* Note: All inputs will be in lower-case.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
using System.Linq;
namespace Algorithms
{
    public class Solution049 
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            IList<IList<String>> res = new List<IList<String>>();  
            if(strs == null || strs.Length == 0)  
                return res;  
            Dictionary<String, List<String>> map = new Dictionary<String, List<String>>();  
            for(int i=0;i<strs.Length;i++)  
            {  
                char[] charArr = strs[i].ToCharArray();  
                Array.Sort(charArr);  
                String str = new String(charArr);  
                if(map.ContainsKey(str))  
                {  
                    map[str].Add(strs[i]);  
                }  
                else  
                {  
                    List<String> list = new List<String>();  
                    list.Add(strs[i]);  
                    map.Add(str,list);  
                }  
            }  
            foreach(var iter in map.Values)  
            {  
                List<String> item = (List<String>)iter;  
                if(item.Count>0)  
                    res.Add(item);  
            }  
            return res;    
        }
    }
}


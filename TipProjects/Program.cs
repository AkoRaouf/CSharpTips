using CShapAdvancedTips.Class;
using CShapAdvancedTips.Class.Projection;
using CShapAdvancedTips.Exceptions;
using CShapAdvancedTips.Struct._3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> state = new Dictionary<string, List<string>>();
            if(state.ContainsKey("Key"))
            {
                state["Key"].Add("tick");
            }
            state.Add("ss", new List<string>() {""});
            int[] ticketNumberArray = new int[100];
            var check = state.Where(x => x.Value.Contains(""))
        .Select(p => new KeyValuePair{ Key = p.Key, Value = p.Value }).FirstOrDefault();

            check["aa"] = 
        }
    }
}

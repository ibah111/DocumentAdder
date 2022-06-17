using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentAdder.Utils
{
    static class Addons
    {
        static public string GetName(string[] names)
        {
            List<string> result = new List<string>();
            foreach (var name in names)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    result.Add(name);
                }
            }
            return string.Join(" ", result);
        }
    }
}

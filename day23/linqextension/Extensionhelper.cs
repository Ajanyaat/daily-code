﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqextension
{
    public static  class Extensionhelper
    {

       
            public static int GetWordCount(this string str)
            {
                if (!String.IsNullOrEmpty(str))
                    return str.Split(' ').Length;
                return 0;
            }
        
    }
}

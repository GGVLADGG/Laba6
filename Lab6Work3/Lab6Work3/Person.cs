﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Work3
{
    public abstract class Person : IWhatDo
    {
        public static string name;
        public static int age;
        public abstract void Do();
    }
}

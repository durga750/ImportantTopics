﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in both code and config file together.
    public class MyService : IMyService
    {
        public string GetMessage(string Name)
        {
            return $"Hi {Name}";
        }
    }
}

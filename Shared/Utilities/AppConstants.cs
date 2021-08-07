﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotely.Shared.Utilities
{
    public class AppConstants
    {
        public const string DefaultProductName = "jRemote";
        public const string DefaultPublisherName = "HashForEver";
        public const long MaxUploadFileSize = 100_000_000;
        public const int RelayCodeLength = 4;
        public const double ScriptRunExpirationMinutes = 30;

        public const string RemotelyAscii = @"
  _____                      _       _       
 |  __ \                    | |     | |      
 | |__) |___ _ __ ___   ___ | |_ ___| |_   _ 
 |  _  // _ \ '_ ` _ \ / _ \| __/ _ \ | | | |
 | | \ \  __/ | | | | | (_) | ||  __/ | |_| |
 |_|  \_\___|_| |_| |_|\___/ \__\___|_|\__, |
                                        __/ |
                                       |___/ ";
    }
}
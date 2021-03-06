//  Copyright (c) 2018 Alachisoft
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//     http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License
using System;
using System.Collections.Generic;
using System.Text;
namespace Alachisoft.NCache.Runtime.CacheManagement
{
    /// <summary>
    /// CacheClient class contains information about CacheClient
    /// ProcessId ,ClientIp and Port of the Client process
    /// </summary>
    public  class  CacheClient
    {
        private string _processID;
        private string _clientIP;
        private int _port;
        /// <summary>
        /// Client process id
        /// </summary>
        public string ProcessID 
        {
            set { this._processID = value; }
            get { return this._processID; } 
        }

        /// <summary>
        /// Client IP Address
        /// </summary>
        public string ClientIP
        {
            set { this._clientIP = value; }
            get { return this._clientIP; }
        }

        /// <summary>
        /// Client Port
        /// </summary>
        public int Port
        {
            set { this._port = value;}
            get { return this._port;}
        }              
    }
}

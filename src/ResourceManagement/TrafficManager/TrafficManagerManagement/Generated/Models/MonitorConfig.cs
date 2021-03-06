// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    /// <summary>
    /// Class containing endpoint monitoring settings in a Traffic Manager
    /// profile.
    /// </summary>
    public partial class MonitorConfig
    {
        private string _path;
        
        /// <summary>
        /// Required. Gets or sets the path relative to the endpoint domain
        /// name used to probe for endpoint health.
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        
        private uint _port;
        
        /// <summary>
        /// Required. Gets or sets the TCP port used to probe for endpoint
        /// health.
        /// </summary>
        public uint Port
        {
            get { return this._port; }
            set { this._port = value; }
        }
        
        private string _profileMonitorStatus;
        
        /// <summary>
        /// Optional. Gets or sets the profile-level monitoring status of the
        /// Traffic Manager profile.
        /// </summary>
        public string ProfileMonitorStatus
        {
            get { return this._profileMonitorStatus; }
            set { this._profileMonitorStatus = value; }
        }
        
        private string _protocol;
        
        /// <summary>
        /// Required. Gets or sets the protocol (HTTP or HTTPS) used to probe
        /// for endpoint health.
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MonitorConfig class.
        /// </summary>
        public MonitorConfig()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the MonitorConfig class with required
        /// arguments.
        /// </summary>
        public MonitorConfig(string protocol, uint port, string path)
            : this()
        {
            if (protocol == null)
            {
                throw new ArgumentNullException("protocol");
            }
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            this.Protocol = protocol;
            this.Port = port;
            this.Path = path;
        }
    }
}

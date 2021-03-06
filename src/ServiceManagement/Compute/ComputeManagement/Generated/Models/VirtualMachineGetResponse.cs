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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The Get Virtual Machine operation response.
    /// </summary>
    public partial class VirtualMachineGetResponse : AzureOperationResponse
    {
        private string _availabilitySetName;
        
        /// <summary>
        /// Optional. The name of the availability set the virtual machine
        /// belongs to. This value controls the virtual machine allocation in
        /// the Windows Azure environment. Virtual machines specified in the
        /// same availability set are allocated to different nodes to maximize
        /// availability.
        /// </summary>
        public string AvailabilitySetName
        {
            get { return this._availabilitySetName; }
            set { this._availabilitySetName = value; }
        }
        
        private IList<ConfigurationSet> _configurationSets;
        
        /// <summary>
        /// Optional. Contains the collection of configuration sets that
        /// contain system and application configuration settings.
        /// </summary>
        public IList<ConfigurationSet> ConfigurationSets
        {
            get { return this._configurationSets; }
            set { this._configurationSets = value; }
        }
        
        private IList<DataVirtualHardDisk> _dataVirtualHardDisks;
        
        /// <summary>
        /// Optional. Contains the parameters Azure used to create the data
        /// disk for the virtual machine.
        /// </summary>
        public IList<DataVirtualHardDisk> DataVirtualHardDisks
        {
            get { return this._dataVirtualHardDisks; }
            set { this._dataVirtualHardDisks = value; }
        }
        
        private DebugSettings _debugSettings;
        
        /// <summary>
        /// Optional. Debug settings for console output.
        /// </summary>
        public DebugSettings DebugSettings
        {
            get { return this._debugSettings; }
            set { this._debugSettings = value; }
        }
        
        private string _defaultWinRmCertificateThumbprint;
        
        /// <summary>
        /// Optional. The read-only thumbprint of the certificate that is used
        /// with the HTTPS listener for WinRM.
        /// </summary>
        public string DefaultWinRmCertificateThumbprint
        {
            get { return this._defaultWinRmCertificateThumbprint; }
            set { this._defaultWinRmCertificateThumbprint = value; }
        }
        
        private string _licenseType;
        
        /// <summary>
        /// Optional. Specifies that the image or disk that is being used was
        /// licensed on-premises. This element is only used for images that
        /// contain the Windows Server operating system. Possible values are:
        /// Windows_Client, Windows_Server
        /// </summary>
        public string LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }
        
        private string _migrationState;
        
        /// <summary>
        /// Optional. Specifies the IaaS Classic to ARM migration state of the
        /// virtual machine.Possible values are: None, Preparing, Prepared,
        /// PrepareFailed, Committing, Committed, CommitFailed, Aborting,
        /// AbortFailed.None is treated as null value and it is not be visible.
        /// </summary>
        public string MigrationState
        {
            get { return this._migrationState; }
            set { this._migrationState = value; }
        }
        
        private string _osVersion;
        
        /// <summary>
        /// Optional. The version of the operating system on which the role
        /// instances are running.
        /// </summary>
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }
        
        private OSVirtualHardDisk _oSVirtualHardDisk;
        
        /// <summary>
        /// Optional. Contains the parameters Azure used to create the
        /// operating system disk for the virtual machine.
        /// </summary>
        public OSVirtualHardDisk OSVirtualHardDisk
        {
            get { return this._oSVirtualHardDisk; }
            set { this._oSVirtualHardDisk = value; }
        }
        
        private bool? _provisionGuestAgent;
        
        /// <summary>
        /// Optional. Optional. Indicates whether the VM Agent is installed on
        /// the Virtual Machine. To run a resource extension in a Virtual
        /// Machine,this service must be installed. Possible values are: true,
        /// false
        /// </summary>
        public bool? ProvisionGuestAgent
        {
            get { return this._provisionGuestAgent; }
            set { this._provisionGuestAgent = value; }
        }
        
        private string _roleName;
        
        /// <summary>
        /// Optional. The name for the virtual machine. The name is unique
        /// within Azure.
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }
        
        private string _roleSize;
        
        /// <summary>
        /// Optional. The size of the virtual machine.
        /// </summary>
        public string RoleSize
        {
            get { return this._roleSize; }
            set { this._roleSize = value; }
        }
        
        private VirtualMachineRoleType _roleType;
        
        /// <summary>
        /// Optional. The type of the role for the virtual machine. The only
        /// supported value is PersistentVMRole.
        /// </summary>
        public VirtualMachineRoleType RoleType
        {
            get { return this._roleType; }
            set { this._roleType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineGetResponse class.
        /// </summary>
        public VirtualMachineGetResponse()
        {
            this.ConfigurationSets = new LazyList<ConfigurationSet>();
            this.DataVirtualHardDisks = new LazyList<DataVirtualHardDisk>();
        }
    }
}

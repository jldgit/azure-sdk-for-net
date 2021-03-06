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

namespace Microsoft.Azure.Management.Batch.Models
{
    /// <summary>
    /// Contains information about the auto storage associated with a Batch
    /// account.
    /// </summary>
    public partial class AutoStorageProperties
    {
        private DateTime _lastKeySync;
        
        /// <summary>
        /// Required. Gets or sets the UTC time at which storage keys were last
        /// synced to the Batch account.
        /// </summary>
        public DateTime LastKeySync
        {
            get { return this._lastKeySync; }
            set { this._lastKeySync = value; }
        }
        
        private string _storageAccountId;
        
        /// <summary>
        /// Required. Gets or sets the resource id of the storage account to be
        /// used for auto storage.
        /// </summary>
        public string StorageAccountId
        {
            get { return this._storageAccountId; }
            set { this._storageAccountId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AutoStorageProperties class.
        /// </summary>
        public AutoStorageProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the AutoStorageProperties class with
        /// required arguments.
        /// </summary>
        public AutoStorageProperties(string storageAccountId, DateTime lastKeySync)
            : this()
        {
            if (storageAccountId == null)
            {
                throw new ArgumentNullException("storageAccountId");
            }
            this.StorageAccountId = storageAccountId;
            this.LastKeySync = lastKeySync;
        }
    }
}

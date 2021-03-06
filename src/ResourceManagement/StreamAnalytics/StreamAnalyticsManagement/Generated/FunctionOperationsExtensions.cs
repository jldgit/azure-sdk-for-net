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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics
{
    public static partial class FunctionOperationsExtensions
    {
        /// <summary>
        /// Test the connectivity of a function for a stream analytics job.
        /// Asynchronous call.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static ResourceTestConnectionResponse BeginTestConnection(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).BeginTestConnectionAsync(resourceGroupName, jobName, functionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Test the connectivity of a function for a stream analytics job.
        /// Asynchronous call.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static Task<ResourceTestConnectionResponse> BeginTestConnectionAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return operations.BeginTestConnectionAsync(resourceGroupName, jobName, functionName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a function
        /// for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the function create or update operation.
        /// </returns>
        public static FunctionCreateOrUpdateResponse CreateOrUpdate(this IFunctionOperations operations, string resourceGroupName, string jobName, FunctionCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).CreateOrUpdateAsync(resourceGroupName, jobName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a function
        /// for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the function create or update operation.
        /// </returns>
        public static Task<FunctionCreateOrUpdateResponse> CreateOrUpdateAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, FunctionCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, jobName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update a function for a stream analytics job. The raw
        /// json content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a function
        /// for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the function create or update operation.
        /// </returns>
        public static FunctionCreateOrUpdateResponse CreateOrUpdateWithRawJsonContent(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, functionName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a function for a stream analytics job. The raw
        /// json content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a function
        /// for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the function create or update operation.
        /// </returns>
        public static Task<FunctionCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, functionName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The common operation response.
        /// </returns>
        public static CommonOperationResponse Delete(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).DeleteAsync(resourceGroupName, jobName, functionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The common operation response.
        /// </returns>
        public static Task<CommonOperationResponse> DeleteAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return operations.DeleteAsync(resourceGroupName, jobName, functionName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the get stream analytics function operation.
        /// </returns>
        public static FunctionGetResponse Get(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).GetAsync(resourceGroupName, jobName, functionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the get stream analytics function operation.
        /// </returns>
        public static Task<FunctionGetResponse> GetAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return operations.GetAsync(resourceGroupName, jobName, functionName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of the functions defined in a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the function list operation.
        /// </returns>
        public static FunctionListResponse ListFunctionsInJob(this IFunctionOperations operations, string resourceGroupName, string jobName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).ListFunctionsInJobAsync(resourceGroupName, jobName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of the functions defined in a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the function list operation.
        /// </returns>
        public static Task<FunctionListResponse> ListFunctionsInJobAsync(this IFunctionOperations operations, string resourceGroupName, string jobName)
        {
            return operations.ListFunctionsInJobAsync(resourceGroupName, jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Update a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to update a function for a stream
        /// analytics job.
        /// </param>
        /// <returns>
        /// The response of the function patch operation.
        /// </returns>
        public static FunctionPatchResponse Patch(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionPatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).PatchAsync(resourceGroupName, jobName, functionName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to update a function for a stream
        /// analytics job.
        /// </param>
        /// <returns>
        /// The response of the function patch operation.
        /// </returns>
        public static Task<FunctionPatchResponse> PatchAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionPatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, jobName, functionName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the default definition of a function for a stream
        /// analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to retrieve the default
        /// definition of a function for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the retrieve default function definition operation.
        /// </returns>
        public static FunctionRetrieveDefaultDefinitionResponse RetrieveDefaultDefinition(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionRetrieveDefaultDefinitionParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).RetrieveDefaultDefinitionAsync(resourceGroupName, jobName, functionName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the default definition of a function for a stream
        /// analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to retrieve the default
        /// definition of a function for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the retrieve default function definition operation.
        /// </returns>
        public static Task<FunctionRetrieveDefaultDefinitionResponse> RetrieveDefaultDefinitionAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionRetrieveDefaultDefinitionParameters parameters)
        {
            return operations.RetrieveDefaultDefinitionAsync(resourceGroupName, jobName, functionName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the default definition of a function for a stream
        /// analytics job. The raw json content will be used for the request
        /// body.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to retrieve the default
        /// definition of a function for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the retrieve default function definition operation.
        /// </returns>
        public static FunctionRetrieveDefaultDefinitionResponse RetrieveDefaultDefinitionWithRawJsonContent(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionRetrieveDefaultDefinitionWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).RetrieveDefaultDefinitionWithRawJsonContentAsync(resourceGroupName, jobName, functionName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the default definition of a function for a stream
        /// analytics job. The raw json content will be used for the request
        /// body.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to retrieve the default
        /// definition of a function for a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the retrieve default function definition operation.
        /// </returns>
        public static Task<FunctionRetrieveDefaultDefinitionResponse> RetrieveDefaultDefinitionWithRawJsonContentAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName, FunctionRetrieveDefaultDefinitionWithRawJsonContentParameters parameters)
        {
            return operations.RetrieveDefaultDefinitionWithRawJsonContentAsync(resourceGroupName, jobName, functionName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Test the connectivity of a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static ResourceTestConnectionResponse TestConnection(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IFunctionOperations)s).TestConnectionAsync(resourceGroupName, jobName, functionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Test the connectivity of a function for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IFunctionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='functionName'>
        /// Required. The name of the function for the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static Task<ResourceTestConnectionResponse> TestConnectionAsync(this IFunctionOperations operations, string resourceGroupName, string jobName, string functionName)
        {
            return operations.TestConnectionAsync(resourceGroupName, jobName, functionName, CancellationToken.None);
        }
    }
}

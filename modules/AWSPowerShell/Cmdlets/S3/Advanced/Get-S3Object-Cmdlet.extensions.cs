/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Linq;
using System.Management.Automation;
using Amazon.PowerShell.Common;
using Amazon.S3;
using Amazon.S3.Model;
using System.Threading;
using Amazon.Runtime;

namespace Amazon.PowerShell.Cmdlets.S3
{
    public partial class GetS3ObjectCmdlet
    {
        #region Parameter Key 
        /// <summary>
        /// Key value identifying a single object in S3 to return metadata for.
        /// </summary>
        [Parameter(Position = 1, ParameterSetName = "GetSingleObject", ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Key { get; set; }
        #endregion

        // try and anticipate all the ways a user might mean 'get everything from root'
        readonly string[] rootIndicators = new string[] { "/", @"\", "*", "/*", @"\*" };

        protected override void PostExecutionContextLoad(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;

            if (this.Key != null)
            {
                this.Key = AmazonS3Helper.CleanKey(this.Key);
                cmdletContext.Prefix = this.Key;
            }
            else
            {
                cmdletContext.Prefix = rootIndicators.Contains<string>(this.Prefix, StringComparer.OrdinalIgnoreCase)
                    ? null : AmazonS3Helper.CleanKey(this.Prefix);
            }
        }

        protected override void ProcessOutput(CmdletOutput cmdletOutput)
        {
            if (cmdletOutput == null)
                return;

            if (this.Key != null && cmdletOutput.PipelineOutput is System.Collections.Generic.List<Amazon.S3.Model.S3Object> objects)
            {
                cmdletOutput.PipelineOutput = objects.Where(b => b.Key == this.Key).ToList();
            }

            base.ProcessOutput(cmdletOutput);
        }
    }
}

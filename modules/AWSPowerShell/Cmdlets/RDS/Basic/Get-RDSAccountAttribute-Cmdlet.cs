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
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.RDS;
using Amazon.RDS.Model;

namespace Amazon.PowerShell.Cmdlets.RDS
{
    /// <summary>
    /// Lists all of the attributes for a customer account. The attributes include Amazon
    /// RDS quotas for the account, such as the number of DB instances allowed. The description
    /// for a quota includes the quota name, current usage toward that quota, and the quota's
    /// maximum value.
    /// 
    ///  
    /// <para>
    /// This command doesn't take any parameters.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "RDSAccountAttribute")]
    [OutputType("Amazon.RDS.Model.AccountQuota")]
    [AWSCmdlet("Calls the Amazon Relational Database Service DescribeAccountAttributes API operation.", Operation = new[] {"DescribeAccountAttributes"}, SelectReturnType = typeof(Amazon.RDS.Model.DescribeAccountAttributesResponse), LegacyAlias="Get-RDSAccountAttributes")]
    [AWSCmdletOutput("Amazon.RDS.Model.AccountQuota or Amazon.RDS.Model.DescribeAccountAttributesResponse",
        "This cmdlet returns a collection of Amazon.RDS.Model.AccountQuota objects.",
        "The service call response (type Amazon.RDS.Model.DescribeAccountAttributesResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetRDSAccountAttributeCmdlet : AmazonRDSClientCmdlet, IExecutor
    {
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'AccountQuotas'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.RDS.Model.DescribeAccountAttributesResponse).
        /// Specifying the name of a property of type Amazon.RDS.Model.DescribeAccountAttributesResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "AccountQuotas";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.RDS.Model.DescribeAccountAttributesResponse, GetRDSAccountAttributeCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.RDS.Model.DescribeAccountAttributesRequest();
            
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.RDS.Model.DescribeAccountAttributesResponse CallAWSServiceOperation(IAmazonRDS client, Amazon.RDS.Model.DescribeAccountAttributesRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Relational Database Service", "DescribeAccountAttributes");
            try
            {
                #if DESKTOP
                return client.DescribeAccountAttributes(request);
                #elif CORECLR
                return client.DescribeAccountAttributesAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.Func<Amazon.RDS.Model.DescribeAccountAttributesResponse, GetRDSAccountAttributeCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.AccountQuotas;
        }
        
    }
}

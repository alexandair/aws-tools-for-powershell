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
using Amazon.GameLift;
using Amazon.GameLift.Model;

namespace Amazon.PowerShell.Cmdlets.GML
{
    /// <summary>
    /// Retrieves valid VPC peering authorizations that are pending for the AWS account. This
    /// operation returns all VPC peering authorizations and requests for peering. This includes
    /// those initiated and received by this account. 
    /// 
    ///  <ul><li><para><a>CreateVpcPeeringAuthorization</a></para></li><li><para><a>DescribeVpcPeeringAuthorizations</a></para></li><li><para><a>DeleteVpcPeeringAuthorization</a></para></li><li><para><a>CreateVpcPeeringConnection</a></para></li><li><para><a>DescribeVpcPeeringConnections</a></para></li><li><para><a>DeleteVpcPeeringConnection</a></para></li></ul>
    /// </summary>
    [Cmdlet("Get", "GMLVpcPeeringAuthorization")]
    [OutputType("Amazon.GameLift.Model.VpcPeeringAuthorization")]
    [AWSCmdlet("Calls the Amazon GameLift Service DescribeVpcPeeringAuthorizations API operation.", Operation = new[] {"DescribeVpcPeeringAuthorizations"}, SelectReturnType = typeof(Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse))]
    [AWSCmdletOutput("Amazon.GameLift.Model.VpcPeeringAuthorization or Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse",
        "This cmdlet returns a collection of Amazon.GameLift.Model.VpcPeeringAuthorization objects.",
        "The service call response (type Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetGMLVpcPeeringAuthorizationCmdlet : AmazonGameLiftClientCmdlet, IExecutor
    {
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'VpcPeeringAuthorizations'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse).
        /// Specifying the name of a property of type Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "VpcPeeringAuthorizations";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse, GetGMLVpcPeeringAuthorizationCmdlet>(Select) ??
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
            var request = new Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsRequest();
            
            
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
        
        private Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse CallAWSServiceOperation(IAmazonGameLift client, Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameLift Service", "DescribeVpcPeeringAuthorizations");
            try
            {
                #if DESKTOP
                return client.DescribeVpcPeeringAuthorizations(request);
                #elif CORECLR
                return client.DescribeVpcPeeringAuthorizationsAsync(request).GetAwaiter().GetResult();
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
            public System.Func<Amazon.GameLift.Model.DescribeVpcPeeringAuthorizationsResponse, GetGMLVpcPeeringAuthorizationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.VpcPeeringAuthorizations;
        }
        
    }
}

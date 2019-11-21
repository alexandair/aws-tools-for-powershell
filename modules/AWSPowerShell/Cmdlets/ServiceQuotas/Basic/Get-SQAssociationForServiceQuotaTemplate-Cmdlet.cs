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
using Amazon.ServiceQuotas;
using Amazon.ServiceQuotas.Model;

namespace Amazon.PowerShell.Cmdlets.SQ
{
    /// <summary>
    /// Retrieves the <code>ServiceQuotaTemplateAssociationStatus</code> value from the service.
    /// Use this action to determine if the Service Quota template is associated, or enabled.
    /// </summary>
    [Cmdlet("Get", "SQAssociationForServiceQuotaTemplate")]
    [OutputType("Amazon.ServiceQuotas.ServiceQuotaTemplateAssociationStatus")]
    [AWSCmdlet("Calls the AWS Service Quotas GetAssociationForServiceQuotaTemplate API operation.", Operation = new[] {"GetAssociationForServiceQuotaTemplate"}, SelectReturnType = typeof(Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse))]
    [AWSCmdletOutput("Amazon.ServiceQuotas.ServiceQuotaTemplateAssociationStatus or Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse",
        "This cmdlet returns an Amazon.ServiceQuotas.ServiceQuotaTemplateAssociationStatus object.",
        "The service call response (type Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetSQAssociationForServiceQuotaTemplateCmdlet : AmazonServiceQuotasClientCmdlet, IExecutor
    {
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ServiceQuotaTemplateAssociationStatus'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse).
        /// Specifying the name of a property of type Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ServiceQuotaTemplateAssociationStatus";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse, GetSQAssociationForServiceQuotaTemplateCmdlet>(Select) ??
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
            var request = new Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateRequest();
            
            
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
        
        private Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse CallAWSServiceOperation(IAmazonServiceQuotas client, Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Service Quotas", "GetAssociationForServiceQuotaTemplate");
            try
            {
                #if DESKTOP
                return client.GetAssociationForServiceQuotaTemplate(request);
                #elif CORECLR
                return client.GetAssociationForServiceQuotaTemplateAsync(request).GetAwaiter().GetResult();
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
            public System.Func<Amazon.ServiceQuotas.Model.GetAssociationForServiceQuotaTemplateResponse, GetSQAssociationForServiceQuotaTemplateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ServiceQuotaTemplateAssociationStatus;
        }
        
    }
}

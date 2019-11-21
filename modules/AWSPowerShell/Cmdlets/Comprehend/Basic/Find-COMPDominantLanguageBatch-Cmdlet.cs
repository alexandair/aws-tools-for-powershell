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
using Amazon.Comprehend;
using Amazon.Comprehend.Model;

namespace Amazon.PowerShell.Cmdlets.COMP
{
    /// <summary>
    /// Determines the dominant language of the input text for a batch of documents. For a
    /// list of languages that Amazon Comprehend can detect, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
    /// Comprehend Supported Languages</a>.
    /// </summary>
    [Cmdlet("Find", "COMPDominantLanguageBatch")]
    [OutputType("Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse")]
    [AWSCmdlet("Calls the Amazon Comprehend BatchDetectDominantLanguage API operation.", Operation = new[] {"BatchDetectDominantLanguage"}, SelectReturnType = typeof(Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse))]
    [AWSCmdletOutput("Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse",
        "This cmdlet returns an Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class FindCOMPDominantLanguageBatchCmdlet : AmazonComprehendClientCmdlet, IExecutor
    {
        
        #region Parameter TextList
        /// <summary>
        /// <para>
        /// <para>A list containing the text of the input documents. The list can contain a maximum
        /// of 25 documents. Each document should contain at least 20 characters and must contain
        /// fewer than 5,000 bytes of UTF-8 encoded characters.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String[] TextList { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse).
        /// Specifying the name of a property of type Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse, FindCOMPDominantLanguageBatchCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            if (this.TextList != null)
            {
                context.TextList = new List<System.String>(this.TextList);
            }
            #if MODULAR
            if (this.TextList == null && ParameterWasBound(nameof(this.TextList)))
            {
                WriteWarning("You are passing $null as a value for parameter TextList which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.Comprehend.Model.BatchDetectDominantLanguageRequest();
            
            if (cmdletContext.TextList != null)
            {
                request.TextList = cmdletContext.TextList;
            }
            
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
        
        private Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse CallAWSServiceOperation(IAmazonComprehend client, Amazon.Comprehend.Model.BatchDetectDominantLanguageRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Comprehend", "BatchDetectDominantLanguage");
            try
            {
                #if DESKTOP
                return client.BatchDetectDominantLanguage(request);
                #elif CORECLR
                return client.BatchDetectDominantLanguageAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> TextList { get; set; }
            public System.Func<Amazon.Comprehend.Model.BatchDetectDominantLanguageResponse, FindCOMPDominantLanguageBatchCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}

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
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

namespace Amazon.PowerShell.Cmdlets.SES
{
    /// <summary>
    /// Sets the specified receipt rule set as the active receipt rule set.
    /// 
    ///  <note><para>
    /// To disable your email-receiving through Amazon SES completely, you can call this API
    /// with RuleSetName set to null.
    /// </para></note><para>
    /// For information about managing receipt rule sets, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-receipt-rule-sets.html">Amazon
    /// SES Developer Guide</a>.
    /// </para><para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    [Cmdlet("Set", "SESActiveReceiptRuleSet", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Amazon Simple Email Service (SES) SetActiveReceiptRuleSet API operation.", Operation = new[] {"SetActiveReceiptRuleSet"}, SelectReturnType = typeof(Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetResponse))]
    [AWSCmdletOutput("None or Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class SetSESActiveReceiptRuleSetCmdlet : AmazonSimpleEmailServiceClientCmdlet, IExecutor
    {
        
        #region Parameter RuleSetName
        /// <summary>
        /// <para>
        /// <para>The name of the receipt rule set to make active. Setting this value to null disables
        /// all email receiving.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String RuleSetName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the RuleSetName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^RuleSetName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^RuleSetName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.RuleSetName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Set-SESActiveReceiptRuleSet (SetActiveReceiptRuleSet)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetResponse, SetSESActiveReceiptRuleSetCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.RuleSetName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.RuleSetName = this.RuleSetName;
            
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
            var request = new Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetRequest();
            
            if (cmdletContext.RuleSetName != null)
            {
                request.RuleSetName = cmdletContext.RuleSetName;
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
        
        private Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetResponse CallAWSServiceOperation(IAmazonSimpleEmailService client, Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Simple Email Service (SES)", "SetActiveReceiptRuleSet");
            try
            {
                #if DESKTOP
                return client.SetActiveReceiptRuleSet(request);
                #elif CORECLR
                return client.SetActiveReceiptRuleSetAsync(request).GetAwaiter().GetResult();
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
            public System.String RuleSetName { get; set; }
            public System.Func<Amazon.SimpleEmail.Model.SetActiveReceiptRuleSetResponse, SetSESActiveReceiptRuleSetCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}

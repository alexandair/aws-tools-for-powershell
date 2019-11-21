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
using Amazon.AWSSupport;
using Amazon.AWSSupport.Model;

namespace Amazon.PowerShell.Cmdlets.ASA
{
    /// <summary>
    /// Adds one or more attachments to an attachment set. If an <code>attachmentSetId</code>
    /// is not specified, a new attachment set is created, and the ID of the set is returned
    /// in the response. If an <code>attachmentSetId</code> is specified, the attachments
    /// are added to the specified set, if it exists.
    /// 
    ///  
    /// <para>
    /// An attachment set is a temporary container for attachments that are to be added to
    /// a case or case communication. The set is available for one hour after it is created;
    /// the <code>expiryTime</code> returned in the response indicates when the set expires.
    /// The maximum number of attachments in a set is 3, and the maximum size of any attachment
    /// in the set is 5 MB.
    /// </para>
    /// </summary>
    [Cmdlet("Add", "ASAAttachmentsToSet", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.AWSSupport.Model.AddAttachmentsToSetResponse")]
    [AWSCmdlet("Calls the AWS Support AddAttachmentsToSet API operation.", Operation = new[] {"AddAttachmentsToSet"}, SelectReturnType = typeof(Amazon.AWSSupport.Model.AddAttachmentsToSetResponse))]
    [AWSCmdletOutput("Amazon.AWSSupport.Model.AddAttachmentsToSetResponse",
        "This cmdlet returns an Amazon.AWSSupport.Model.AddAttachmentsToSetResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class AddASAAttachmentsToSetCmdlet : AmazonAWSSupportClientCmdlet, IExecutor
    {
        
        #region Parameter Attachment
        /// <summary>
        /// <para>
        /// <para>One or more attachments to add to the set. The limit is 3 attachments per set, and
        /// the size limit is 5 MB per attachment.</para>
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
        [Alias("Attachments")]
        public Amazon.AWSSupport.Model.Attachment[] Attachment { get; set; }
        #endregion
        
        #region Parameter AttachmentSetId
        /// <summary>
        /// <para>
        /// <para>The ID of the attachment set. If an <code>attachmentSetId</code> is not specified,
        /// a new attachment set is created, and the ID of the set is returned in the response.
        /// If an <code>attachmentSetId</code> is specified, the attachments are added to the
        /// specified set, if it exists.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String AttachmentSetId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AWSSupport.Model.AddAttachmentsToSetResponse).
        /// Specifying the name of a property of type Amazon.AWSSupport.Model.AddAttachmentsToSetResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AttachmentSetId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AttachmentSetId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AttachmentSetId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AttachmentSetId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Add-ASAAttachmentsToSet (AddAttachmentsToSet)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AWSSupport.Model.AddAttachmentsToSetResponse, AddASAAttachmentsToSetCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AttachmentSetId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.Attachment != null)
            {
                context.Attachment = new List<Amazon.AWSSupport.Model.Attachment>(this.Attachment);
            }
            #if MODULAR
            if (this.Attachment == null && ParameterWasBound(nameof(this.Attachment)))
            {
                WriteWarning("You are passing $null as a value for parameter Attachment which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AttachmentSetId = this.AttachmentSetId;
            
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
            var request = new Amazon.AWSSupport.Model.AddAttachmentsToSetRequest();
            
            if (cmdletContext.Attachment != null)
            {
                request.Attachments = cmdletContext.Attachment;
            }
            if (cmdletContext.AttachmentSetId != null)
            {
                request.AttachmentSetId = cmdletContext.AttachmentSetId;
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
        
        private Amazon.AWSSupport.Model.AddAttachmentsToSetResponse CallAWSServiceOperation(IAmazonAWSSupport client, Amazon.AWSSupport.Model.AddAttachmentsToSetRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Support", "AddAttachmentsToSet");
            try
            {
                #if DESKTOP
                return client.AddAttachmentsToSet(request);
                #elif CORECLR
                return client.AddAttachmentsToSetAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.AWSSupport.Model.Attachment> Attachment { get; set; }
            public System.String AttachmentSetId { get; set; }
            public System.Func<Amazon.AWSSupport.Model.AddAttachmentsToSetResponse, AddASAAttachmentsToSetCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}

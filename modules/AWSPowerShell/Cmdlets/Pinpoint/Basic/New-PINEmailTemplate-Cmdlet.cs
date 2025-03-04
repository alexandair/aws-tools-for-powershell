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
using Amazon.Pinpoint;
using Amazon.Pinpoint.Model;

namespace Amazon.PowerShell.Cmdlets.PIN
{
    /// <summary>
    /// Creates a message template that you can use in messages that are sent through the
    /// email channel.
    /// </summary>
    [Cmdlet("New", "PINEmailTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Pinpoint.Model.CreateTemplateMessageBody")]
    [AWSCmdlet("Calls the Amazon Pinpoint CreateEmailTemplate API operation.", Operation = new[] {"CreateEmailTemplate"}, SelectReturnType = typeof(Amazon.Pinpoint.Model.CreateEmailTemplateResponse))]
    [AWSCmdletOutput("Amazon.Pinpoint.Model.CreateTemplateMessageBody or Amazon.Pinpoint.Model.CreateEmailTemplateResponse",
        "This cmdlet returns an Amazon.Pinpoint.Model.CreateTemplateMessageBody object.",
        "The service call response (type Amazon.Pinpoint.Model.CreateEmailTemplateResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewPINEmailTemplateCmdlet : AmazonPinpointClientCmdlet, IExecutor
    {
        
        #region Parameter EmailTemplateRequest_HtmlPart
        /// <summary>
        /// <para>
        /// <para>The message body, in HTML format, to use in email messages that are based on the message
        /// template. We recommend using HTML format for email clients that support HTML. You
        /// can include links, formatted text, and more in an HTML message.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String EmailTemplateRequest_HtmlPart { get; set; }
        #endregion
        
        #region Parameter EmailTemplateRequest_Subject
        /// <summary>
        /// <para>
        /// <para>The subject line, or title, to use in email messages that are based on the message
        /// template.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String EmailTemplateRequest_Subject { get; set; }
        #endregion
        
        #region Parameter EmailTemplateRequest_Tag
        /// <summary>
        /// <para>
        /// <para>A string-to-string map of key-value pairs that defines the tags to associate with
        /// the message template. Each tag consists of a required tag key and an associated tag
        /// value.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("EmailTemplateRequest_Tags")]
        public System.Collections.Hashtable EmailTemplateRequest_Tag { get; set; }
        #endregion
        
        #region Parameter TemplateName
        /// <summary>
        /// <para>
        /// <para>The name of the message template. A template name must start with an alphanumeric
        /// character and can contain a maximum of 128 characters. The characters can be alphanumeric
        /// characters, underscores (_), or hyphens (-). Template names are case sensitive.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String TemplateName { get; set; }
        #endregion
        
        #region Parameter EmailTemplateRequest_TextPart
        /// <summary>
        /// <para>
        /// <para>The message body, in text format, to use in email messages that are based on the message
        /// template. We recommend using text format for email clients that don't support HTML
        /// and clients that are connected to high-latency networks, such as mobile devices.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String EmailTemplateRequest_TextPart { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'CreateTemplateMessageBody'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Pinpoint.Model.CreateEmailTemplateResponse).
        /// Specifying the name of a property of type Amazon.Pinpoint.Model.CreateEmailTemplateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "CreateTemplateMessageBody";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the TemplateName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^TemplateName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^TemplateName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.TemplateName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-PINEmailTemplate (CreateEmailTemplate)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Pinpoint.Model.CreateEmailTemplateResponse, NewPINEmailTemplateCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.TemplateName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.EmailTemplateRequest_HtmlPart = this.EmailTemplateRequest_HtmlPart;
            context.EmailTemplateRequest_Subject = this.EmailTemplateRequest_Subject;
            if (this.EmailTemplateRequest_Tag != null)
            {
                context.EmailTemplateRequest_Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.EmailTemplateRequest_Tag.Keys)
                {
                    context.EmailTemplateRequest_Tag.Add((String)hashKey, (String)(this.EmailTemplateRequest_Tag[hashKey]));
                }
            }
            context.EmailTemplateRequest_TextPart = this.EmailTemplateRequest_TextPart;
            context.TemplateName = this.TemplateName;
            #if MODULAR
            if (this.TemplateName == null && ParameterWasBound(nameof(this.TemplateName)))
            {
                WriteWarning("You are passing $null as a value for parameter TemplateName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.Pinpoint.Model.CreateEmailTemplateRequest();
            
            
             // populate EmailTemplateRequest
            var requestEmailTemplateRequestIsNull = true;
            request.EmailTemplateRequest = new Amazon.Pinpoint.Model.EmailTemplateRequest();
            System.String requestEmailTemplateRequest_emailTemplateRequest_HtmlPart = null;
            if (cmdletContext.EmailTemplateRequest_HtmlPart != null)
            {
                requestEmailTemplateRequest_emailTemplateRequest_HtmlPart = cmdletContext.EmailTemplateRequest_HtmlPart;
            }
            if (requestEmailTemplateRequest_emailTemplateRequest_HtmlPart != null)
            {
                request.EmailTemplateRequest.HtmlPart = requestEmailTemplateRequest_emailTemplateRequest_HtmlPart;
                requestEmailTemplateRequestIsNull = false;
            }
            System.String requestEmailTemplateRequest_emailTemplateRequest_Subject = null;
            if (cmdletContext.EmailTemplateRequest_Subject != null)
            {
                requestEmailTemplateRequest_emailTemplateRequest_Subject = cmdletContext.EmailTemplateRequest_Subject;
            }
            if (requestEmailTemplateRequest_emailTemplateRequest_Subject != null)
            {
                request.EmailTemplateRequest.Subject = requestEmailTemplateRequest_emailTemplateRequest_Subject;
                requestEmailTemplateRequestIsNull = false;
            }
            Dictionary<System.String, System.String> requestEmailTemplateRequest_emailTemplateRequest_Tag = null;
            if (cmdletContext.EmailTemplateRequest_Tag != null)
            {
                requestEmailTemplateRequest_emailTemplateRequest_Tag = cmdletContext.EmailTemplateRequest_Tag;
            }
            if (requestEmailTemplateRequest_emailTemplateRequest_Tag != null)
            {
                request.EmailTemplateRequest.Tags = requestEmailTemplateRequest_emailTemplateRequest_Tag;
                requestEmailTemplateRequestIsNull = false;
            }
            System.String requestEmailTemplateRequest_emailTemplateRequest_TextPart = null;
            if (cmdletContext.EmailTemplateRequest_TextPart != null)
            {
                requestEmailTemplateRequest_emailTemplateRequest_TextPart = cmdletContext.EmailTemplateRequest_TextPart;
            }
            if (requestEmailTemplateRequest_emailTemplateRequest_TextPart != null)
            {
                request.EmailTemplateRequest.TextPart = requestEmailTemplateRequest_emailTemplateRequest_TextPart;
                requestEmailTemplateRequestIsNull = false;
            }
             // determine if request.EmailTemplateRequest should be set to null
            if (requestEmailTemplateRequestIsNull)
            {
                request.EmailTemplateRequest = null;
            }
            if (cmdletContext.TemplateName != null)
            {
                request.TemplateName = cmdletContext.TemplateName;
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
        
        private Amazon.Pinpoint.Model.CreateEmailTemplateResponse CallAWSServiceOperation(IAmazonPinpoint client, Amazon.Pinpoint.Model.CreateEmailTemplateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Pinpoint", "CreateEmailTemplate");
            try
            {
                #if DESKTOP
                return client.CreateEmailTemplate(request);
                #elif CORECLR
                return client.CreateEmailTemplateAsync(request).GetAwaiter().GetResult();
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
            public System.String EmailTemplateRequest_HtmlPart { get; set; }
            public System.String EmailTemplateRequest_Subject { get; set; }
            public Dictionary<System.String, System.String> EmailTemplateRequest_Tag { get; set; }
            public System.String EmailTemplateRequest_TextPart { get; set; }
            public System.String TemplateName { get; set; }
            public System.Func<Amazon.Pinpoint.Model.CreateEmailTemplateResponse, NewPINEmailTemplateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.CreateTemplateMessageBody;
        }
        
    }
}

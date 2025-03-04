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
    /// Creates a new case in the AWS Support Center. This operation is modeled on the behavior
    /// of the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page. Its parameters require you to specify the following information: 
    /// 
    ///  <ul><li><para><b>issueType.</b> The type of issue for the case. You can specify either "customer-service"
    /// or "technical." If you do not indicate a value, the default is "technical." 
    /// </para></li><li><para><b>serviceCode.</b> The code for an AWS service. You obtain the <code>serviceCode</code>
    /// by calling <a>DescribeServices</a>. 
    /// </para></li><li><para><b>categoryCode.</b> The category for the service defined for the <code>serviceCode</code>
    /// value. You also obtain the category code for a service by calling <a>DescribeServices</a>.
    /// Each AWS service defines its own set of category codes. 
    /// </para></li><li><para><b>severityCode.</b> A value that indicates the urgency of the case, which in turn
    /// determines the response time according to your service level agreement with AWS Support.
    /// You obtain the SeverityCode by calling <a>DescribeSeverityLevels</a>.
    /// </para></li><li><para><b>subject.</b> The <b>Subject</b> field on the AWS Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page.
    /// </para></li><li><para><b>communicationBody.</b> The <b>Description</b> field on the AWS Support Center
    /// <a href="https://console.aws.amazon.com/support/home#/case/create">Create Case</a>
    /// page.
    /// </para></li><li><para><b>attachmentSetId.</b> The ID of a set of attachments that has been created by using
    /// <a>AddAttachmentsToSet</a>.
    /// </para></li><li><para><b>language.</b> The human language in which AWS Support handles the case. English
    /// and Japanese are currently supported.
    /// </para></li><li><para><b>ccEmailAddresses.</b> The AWS Support Center <b>CC</b> field on the <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page. You can list email addresses to be copied on any correspondence about
    /// the case. The account that opens the case is already identified by passing the AWS
    /// Credentials in the HTTP POST method or in a method or function call from one of the
    /// programming languages supported by an <a href="http://aws.amazon.com/tools/">AWS SDK</a>.
    /// 
    /// </para></li></ul><note><para>
    /// To add additional communication or attachments to an existing case, use <a>AddCommunicationToCase</a>.
    /// </para></note><para>
    /// A successful <a>CreateCase</a> request returns an AWS Support case number. Case numbers
    /// are used by the <a>DescribeCases</a> operation to retrieve existing AWS Support cases.
    /// 
    /// </para>
    /// </summary>
    [Cmdlet("New", "ASACase", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Support CreateCase API operation.", Operation = new[] {"CreateCase"}, SelectReturnType = typeof(Amazon.AWSSupport.Model.CreateCaseResponse))]
    [AWSCmdletOutput("System.String or Amazon.AWSSupport.Model.CreateCaseResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.AWSSupport.Model.CreateCaseResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewASACaseCmdlet : AmazonAWSSupportClientCmdlet, IExecutor
    {
        
        #region Parameter AttachmentSetId
        /// <summary>
        /// <para>
        /// <para>The ID of a set of one or more attachments for the case. Create the set by using <a>AddAttachmentsToSet</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AttachmentSetId { get; set; }
        #endregion
        
        #region Parameter CategoryCode
        /// <summary>
        /// <para>
        /// <para>The category of problem for the AWS Support case.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 3, ValueFromPipelineByPropertyName = true)]
        public System.String CategoryCode { get; set; }
        #endregion
        
        #region Parameter CcEmailAddress
        /// <summary>
        /// <para>
        /// <para>A list of email addresses that AWS Support copies on case correspondence.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CcEmailAddresses")]
        public System.String[] CcEmailAddress { get; set; }
        #endregion
        
        #region Parameter CommunicationBody
        /// <summary>
        /// <para>
        /// <para>The communication body text when you create an AWS Support case by calling <a>CreateCase</a>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 4, ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(Position = 4, ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String CommunicationBody { get; set; }
        #endregion
        
        #region Parameter IssueType
        /// <summary>
        /// <para>
        /// <para>The type of issue for the case. You can specify either "customer-service" or "technical."
        /// If you do not indicate a value, the default is "technical."</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String IssueType { get; set; }
        #endregion
        
        #region Parameter Language
        /// <summary>
        /// <para>
        /// <para>The ISO 639-1 code for the language in which AWS provides support. AWS Support currently
        /// supports English ("en") and Japanese ("ja"). Language parameters must be passed explicitly
        /// for operations that take them.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Language { get; set; }
        #endregion
        
        #region Parameter ServiceCode
        /// <summary>
        /// <para>
        /// <para>The code for the AWS service returned by the call to <a>DescribeServices</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        public System.String ServiceCode { get; set; }
        #endregion
        
        #region Parameter SeverityCode
        /// <summary>
        /// <para>
        /// <para>The code for the severity level returned by the call to <a>DescribeSeverityLevels</a>.</para><note><para>The availability of severity levels depends on each customer's support subscription.
        /// In other words, your subscription may not necessarily require the urgent level of
        /// response time.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true)]
        public System.String SeverityCode { get; set; }
        #endregion
        
        #region Parameter Subject
        /// <summary>
        /// <para>
        /// <para>The title of the AWS Support case.</para>
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
        public System.String Subject { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'CaseId'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AWSSupport.Model.CreateCaseResponse).
        /// Specifying the name of a property of type Amazon.AWSSupport.Model.CreateCaseResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "CaseId";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Subject parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Subject' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Subject' instead. This parameter will be removed in a future version.")]
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-ASACase (CreateCase)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AWSSupport.Model.CreateCaseResponse, NewASACaseCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Subject;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AttachmentSetId = this.AttachmentSetId;
            context.CategoryCode = this.CategoryCode;
            if (this.CcEmailAddress != null)
            {
                context.CcEmailAddress = new List<System.String>(this.CcEmailAddress);
            }
            context.CommunicationBody = this.CommunicationBody;
            #if MODULAR
            if (this.CommunicationBody == null && ParameterWasBound(nameof(this.CommunicationBody)))
            {
                WriteWarning("You are passing $null as a value for parameter CommunicationBody which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.IssueType = this.IssueType;
            context.Language = this.Language;
            context.ServiceCode = this.ServiceCode;
            context.SeverityCode = this.SeverityCode;
            context.Subject = this.Subject;
            #if MODULAR
            if (this.Subject == null && ParameterWasBound(nameof(this.Subject)))
            {
                WriteWarning("You are passing $null as a value for parameter Subject which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.AWSSupport.Model.CreateCaseRequest();
            
            if (cmdletContext.AttachmentSetId != null)
            {
                request.AttachmentSetId = cmdletContext.AttachmentSetId;
            }
            if (cmdletContext.CategoryCode != null)
            {
                request.CategoryCode = cmdletContext.CategoryCode;
            }
            if (cmdletContext.CcEmailAddress != null)
            {
                request.CcEmailAddresses = cmdletContext.CcEmailAddress;
            }
            if (cmdletContext.CommunicationBody != null)
            {
                request.CommunicationBody = cmdletContext.CommunicationBody;
            }
            if (cmdletContext.IssueType != null)
            {
                request.IssueType = cmdletContext.IssueType;
            }
            if (cmdletContext.Language != null)
            {
                request.Language = cmdletContext.Language;
            }
            if (cmdletContext.ServiceCode != null)
            {
                request.ServiceCode = cmdletContext.ServiceCode;
            }
            if (cmdletContext.SeverityCode != null)
            {
                request.SeverityCode = cmdletContext.SeverityCode;
            }
            if (cmdletContext.Subject != null)
            {
                request.Subject = cmdletContext.Subject;
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
        
        private Amazon.AWSSupport.Model.CreateCaseResponse CallAWSServiceOperation(IAmazonAWSSupport client, Amazon.AWSSupport.Model.CreateCaseRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Support", "CreateCase");
            try
            {
                #if DESKTOP
                return client.CreateCase(request);
                #elif CORECLR
                return client.CreateCaseAsync(request).GetAwaiter().GetResult();
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
            public System.String AttachmentSetId { get; set; }
            public System.String CategoryCode { get; set; }
            public List<System.String> CcEmailAddress { get; set; }
            public System.String CommunicationBody { get; set; }
            public System.String IssueType { get; set; }
            public System.String Language { get; set; }
            public System.String ServiceCode { get; set; }
            public System.String SeverityCode { get; set; }
            public System.String Subject { get; set; }
            public System.Func<Amazon.AWSSupport.Model.CreateCaseResponse, NewASACaseCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.CaseId;
        }
        
    }
}

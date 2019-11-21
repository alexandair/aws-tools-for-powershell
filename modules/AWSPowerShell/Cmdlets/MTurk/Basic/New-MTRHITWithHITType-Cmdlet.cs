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
using Amazon.MTurk;
using Amazon.MTurk.Model;

namespace Amazon.PowerShell.Cmdlets.MTR
{
    /// <summary>
    /// The <code>CreateHITWithHITType</code> operation creates a new Human Intelligence
    /// Task (HIT) using an existing HITTypeID generated by the <code>CreateHITType</code>
    /// operation. 
    /// 
    ///  
    /// <para>
    ///  This is an alternative way to create HITs from the <code>CreateHIT</code> operation.
    /// This is the recommended best practice for Requesters who are creating large numbers
    /// of HITs. 
    /// </para><para>
    /// CreateHITWithHITType also supports several ways to provide question data: by providing
    /// a value for the <code>Question</code> parameter that fully specifies the contents
    /// of the HIT, or by providing a <code>HitLayoutId</code> and associated <code>HitLayoutParameters</code>.
    /// 
    /// </para><note><para>
    ///  If a HIT is created with 10 or more maximum assignments, there is an additional fee.
    /// For more information, see <a href="https://requester.mturk.com/pricing">Amazon Mechanical
    /// Turk Pricing</a>. 
    /// </para></note>
    /// </summary>
    [Cmdlet("New", "MTRHITWithHITType", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.MTurk.Model.HIT")]
    [AWSCmdlet("Calls the Amazon MTurk Service CreateHITWithHITType API operation.", Operation = new[] {"CreateHITWithHITType"}, SelectReturnType = typeof(Amazon.MTurk.Model.CreateHITWithHITTypeResponse))]
    [AWSCmdletOutput("Amazon.MTurk.Model.HIT or Amazon.MTurk.Model.CreateHITWithHITTypeResponse",
        "This cmdlet returns an Amazon.MTurk.Model.HIT object.",
        "The service call response (type Amazon.MTurk.Model.CreateHITWithHITTypeResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewMTRHITWithHITTypeCmdlet : AmazonMTurkClientCmdlet, IExecutor
    {
        
        #region Parameter HITLayoutId
        /// <summary>
        /// <para>
        /// <para> The HITLayoutId allows you to use a pre-existing HIT design with placeholder values
        /// and create an additional HIT by providing those values as HITLayoutParameters. </para><para> Constraints: Either a Question parameter or a HITLayoutId parameter must be provided.
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String HITLayoutId { get; set; }
        #endregion
        
        #region Parameter HITLayoutParameter
        /// <summary>
        /// <para>
        /// <para> If the HITLayoutId is provided, any placeholder values must be filled in with values
        /// using the HITLayoutParameter structure. For more information, see HITLayout. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("HITLayoutParameters")]
        public Amazon.MTurk.Model.HITLayoutParameter[] HITLayoutParameter { get; set; }
        #endregion
        
        #region Parameter HITTypeId
        /// <summary>
        /// <para>
        /// <para>The HIT type ID you want to create this HIT with.</para>
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
        public System.String HITTypeId { get; set; }
        #endregion
        
        #region Parameter LifetimeInSecond
        /// <summary>
        /// <para>
        /// <para> An amount of time, in seconds, after which the HIT is no longer available for users
        /// to accept. After the lifetime of the HIT elapses, the HIT no longer appears in HIT
        /// searches, even if not all of the assignments for the HIT have been accepted. </para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("LifetimeInSeconds")]
        public System.Int64? LifetimeInSecond { get; set; }
        #endregion
        
        #region Parameter MaxAssignment
        /// <summary>
        /// <para>
        /// <para> The number of times the HIT can be accepted and completed before the HIT becomes
        /// unavailable. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxAssignments")]
        public System.Int32? MaxAssignment { get; set; }
        #endregion
        
        #region Parameter AssignmentReviewPolicy_Parameter
        /// <summary>
        /// <para>
        /// <para>Name of the parameter from the Review policy.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AssignmentReviewPolicy_Parameters")]
        public Amazon.MTurk.Model.PolicyParameter[] AssignmentReviewPolicy_Parameter { get; set; }
        #endregion
        
        #region Parameter HITReviewPolicy_Parameter
        /// <summary>
        /// <para>
        /// <para>Name of the parameter from the Review policy.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("HITReviewPolicy_Parameters")]
        public Amazon.MTurk.Model.PolicyParameter[] HITReviewPolicy_Parameter { get; set; }
        #endregion
        
        #region Parameter AssignmentReviewPolicy_PolicyName
        /// <summary>
        /// <para>
        /// <para> Name of a Review Policy: SimplePlurality/2011-09-01 or ScoreMyKnownAnswers/2011-09-01
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AssignmentReviewPolicy_PolicyName { get; set; }
        #endregion
        
        #region Parameter HITReviewPolicy_PolicyName
        /// <summary>
        /// <para>
        /// <para> Name of a Review Policy: SimplePlurality/2011-09-01 or ScoreMyKnownAnswers/2011-09-01
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String HITReviewPolicy_PolicyName { get; set; }
        #endregion
        
        #region Parameter Question
        /// <summary>
        /// <para>
        /// <para> The data the person completing the HIT uses to produce the results. </para><para> Constraints: Must be a QuestionForm data structure, an ExternalQuestion data structure,
        /// or an HTMLQuestion data structure. The XML question data must not be larger than 64
        /// kilobytes (65,535 bytes) in size, including whitespace. </para><para>Either a Question parameter or a HITLayoutId parameter must be provided.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Question { get; set; }
        #endregion
        
        #region Parameter RequesterAnnotation
        /// <summary>
        /// <para>
        /// <para> An arbitrary data field. The RequesterAnnotation parameter lets your application
        /// attach arbitrary data to the HIT for tracking purposes. For example, this parameter
        /// could be an identifier internal to the Requester's application that corresponds with
        /// the HIT. </para><para> The RequesterAnnotation parameter for a HIT is only visible to the Requester who
        /// created the HIT. It is not shown to the Worker, or any other Requester. </para><para> The RequesterAnnotation parameter may be different for each HIT you submit. It does
        /// not affect how your HITs are grouped. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RequesterAnnotation { get; set; }
        #endregion
        
        #region Parameter UniqueRequestToken
        /// <summary>
        /// <para>
        /// <para> A unique identifier for this request which allows you to retry the call on error
        /// without creating duplicate HITs. This is useful in cases such as network timeouts
        /// where it is unclear whether or not the call succeeded on the server. If the HIT already
        /// exists in the system from a previous call using the same UniqueRequestToken, subsequent
        /// calls will return a AWS.MechanicalTurk.HitAlreadyExists error with a message containing
        /// the HITId. </para><note><para> Note: It is your responsibility to ensure uniqueness of the token. The unique token
        /// expires after 24 hours. Subsequent calls using the same UniqueRequestToken made after
        /// the 24 hour limit could create duplicate HITs. </para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String UniqueRequestToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'HIT'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.MTurk.Model.CreateHITWithHITTypeResponse).
        /// Specifying the name of a property of type Amazon.MTurk.Model.CreateHITWithHITTypeResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "HIT";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the HITTypeId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^HITTypeId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^HITTypeId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.HITTypeId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-MTRHITWithHITType (CreateHITWithHITType)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.MTurk.Model.CreateHITWithHITTypeResponse, NewMTRHITWithHITTypeCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.HITTypeId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.AssignmentReviewPolicy_Parameter != null)
            {
                context.AssignmentReviewPolicy_Parameter = new List<Amazon.MTurk.Model.PolicyParameter>(this.AssignmentReviewPolicy_Parameter);
            }
            context.AssignmentReviewPolicy_PolicyName = this.AssignmentReviewPolicy_PolicyName;
            context.HITLayoutId = this.HITLayoutId;
            if (this.HITLayoutParameter != null)
            {
                context.HITLayoutParameter = new List<Amazon.MTurk.Model.HITLayoutParameter>(this.HITLayoutParameter);
            }
            if (this.HITReviewPolicy_Parameter != null)
            {
                context.HITReviewPolicy_Parameter = new List<Amazon.MTurk.Model.PolicyParameter>(this.HITReviewPolicy_Parameter);
            }
            context.HITReviewPolicy_PolicyName = this.HITReviewPolicy_PolicyName;
            context.HITTypeId = this.HITTypeId;
            #if MODULAR
            if (this.HITTypeId == null && ParameterWasBound(nameof(this.HITTypeId)))
            {
                WriteWarning("You are passing $null as a value for parameter HITTypeId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.LifetimeInSecond = this.LifetimeInSecond;
            #if MODULAR
            if (this.LifetimeInSecond == null && ParameterWasBound(nameof(this.LifetimeInSecond)))
            {
                WriteWarning("You are passing $null as a value for parameter LifetimeInSecond which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MaxAssignment = this.MaxAssignment;
            context.Question = this.Question;
            context.RequesterAnnotation = this.RequesterAnnotation;
            context.UniqueRequestToken = this.UniqueRequestToken;
            
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
            var request = new Amazon.MTurk.Model.CreateHITWithHITTypeRequest();
            
            
             // populate AssignmentReviewPolicy
            var requestAssignmentReviewPolicyIsNull = true;
            request.AssignmentReviewPolicy = new Amazon.MTurk.Model.ReviewPolicy();
            List<Amazon.MTurk.Model.PolicyParameter> requestAssignmentReviewPolicy_assignmentReviewPolicy_Parameter = null;
            if (cmdletContext.AssignmentReviewPolicy_Parameter != null)
            {
                requestAssignmentReviewPolicy_assignmentReviewPolicy_Parameter = cmdletContext.AssignmentReviewPolicy_Parameter;
            }
            if (requestAssignmentReviewPolicy_assignmentReviewPolicy_Parameter != null)
            {
                request.AssignmentReviewPolicy.Parameters = requestAssignmentReviewPolicy_assignmentReviewPolicy_Parameter;
                requestAssignmentReviewPolicyIsNull = false;
            }
            System.String requestAssignmentReviewPolicy_assignmentReviewPolicy_PolicyName = null;
            if (cmdletContext.AssignmentReviewPolicy_PolicyName != null)
            {
                requestAssignmentReviewPolicy_assignmentReviewPolicy_PolicyName = cmdletContext.AssignmentReviewPolicy_PolicyName;
            }
            if (requestAssignmentReviewPolicy_assignmentReviewPolicy_PolicyName != null)
            {
                request.AssignmentReviewPolicy.PolicyName = requestAssignmentReviewPolicy_assignmentReviewPolicy_PolicyName;
                requestAssignmentReviewPolicyIsNull = false;
            }
             // determine if request.AssignmentReviewPolicy should be set to null
            if (requestAssignmentReviewPolicyIsNull)
            {
                request.AssignmentReviewPolicy = null;
            }
            if (cmdletContext.HITLayoutId != null)
            {
                request.HITLayoutId = cmdletContext.HITLayoutId;
            }
            if (cmdletContext.HITLayoutParameter != null)
            {
                request.HITLayoutParameters = cmdletContext.HITLayoutParameter;
            }
            
             // populate HITReviewPolicy
            var requestHITReviewPolicyIsNull = true;
            request.HITReviewPolicy = new Amazon.MTurk.Model.ReviewPolicy();
            List<Amazon.MTurk.Model.PolicyParameter> requestHITReviewPolicy_hITReviewPolicy_Parameter = null;
            if (cmdletContext.HITReviewPolicy_Parameter != null)
            {
                requestHITReviewPolicy_hITReviewPolicy_Parameter = cmdletContext.HITReviewPolicy_Parameter;
            }
            if (requestHITReviewPolicy_hITReviewPolicy_Parameter != null)
            {
                request.HITReviewPolicy.Parameters = requestHITReviewPolicy_hITReviewPolicy_Parameter;
                requestHITReviewPolicyIsNull = false;
            }
            System.String requestHITReviewPolicy_hITReviewPolicy_PolicyName = null;
            if (cmdletContext.HITReviewPolicy_PolicyName != null)
            {
                requestHITReviewPolicy_hITReviewPolicy_PolicyName = cmdletContext.HITReviewPolicy_PolicyName;
            }
            if (requestHITReviewPolicy_hITReviewPolicy_PolicyName != null)
            {
                request.HITReviewPolicy.PolicyName = requestHITReviewPolicy_hITReviewPolicy_PolicyName;
                requestHITReviewPolicyIsNull = false;
            }
             // determine if request.HITReviewPolicy should be set to null
            if (requestHITReviewPolicyIsNull)
            {
                request.HITReviewPolicy = null;
            }
            if (cmdletContext.HITTypeId != null)
            {
                request.HITTypeId = cmdletContext.HITTypeId;
            }
            if (cmdletContext.LifetimeInSecond != null)
            {
                request.LifetimeInSeconds = cmdletContext.LifetimeInSecond.Value;
            }
            if (cmdletContext.MaxAssignment != null)
            {
                request.MaxAssignments = cmdletContext.MaxAssignment.Value;
            }
            if (cmdletContext.Question != null)
            {
                request.Question = cmdletContext.Question;
            }
            if (cmdletContext.RequesterAnnotation != null)
            {
                request.RequesterAnnotation = cmdletContext.RequesterAnnotation;
            }
            if (cmdletContext.UniqueRequestToken != null)
            {
                request.UniqueRequestToken = cmdletContext.UniqueRequestToken;
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
        
        private Amazon.MTurk.Model.CreateHITWithHITTypeResponse CallAWSServiceOperation(IAmazonMTurk client, Amazon.MTurk.Model.CreateHITWithHITTypeRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon MTurk Service", "CreateHITWithHITType");
            try
            {
                #if DESKTOP
                return client.CreateHITWithHITType(request);
                #elif CORECLR
                return client.CreateHITWithHITTypeAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.MTurk.Model.PolicyParameter> AssignmentReviewPolicy_Parameter { get; set; }
            public System.String AssignmentReviewPolicy_PolicyName { get; set; }
            public System.String HITLayoutId { get; set; }
            public List<Amazon.MTurk.Model.HITLayoutParameter> HITLayoutParameter { get; set; }
            public List<Amazon.MTurk.Model.PolicyParameter> HITReviewPolicy_Parameter { get; set; }
            public System.String HITReviewPolicy_PolicyName { get; set; }
            public System.String HITTypeId { get; set; }
            public System.Int64? LifetimeInSecond { get; set; }
            public System.Int32? MaxAssignment { get; set; }
            public System.String Question { get; set; }
            public System.String RequesterAnnotation { get; set; }
            public System.String UniqueRequestToken { get; set; }
            public System.Func<Amazon.MTurk.Model.CreateHITWithHITTypeResponse, NewMTRHITWithHITTypeCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.HIT;
        }
        
    }
}

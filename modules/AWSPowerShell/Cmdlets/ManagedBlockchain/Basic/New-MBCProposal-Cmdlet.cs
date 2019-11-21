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
using Amazon.ManagedBlockchain;
using Amazon.ManagedBlockchain.Model;

namespace Amazon.PowerShell.Cmdlets.MBC
{
    /// <summary>
    /// Creates a proposal for a change to the network that other members of the network can
    /// vote on, for example, a proposal to add a new member to the network. Any member can
    /// create a proposal.
    /// </summary>
    [Cmdlet("New", "MBCProposal", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Managed Blockchain CreateProposal API operation.", Operation = new[] {"CreateProposal"}, SelectReturnType = typeof(Amazon.ManagedBlockchain.Model.CreateProposalResponse))]
    [AWSCmdletOutput("System.String or Amazon.ManagedBlockchain.Model.CreateProposalResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.ManagedBlockchain.Model.CreateProposalResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewMBCProposalCmdlet : AmazonManagedBlockchainClientCmdlet, IExecutor
    {
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// <para>A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than one time. This identifier
        /// is required only if you make a service request directly using an HTTP client. It is
        /// generated automatically if you use an AWS SDK or the AWS CLI.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A description for the proposal that is visible to voting members, for example, "Proposal
        /// to add Example Corp. as member."</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter Actions_Invitation
        /// <summary>
        /// <para>
        /// <para> The actions to perform for an <code>APPROVED</code> proposal to invite an AWS account
        /// to create a member and join the network. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Actions_Invitations")]
        public Amazon.ManagedBlockchain.Model.InviteAction[] Actions_Invitation { get; set; }
        #endregion
        
        #region Parameter MemberId
        /// <summary>
        /// <para>
        /// <para>The unique identifier of the member that is creating the proposal. This identifier
        /// is especially useful for identifying the member making the proposal when multiple
        /// members exist in a single AWS account.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String MemberId { get; set; }
        #endregion
        
        #region Parameter NetworkId
        /// <summary>
        /// <para>
        /// <para> The unique identifier of the network for which the proposal is made.</para>
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
        public System.String NetworkId { get; set; }
        #endregion
        
        #region Parameter Actions_Removal
        /// <summary>
        /// <para>
        /// <para> The actions to perform for an <code>APPROVED</code> proposal to remove a member from
        /// the network, which deletes the member and all associated member resources from the
        /// network. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Actions_Removals")]
        public Amazon.ManagedBlockchain.Model.RemoveAction[] Actions_Removal { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ProposalId'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ManagedBlockchain.Model.CreateProposalResponse).
        /// Specifying the name of a property of type Amazon.ManagedBlockchain.Model.CreateProposalResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ProposalId";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the NetworkId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^NetworkId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^NetworkId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.NetworkId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-MBCProposal (CreateProposal)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ManagedBlockchain.Model.CreateProposalResponse, NewMBCProposalCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.NetworkId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.Actions_Invitation != null)
            {
                context.Actions_Invitation = new List<Amazon.ManagedBlockchain.Model.InviteAction>(this.Actions_Invitation);
            }
            if (this.Actions_Removal != null)
            {
                context.Actions_Removal = new List<Amazon.ManagedBlockchain.Model.RemoveAction>(this.Actions_Removal);
            }
            context.ClientRequestToken = this.ClientRequestToken;
            context.Description = this.Description;
            context.MemberId = this.MemberId;
            #if MODULAR
            if (this.MemberId == null && ParameterWasBound(nameof(this.MemberId)))
            {
                WriteWarning("You are passing $null as a value for parameter MemberId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NetworkId = this.NetworkId;
            #if MODULAR
            if (this.NetworkId == null && ParameterWasBound(nameof(this.NetworkId)))
            {
                WriteWarning("You are passing $null as a value for parameter NetworkId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ManagedBlockchain.Model.CreateProposalRequest();
            
            
             // populate Actions
            var requestActionsIsNull = true;
            request.Actions = new Amazon.ManagedBlockchain.Model.ProposalActions();
            List<Amazon.ManagedBlockchain.Model.InviteAction> requestActions_actions_Invitation = null;
            if (cmdletContext.Actions_Invitation != null)
            {
                requestActions_actions_Invitation = cmdletContext.Actions_Invitation;
            }
            if (requestActions_actions_Invitation != null)
            {
                request.Actions.Invitations = requestActions_actions_Invitation;
                requestActionsIsNull = false;
            }
            List<Amazon.ManagedBlockchain.Model.RemoveAction> requestActions_actions_Removal = null;
            if (cmdletContext.Actions_Removal != null)
            {
                requestActions_actions_Removal = cmdletContext.Actions_Removal;
            }
            if (requestActions_actions_Removal != null)
            {
                request.Actions.Removals = requestActions_actions_Removal;
                requestActionsIsNull = false;
            }
             // determine if request.Actions should be set to null
            if (requestActionsIsNull)
            {
                request.Actions = null;
            }
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.MemberId != null)
            {
                request.MemberId = cmdletContext.MemberId;
            }
            if (cmdletContext.NetworkId != null)
            {
                request.NetworkId = cmdletContext.NetworkId;
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
        
        private Amazon.ManagedBlockchain.Model.CreateProposalResponse CallAWSServiceOperation(IAmazonManagedBlockchain client, Amazon.ManagedBlockchain.Model.CreateProposalRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Managed Blockchain", "CreateProposal");
            try
            {
                #if DESKTOP
                return client.CreateProposal(request);
                #elif CORECLR
                return client.CreateProposalAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.ManagedBlockchain.Model.InviteAction> Actions_Invitation { get; set; }
            public List<Amazon.ManagedBlockchain.Model.RemoveAction> Actions_Removal { get; set; }
            public System.String ClientRequestToken { get; set; }
            public System.String Description { get; set; }
            public System.String MemberId { get; set; }
            public System.String NetworkId { get; set; }
            public System.Func<Amazon.ManagedBlockchain.Model.CreateProposalResponse, NewMBCProposalCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ProposalId;
        }
        
    }
}

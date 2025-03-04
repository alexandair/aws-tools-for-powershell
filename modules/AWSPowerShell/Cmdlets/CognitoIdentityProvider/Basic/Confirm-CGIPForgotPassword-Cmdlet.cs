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
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;

namespace Amazon.PowerShell.Cmdlets.CGIP
{
    /// <summary>
    /// Allows a user to enter a confirmation code to reset a forgotten password.
    /// </summary>
    [Cmdlet("Confirm", "CGIPForgotPassword", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Amazon Cognito Identity Provider ConfirmForgotPassword API operation. This operation uses anonymous authentication and does not require credential parameters to be supplied.", Operation = new[] {"ConfirmForgotPassword"}, SelectReturnType = typeof(Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordResponse))]
    [AWSCmdletOutput("None or Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class ConfirmCGIPForgotPasswordCmdlet : AnonymousAmazonCognitoIdentityProviderClientCmdlet, IExecutor
    {
        
        #region Parameter AnalyticsMetadata_AnalyticsEndpointId
        /// <summary>
        /// <para>
        /// <para>The endpoint ID.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AnalyticsMetadata_AnalyticsEndpointId { get; set; }
        #endregion
        
        #region Parameter ClientId
        /// <summary>
        /// <para>
        /// <para>The app client ID of the app associated with the user pool.</para>
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
        public System.String ClientId { get; set; }
        #endregion
        
        #region Parameter ClientMetadata
        /// <summary>
        /// <para>
        /// <para>A map of custom key-value pairs that you can provide as input for any custom workflows
        /// that this action triggers. </para><para>You create custom workflows by assigning AWS Lambda functions to user pool triggers.
        /// When you use the ConfirmForgotPassword API action, Amazon Cognito invokes the functions
        /// that are assigned to the <i>post confirmation</i> and <i>pre mutation</i> triggers.
        /// When Amazon Cognito invokes either of these functions, it passes a JSON payload, which
        /// the function receives as input. This payload contains a <code>clientMetadata</code>
        /// attribute, which provides the data that you assigned to the ClientMetadata parameter
        /// in your ConfirmForgotPassword request. In your function code in AWS Lambda, you can
        /// process the <code>clientMetadata</code> value to enhance your workflow for your specific
        /// needs.</para><para>For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">Customizing
        /// User Pool Workflows with Lambda Triggers</a> in the <i>Amazon Cognito Developer Guide</i>.</para><note><para>Take the following limitations into consideration when you use the ClientMetadata
        /// parameter:</para><ul><li><para>Amazon Cognito does not store the ClientMetadata value. This data is available only
        /// to AWS Lambda triggers that are assigned to a user pool to support custom workflows.
        /// If your user pool configuration does not include triggers, the ClientMetadata parameter
        /// serves no purpose.</para></li><li><para>Amazon Cognito does not validate the ClientMetadata value.</para></li><li><para>Amazon Cognito does not encrypt the the ClientMetadata value, so don't use it to provide
        /// sensitive information.</para></li></ul></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Collections.Hashtable ClientMetadata { get; set; }
        #endregion
        
        #region Parameter ConfirmationCode
        /// <summary>
        /// <para>
        /// <para>The confirmation code sent by a user's request to retrieve a forgotten password. For
        /// more information, see </para>
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
        public System.String ConfirmationCode { get; set; }
        #endregion
        
        #region Parameter UserContextData_EncodedData
        /// <summary>
        /// <para>
        /// <para>Contextual data such as the user's device fingerprint, IP address, or location used
        /// for evaluating the risk of an unexpected event by Amazon Cognito advanced security.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String UserContextData_EncodedData { get; set; }
        #endregion
        
        #region Parameter Password
        /// <summary>
        /// <para>
        /// <para>The password sent by a user's request to retrieve a forgotten password.</para>
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
        public System.String Password { get; set; }
        #endregion
        
        #region Parameter SecretHash
        /// <summary>
        /// <para>
        /// <para>A keyed-hash message authentication code (HMAC) calculated using the secret key of
        /// a user pool client and username plus the client ID in the message.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SecretHash { get; set; }
        #endregion
        
        #region Parameter Username
        /// <summary>
        /// <para>
        /// <para>The user name of the user for whom you want to enter a code to retrieve a forgotten
        /// password.</para>
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
        public System.String Username { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Username parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Username' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Username' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Username), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Confirm-CGIPForgotPassword (ConfirmForgotPassword)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordResponse, ConfirmCGIPForgotPasswordCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Username;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AnalyticsMetadata_AnalyticsEndpointId = this.AnalyticsMetadata_AnalyticsEndpointId;
            context.ClientId = this.ClientId;
            #if MODULAR
            if (this.ClientId == null && ParameterWasBound(nameof(this.ClientId)))
            {
                WriteWarning("You are passing $null as a value for parameter ClientId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.ClientMetadata != null)
            {
                context.ClientMetadata = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.ClientMetadata.Keys)
                {
                    context.ClientMetadata.Add((String)hashKey, (String)(this.ClientMetadata[hashKey]));
                }
            }
            context.ConfirmationCode = this.ConfirmationCode;
            #if MODULAR
            if (this.ConfirmationCode == null && ParameterWasBound(nameof(this.ConfirmationCode)))
            {
                WriteWarning("You are passing $null as a value for parameter ConfirmationCode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Password = this.Password;
            #if MODULAR
            if (this.Password == null && ParameterWasBound(nameof(this.Password)))
            {
                WriteWarning("You are passing $null as a value for parameter Password which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SecretHash = this.SecretHash;
            context.UserContextData_EncodedData = this.UserContextData_EncodedData;
            context.Username = this.Username;
            #if MODULAR
            if (this.Username == null && ParameterWasBound(nameof(this.Username)))
            {
                WriteWarning("You are passing $null as a value for parameter Username which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordRequest();
            
            
             // populate AnalyticsMetadata
            var requestAnalyticsMetadataIsNull = true;
            request.AnalyticsMetadata = new Amazon.CognitoIdentityProvider.Model.AnalyticsMetadataType();
            System.String requestAnalyticsMetadata_analyticsMetadata_AnalyticsEndpointId = null;
            if (cmdletContext.AnalyticsMetadata_AnalyticsEndpointId != null)
            {
                requestAnalyticsMetadata_analyticsMetadata_AnalyticsEndpointId = cmdletContext.AnalyticsMetadata_AnalyticsEndpointId;
            }
            if (requestAnalyticsMetadata_analyticsMetadata_AnalyticsEndpointId != null)
            {
                request.AnalyticsMetadata.AnalyticsEndpointId = requestAnalyticsMetadata_analyticsMetadata_AnalyticsEndpointId;
                requestAnalyticsMetadataIsNull = false;
            }
             // determine if request.AnalyticsMetadata should be set to null
            if (requestAnalyticsMetadataIsNull)
            {
                request.AnalyticsMetadata = null;
            }
            if (cmdletContext.ClientId != null)
            {
                request.ClientId = cmdletContext.ClientId;
            }
            if (cmdletContext.ClientMetadata != null)
            {
                request.ClientMetadata = cmdletContext.ClientMetadata;
            }
            if (cmdletContext.ConfirmationCode != null)
            {
                request.ConfirmationCode = cmdletContext.ConfirmationCode;
            }
            if (cmdletContext.Password != null)
            {
                request.Password = cmdletContext.Password;
            }
            if (cmdletContext.SecretHash != null)
            {
                request.SecretHash = cmdletContext.SecretHash;
            }
            
             // populate UserContextData
            var requestUserContextDataIsNull = true;
            request.UserContextData = new Amazon.CognitoIdentityProvider.Model.UserContextDataType();
            System.String requestUserContextData_userContextData_EncodedData = null;
            if (cmdletContext.UserContextData_EncodedData != null)
            {
                requestUserContextData_userContextData_EncodedData = cmdletContext.UserContextData_EncodedData;
            }
            if (requestUserContextData_userContextData_EncodedData != null)
            {
                request.UserContextData.EncodedData = requestUserContextData_userContextData_EncodedData;
                requestUserContextDataIsNull = false;
            }
             // determine if request.UserContextData should be set to null
            if (requestUserContextDataIsNull)
            {
                request.UserContextData = null;
            }
            if (cmdletContext.Username != null)
            {
                request.Username = cmdletContext.Username;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_RegionEndpoint);
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
        
        private Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordResponse CallAWSServiceOperation(IAmazonCognitoIdentityProvider client, Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Cognito Identity Provider", "ConfirmForgotPassword");
            try
            {
                #if DESKTOP
                return client.ConfirmForgotPassword(request);
                #elif CORECLR
                return client.ConfirmForgotPasswordAsync(request).GetAwaiter().GetResult();
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
            public System.String AnalyticsMetadata_AnalyticsEndpointId { get; set; }
            public System.String ClientId { get; set; }
            public Dictionary<System.String, System.String> ClientMetadata { get; set; }
            public System.String ConfirmationCode { get; set; }
            public System.String Password { get; set; }
            public System.String SecretHash { get; set; }
            public System.String UserContextData_EncodedData { get; set; }
            public System.String Username { get; set; }
            public System.Func<Amazon.CognitoIdentityProvider.Model.ConfirmForgotPasswordResponse, ConfirmCGIPForgotPasswordCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}

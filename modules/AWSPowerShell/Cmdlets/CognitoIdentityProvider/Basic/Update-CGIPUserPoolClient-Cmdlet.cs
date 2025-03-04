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
    /// Updates the specified user pool app client with the specified attributes. If you don't
    /// provide a value for an attribute, it will be set to the default value. You can get
    /// a list of the current user pool app client settings with .
    /// </summary>
    [Cmdlet("Update", "CGIPUserPoolClient", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.CognitoIdentityProvider.Model.UserPoolClientType")]
    [AWSCmdlet("Calls the Amazon Cognito Identity Provider UpdateUserPoolClient API operation.", Operation = new[] {"UpdateUserPoolClient"}, SelectReturnType = typeof(Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse))]
    [AWSCmdletOutput("Amazon.CognitoIdentityProvider.Model.UserPoolClientType or Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse",
        "This cmdlet returns an Amazon.CognitoIdentityProvider.Model.UserPoolClientType object.",
        "The service call response (type Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateCGIPUserPoolClientCmdlet : AmazonCognitoIdentityProviderClientCmdlet, IExecutor
    {
        
        #region Parameter AllowedOAuthFlow
        /// <summary>
        /// <para>
        /// <para>Set to <code>code</code> to initiate a code grant flow, which provides an authorization
        /// code as the response. This code can be exchanged for access tokens with the token
        /// endpoint.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AllowedOAuthFlows")]
        public System.String[] AllowedOAuthFlow { get; set; }
        #endregion
        
        #region Parameter AllowedOAuthFlowsUserPoolClient
        /// <summary>
        /// <para>
        /// <para>Set to TRUE if the client is allowed to follow the OAuth protocol when interacting
        /// with Cognito user pools.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AllowedOAuthFlowsUserPoolClient { get; set; }
        #endregion
        
        #region Parameter AllowedOAuthScope
        /// <summary>
        /// <para>
        /// <para>A list of allowed <code>OAuth</code> scopes. Currently supported values are <code>"phone"</code>,
        /// <code>"email"</code>, <code>"openid"</code>, and <code>"Cognito"</code>. In addition
        /// to these values, custom scopes created in Resource Servers are also supported.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AllowedOAuthScopes")]
        public System.String[] AllowedOAuthScope { get; set; }
        #endregion
        
        #region Parameter AnalyticsConfiguration_ApplicationId
        /// <summary>
        /// <para>
        /// <para>The application ID for an Amazon Pinpoint application.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AnalyticsConfiguration_ApplicationId { get; set; }
        #endregion
        
        #region Parameter CallbackURLs
        /// <summary>
        /// <para>
        /// <para>A list of allowed redirect (callback) URLs for the identity providers.</para><para>A redirect URI must:</para><ul><li><para>Be an absolute URI.</para></li><li><para>Be registered with the authorization server.</para></li><li><para>Not include a fragment component.</para></li></ul><para>See <a href="https://tools.ietf.org/html/rfc6749#section-3.1.2">OAuth 2.0 - Redirection
        /// Endpoint</a>.</para><para>Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing purposes
        /// only.</para><para>App callback URLs such as myapp://example are also supported.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] CallbackURLs { get; set; }
        #endregion
        
        #region Parameter ClientId
        /// <summary>
        /// <para>
        /// <para>The ID of the client associated with the user pool.</para>
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
        
        #region Parameter ClientName
        /// <summary>
        /// <para>
        /// <para>The client name from the update user pool client request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientName { get; set; }
        #endregion
        
        #region Parameter DefaultRedirectURI
        /// <summary>
        /// <para>
        /// <para>The default redirect URI. Must be in the <code>CallbackURLs</code> list.</para><para>A redirect URI must:</para><ul><li><para>Be an absolute URI.</para></li><li><para>Be registered with the authorization server.</para></li><li><para>Not include a fragment component.</para></li></ul><para>See <a href="https://tools.ietf.org/html/rfc6749#section-3.1.2">OAuth 2.0 - Redirection
        /// Endpoint</a>.</para><para>Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing purposes
        /// only.</para><para>App callback URLs such as myapp://example are also supported.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DefaultRedirectURI { get; set; }
        #endregion
        
        #region Parameter ExplicitAuthFlow
        /// <summary>
        /// <para>
        /// <para>Explicit authentication flows.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ExplicitAuthFlows")]
        public System.String[] ExplicitAuthFlow { get; set; }
        #endregion
        
        #region Parameter AnalyticsConfiguration_ExternalId
        /// <summary>
        /// <para>
        /// <para>The external ID.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AnalyticsConfiguration_ExternalId { get; set; }
        #endregion
        
        #region Parameter LogoutURLs
        /// <summary>
        /// <para>
        /// <para>A list of allowed logout URLs for the identity providers.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] LogoutURLs { get; set; }
        #endregion
        
        #region Parameter ReadAttribute
        /// <summary>
        /// <para>
        /// <para>The read-only attributes of the user pool.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ReadAttributes")]
        public System.String[] ReadAttribute { get; set; }
        #endregion
        
        #region Parameter RefreshTokenValidity
        /// <summary>
        /// <para>
        /// <para>The time limit, in days, after which the refresh token is no longer valid and cannot
        /// be used.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? RefreshTokenValidity { get; set; }
        #endregion
        
        #region Parameter AnalyticsConfiguration_RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of an IAM role that authorizes Amazon Cognito to publish events to Amazon
        /// Pinpoint analytics.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AnalyticsConfiguration_RoleArn { get; set; }
        #endregion
        
        #region Parameter SupportedIdentityProvider
        /// <summary>
        /// <para>
        /// <para>A list of provider names for the identity providers that are supported on this client.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SupportedIdentityProviders")]
        public System.String[] SupportedIdentityProvider { get; set; }
        #endregion
        
        #region Parameter AnalyticsConfiguration_UserDataShared
        /// <summary>
        /// <para>
        /// <para>If <code>UserDataShared</code> is <code>true</code>, Amazon Cognito will include user
        /// data in the events it publishes to Amazon Pinpoint analytics.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AnalyticsConfiguration_UserDataShared { get; set; }
        #endregion
        
        #region Parameter UserPoolId
        /// <summary>
        /// <para>
        /// <para>The user pool ID for the user pool where you want to update the user pool client.</para>
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
        public System.String UserPoolId { get; set; }
        #endregion
        
        #region Parameter WriteAttribute
        /// <summary>
        /// <para>
        /// <para>The writeable attributes of the user pool.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteAttributes")]
        public System.String[] WriteAttribute { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'UserPoolClient'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse).
        /// Specifying the name of a property of type Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "UserPoolClient";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the UserPoolId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^UserPoolId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^UserPoolId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.UserPoolId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-CGIPUserPoolClient (UpdateUserPoolClient)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse, UpdateCGIPUserPoolClientCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.UserPoolId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.AllowedOAuthFlow != null)
            {
                context.AllowedOAuthFlow = new List<System.String>(this.AllowedOAuthFlow);
            }
            context.AllowedOAuthFlowsUserPoolClient = this.AllowedOAuthFlowsUserPoolClient;
            if (this.AllowedOAuthScope != null)
            {
                context.AllowedOAuthScope = new List<System.String>(this.AllowedOAuthScope);
            }
            context.AnalyticsConfiguration_ApplicationId = this.AnalyticsConfiguration_ApplicationId;
            context.AnalyticsConfiguration_ExternalId = this.AnalyticsConfiguration_ExternalId;
            context.AnalyticsConfiguration_RoleArn = this.AnalyticsConfiguration_RoleArn;
            context.AnalyticsConfiguration_UserDataShared = this.AnalyticsConfiguration_UserDataShared;
            if (this.CallbackURLs != null)
            {
                context.CallbackURLs = new List<System.String>(this.CallbackURLs);
            }
            context.ClientId = this.ClientId;
            #if MODULAR
            if (this.ClientId == null && ParameterWasBound(nameof(this.ClientId)))
            {
                WriteWarning("You are passing $null as a value for parameter ClientId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ClientName = this.ClientName;
            context.DefaultRedirectURI = this.DefaultRedirectURI;
            if (this.ExplicitAuthFlow != null)
            {
                context.ExplicitAuthFlow = new List<System.String>(this.ExplicitAuthFlow);
            }
            if (this.LogoutURLs != null)
            {
                context.LogoutURLs = new List<System.String>(this.LogoutURLs);
            }
            if (this.ReadAttribute != null)
            {
                context.ReadAttribute = new List<System.String>(this.ReadAttribute);
            }
            context.RefreshTokenValidity = this.RefreshTokenValidity;
            if (this.SupportedIdentityProvider != null)
            {
                context.SupportedIdentityProvider = new List<System.String>(this.SupportedIdentityProvider);
            }
            context.UserPoolId = this.UserPoolId;
            #if MODULAR
            if (this.UserPoolId == null && ParameterWasBound(nameof(this.UserPoolId)))
            {
                WriteWarning("You are passing $null as a value for parameter UserPoolId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.WriteAttribute != null)
            {
                context.WriteAttribute = new List<System.String>(this.WriteAttribute);
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
            var request = new Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientRequest();
            
            if (cmdletContext.AllowedOAuthFlow != null)
            {
                request.AllowedOAuthFlows = cmdletContext.AllowedOAuthFlow;
            }
            if (cmdletContext.AllowedOAuthFlowsUserPoolClient != null)
            {
                request.AllowedOAuthFlowsUserPoolClient = cmdletContext.AllowedOAuthFlowsUserPoolClient.Value;
            }
            if (cmdletContext.AllowedOAuthScope != null)
            {
                request.AllowedOAuthScopes = cmdletContext.AllowedOAuthScope;
            }
            
             // populate AnalyticsConfiguration
            var requestAnalyticsConfigurationIsNull = true;
            request.AnalyticsConfiguration = new Amazon.CognitoIdentityProvider.Model.AnalyticsConfigurationType();
            System.String requestAnalyticsConfiguration_analyticsConfiguration_ApplicationId = null;
            if (cmdletContext.AnalyticsConfiguration_ApplicationId != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_ApplicationId = cmdletContext.AnalyticsConfiguration_ApplicationId;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_ApplicationId != null)
            {
                request.AnalyticsConfiguration.ApplicationId = requestAnalyticsConfiguration_analyticsConfiguration_ApplicationId;
                requestAnalyticsConfigurationIsNull = false;
            }
            System.String requestAnalyticsConfiguration_analyticsConfiguration_ExternalId = null;
            if (cmdletContext.AnalyticsConfiguration_ExternalId != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_ExternalId = cmdletContext.AnalyticsConfiguration_ExternalId;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_ExternalId != null)
            {
                request.AnalyticsConfiguration.ExternalId = requestAnalyticsConfiguration_analyticsConfiguration_ExternalId;
                requestAnalyticsConfigurationIsNull = false;
            }
            System.String requestAnalyticsConfiguration_analyticsConfiguration_RoleArn = null;
            if (cmdletContext.AnalyticsConfiguration_RoleArn != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_RoleArn = cmdletContext.AnalyticsConfiguration_RoleArn;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_RoleArn != null)
            {
                request.AnalyticsConfiguration.RoleArn = requestAnalyticsConfiguration_analyticsConfiguration_RoleArn;
                requestAnalyticsConfigurationIsNull = false;
            }
            System.Boolean? requestAnalyticsConfiguration_analyticsConfiguration_UserDataShared = null;
            if (cmdletContext.AnalyticsConfiguration_UserDataShared != null)
            {
                requestAnalyticsConfiguration_analyticsConfiguration_UserDataShared = cmdletContext.AnalyticsConfiguration_UserDataShared.Value;
            }
            if (requestAnalyticsConfiguration_analyticsConfiguration_UserDataShared != null)
            {
                request.AnalyticsConfiguration.UserDataShared = requestAnalyticsConfiguration_analyticsConfiguration_UserDataShared.Value;
                requestAnalyticsConfigurationIsNull = false;
            }
             // determine if request.AnalyticsConfiguration should be set to null
            if (requestAnalyticsConfigurationIsNull)
            {
                request.AnalyticsConfiguration = null;
            }
            if (cmdletContext.CallbackURLs != null)
            {
                request.CallbackURLs = cmdletContext.CallbackURLs;
            }
            if (cmdletContext.ClientId != null)
            {
                request.ClientId = cmdletContext.ClientId;
            }
            if (cmdletContext.ClientName != null)
            {
                request.ClientName = cmdletContext.ClientName;
            }
            if (cmdletContext.DefaultRedirectURI != null)
            {
                request.DefaultRedirectURI = cmdletContext.DefaultRedirectURI;
            }
            if (cmdletContext.ExplicitAuthFlow != null)
            {
                request.ExplicitAuthFlows = cmdletContext.ExplicitAuthFlow;
            }
            if (cmdletContext.LogoutURLs != null)
            {
                request.LogoutURLs = cmdletContext.LogoutURLs;
            }
            if (cmdletContext.ReadAttribute != null)
            {
                request.ReadAttributes = cmdletContext.ReadAttribute;
            }
            if (cmdletContext.RefreshTokenValidity != null)
            {
                request.RefreshTokenValidity = cmdletContext.RefreshTokenValidity.Value;
            }
            if (cmdletContext.SupportedIdentityProvider != null)
            {
                request.SupportedIdentityProviders = cmdletContext.SupportedIdentityProvider;
            }
            if (cmdletContext.UserPoolId != null)
            {
                request.UserPoolId = cmdletContext.UserPoolId;
            }
            if (cmdletContext.WriteAttribute != null)
            {
                request.WriteAttributes = cmdletContext.WriteAttribute;
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
        
        private Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse CallAWSServiceOperation(IAmazonCognitoIdentityProvider client, Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Cognito Identity Provider", "UpdateUserPoolClient");
            try
            {
                #if DESKTOP
                return client.UpdateUserPoolClient(request);
                #elif CORECLR
                return client.UpdateUserPoolClientAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> AllowedOAuthFlow { get; set; }
            public System.Boolean? AllowedOAuthFlowsUserPoolClient { get; set; }
            public List<System.String> AllowedOAuthScope { get; set; }
            public System.String AnalyticsConfiguration_ApplicationId { get; set; }
            public System.String AnalyticsConfiguration_ExternalId { get; set; }
            public System.String AnalyticsConfiguration_RoleArn { get; set; }
            public System.Boolean? AnalyticsConfiguration_UserDataShared { get; set; }
            public List<System.String> CallbackURLs { get; set; }
            public System.String ClientId { get; set; }
            public System.String ClientName { get; set; }
            public System.String DefaultRedirectURI { get; set; }
            public List<System.String> ExplicitAuthFlow { get; set; }
            public List<System.String> LogoutURLs { get; set; }
            public List<System.String> ReadAttribute { get; set; }
            public System.Int32? RefreshTokenValidity { get; set; }
            public List<System.String> SupportedIdentityProvider { get; set; }
            public System.String UserPoolId { get; set; }
            public List<System.String> WriteAttribute { get; set; }
            public System.Func<Amazon.CognitoIdentityProvider.Model.UpdateUserPoolClientResponse, UpdateCGIPUserPoolClientCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.UserPoolClient;
        }
        
    }
}

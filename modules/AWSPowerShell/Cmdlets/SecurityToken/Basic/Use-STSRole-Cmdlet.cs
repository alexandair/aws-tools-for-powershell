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
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace Amazon.PowerShell.Cmdlets.STS
{
    /// <summary>
    /// Returns a set of temporary security credentials that you can use to access AWS resources
    /// that you might not normally have access to. These temporary credentials consist of
    /// an access key ID, a secret access key, and a security token. Typically, you use <code>AssumeRole</code>
    /// within your account or for cross-account access. For a comparison of <code>AssumeRole</code>
    /// with other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
    /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
    /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
    /// 
    ///  <important><para>
    /// You cannot use AWS account root user credentials to call <code>AssumeRole</code>.
    /// You must use credentials for an IAM user or an IAM role to call <code>AssumeRole</code>.
    /// </para></important><para>
    /// For cross-account access, imagine that you own multiple accounts and need to access
    /// resources in each account. You could create long-term credentials in each account
    /// to access those resources. However, managing all those credentials and remembering
    /// which one can access which account can be time consuming. Instead, you can create
    /// one set of long-term credentials in one account. Then use temporary security credentials
    /// to access all the other accounts by assuming roles in those accounts. For more information
    /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
    /// Roles</a> in the <i>IAM User Guide</i>. 
    /// </para><para>
    /// By default, the temporary security credentials created by <code>AssumeRole</code>
    /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
    /// parameter to specify the duration of your session. You can provide a value from 900
    /// seconds (15 minutes) up to the maximum session duration setting for the role. This
    /// setting can have a value from 1 hour to 12 hours. To learn how to view the maximum
    /// value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
    /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
    /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
    /// API operations or the <code>assume-role*</code> CLI commands. However the limit does
    /// not apply when you use those operations to create a console URL. For more information,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
    /// IAM Roles</a> in the <i>IAM User Guide</i>.
    /// </para><para>
    /// The temporary security credentials created by <code>AssumeRole</code> can be used
    /// to make API calls to any AWS service with the following exception: You cannot call
    /// the AWS STS <code>GetFederationToken</code> or <code>GetSessionToken</code> API operations.
    /// </para><para>
    /// (Optional) You can pass inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
    /// policies</a> to this operation. You can pass a single JSON policy document to use
    /// as an inline session policy. You can also specify up to 10 managed policies to use
    /// as managed session policies. The plain text that you use for both inline and managed
    /// session policies shouldn't exceed 2048 characters. Passing policies to this operation
    /// returns new temporary credentials. The resulting session's permissions are the intersection
    /// of the role's identity-based policy and the session policies. You can use the role's
    /// temporary credentials in subsequent AWS API calls to access resources in the account
    /// that owns the role. You cannot use session policies to grant more permissions than
    /// those allowed by the identity-based policy of the role that is being assumed. For
    /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para><para>
    /// To assume a role from a different account, your AWS account must be trusted by the
    /// role. The trust relationship is defined in the role's trust policy when the role is
    /// created. That trust policy states which accounts are allowed to delegate that access
    /// to users in the account. 
    /// </para><para>
    /// A user who wants to access a role in a different account must also have permissions
    /// that are delegated from the user account administrator. The administrator must attach
    /// a policy that allows the user to call <code>AssumeRole</code> for the ARN of the role
    /// in the other account. If the user is in the same account as the role, then you can
    /// do either of the following:
    /// </para><ul><li><para>
    /// Attach a policy to the user (identical to the previous user in a different account).
    /// </para></li><li><para>
    /// Add the user as a principal directly in the role's trust policy.
    /// </para></li></ul><para>
    /// In this case, the trust policy acts as an IAM resource-based policy. Users in the
    /// same account as the role do not need explicit permission to assume the role. For more
    /// information about trust policies and resource-based policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
    /// Policies</a> in the <i>IAM User Guide</i>.
    /// </para><para><b>Using MFA with AssumeRole</b></para><para>
    /// (Optional) You can include multi-factor authentication (MFA) information when you
    /// call <code>AssumeRole</code>. This is useful for cross-account scenarios to ensure
    /// that the user that assumes the role has been authenticated with an AWS MFA device.
    /// In that scenario, the trust policy of the role being assumed includes a condition
    /// that tests for MFA authentication. If the caller does not include valid MFA information,
    /// the request to assume the role is denied. The condition in a trust policy that tests
    /// for MFA authentication might look like the following example.
    /// </para><para><code>"Condition": {"Bool": {"aws:MultiFactorAuthPresent": true}}</code></para><para>
    /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/MFAProtectedAPI.html">Configuring
    /// MFA-Protected API Access</a> in the <i>IAM User Guide</i> guide.
    /// </para><para>
    /// To use MFA with <code>AssumeRole</code>, you pass values for the <code>SerialNumber</code>
    /// and <code>TokenCode</code> parameters. The <code>SerialNumber</code> value identifies
    /// the user's hardware or virtual MFA device. The <code>TokenCode</code> is the time-based
    /// one-time password (TOTP) that the MFA device produces. 
    /// </para>
    /// </summary>
    [Cmdlet("Use", "STSRole", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.SecurityToken.Model.AssumeRoleResponse")]
    [AWSCmdlet("Calls the AWS Security Token Service (STS) AssumeRole API operation.", Operation = new[] {"AssumeRole"}, SelectReturnType = typeof(Amazon.SecurityToken.Model.AssumeRoleResponse))]
    [AWSCmdletOutput("Amazon.SecurityToken.Model.AssumeRoleResponse",
        "This cmdlet returns an Amazon.SecurityToken.Model.AssumeRoleResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UseSTSRoleCmdlet : AmazonSecurityTokenServiceClientCmdlet, IExecutor
    {
        
        #region Parameter DurationInSeconds
        /// <summary>
        /// <para>
        /// <para>The duration, in seconds, of the role session. The value can range from 900 seconds
        /// (15 minutes) up to the maximum session duration setting for the role. This setting
        /// can have a value from 1 hour to 12 hours. If you specify a value higher than this
        /// setting, the operation fails. For example, if you specify a session duration of 12
        /// hours, but your administrator set the maximum session duration to 6 hours, your operation
        /// fails. To learn how to view the maximum value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.</para><para>By default, the value is set to <code>3600</code> seconds. </para><note><para>The <code>DurationSeconds</code> parameter is separate from the duration of a console
        /// session that you might request using the returned credentials. The request to the
        /// federation endpoint for a console sign-in token takes a <code>SessionDuration</code>
        /// parameter that specifies the maximum length of the console session. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-custom-url.html">Creating
        /// a URL that Enables Federated Users to Access the AWS Management Console</a> in the
        /// <i>IAM User Guide</i>.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 3, ValueFromPipelineByPropertyName = true)]
        [Alias("DurationSeconds")]
        public System.Int32? DurationInSeconds { get; set; }
        #endregion
        
        #region Parameter ExternalId
        /// <summary>
        /// <para>
        /// <para>A unique identifier that might be required when you assume a role in another account.
        /// If the administrator of the account to which the role belongs provided you with an
        /// external ID, then provide that value in the <code>ExternalId</code> parameter. This
        /// value can be any string, such as a passphrase or account number. A cross-account role
        /// is usually set up to trust everyone in an account. Therefore, the administrator of
        /// the trusting account might send an external ID to the administrator of the trusted
        /// account. That way, only someone with the ID can assume the role, rather than everyone
        /// in the account. For more information about the external ID, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html">How
        /// to Use an External ID When Granting Access to Your AWS Resources to a Third Party</a>
        /// in the <i>IAM User Guide</i>.</para><para>The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@:/-</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 4, ValueFromPipelineByPropertyName = true)]
        public System.String ExternalId { get; set; }
        #endregion
        
        #region Parameter Policy
        /// <summary>
        /// <para>
        /// <para>An IAM policy in JSON format that you want to use as an inline session policy.</para><para>This parameter is optional. Passing policies to this operation returns new temporary
        /// credentials. The resulting session's permissions are the intersection of the role's
        /// identity-based policy and the session policies. You can use the role's temporary credentials
        /// in subsequent AWS API calls to access resources in the account that owns the role.
        /// You cannot use session policies to grant more permissions than those allowed by the
        /// identity-based policy of the role that is being assumed. For more information, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.</para><para>The plain text that you use for both inline and managed session policies shouldn't
        /// exceed 2048 characters. The JSON policy characters can be any ASCII character from
        /// the space character to the end of the valid character list (\u0020 through \u00FF).
        /// It can also include the tab (\u0009), linefeed (\u000A), and carriage return (\u000D)
        /// characters.</para><note><para>The characters in this parameter count towards the 2048 character session policy guideline.
        /// However, an AWS conversion compresses the session policies into a packed binary format
        /// that has a separate limit. This is the enforced limit. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close the policy is to the upper size
        /// limit.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true)]
        public System.String Policy { get; set; }
        #endregion
        
        #region Parameter PolicyArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Names (ARNs) of the IAM managed policies that you want to use
        /// as managed session policies. The policies must exist in the same account as the role.</para><para>This parameter is optional. You can provide up to 10 managed policy ARNs. However,
        /// the plain text that you use for both inline and managed session policies shouldn't
        /// exceed 2048 characters. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the AWS General Reference.</para><note><para>The characters in this parameter count towards the 2048 character session policy guideline.
        /// However, an AWS conversion compresses the session policies into a packed binary format
        /// that has a separate limit. This is the enforced limit. The <code>PackedPolicySize</code>
        /// response element indicates by percentage how close the policy is to the upper size
        /// limit.</para></note><para>Passing policies to this operation returns new temporary credentials. The resulting
        /// session's permissions are the intersection of the role's identity-based policy and
        /// the session policies. You can use the role's temporary credentials in subsequent AWS
        /// API calls to access resources in the account that owns the role. You cannot use session
        /// policies to grant more permissions than those allowed by the identity-based policy
        /// of the role that is being assumed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("PolicyArns")]
        public Amazon.SecurityToken.Model.PolicyDescriptorType[] PolicyArn { get; set; }
        #endregion
        
        #region Parameter RoleArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the role to assume.</para>
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
        public System.String RoleArn { get; set; }
        #endregion
        
        #region Parameter RoleSessionName
        /// <summary>
        /// <para>
        /// <para>An identifier for the assumed role session.</para><para>Use the role session name to uniquely identify a session when the same role is assumed
        /// by different principals or for different reasons. In cross-account scenarios, the
        /// role session name is visible to, and can be logged by the account that owns the role.
        /// The role session name is also used in the ARN of the assumed role principal. This
        /// means that subsequent cross-account API requests that use the temporary security credentials
        /// will expose the role session name to the external account in their AWS CloudTrail
        /// logs.</para><para>The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String RoleSessionName { get; set; }
        #endregion
        
        #region Parameter SerialNumber
        /// <summary>
        /// <para>
        /// <para>The identification number of the MFA device that is associated with the user who is
        /// making the <code>AssumeRole</code> call. Specify this value if the trust policy of
        /// the role being assumed includes a condition that requires MFA authentication. The
        /// value is either the serial number for a hardware device (such as <code>GAHT12345678</code>)
        /// or an Amazon Resource Name (ARN) for a virtual device (such as <code>arn:aws:iam::123456789012:mfa/user</code>).</para><para>The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SerialNumber { get; set; }
        #endregion
        
        #region Parameter TokenCode
        /// <summary>
        /// <para>
        /// <para>The value provided by the MFA device, if the trust policy of the role being assumed
        /// requires MFA (that is, if the policy includes a condition that tests for MFA). If
        /// the role being assumed requires MFA and if the <code>TokenCode</code> value is missing
        /// or expired, the <code>AssumeRole</code> call returns an "access denied" error.</para><para>The format for this parameter, as described by its regex pattern, is a sequence of
        /// six numeric digits.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String TokenCode { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SecurityToken.Model.AssumeRoleResponse).
        /// Specifying the name of a property of type Amazon.SecurityToken.Model.AssumeRoleResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the RoleArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^RoleArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^RoleArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.RoleArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Use-STSRole (AssumeRole)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SecurityToken.Model.AssumeRoleResponse, UseSTSRoleCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.RoleArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.DurationInSeconds = this.DurationInSeconds;
            context.ExternalId = this.ExternalId;
            context.Policy = this.Policy;
            if (this.PolicyArn != null)
            {
                context.PolicyArn = new List<Amazon.SecurityToken.Model.PolicyDescriptorType>(this.PolicyArn);
            }
            context.RoleArn = this.RoleArn;
            #if MODULAR
            if (this.RoleArn == null && ParameterWasBound(nameof(this.RoleArn)))
            {
                WriteWarning("You are passing $null as a value for parameter RoleArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RoleSessionName = this.RoleSessionName;
            #if MODULAR
            if (this.RoleSessionName == null && ParameterWasBound(nameof(this.RoleSessionName)))
            {
                WriteWarning("You are passing $null as a value for parameter RoleSessionName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SerialNumber = this.SerialNumber;
            context.TokenCode = this.TokenCode;
            
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
            var request = new Amazon.SecurityToken.Model.AssumeRoleRequest();
            
            if (cmdletContext.DurationInSeconds != null)
            {
                request.DurationSeconds = cmdletContext.DurationInSeconds.Value;
            }
            if (cmdletContext.ExternalId != null)
            {
                request.ExternalId = cmdletContext.ExternalId;
            }
            if (cmdletContext.Policy != null)
            {
                request.Policy = cmdletContext.Policy;
            }
            if (cmdletContext.PolicyArn != null)
            {
                request.PolicyArns = cmdletContext.PolicyArn;
            }
            if (cmdletContext.RoleArn != null)
            {
                request.RoleArn = cmdletContext.RoleArn;
            }
            if (cmdletContext.RoleSessionName != null)
            {
                request.RoleSessionName = cmdletContext.RoleSessionName;
            }
            if (cmdletContext.SerialNumber != null)
            {
                request.SerialNumber = cmdletContext.SerialNumber;
            }
            if (cmdletContext.TokenCode != null)
            {
                request.TokenCode = cmdletContext.TokenCode;
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
        
        private Amazon.SecurityToken.Model.AssumeRoleResponse CallAWSServiceOperation(IAmazonSecurityTokenService client, Amazon.SecurityToken.Model.AssumeRoleRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Security Token Service (STS)", "AssumeRole");
            try
            {
                #if DESKTOP
                return client.AssumeRole(request);
                #elif CORECLR
                return client.AssumeRoleAsync(request).GetAwaiter().GetResult();
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
            public System.Int32? DurationInSeconds { get; set; }
            public System.String ExternalId { get; set; }
            public System.String Policy { get; set; }
            public List<Amazon.SecurityToken.Model.PolicyDescriptorType> PolicyArn { get; set; }
            public System.String RoleArn { get; set; }
            public System.String RoleSessionName { get; set; }
            public System.String SerialNumber { get; set; }
            public System.String TokenCode { get; set; }
            public System.Func<Amazon.SecurityToken.Model.AssumeRoleResponse, UseSTSRoleCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}

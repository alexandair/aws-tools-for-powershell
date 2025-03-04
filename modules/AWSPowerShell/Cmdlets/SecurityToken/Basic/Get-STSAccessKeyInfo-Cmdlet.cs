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
    /// Returns the account identifier for the specified access key ID.
    /// 
    ///  
    /// <para>
    /// Access keys consist of two parts: an access key ID (for example, <code>AKIAIOSFODNN7EXAMPLE</code>)
    /// and a secret access key (for example, <code>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</code>).
    /// For more information about access keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html">Managing
    /// Access Keys for IAM Users</a> in the <i>IAM User Guide</i>.
    /// </para><para>
    /// When you pass an access key ID to this operation, it returns the ID of the AWS account
    /// to which the keys belong. Access key IDs beginning with <code>AKIA</code> are long-term
    /// credentials for an IAM user or the AWS account root user. Access key IDs beginning
    /// with <code>ASIA</code> are temporary credentials that are created using STS operations.
    /// If the account in the response belongs to you, you can sign in as the root user and
    /// review your root user access keys. Then, you can pull a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_getting-report.html">credentials
    /// report</a> to learn which IAM user owns the keys. To learn who requested the temporary
    /// credentials for an <code>ASIA</code> access key, view the STS events in your <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">CloudTrail
    /// logs</a>.
    /// </para><para>
    /// This operation does not indicate the state of the access key. The key might be active,
    /// inactive, or deleted. Active keys might not have permissions to perform an operation.
    /// Providing a deleted access key might return an error that the key doesn't exist.
    /// </para>
    /// </summary>
    [Cmdlet("Get", "STSAccessKeyInfo")]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Security Token Service (STS) GetAccessKeyInfo API operation.", Operation = new[] {"GetAccessKeyInfo"}, SelectReturnType = typeof(Amazon.SecurityToken.Model.GetAccessKeyInfoResponse))]
    [AWSCmdletOutput("System.String or Amazon.SecurityToken.Model.GetAccessKeyInfoResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.SecurityToken.Model.GetAccessKeyInfoResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetSTSAccessKeyInfoCmdlet : AmazonSecurityTokenServiceClientCmdlet, IExecutor
    {
        
        #region Parameter IdOfAccessKey
        /// <summary>
        /// <para>
        /// <para>The identifier of an access key.</para><para>This parameter allows (through its regex pattern) a string of characters that can
        /// consist of any upper- or lowercased letter or digit.</para>
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
        public System.String IdOfAccessKey { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Account'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SecurityToken.Model.GetAccessKeyInfoResponse).
        /// Specifying the name of a property of type Amazon.SecurityToken.Model.GetAccessKeyInfoResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Account";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the IdOfAccessKey parameter.
        /// The -PassThru parameter is deprecated, use -Select '^IdOfAccessKey' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^IdOfAccessKey' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SecurityToken.Model.GetAccessKeyInfoResponse, GetSTSAccessKeyInfoCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.IdOfAccessKey;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.IdOfAccessKey = this.IdOfAccessKey;
            #if MODULAR
            if (this.IdOfAccessKey == null && ParameterWasBound(nameof(this.IdOfAccessKey)))
            {
                WriteWarning("You are passing $null as a value for parameter IdOfAccessKey which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.SecurityToken.Model.GetAccessKeyInfoRequest();
            
            if (cmdletContext.IdOfAccessKey != null)
            {
                request.AccessKeyId = cmdletContext.IdOfAccessKey;
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
        
        private Amazon.SecurityToken.Model.GetAccessKeyInfoResponse CallAWSServiceOperation(IAmazonSecurityTokenService client, Amazon.SecurityToken.Model.GetAccessKeyInfoRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Security Token Service (STS)", "GetAccessKeyInfo");
            try
            {
                #if DESKTOP
                return client.GetAccessKeyInfo(request);
                #elif CORECLR
                return client.GetAccessKeyInfoAsync(request).GetAwaiter().GetResult();
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
            public System.String IdOfAccessKey { get; set; }
            public System.Func<Amazon.SecurityToken.Model.GetAccessKeyInfoResponse, GetSTSAccessKeyInfoCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Account;
        }
        
    }
}

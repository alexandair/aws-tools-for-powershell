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
using Amazon.ECR;
using Amazon.ECR.Model;

namespace Amazon.PowerShell.Cmdlets.ECR
{
    /// <summary>
    /// Creates an Amazon Elastic Container Registry (Amazon ECR) repository, where users
    /// can push and pull Docker images. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
    /// ECR Repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </summary>
    [Cmdlet("New", "ECRRepository", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ECR.Model.Repository")]
    [AWSCmdlet("Calls the Amazon EC2 Container Registry CreateRepository API operation.", Operation = new[] {"CreateRepository"}, SelectReturnType = typeof(Amazon.ECR.Model.CreateRepositoryResponse))]
    [AWSCmdletOutput("Amazon.ECR.Model.Repository or Amazon.ECR.Model.CreateRepositoryResponse",
        "This cmdlet returns an Amazon.ECR.Model.Repository object.",
        "The service call response (type Amazon.ECR.Model.CreateRepositoryResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewECRRepositoryCmdlet : AmazonECRClientCmdlet, IExecutor
    {
        
        #region Parameter ImageTagMutability
        /// <summary>
        /// <para>
        /// <para>The tag mutability setting for the repository. If this parameter is omitted, the default
        /// setting of <code>MUTABLE</code> will be used which will allow image tags to be overwritten.
        /// If <code>IMMUTABLE</code> is specified, all image tags within the repository will
        /// be immutable which will prevent them from being overwritten.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.ECR.ImageTagMutability")]
        public Amazon.ECR.ImageTagMutability ImageTagMutability { get; set; }
        #endregion
        
        #region Parameter RepositoryName
        /// <summary>
        /// <para>
        /// <para>The name to use for the repository. The repository name may be specified on its own
        /// (such as <code>nginx-web-app</code>) or it can be prepended with a namespace to group
        /// the repository into a category (such as <code>project-a/nginx-web-app</code>).</para>
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
        public System.String RepositoryName { get; set; }
        #endregion
        
        #region Parameter ImageScanningConfiguration_ScanOnPush
        /// <summary>
        /// <para>
        /// <para>The setting that determines whether images are scanned after being pushed to a repository.
        /// If set to <code>true</code>, images will be scanned after being pushed. If this parameter
        /// is not specified, it will default to <code>false</code> and images will not be scanned
        /// unless a scan is manually started with the <a>StartImageScan</a> API.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? ImageScanningConfiguration_ScanOnPush { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The metadata that you apply to the repository to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
        /// Tag keys can have a maximum character length of 128 characters, and tag values can
        /// have a maximum length of 256 characters.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.ECR.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Repository'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ECR.Model.CreateRepositoryResponse).
        /// Specifying the name of a property of type Amazon.ECR.Model.CreateRepositoryResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Repository";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the RepositoryName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^RepositoryName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^RepositoryName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.RepositoryName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-ECRRepository (CreateRepository)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ECR.Model.CreateRepositoryResponse, NewECRRepositoryCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.RepositoryName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ImageScanningConfiguration_ScanOnPush = this.ImageScanningConfiguration_ScanOnPush;
            context.ImageTagMutability = this.ImageTagMutability;
            context.RepositoryName = this.RepositoryName;
            #if MODULAR
            if (this.RepositoryName == null && ParameterWasBound(nameof(this.RepositoryName)))
            {
                WriteWarning("You are passing $null as a value for parameter RepositoryName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.ECR.Model.Tag>(this.Tag);
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
            var request = new Amazon.ECR.Model.CreateRepositoryRequest();
            
            
             // populate ImageScanningConfiguration
            var requestImageScanningConfigurationIsNull = true;
            request.ImageScanningConfiguration = new Amazon.ECR.Model.ImageScanningConfiguration();
            System.Boolean? requestImageScanningConfiguration_imageScanningConfiguration_ScanOnPush = null;
            if (cmdletContext.ImageScanningConfiguration_ScanOnPush != null)
            {
                requestImageScanningConfiguration_imageScanningConfiguration_ScanOnPush = cmdletContext.ImageScanningConfiguration_ScanOnPush.Value;
            }
            if (requestImageScanningConfiguration_imageScanningConfiguration_ScanOnPush != null)
            {
                request.ImageScanningConfiguration.ScanOnPush = requestImageScanningConfiguration_imageScanningConfiguration_ScanOnPush.Value;
                requestImageScanningConfigurationIsNull = false;
            }
             // determine if request.ImageScanningConfiguration should be set to null
            if (requestImageScanningConfigurationIsNull)
            {
                request.ImageScanningConfiguration = null;
            }
            if (cmdletContext.ImageTagMutability != null)
            {
                request.ImageTagMutability = cmdletContext.ImageTagMutability;
            }
            if (cmdletContext.RepositoryName != null)
            {
                request.RepositoryName = cmdletContext.RepositoryName;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.ECR.Model.CreateRepositoryResponse CallAWSServiceOperation(IAmazonECR client, Amazon.ECR.Model.CreateRepositoryRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon EC2 Container Registry", "CreateRepository");
            try
            {
                #if DESKTOP
                return client.CreateRepository(request);
                #elif CORECLR
                return client.CreateRepositoryAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? ImageScanningConfiguration_ScanOnPush { get; set; }
            public Amazon.ECR.ImageTagMutability ImageTagMutability { get; set; }
            public System.String RepositoryName { get; set; }
            public List<Amazon.ECR.Model.Tag> Tag { get; set; }
            public System.Func<Amazon.ECR.Model.CreateRepositoryResponse, NewECRRepositoryCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Repository;
        }
        
    }
}

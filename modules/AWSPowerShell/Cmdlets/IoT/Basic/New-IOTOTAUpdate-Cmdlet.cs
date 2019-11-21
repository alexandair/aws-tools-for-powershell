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
using Amazon.IoT;
using Amazon.IoT.Model;

namespace Amazon.PowerShell.Cmdlets.IOT
{
    /// <summary>
    /// Creates an AWS IoT OTAUpdate on a target group of things or groups.
    /// </summary>
    [Cmdlet("New", "IOTOTAUpdate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.IoT.Model.CreateOTAUpdateResponse")]
    [AWSCmdlet("Calls the AWS IoT CreateOTAUpdate API operation.", Operation = new[] {"CreateOTAUpdate"}, SelectReturnType = typeof(Amazon.IoT.Model.CreateOTAUpdateResponse))]
    [AWSCmdletOutput("Amazon.IoT.Model.CreateOTAUpdateResponse",
        "This cmdlet returns an Amazon.IoT.Model.CreateOTAUpdateResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewIOTOTAUpdateCmdlet : AmazonIoTClientCmdlet, IExecutor
    {
        
        #region Parameter AdditionalParameter
        /// <summary>
        /// <para>
        /// <para>A list of additional OTA update parameters which are name-value pairs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AdditionalParameters")]
        public System.Collections.Hashtable AdditionalParameter { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>The description of the OTA update.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter File
        /// <summary>
        /// <para>
        /// <para>The files to be streamed by the OTA update.</para>
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
        [Alias("Files")]
        public Amazon.IoT.Model.OTAUpdateFile[] File { get; set; }
        #endregion
        
        #region Parameter AwsJobExecutionsRolloutConfig_MaximumPerMinute
        /// <summary>
        /// <para>
        /// <para>The maximum number of OTA update job executions started per minute.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? AwsJobExecutionsRolloutConfig_MaximumPerMinute { get; set; }
        #endregion
        
        #region Parameter OtaUpdateId
        /// <summary>
        /// <para>
        /// <para>The ID of the OTA update to be created.</para>
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
        public System.String OtaUpdateId { get; set; }
        #endregion
        
        #region Parameter RoleArn
        /// <summary>
        /// <para>
        /// <para>The IAM role that allows access to the AWS IoT Jobs service.</para>
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
        public System.String RoleArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Metadata which can be used to manage updates.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.IoT.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Target
        /// <summary>
        /// <para>
        /// <para>The targeted devices to receive OTA updates.</para>
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
        [Alias("Targets")]
        public System.String[] Target { get; set; }
        #endregion
        
        #region Parameter TargetSelection
        /// <summary>
        /// <para>
        /// <para>Specifies whether the update will continue to run (CONTINUOUS), or will be complete
        /// after all the things specified as targets have completed the update (SNAPSHOT). If
        /// continuous, the update may also be run on a thing when a change is detected in a target.
        /// For example, an update will run on a thing when the thing is added to a target group,
        /// even after the update was completed by all things originally in the group. Valid values:
        /// CONTINUOUS | SNAPSHOT.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.IoT.TargetSelection")]
        public Amazon.IoT.TargetSelection TargetSelection { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoT.Model.CreateOTAUpdateResponse).
        /// Specifying the name of a property of type Amazon.IoT.Model.CreateOTAUpdateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the OtaUpdateId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^OtaUpdateId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^OtaUpdateId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.OtaUpdateId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-IOTOTAUpdate (CreateOTAUpdate)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoT.Model.CreateOTAUpdateResponse, NewIOTOTAUpdateCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.OtaUpdateId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.AdditionalParameter != null)
            {
                context.AdditionalParameter = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.AdditionalParameter.Keys)
                {
                    context.AdditionalParameter.Add((String)hashKey, (String)(this.AdditionalParameter[hashKey]));
                }
            }
            context.AwsJobExecutionsRolloutConfig_MaximumPerMinute = this.AwsJobExecutionsRolloutConfig_MaximumPerMinute;
            context.Description = this.Description;
            if (this.File != null)
            {
                context.File = new List<Amazon.IoT.Model.OTAUpdateFile>(this.File);
            }
            #if MODULAR
            if (this.File == null && ParameterWasBound(nameof(this.File)))
            {
                WriteWarning("You are passing $null as a value for parameter File which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.OtaUpdateId = this.OtaUpdateId;
            #if MODULAR
            if (this.OtaUpdateId == null && ParameterWasBound(nameof(this.OtaUpdateId)))
            {
                WriteWarning("You are passing $null as a value for parameter OtaUpdateId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RoleArn = this.RoleArn;
            #if MODULAR
            if (this.RoleArn == null && ParameterWasBound(nameof(this.RoleArn)))
            {
                WriteWarning("You are passing $null as a value for parameter RoleArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.IoT.Model.Tag>(this.Tag);
            }
            if (this.Target != null)
            {
                context.Target = new List<System.String>(this.Target);
            }
            #if MODULAR
            if (this.Target == null && ParameterWasBound(nameof(this.Target)))
            {
                WriteWarning("You are passing $null as a value for parameter Target which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TargetSelection = this.TargetSelection;
            
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
            var request = new Amazon.IoT.Model.CreateOTAUpdateRequest();
            
            if (cmdletContext.AdditionalParameter != null)
            {
                request.AdditionalParameters = cmdletContext.AdditionalParameter;
            }
            
             // populate AwsJobExecutionsRolloutConfig
            var requestAwsJobExecutionsRolloutConfigIsNull = true;
            request.AwsJobExecutionsRolloutConfig = new Amazon.IoT.Model.AwsJobExecutionsRolloutConfig();
            System.Int32? requestAwsJobExecutionsRolloutConfig_awsJobExecutionsRolloutConfig_MaximumPerMinute = null;
            if (cmdletContext.AwsJobExecutionsRolloutConfig_MaximumPerMinute != null)
            {
                requestAwsJobExecutionsRolloutConfig_awsJobExecutionsRolloutConfig_MaximumPerMinute = cmdletContext.AwsJobExecutionsRolloutConfig_MaximumPerMinute.Value;
            }
            if (requestAwsJobExecutionsRolloutConfig_awsJobExecutionsRolloutConfig_MaximumPerMinute != null)
            {
                request.AwsJobExecutionsRolloutConfig.MaximumPerMinute = requestAwsJobExecutionsRolloutConfig_awsJobExecutionsRolloutConfig_MaximumPerMinute.Value;
                requestAwsJobExecutionsRolloutConfigIsNull = false;
            }
             // determine if request.AwsJobExecutionsRolloutConfig should be set to null
            if (requestAwsJobExecutionsRolloutConfigIsNull)
            {
                request.AwsJobExecutionsRolloutConfig = null;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.File != null)
            {
                request.Files = cmdletContext.File;
            }
            if (cmdletContext.OtaUpdateId != null)
            {
                request.OtaUpdateId = cmdletContext.OtaUpdateId;
            }
            if (cmdletContext.RoleArn != null)
            {
                request.RoleArn = cmdletContext.RoleArn;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.Target != null)
            {
                request.Targets = cmdletContext.Target;
            }
            if (cmdletContext.TargetSelection != null)
            {
                request.TargetSelection = cmdletContext.TargetSelection;
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
        
        private Amazon.IoT.Model.CreateOTAUpdateResponse CallAWSServiceOperation(IAmazonIoT client, Amazon.IoT.Model.CreateOTAUpdateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT", "CreateOTAUpdate");
            try
            {
                #if DESKTOP
                return client.CreateOTAUpdate(request);
                #elif CORECLR
                return client.CreateOTAUpdateAsync(request).GetAwaiter().GetResult();
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
            public Dictionary<System.String, System.String> AdditionalParameter { get; set; }
            public System.Int32? AwsJobExecutionsRolloutConfig_MaximumPerMinute { get; set; }
            public System.String Description { get; set; }
            public List<Amazon.IoT.Model.OTAUpdateFile> File { get; set; }
            public System.String OtaUpdateId { get; set; }
            public System.String RoleArn { get; set; }
            public List<Amazon.IoT.Model.Tag> Tag { get; set; }
            public List<System.String> Target { get; set; }
            public Amazon.IoT.TargetSelection TargetSelection { get; set; }
            public System.Func<Amazon.IoT.Model.CreateOTAUpdateResponse, NewIOTOTAUpdateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}

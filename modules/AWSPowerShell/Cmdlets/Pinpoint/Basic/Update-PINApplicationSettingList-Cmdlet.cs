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
    /// Updates the settings for an application.
    /// </summary>
    [Cmdlet("Update", "PINApplicationSettingList", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Pinpoint.Model.ApplicationSettingsResource")]
    [AWSCmdlet("Calls the Amazon Pinpoint UpdateApplicationSettings API operation.", Operation = new[] {"UpdateApplicationSettings"}, SelectReturnType = typeof(Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse))]
    [AWSCmdletOutput("Amazon.Pinpoint.Model.ApplicationSettingsResource or Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse",
        "This cmdlet returns an Amazon.Pinpoint.Model.ApplicationSettingsResource object.",
        "The service call response (type Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdatePINApplicationSettingListCmdlet : AmazonPinpointClientCmdlet, IExecutor
    {
        
        #region Parameter ApplicationId
        /// <summary>
        /// <para>
        /// <para>The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.</para>
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
        public System.String ApplicationId { get; set; }
        #endregion
        
        #region Parameter WriteApplicationSettingsRequest_CloudWatchMetricsEnabled
        /// <summary>
        /// <para>
        /// <para>Specifies whether to enable application-related alarms in Amazon CloudWatch.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? WriteApplicationSettingsRequest_CloudWatchMetricsEnabled { get; set; }
        #endregion
        
        #region Parameter Limits_Daily
        /// <summary>
        /// <para>
        /// <para>The maximum number of messages that a campaign can send to a single endpoint during
        /// a 24-hour period. The maximum value is 100.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_Limits_Daily")]
        public System.Int32? Limits_Daily { get; set; }
        #endregion
        
        #region Parameter QuietTime_End
        /// <summary>
        /// <para>
        /// <para>The specific time when quiet time ends. This value has to use 24-hour notation and
        /// be in HH:MM format, where HH is the hour (with a leading zero, if applicable) and
        /// MM is the minutes. For example, use 02:30 to represent 2:30 AM, or 14:30 to represent
        /// 2:30 PM.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_QuietTime_End")]
        public System.String QuietTime_End { get; set; }
        #endregion
        
        #region Parameter CampaignHook_LambdaFunctionName
        /// <summary>
        /// <para>
        /// <para>The name or Amazon Resource Name (ARN) of the AWS Lambda function that Amazon Pinpoint
        /// invokes to send messages for a campaign.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_CampaignHook_LambdaFunctionName")]
        public System.String CampaignHook_LambdaFunctionName { get; set; }
        #endregion
        
        #region Parameter Limits_MaximumDuration
        /// <summary>
        /// <para>
        /// <para>The maximum amount of time, in seconds, that a campaign can attempt to deliver a message
        /// after the scheduled start time for the campaign. The minimum value is 60 seconds.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_Limits_MaximumDuration")]
        public System.Int32? Limits_MaximumDuration { get; set; }
        #endregion
        
        #region Parameter Limits_MessagesPerSecond
        /// <summary>
        /// <para>
        /// <para>The maximum number of messages that a campaign can send each second. The minimum value
        /// is 50. The maximum value is 20,000.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_Limits_MessagesPerSecond")]
        public System.Int32? Limits_MessagesPerSecond { get; set; }
        #endregion
        
        #region Parameter CampaignHook_Mode
        /// <summary>
        /// <para>
        /// <para>Specifies which Lambda mode to use when invoking the AWS Lambda function.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_CampaignHook_Mode")]
        [AWSConstantClassSource("Amazon.Pinpoint.Mode")]
        public Amazon.Pinpoint.Mode CampaignHook_Mode { get; set; }
        #endregion
        
        #region Parameter QuietTime_Start
        /// <summary>
        /// <para>
        /// <para>The specific time when quiet time begins. This value has to use 24-hour notation and
        /// be in HH:MM format, where HH is the hour (with a leading zero, if applicable) and
        /// MM is the minutes. For example, use 02:30 to represent 2:30 AM, or 14:30 to represent
        /// 2:30 PM.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_QuietTime_Start")]
        public System.String QuietTime_Start { get; set; }
        #endregion
        
        #region Parameter Limits_Total
        /// <summary>
        /// <para>
        /// <para>The maximum number of messages that a campaign can send to a single endpoint during
        /// the course of the campaign. The maximum value is 100.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_Limits_Total")]
        public System.Int32? Limits_Total { get; set; }
        #endregion
        
        #region Parameter CampaignHook_WebUrl
        /// <summary>
        /// <para>
        /// <para>The web URL that Amazon Pinpoint calls to invoke the AWS Lambda function over HTTPS.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WriteApplicationSettingsRequest_CampaignHook_WebUrl")]
        public System.String CampaignHook_WebUrl { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'ApplicationSettingsResource'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse).
        /// Specifying the name of a property of type Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "ApplicationSettingsResource";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ApplicationId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ApplicationId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ApplicationId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ApplicationId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-PINApplicationSettingList (UpdateApplicationSettings)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse, UpdatePINApplicationSettingListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ApplicationId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ApplicationId = this.ApplicationId;
            #if MODULAR
            if (this.ApplicationId == null && ParameterWasBound(nameof(this.ApplicationId)))
            {
                WriteWarning("You are passing $null as a value for parameter ApplicationId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.CampaignHook_LambdaFunctionName = this.CampaignHook_LambdaFunctionName;
            context.CampaignHook_Mode = this.CampaignHook_Mode;
            context.CampaignHook_WebUrl = this.CampaignHook_WebUrl;
            context.WriteApplicationSettingsRequest_CloudWatchMetricsEnabled = this.WriteApplicationSettingsRequest_CloudWatchMetricsEnabled;
            context.Limits_Daily = this.Limits_Daily;
            context.Limits_MaximumDuration = this.Limits_MaximumDuration;
            context.Limits_MessagesPerSecond = this.Limits_MessagesPerSecond;
            context.Limits_Total = this.Limits_Total;
            context.QuietTime_End = this.QuietTime_End;
            context.QuietTime_Start = this.QuietTime_Start;
            
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
            var request = new Amazon.Pinpoint.Model.UpdateApplicationSettingsRequest();
            
            if (cmdletContext.ApplicationId != null)
            {
                request.ApplicationId = cmdletContext.ApplicationId;
            }
            
             // populate WriteApplicationSettingsRequest
            var requestWriteApplicationSettingsRequestIsNull = true;
            request.WriteApplicationSettingsRequest = new Amazon.Pinpoint.Model.WriteApplicationSettingsRequest();
            System.Boolean? requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CloudWatchMetricsEnabled = null;
            if (cmdletContext.WriteApplicationSettingsRequest_CloudWatchMetricsEnabled != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CloudWatchMetricsEnabled = cmdletContext.WriteApplicationSettingsRequest_CloudWatchMetricsEnabled.Value;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CloudWatchMetricsEnabled != null)
            {
                request.WriteApplicationSettingsRequest.CloudWatchMetricsEnabled = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CloudWatchMetricsEnabled.Value;
                requestWriteApplicationSettingsRequestIsNull = false;
            }
            Amazon.Pinpoint.Model.QuietTime requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime = null;
            
             // populate QuietTime
            var requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTimeIsNull = true;
            requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime = new Amazon.Pinpoint.Model.QuietTime();
            System.String requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_End = null;
            if (cmdletContext.QuietTime_End != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_End = cmdletContext.QuietTime_End;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_End != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime.End = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_End;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTimeIsNull = false;
            }
            System.String requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_Start = null;
            if (cmdletContext.QuietTime_Start != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_Start = cmdletContext.QuietTime_Start;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_Start != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime.Start = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime_quietTime_Start;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTimeIsNull = false;
            }
             // determine if requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime should be set to null
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTimeIsNull)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime = null;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime != null)
            {
                request.WriteApplicationSettingsRequest.QuietTime = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_QuietTime;
                requestWriteApplicationSettingsRequestIsNull = false;
            }
            Amazon.Pinpoint.Model.CampaignHook requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook = null;
            
             // populate CampaignHook
            var requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHookIsNull = true;
            requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook = new Amazon.Pinpoint.Model.CampaignHook();
            System.String requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_LambdaFunctionName = null;
            if (cmdletContext.CampaignHook_LambdaFunctionName != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_LambdaFunctionName = cmdletContext.CampaignHook_LambdaFunctionName;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_LambdaFunctionName != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook.LambdaFunctionName = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_LambdaFunctionName;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHookIsNull = false;
            }
            Amazon.Pinpoint.Mode requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_Mode = null;
            if (cmdletContext.CampaignHook_Mode != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_Mode = cmdletContext.CampaignHook_Mode;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_Mode != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook.Mode = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_Mode;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHookIsNull = false;
            }
            System.String requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_WebUrl = null;
            if (cmdletContext.CampaignHook_WebUrl != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_WebUrl = cmdletContext.CampaignHook_WebUrl;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_WebUrl != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook.WebUrl = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook_campaignHook_WebUrl;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHookIsNull = false;
            }
             // determine if requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook should be set to null
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHookIsNull)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook = null;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook != null)
            {
                request.WriteApplicationSettingsRequest.CampaignHook = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_CampaignHook;
                requestWriteApplicationSettingsRequestIsNull = false;
            }
            Amazon.Pinpoint.Model.CampaignLimits requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits = null;
            
             // populate Limits
            var requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_LimitsIsNull = true;
            requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits = new Amazon.Pinpoint.Model.CampaignLimits();
            System.Int32? requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Daily = null;
            if (cmdletContext.Limits_Daily != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Daily = cmdletContext.Limits_Daily.Value;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Daily != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits.Daily = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Daily.Value;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_LimitsIsNull = false;
            }
            System.Int32? requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MaximumDuration = null;
            if (cmdletContext.Limits_MaximumDuration != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MaximumDuration = cmdletContext.Limits_MaximumDuration.Value;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MaximumDuration != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits.MaximumDuration = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MaximumDuration.Value;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_LimitsIsNull = false;
            }
            System.Int32? requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MessagesPerSecond = null;
            if (cmdletContext.Limits_MessagesPerSecond != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MessagesPerSecond = cmdletContext.Limits_MessagesPerSecond.Value;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MessagesPerSecond != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits.MessagesPerSecond = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_MessagesPerSecond.Value;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_LimitsIsNull = false;
            }
            System.Int32? requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Total = null;
            if (cmdletContext.Limits_Total != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Total = cmdletContext.Limits_Total.Value;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Total != null)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits.Total = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits_limits_Total.Value;
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_LimitsIsNull = false;
            }
             // determine if requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits should be set to null
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_LimitsIsNull)
            {
                requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits = null;
            }
            if (requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits != null)
            {
                request.WriteApplicationSettingsRequest.Limits = requestWriteApplicationSettingsRequest_writeApplicationSettingsRequest_Limits;
                requestWriteApplicationSettingsRequestIsNull = false;
            }
             // determine if request.WriteApplicationSettingsRequest should be set to null
            if (requestWriteApplicationSettingsRequestIsNull)
            {
                request.WriteApplicationSettingsRequest = null;
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
        
        private Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse CallAWSServiceOperation(IAmazonPinpoint client, Amazon.Pinpoint.Model.UpdateApplicationSettingsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Pinpoint", "UpdateApplicationSettings");
            try
            {
                #if DESKTOP
                return client.UpdateApplicationSettings(request);
                #elif CORECLR
                return client.UpdateApplicationSettingsAsync(request).GetAwaiter().GetResult();
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
            public System.String ApplicationId { get; set; }
            public System.String CampaignHook_LambdaFunctionName { get; set; }
            public Amazon.Pinpoint.Mode CampaignHook_Mode { get; set; }
            public System.String CampaignHook_WebUrl { get; set; }
            public System.Boolean? WriteApplicationSettingsRequest_CloudWatchMetricsEnabled { get; set; }
            public System.Int32? Limits_Daily { get; set; }
            public System.Int32? Limits_MaximumDuration { get; set; }
            public System.Int32? Limits_MessagesPerSecond { get; set; }
            public System.Int32? Limits_Total { get; set; }
            public System.String QuietTime_End { get; set; }
            public System.String QuietTime_Start { get; set; }
            public System.Func<Amazon.Pinpoint.Model.UpdateApplicationSettingsResponse, UpdatePINApplicationSettingListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.ApplicationSettingsResource;
        }
        
    }
}

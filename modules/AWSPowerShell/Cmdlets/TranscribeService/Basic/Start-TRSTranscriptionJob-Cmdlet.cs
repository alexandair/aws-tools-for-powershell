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
using Amazon.TranscribeService;
using Amazon.TranscribeService.Model;

namespace Amazon.PowerShell.Cmdlets.TRS
{
    /// <summary>
    /// Starts an asynchronous job to transcribe speech to text.
    /// </summary>
    [Cmdlet("Start", "TRSTranscriptionJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.TranscribeService.Model.TranscriptionJob")]
    [AWSCmdlet("Calls the Amazon Transcribe Service StartTranscriptionJob API operation.", Operation = new[] {"StartTranscriptionJob"}, SelectReturnType = typeof(Amazon.TranscribeService.Model.StartTranscriptionJobResponse))]
    [AWSCmdletOutput("Amazon.TranscribeService.Model.TranscriptionJob or Amazon.TranscribeService.Model.StartTranscriptionJobResponse",
        "This cmdlet returns an Amazon.TranscribeService.Model.TranscriptionJob object.",
        "The service call response (type Amazon.TranscribeService.Model.StartTranscriptionJobResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class StartTRSTranscriptionJobCmdlet : AmazonTranscribeServiceClientCmdlet, IExecutor
    {
        
        #region Parameter Settings_ChannelIdentification
        /// <summary>
        /// <para>
        /// <para>Instructs Amazon Transcribe to process each audio channel separately and then merge
        /// the transcription output of each channel into a single transcription. </para><para>Amazon Transcribe also produces a transcription of each item detected on an audio
        /// channel, including the start time and end time of the item and alternative transcriptions
        /// of the item including the confidence that Amazon Transcribe has in the transcription.</para><para>You can't set both <code>ShowSpeakerLabels</code> and <code>ChannelIdentification</code>
        /// in the same request. If you set both, your request returns a <code>BadRequestException</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Settings_ChannelIdentification { get; set; }
        #endregion
        
        #region Parameter LanguageCode
        /// <summary>
        /// <para>
        /// <para>The language code for the language used in the input media file.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.TranscribeService.LanguageCode")]
        public Amazon.TranscribeService.LanguageCode LanguageCode { get; set; }
        #endregion
        
        #region Parameter Settings_MaxSpeakerLabel
        /// <summary>
        /// <para>
        /// <para>The maximum number of speakers to identify in the input audio. If there are more speakers
        /// in the audio than this number, multiple speakers will be identified as a single speaker.
        /// If you specify the <code>MaxSpeakerLabels</code> field, you must set the <code>ShowSpeakerLabels</code>
        /// field to true.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Settings_MaxSpeakerLabels")]
        public System.Int32? Settings_MaxSpeakerLabel { get; set; }
        #endregion
        
        #region Parameter Media_MediaFileUri
        /// <summary>
        /// <para>
        /// <para>The S3 location of the input media file. The URI must be in the same region as the
        /// API endpoint that you are calling. The general form is:</para><para><code> https://s3-&lt;aws-region&gt;.amazonaws.com/&lt;bucket-name&gt;/&lt;keyprefix&gt;/&lt;objectkey&gt;
        /// </code></para><para>For example:</para><para><code>https://s3-us-east-1.amazonaws.com/examplebucket/example.mp4</code></para><para><code>https://s3-us-east-1.amazonaws.com/examplebucket/mediadocs/example.mp4</code></para><para>For more information about S3 object names, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html#object-keys">Object
        /// Keys</a> in the <i>Amazon S3 Developer Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Media_MediaFileUri { get; set; }
        #endregion
        
        #region Parameter MediaFormat
        /// <summary>
        /// <para>
        /// <para>The format of the input media file.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.TranscribeService.MediaFormat")]
        public Amazon.TranscribeService.MediaFormat MediaFormat { get; set; }
        #endregion
        
        #region Parameter MediaSampleRateHertz
        /// <summary>
        /// <para>
        /// <para>The sample rate, in Hertz, of the audio track in the input media file. </para><para>If you do not specify the media sample rate, Amazon Transcribe determines the sample
        /// rate. If you specify the sample rate, it must match the sample rate detected by Amazon
        /// Transcribe. In most cases, you should leave the <code>MediaSampleRateHertz</code>
        /// field blank and let Amazon Transcribe determine the sample rate.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? MediaSampleRateHertz { get; set; }
        #endregion
        
        #region Parameter OutputBucketName
        /// <summary>
        /// <para>
        /// <para>The location where the transcription is stored.</para><para>If you set the <code>OutputBucketName</code>, Amazon Transcribe puts the transcription
        /// in the specified S3 bucket. When you call the <a>GetTranscriptionJob</a> operation,
        /// the operation returns this location in the <code>TranscriptFileUri</code> field. The
        /// S3 bucket must have permissions that allow Amazon Transcribe to put files in the bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/security_iam_id-based-policy-examples.html#auth-role-iam-user">Permissions
        /// Required for IAM User Roles</a>.</para><para>Amazon Transcribe uses the default Amazon S3 key for server-side encryption of transcripts
        /// that are placed in your S3 bucket. You can't specify your own encryption key.</para><para>If you don't set the <code>OutputBucketName</code>, Amazon Transcribe generates a
        /// pre-signed URL, a shareable URL that provides secure access to your transcription,
        /// and returns it in the <code>TranscriptFileUri</code> field. Use this URL to download
        /// the transcription.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OutputBucketName { get; set; }
        #endregion
        
        #region Parameter OutputEncryptionKMSKeyId
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OutputEncryptionKMSKeyId { get; set; }
        #endregion
        
        #region Parameter Settings_ShowSpeakerLabel
        /// <summary>
        /// <para>
        /// <para>Determines whether the transcription job uses speaker recognition to identify different
        /// speakers in the input audio. Speaker recognition labels individual speakers in the
        /// audio file. If you set the <code>ShowSpeakerLabels</code> field to true, you must
        /// also set the maximum number of speaker labels <code>MaxSpeakerLabels</code> field.</para><para>You can't set both <code>ShowSpeakerLabels</code> and <code>ChannelIdentification</code>
        /// in the same request. If you set both, your request returns a <code>BadRequestException</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Settings_ShowSpeakerLabels")]
        public System.Boolean? Settings_ShowSpeakerLabel { get; set; }
        #endregion
        
        #region Parameter TranscriptionJobName
        /// <summary>
        /// <para>
        /// <para>The name of the job. Note that you can't use the strings "." or ".." by themselves
        /// as the job name. The name must also be unique within an AWS account.</para>
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
        public System.String TranscriptionJobName { get; set; }
        #endregion
        
        #region Parameter Settings_VocabularyName
        /// <summary>
        /// <para>
        /// <para>The name of a vocabulary to use when processing the transcription job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Settings_VocabularyName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'TranscriptionJob'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.TranscribeService.Model.StartTranscriptionJobResponse).
        /// Specifying the name of a property of type Amazon.TranscribeService.Model.StartTranscriptionJobResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "TranscriptionJob";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the TranscriptionJobName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^TranscriptionJobName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^TranscriptionJobName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.TranscriptionJobName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-TRSTranscriptionJob (StartTranscriptionJob)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.TranscribeService.Model.StartTranscriptionJobResponse, StartTRSTranscriptionJobCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.TranscriptionJobName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.LanguageCode = this.LanguageCode;
            #if MODULAR
            if (this.LanguageCode == null && ParameterWasBound(nameof(this.LanguageCode)))
            {
                WriteWarning("You are passing $null as a value for parameter LanguageCode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Media_MediaFileUri = this.Media_MediaFileUri;
            context.MediaFormat = this.MediaFormat;
            context.MediaSampleRateHertz = this.MediaSampleRateHertz;
            context.OutputBucketName = this.OutputBucketName;
            context.OutputEncryptionKMSKeyId = this.OutputEncryptionKMSKeyId;
            context.Settings_ChannelIdentification = this.Settings_ChannelIdentification;
            context.Settings_MaxSpeakerLabel = this.Settings_MaxSpeakerLabel;
            context.Settings_ShowSpeakerLabel = this.Settings_ShowSpeakerLabel;
            context.Settings_VocabularyName = this.Settings_VocabularyName;
            context.TranscriptionJobName = this.TranscriptionJobName;
            #if MODULAR
            if (this.TranscriptionJobName == null && ParameterWasBound(nameof(this.TranscriptionJobName)))
            {
                WriteWarning("You are passing $null as a value for parameter TranscriptionJobName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.TranscribeService.Model.StartTranscriptionJobRequest();
            
            if (cmdletContext.LanguageCode != null)
            {
                request.LanguageCode = cmdletContext.LanguageCode;
            }
            
             // populate Media
            var requestMediaIsNull = true;
            request.Media = new Amazon.TranscribeService.Model.Media();
            System.String requestMedia_media_MediaFileUri = null;
            if (cmdletContext.Media_MediaFileUri != null)
            {
                requestMedia_media_MediaFileUri = cmdletContext.Media_MediaFileUri;
            }
            if (requestMedia_media_MediaFileUri != null)
            {
                request.Media.MediaFileUri = requestMedia_media_MediaFileUri;
                requestMediaIsNull = false;
            }
             // determine if request.Media should be set to null
            if (requestMediaIsNull)
            {
                request.Media = null;
            }
            if (cmdletContext.MediaFormat != null)
            {
                request.MediaFormat = cmdletContext.MediaFormat;
            }
            if (cmdletContext.MediaSampleRateHertz != null)
            {
                request.MediaSampleRateHertz = cmdletContext.MediaSampleRateHertz.Value;
            }
            if (cmdletContext.OutputBucketName != null)
            {
                request.OutputBucketName = cmdletContext.OutputBucketName;
            }
            if (cmdletContext.OutputEncryptionKMSKeyId != null)
            {
                request.OutputEncryptionKMSKeyId = cmdletContext.OutputEncryptionKMSKeyId;
            }
            
             // populate Settings
            var requestSettingsIsNull = true;
            request.Settings = new Amazon.TranscribeService.Model.Settings();
            System.Boolean? requestSettings_settings_ChannelIdentification = null;
            if (cmdletContext.Settings_ChannelIdentification != null)
            {
                requestSettings_settings_ChannelIdentification = cmdletContext.Settings_ChannelIdentification.Value;
            }
            if (requestSettings_settings_ChannelIdentification != null)
            {
                request.Settings.ChannelIdentification = requestSettings_settings_ChannelIdentification.Value;
                requestSettingsIsNull = false;
            }
            System.Int32? requestSettings_settings_MaxSpeakerLabel = null;
            if (cmdletContext.Settings_MaxSpeakerLabel != null)
            {
                requestSettings_settings_MaxSpeakerLabel = cmdletContext.Settings_MaxSpeakerLabel.Value;
            }
            if (requestSettings_settings_MaxSpeakerLabel != null)
            {
                request.Settings.MaxSpeakerLabels = requestSettings_settings_MaxSpeakerLabel.Value;
                requestSettingsIsNull = false;
            }
            System.Boolean? requestSettings_settings_ShowSpeakerLabel = null;
            if (cmdletContext.Settings_ShowSpeakerLabel != null)
            {
                requestSettings_settings_ShowSpeakerLabel = cmdletContext.Settings_ShowSpeakerLabel.Value;
            }
            if (requestSettings_settings_ShowSpeakerLabel != null)
            {
                request.Settings.ShowSpeakerLabels = requestSettings_settings_ShowSpeakerLabel.Value;
                requestSettingsIsNull = false;
            }
            System.String requestSettings_settings_VocabularyName = null;
            if (cmdletContext.Settings_VocabularyName != null)
            {
                requestSettings_settings_VocabularyName = cmdletContext.Settings_VocabularyName;
            }
            if (requestSettings_settings_VocabularyName != null)
            {
                request.Settings.VocabularyName = requestSettings_settings_VocabularyName;
                requestSettingsIsNull = false;
            }
             // determine if request.Settings should be set to null
            if (requestSettingsIsNull)
            {
                request.Settings = null;
            }
            if (cmdletContext.TranscriptionJobName != null)
            {
                request.TranscriptionJobName = cmdletContext.TranscriptionJobName;
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
        
        private Amazon.TranscribeService.Model.StartTranscriptionJobResponse CallAWSServiceOperation(IAmazonTranscribeService client, Amazon.TranscribeService.Model.StartTranscriptionJobRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Transcribe Service", "StartTranscriptionJob");
            try
            {
                #if DESKTOP
                return client.StartTranscriptionJob(request);
                #elif CORECLR
                return client.StartTranscriptionJobAsync(request).GetAwaiter().GetResult();
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
            public Amazon.TranscribeService.LanguageCode LanguageCode { get; set; }
            public System.String Media_MediaFileUri { get; set; }
            public Amazon.TranscribeService.MediaFormat MediaFormat { get; set; }
            public System.Int32? MediaSampleRateHertz { get; set; }
            public System.String OutputBucketName { get; set; }
            public System.String OutputEncryptionKMSKeyId { get; set; }
            public System.Boolean? Settings_ChannelIdentification { get; set; }
            public System.Int32? Settings_MaxSpeakerLabel { get; set; }
            public System.Boolean? Settings_ShowSpeakerLabel { get; set; }
            public System.String Settings_VocabularyName { get; set; }
            public System.String TranscriptionJobName { get; set; }
            public System.Func<Amazon.TranscribeService.Model.StartTranscriptionJobResponse, StartTRSTranscriptionJobCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.TranscriptionJob;
        }
        
    }
}

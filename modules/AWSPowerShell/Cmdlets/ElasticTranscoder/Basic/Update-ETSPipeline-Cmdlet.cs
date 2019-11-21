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
using Amazon.ElasticTranscoder;
using Amazon.ElasticTranscoder.Model;

namespace Amazon.PowerShell.Cmdlets.ETS
{
    /// <summary>
    /// Use the <code>UpdatePipeline</code> operation to update settings for a pipeline.
    /// 
    ///  <important><para>
    /// When you change pipeline settings, your changes take effect immediately. Jobs that
    /// you have already submitted and that Elastic Transcoder has not started to process
    /// are affected in addition to jobs that you submit after you change settings. 
    /// </para></important>
    /// </summary>
    [Cmdlet("Update", "ETSPipeline", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ElasticTranscoder.Model.Pipeline")]
    [AWSCmdlet("Calls the Amazon Elastic Transcoder UpdatePipeline API operation.", Operation = new[] {"UpdatePipeline"}, SelectReturnType = typeof(Amazon.ElasticTranscoder.Model.UpdatePipelineResponse))]
    [AWSCmdletOutput("Amazon.ElasticTranscoder.Model.Pipeline or Amazon.ElasticTranscoder.Model.UpdatePipelineResponse",
        "This cmdlet returns an Amazon.ElasticTranscoder.Model.Pipeline object.",
        "The service call response (type Amazon.ElasticTranscoder.Model.UpdatePipelineResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateETSPipelineCmdlet : AmazonElasticTranscoderClientCmdlet, IExecutor
    {
        
        #region Parameter AwsKmsKeyArn
        /// <summary>
        /// <para>
        /// <para>The AWS Key Management Service (AWS KMS) key that you want to use with this pipeline.</para><para>If you use either <code>s3</code> or <code>s3-aws-kms</code> as your <code>Encryption:Mode</code>,
        /// you don't need to provide a key with your job because a default key, known as an AWS-KMS
        /// key, is created for you automatically. You need to provide an AWS-KMS key only if
        /// you want to use a non-default AWS-KMS key, or if you are using an <code>Encryption:Mode</code>
        /// of <code>aes-cbc-pkcs7</code>, <code>aes-ctr</code>, or <code>aes-gcm</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AwsKmsKeyArn { get; set; }
        #endregion
        
        #region Parameter ContentConfig_Bucket
        /// <summary>
        /// <para>
        /// <para> The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded
        /// files. Specify this value when all of the following are true:</para><ul><li><para>You want to save transcoded files, thumbnails (if any), and playlists (if any) together
        /// in one bucket.</para></li><li><para>You do not want to specify the users or groups who have access to the transcoded files,
        /// thumbnails, and playlists.</para></li><li><para>You do not want to specify the permissions that Elastic Transcoder grants to the files.</para></li><li><para>You want to associate the transcoded files and thumbnails with the Amazon S3 Standard
        /// storage class.</para></li></ul><para>If you want to save transcoded files and playlists in one bucket and thumbnails in
        /// another bucket, specify which users can access the transcoded files or the permissions
        /// the users have, or change the Amazon S3 storage class, omit OutputBucket and specify
        /// values for <code>ContentConfig</code> and <code>ThumbnailConfig</code> instead. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ContentConfig_Bucket { get; set; }
        #endregion
        
        #region Parameter ThumbnailConfig_Bucket
        /// <summary>
        /// <para>
        /// <para> The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded
        /// files. Specify this value when all of the following are true:</para><ul><li><para>You want to save transcoded files, thumbnails (if any), and playlists (if any) together
        /// in one bucket.</para></li><li><para>You do not want to specify the users or groups who have access to the transcoded files,
        /// thumbnails, and playlists.</para></li><li><para>You do not want to specify the permissions that Elastic Transcoder grants to the files.</para></li><li><para>You want to associate the transcoded files and thumbnails with the Amazon S3 Standard
        /// storage class.</para></li></ul><para>If you want to save transcoded files and playlists in one bucket and thumbnails in
        /// another bucket, specify which users can access the transcoded files or the permissions
        /// the users have, or change the Amazon S3 storage class, omit OutputBucket and specify
        /// values for <code>ContentConfig</code> and <code>ThumbnailConfig</code> instead. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ThumbnailConfig_Bucket { get; set; }
        #endregion
        
        #region Parameter Notifications_Completed
        /// <summary>
        /// <para>
        /// <para>The Amazon SNS topic that you want to notify when Elastic Transcoder has finished
        /// processing the job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Notifications_Completed { get; set; }
        #endregion
        
        #region Parameter Notifications_Error
        /// <summary>
        /// <para>
        /// <para>The Amazon SNS topic that you want to notify when Elastic Transcoder encounters an
        /// error condition.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Notifications_Error { get; set; }
        #endregion
        
        #region Parameter Id
        /// <summary>
        /// <para>
        /// <para>The ID of the pipeline that you want to update.</para>
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
        public System.String Id { get; set; }
        #endregion
        
        #region Parameter InputBucket
        /// <summary>
        /// <para>
        /// <para>The Amazon S3 bucket in which you saved the media files that you want to transcode
        /// and the graphics that you want to use as watermarks.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true)]
        public System.String InputBucket { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name of the pipeline. We recommend that the name be unique within the AWS account,
        /// but uniqueness is not enforced.</para><para>Constraints: Maximum 40 characters</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter ContentConfig_Permission
        /// <summary>
        /// <para>
        /// <para>Optional. The <code>Permissions</code> object specifies which users and/or predefined
        /// Amazon S3 groups you want to have access to transcoded files and playlists, and the
        /// type of access you want them to have. You can grant permissions to a maximum of 30
        /// users and/or predefined Amazon S3 groups.</para><para>If you include <code>Permissions</code>, Elastic Transcoder grants only the permissions
        /// that you specify. It does not grant full permissions to the owner of the role specified
        /// by <code>Role</code>. If you want that user to have full control, you must explicitly
        /// grant full control to the user.</para><para> If you omit <code>Permissions</code>, Elastic Transcoder grants full control over
        /// the transcoded files and playlists to the owner of the role specified by <code>Role</code>,
        /// and grants no other permissions to any other user or group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ContentConfig_Permissions")]
        public Amazon.ElasticTranscoder.Model.Permission[] ContentConfig_Permission { get; set; }
        #endregion
        
        #region Parameter ThumbnailConfig_Permission
        /// <summary>
        /// <para>
        /// <para>Optional. The <code>Permissions</code> object specifies which users and/or predefined
        /// Amazon S3 groups you want to have access to transcoded files and playlists, and the
        /// type of access you want them to have. You can grant permissions to a maximum of 30
        /// users and/or predefined Amazon S3 groups.</para><para>If you include <code>Permissions</code>, Elastic Transcoder grants only the permissions
        /// that you specify. It does not grant full permissions to the owner of the role specified
        /// by <code>Role</code>. If you want that user to have full control, you must explicitly
        /// grant full control to the user.</para><para> If you omit <code>Permissions</code>, Elastic Transcoder grants full control over
        /// the transcoded files and playlists to the owner of the role specified by <code>Role</code>,
        /// and grants no other permissions to any other user or group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ThumbnailConfig_Permissions")]
        public Amazon.ElasticTranscoder.Model.Permission[] ThumbnailConfig_Permission { get; set; }
        #endregion
        
        #region Parameter Notifications_Progressing
        /// <summary>
        /// <para>
        /// <para>The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify
        /// when Elastic Transcoder has started to process the job.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Notifications_Progressing { get; set; }
        #endregion
        
        #region Parameter Role
        /// <summary>
        /// <para>
        /// <para>The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to
        /// use to transcode jobs for this pipeline.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 3, ValueFromPipelineByPropertyName = true)]
        public System.String Role { get; set; }
        #endregion
        
        #region Parameter ContentConfig_StorageClass
        /// <summary>
        /// <para>
        /// <para> The Amazon S3 storage class, <code>Standard</code> or <code>ReducedRedundancy</code>,
        /// that you want Elastic Transcoder to assign to the video files and playlists that it
        /// stores in your Amazon S3 bucket. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ContentConfig_StorageClass { get; set; }
        #endregion
        
        #region Parameter ThumbnailConfig_StorageClass
        /// <summary>
        /// <para>
        /// <para> The Amazon S3 storage class, <code>Standard</code> or <code>ReducedRedundancy</code>,
        /// that you want Elastic Transcoder to assign to the video files and playlists that it
        /// stores in your Amazon S3 bucket. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ThumbnailConfig_StorageClass { get; set; }
        #endregion
        
        #region Parameter Notifications_Warning
        /// <summary>
        /// <para>
        /// <para>The Amazon SNS topic that you want to notify when Elastic Transcoder encounters a
        /// warning condition.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Notifications_Warning { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Pipeline'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ElasticTranscoder.Model.UpdatePipelineResponse).
        /// Specifying the name of a property of type Amazon.ElasticTranscoder.Model.UpdatePipelineResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Pipeline";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Id parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Id), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-ETSPipeline (UpdatePipeline)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ElasticTranscoder.Model.UpdatePipelineResponse, UpdateETSPipelineCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Id;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AwsKmsKeyArn = this.AwsKmsKeyArn;
            context.ContentConfig_Bucket = this.ContentConfig_Bucket;
            if (this.ContentConfig_Permission != null)
            {
                context.ContentConfig_Permission = new List<Amazon.ElasticTranscoder.Model.Permission>(this.ContentConfig_Permission);
            }
            context.ContentConfig_StorageClass = this.ContentConfig_StorageClass;
            context.Id = this.Id;
            #if MODULAR
            if (this.Id == null && ParameterWasBound(nameof(this.Id)))
            {
                WriteWarning("You are passing $null as a value for parameter Id which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.InputBucket = this.InputBucket;
            context.Name = this.Name;
            context.Notifications_Completed = this.Notifications_Completed;
            context.Notifications_Error = this.Notifications_Error;
            context.Notifications_Progressing = this.Notifications_Progressing;
            context.Notifications_Warning = this.Notifications_Warning;
            context.Role = this.Role;
            context.ThumbnailConfig_Bucket = this.ThumbnailConfig_Bucket;
            if (this.ThumbnailConfig_Permission != null)
            {
                context.ThumbnailConfig_Permission = new List<Amazon.ElasticTranscoder.Model.Permission>(this.ThumbnailConfig_Permission);
            }
            context.ThumbnailConfig_StorageClass = this.ThumbnailConfig_StorageClass;
            
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
            var request = new Amazon.ElasticTranscoder.Model.UpdatePipelineRequest();
            
            if (cmdletContext.AwsKmsKeyArn != null)
            {
                request.AwsKmsKeyArn = cmdletContext.AwsKmsKeyArn;
            }
            
             // populate ContentConfig
            var requestContentConfigIsNull = true;
            request.ContentConfig = new Amazon.ElasticTranscoder.Model.PipelineOutputConfig();
            System.String requestContentConfig_contentConfig_Bucket = null;
            if (cmdletContext.ContentConfig_Bucket != null)
            {
                requestContentConfig_contentConfig_Bucket = cmdletContext.ContentConfig_Bucket;
            }
            if (requestContentConfig_contentConfig_Bucket != null)
            {
                request.ContentConfig.Bucket = requestContentConfig_contentConfig_Bucket;
                requestContentConfigIsNull = false;
            }
            List<Amazon.ElasticTranscoder.Model.Permission> requestContentConfig_contentConfig_Permission = null;
            if (cmdletContext.ContentConfig_Permission != null)
            {
                requestContentConfig_contentConfig_Permission = cmdletContext.ContentConfig_Permission;
            }
            if (requestContentConfig_contentConfig_Permission != null)
            {
                request.ContentConfig.Permissions = requestContentConfig_contentConfig_Permission;
                requestContentConfigIsNull = false;
            }
            System.String requestContentConfig_contentConfig_StorageClass = null;
            if (cmdletContext.ContentConfig_StorageClass != null)
            {
                requestContentConfig_contentConfig_StorageClass = cmdletContext.ContentConfig_StorageClass;
            }
            if (requestContentConfig_contentConfig_StorageClass != null)
            {
                request.ContentConfig.StorageClass = requestContentConfig_contentConfig_StorageClass;
                requestContentConfigIsNull = false;
            }
             // determine if request.ContentConfig should be set to null
            if (requestContentConfigIsNull)
            {
                request.ContentConfig = null;
            }
            if (cmdletContext.Id != null)
            {
                request.Id = cmdletContext.Id;
            }
            if (cmdletContext.InputBucket != null)
            {
                request.InputBucket = cmdletContext.InputBucket;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            
             // populate Notifications
            var requestNotificationsIsNull = true;
            request.Notifications = new Amazon.ElasticTranscoder.Model.Notifications();
            System.String requestNotifications_notifications_Completed = null;
            if (cmdletContext.Notifications_Completed != null)
            {
                requestNotifications_notifications_Completed = cmdletContext.Notifications_Completed;
            }
            if (requestNotifications_notifications_Completed != null)
            {
                request.Notifications.Completed = requestNotifications_notifications_Completed;
                requestNotificationsIsNull = false;
            }
            System.String requestNotifications_notifications_Error = null;
            if (cmdletContext.Notifications_Error != null)
            {
                requestNotifications_notifications_Error = cmdletContext.Notifications_Error;
            }
            if (requestNotifications_notifications_Error != null)
            {
                request.Notifications.Error = requestNotifications_notifications_Error;
                requestNotificationsIsNull = false;
            }
            System.String requestNotifications_notifications_Progressing = null;
            if (cmdletContext.Notifications_Progressing != null)
            {
                requestNotifications_notifications_Progressing = cmdletContext.Notifications_Progressing;
            }
            if (requestNotifications_notifications_Progressing != null)
            {
                request.Notifications.Progressing = requestNotifications_notifications_Progressing;
                requestNotificationsIsNull = false;
            }
            System.String requestNotifications_notifications_Warning = null;
            if (cmdletContext.Notifications_Warning != null)
            {
                requestNotifications_notifications_Warning = cmdletContext.Notifications_Warning;
            }
            if (requestNotifications_notifications_Warning != null)
            {
                request.Notifications.Warning = requestNotifications_notifications_Warning;
                requestNotificationsIsNull = false;
            }
             // determine if request.Notifications should be set to null
            if (requestNotificationsIsNull)
            {
                request.Notifications = null;
            }
            if (cmdletContext.Role != null)
            {
                request.Role = cmdletContext.Role;
            }
            
             // populate ThumbnailConfig
            var requestThumbnailConfigIsNull = true;
            request.ThumbnailConfig = new Amazon.ElasticTranscoder.Model.PipelineOutputConfig();
            System.String requestThumbnailConfig_thumbnailConfig_Bucket = null;
            if (cmdletContext.ThumbnailConfig_Bucket != null)
            {
                requestThumbnailConfig_thumbnailConfig_Bucket = cmdletContext.ThumbnailConfig_Bucket;
            }
            if (requestThumbnailConfig_thumbnailConfig_Bucket != null)
            {
                request.ThumbnailConfig.Bucket = requestThumbnailConfig_thumbnailConfig_Bucket;
                requestThumbnailConfigIsNull = false;
            }
            List<Amazon.ElasticTranscoder.Model.Permission> requestThumbnailConfig_thumbnailConfig_Permission = null;
            if (cmdletContext.ThumbnailConfig_Permission != null)
            {
                requestThumbnailConfig_thumbnailConfig_Permission = cmdletContext.ThumbnailConfig_Permission;
            }
            if (requestThumbnailConfig_thumbnailConfig_Permission != null)
            {
                request.ThumbnailConfig.Permissions = requestThumbnailConfig_thumbnailConfig_Permission;
                requestThumbnailConfigIsNull = false;
            }
            System.String requestThumbnailConfig_thumbnailConfig_StorageClass = null;
            if (cmdletContext.ThumbnailConfig_StorageClass != null)
            {
                requestThumbnailConfig_thumbnailConfig_StorageClass = cmdletContext.ThumbnailConfig_StorageClass;
            }
            if (requestThumbnailConfig_thumbnailConfig_StorageClass != null)
            {
                request.ThumbnailConfig.StorageClass = requestThumbnailConfig_thumbnailConfig_StorageClass;
                requestThumbnailConfigIsNull = false;
            }
             // determine if request.ThumbnailConfig should be set to null
            if (requestThumbnailConfigIsNull)
            {
                request.ThumbnailConfig = null;
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
        
        private Amazon.ElasticTranscoder.Model.UpdatePipelineResponse CallAWSServiceOperation(IAmazonElasticTranscoder client, Amazon.ElasticTranscoder.Model.UpdatePipelineRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Elastic Transcoder", "UpdatePipeline");
            try
            {
                #if DESKTOP
                return client.UpdatePipeline(request);
                #elif CORECLR
                return client.UpdatePipelineAsync(request).GetAwaiter().GetResult();
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
            public System.String AwsKmsKeyArn { get; set; }
            public System.String ContentConfig_Bucket { get; set; }
            public List<Amazon.ElasticTranscoder.Model.Permission> ContentConfig_Permission { get; set; }
            public System.String ContentConfig_StorageClass { get; set; }
            public System.String Id { get; set; }
            public System.String InputBucket { get; set; }
            public System.String Name { get; set; }
            public System.String Notifications_Completed { get; set; }
            public System.String Notifications_Error { get; set; }
            public System.String Notifications_Progressing { get; set; }
            public System.String Notifications_Warning { get; set; }
            public System.String Role { get; set; }
            public System.String ThumbnailConfig_Bucket { get; set; }
            public List<Amazon.ElasticTranscoder.Model.Permission> ThumbnailConfig_Permission { get; set; }
            public System.String ThumbnailConfig_StorageClass { get; set; }
            public System.Func<Amazon.ElasticTranscoder.Model.UpdatePipelineResponse, UpdateETSPipelineCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Pipeline;
        }
        
    }
}

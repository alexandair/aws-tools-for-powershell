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
using Amazon.Amplify;
using Amazon.Amplify.Model;

namespace Amazon.PowerShell.Cmdlets.AMP
{
    /// <summary>
    /// Updates an existing Amplify App.
    /// </summary>
    [Cmdlet("Update", "AMPApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Amplify.Model.App")]
    [AWSCmdlet("Calls the AWS Amplify UpdateApp API operation.", Operation = new[] {"UpdateApp"}, SelectReturnType = typeof(Amazon.Amplify.Model.UpdateAppResponse))]
    [AWSCmdletOutput("Amazon.Amplify.Model.App or Amazon.Amplify.Model.UpdateAppResponse",
        "This cmdlet returns an Amazon.Amplify.Model.App object.",
        "The service call response (type Amazon.Amplify.Model.UpdateAppResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateAMPAppCmdlet : AmazonAmplifyClientCmdlet, IExecutor
    {
        
        #region Parameter AccessToken
        /// <summary>
        /// <para>
        /// <para> Personal Access token for 3rd party source control system for an Amplify App, used
        /// to create webhook and read-only deploy key. Token is not stored. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AccessToken { get; set; }
        #endregion
        
        #region Parameter AppId
        /// <summary>
        /// <para>
        /// <para> Unique Id for an Amplify App. </para>
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
        public System.String AppId { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationPattern
        /// <summary>
        /// <para>
        /// <para> Automated branch creation glob patterns for the Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AutoBranchCreationPatterns")]
        public System.String[] AutoBranchCreationPattern { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_BasicAuthCredential
        /// <summary>
        /// <para>
        /// <para> Basic Authorization credentials for the auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AutoBranchCreationConfig_BasicAuthCredentials")]
        public System.String AutoBranchCreationConfig_BasicAuthCredential { get; set; }
        #endregion
        
        #region Parameter BasicAuthCredential
        /// <summary>
        /// <para>
        /// <para> Basic Authorization credentials for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("BasicAuthCredentials")]
        public System.String BasicAuthCredential { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_BuildSpec
        /// <summary>
        /// <para>
        /// <para> BuildSpec for the auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AutoBranchCreationConfig_BuildSpec { get; set; }
        #endregion
        
        #region Parameter BuildSpec
        /// <summary>
        /// <para>
        /// <para> BuildSpec for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String BuildSpec { get; set; }
        #endregion
        
        #region Parameter CustomRule
        /// <summary>
        /// <para>
        /// <para> Custom redirect / rewrite rules for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CustomRules")]
        public Amazon.Amplify.Model.CustomRule[] CustomRule { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para> Description for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter EnableAutoBranchCreation
        /// <summary>
        /// <para>
        /// <para> Enables automated branch creation for the Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableAutoBranchCreation { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_EnableAutoBuild
        /// <summary>
        /// <para>
        /// <para> Enables auto building for the auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AutoBranchCreationConfig_EnableAutoBuild { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_EnableBasicAuth
        /// <summary>
        /// <para>
        /// <para> Enables Basic Auth for the auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AutoBranchCreationConfig_EnableBasicAuth { get; set; }
        #endregion
        
        #region Parameter EnableBasicAuth
        /// <summary>
        /// <para>
        /// <para> Enables Basic Authorization for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableBasicAuth { get; set; }
        #endregion
        
        #region Parameter EnableBranchAutoBuild
        /// <summary>
        /// <para>
        /// <para> Enables branch auto-building for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableBranchAutoBuild { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_EnablePullRequestPreview
        /// <summary>
        /// <para>
        /// <para> Enables Pull Request Preview for auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AutoBranchCreationConfig_EnablePullRequestPreview { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_EnvironmentVariable
        /// <summary>
        /// <para>
        /// <para> Environment Variables for the auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AutoBranchCreationConfig_EnvironmentVariables")]
        public System.Collections.Hashtable AutoBranchCreationConfig_EnvironmentVariable { get; set; }
        #endregion
        
        #region Parameter EnvironmentVariable
        /// <summary>
        /// <para>
        /// <para> Environment Variables for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("EnvironmentVariables")]
        public System.Collections.Hashtable EnvironmentVariable { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_Framework
        /// <summary>
        /// <para>
        /// <para> Framework for the auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AutoBranchCreationConfig_Framework { get; set; }
        #endregion
        
        #region Parameter IamServiceRoleArn
        /// <summary>
        /// <para>
        /// <para> IAM service role for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String IamServiceRoleArn { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para> Name for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter OauthToken
        /// <summary>
        /// <para>
        /// <para> OAuth token for 3rd party source control system for an Amplify App, used to create
        /// webhook and read-only deploy key. OAuth token is not stored. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OauthToken { get; set; }
        #endregion
        
        #region Parameter Platform
        /// <summary>
        /// <para>
        /// <para> Platform for an Amplify App. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Amplify.Platform")]
        public Amazon.Amplify.Platform Platform { get; set; }
        #endregion
        
        #region Parameter Repository
        /// <summary>
        /// <para>
        /// <para> Repository for an Amplify App </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Repository { get; set; }
        #endregion
        
        #region Parameter AutoBranchCreationConfig_Stage
        /// <summary>
        /// <para>
        /// <para> Stage for the auto created branch. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Amplify.Stage")]
        public Amazon.Amplify.Stage AutoBranchCreationConfig_Stage { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'App'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Amplify.Model.UpdateAppResponse).
        /// Specifying the name of a property of type Amazon.Amplify.Model.UpdateAppResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "App";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AppId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AppId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AppId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AppId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-AMPApp (UpdateApp)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Amplify.Model.UpdateAppResponse, UpdateAMPAppCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AppId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AccessToken = this.AccessToken;
            context.AppId = this.AppId;
            #if MODULAR
            if (this.AppId == null && ParameterWasBound(nameof(this.AppId)))
            {
                WriteWarning("You are passing $null as a value for parameter AppId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AutoBranchCreationConfig_BasicAuthCredential = this.AutoBranchCreationConfig_BasicAuthCredential;
            context.AutoBranchCreationConfig_BuildSpec = this.AutoBranchCreationConfig_BuildSpec;
            context.AutoBranchCreationConfig_EnableAutoBuild = this.AutoBranchCreationConfig_EnableAutoBuild;
            context.AutoBranchCreationConfig_EnableBasicAuth = this.AutoBranchCreationConfig_EnableBasicAuth;
            context.AutoBranchCreationConfig_EnablePullRequestPreview = this.AutoBranchCreationConfig_EnablePullRequestPreview;
            if (this.AutoBranchCreationConfig_EnvironmentVariable != null)
            {
                context.AutoBranchCreationConfig_EnvironmentVariable = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.AutoBranchCreationConfig_EnvironmentVariable.Keys)
                {
                    context.AutoBranchCreationConfig_EnvironmentVariable.Add((String)hashKey, (String)(this.AutoBranchCreationConfig_EnvironmentVariable[hashKey]));
                }
            }
            context.AutoBranchCreationConfig_Framework = this.AutoBranchCreationConfig_Framework;
            context.AutoBranchCreationConfig_Stage = this.AutoBranchCreationConfig_Stage;
            if (this.AutoBranchCreationPattern != null)
            {
                context.AutoBranchCreationPattern = new List<System.String>(this.AutoBranchCreationPattern);
            }
            context.BasicAuthCredential = this.BasicAuthCredential;
            context.BuildSpec = this.BuildSpec;
            if (this.CustomRule != null)
            {
                context.CustomRule = new List<Amazon.Amplify.Model.CustomRule>(this.CustomRule);
            }
            context.Description = this.Description;
            context.EnableAutoBranchCreation = this.EnableAutoBranchCreation;
            context.EnableBasicAuth = this.EnableBasicAuth;
            context.EnableBranchAutoBuild = this.EnableBranchAutoBuild;
            if (this.EnvironmentVariable != null)
            {
                context.EnvironmentVariable = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.EnvironmentVariable.Keys)
                {
                    context.EnvironmentVariable.Add((String)hashKey, (String)(this.EnvironmentVariable[hashKey]));
                }
            }
            context.IamServiceRoleArn = this.IamServiceRoleArn;
            context.Name = this.Name;
            context.OauthToken = this.OauthToken;
            context.Platform = this.Platform;
            context.Repository = this.Repository;
            
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
            var request = new Amazon.Amplify.Model.UpdateAppRequest();
            
            if (cmdletContext.AccessToken != null)
            {
                request.AccessToken = cmdletContext.AccessToken;
            }
            if (cmdletContext.AppId != null)
            {
                request.AppId = cmdletContext.AppId;
            }
            
             // populate AutoBranchCreationConfig
            var requestAutoBranchCreationConfigIsNull = true;
            request.AutoBranchCreationConfig = new Amazon.Amplify.Model.AutoBranchCreationConfig();
            System.String requestAutoBranchCreationConfig_autoBranchCreationConfig_BasicAuthCredential = null;
            if (cmdletContext.AutoBranchCreationConfig_BasicAuthCredential != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_BasicAuthCredential = cmdletContext.AutoBranchCreationConfig_BasicAuthCredential;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_BasicAuthCredential != null)
            {
                request.AutoBranchCreationConfig.BasicAuthCredentials = requestAutoBranchCreationConfig_autoBranchCreationConfig_BasicAuthCredential;
                requestAutoBranchCreationConfigIsNull = false;
            }
            System.String requestAutoBranchCreationConfig_autoBranchCreationConfig_BuildSpec = null;
            if (cmdletContext.AutoBranchCreationConfig_BuildSpec != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_BuildSpec = cmdletContext.AutoBranchCreationConfig_BuildSpec;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_BuildSpec != null)
            {
                request.AutoBranchCreationConfig.BuildSpec = requestAutoBranchCreationConfig_autoBranchCreationConfig_BuildSpec;
                requestAutoBranchCreationConfigIsNull = false;
            }
            System.Boolean? requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableAutoBuild = null;
            if (cmdletContext.AutoBranchCreationConfig_EnableAutoBuild != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableAutoBuild = cmdletContext.AutoBranchCreationConfig_EnableAutoBuild.Value;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableAutoBuild != null)
            {
                request.AutoBranchCreationConfig.EnableAutoBuild = requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableAutoBuild.Value;
                requestAutoBranchCreationConfigIsNull = false;
            }
            System.Boolean? requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableBasicAuth = null;
            if (cmdletContext.AutoBranchCreationConfig_EnableBasicAuth != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableBasicAuth = cmdletContext.AutoBranchCreationConfig_EnableBasicAuth.Value;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableBasicAuth != null)
            {
                request.AutoBranchCreationConfig.EnableBasicAuth = requestAutoBranchCreationConfig_autoBranchCreationConfig_EnableBasicAuth.Value;
                requestAutoBranchCreationConfigIsNull = false;
            }
            System.Boolean? requestAutoBranchCreationConfig_autoBranchCreationConfig_EnablePullRequestPreview = null;
            if (cmdletContext.AutoBranchCreationConfig_EnablePullRequestPreview != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_EnablePullRequestPreview = cmdletContext.AutoBranchCreationConfig_EnablePullRequestPreview.Value;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_EnablePullRequestPreview != null)
            {
                request.AutoBranchCreationConfig.EnablePullRequestPreview = requestAutoBranchCreationConfig_autoBranchCreationConfig_EnablePullRequestPreview.Value;
                requestAutoBranchCreationConfigIsNull = false;
            }
            Dictionary<System.String, System.String> requestAutoBranchCreationConfig_autoBranchCreationConfig_EnvironmentVariable = null;
            if (cmdletContext.AutoBranchCreationConfig_EnvironmentVariable != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_EnvironmentVariable = cmdletContext.AutoBranchCreationConfig_EnvironmentVariable;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_EnvironmentVariable != null)
            {
                request.AutoBranchCreationConfig.EnvironmentVariables = requestAutoBranchCreationConfig_autoBranchCreationConfig_EnvironmentVariable;
                requestAutoBranchCreationConfigIsNull = false;
            }
            System.String requestAutoBranchCreationConfig_autoBranchCreationConfig_Framework = null;
            if (cmdletContext.AutoBranchCreationConfig_Framework != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_Framework = cmdletContext.AutoBranchCreationConfig_Framework;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_Framework != null)
            {
                request.AutoBranchCreationConfig.Framework = requestAutoBranchCreationConfig_autoBranchCreationConfig_Framework;
                requestAutoBranchCreationConfigIsNull = false;
            }
            Amazon.Amplify.Stage requestAutoBranchCreationConfig_autoBranchCreationConfig_Stage = null;
            if (cmdletContext.AutoBranchCreationConfig_Stage != null)
            {
                requestAutoBranchCreationConfig_autoBranchCreationConfig_Stage = cmdletContext.AutoBranchCreationConfig_Stage;
            }
            if (requestAutoBranchCreationConfig_autoBranchCreationConfig_Stage != null)
            {
                request.AutoBranchCreationConfig.Stage = requestAutoBranchCreationConfig_autoBranchCreationConfig_Stage;
                requestAutoBranchCreationConfigIsNull = false;
            }
             // determine if request.AutoBranchCreationConfig should be set to null
            if (requestAutoBranchCreationConfigIsNull)
            {
                request.AutoBranchCreationConfig = null;
            }
            if (cmdletContext.AutoBranchCreationPattern != null)
            {
                request.AutoBranchCreationPatterns = cmdletContext.AutoBranchCreationPattern;
            }
            if (cmdletContext.BasicAuthCredential != null)
            {
                request.BasicAuthCredentials = cmdletContext.BasicAuthCredential;
            }
            if (cmdletContext.BuildSpec != null)
            {
                request.BuildSpec = cmdletContext.BuildSpec;
            }
            if (cmdletContext.CustomRule != null)
            {
                request.CustomRules = cmdletContext.CustomRule;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.EnableAutoBranchCreation != null)
            {
                request.EnableAutoBranchCreation = cmdletContext.EnableAutoBranchCreation.Value;
            }
            if (cmdletContext.EnableBasicAuth != null)
            {
                request.EnableBasicAuth = cmdletContext.EnableBasicAuth.Value;
            }
            if (cmdletContext.EnableBranchAutoBuild != null)
            {
                request.EnableBranchAutoBuild = cmdletContext.EnableBranchAutoBuild.Value;
            }
            if (cmdletContext.EnvironmentVariable != null)
            {
                request.EnvironmentVariables = cmdletContext.EnvironmentVariable;
            }
            if (cmdletContext.IamServiceRoleArn != null)
            {
                request.IamServiceRoleArn = cmdletContext.IamServiceRoleArn;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.OauthToken != null)
            {
                request.OauthToken = cmdletContext.OauthToken;
            }
            if (cmdletContext.Platform != null)
            {
                request.Platform = cmdletContext.Platform;
            }
            if (cmdletContext.Repository != null)
            {
                request.Repository = cmdletContext.Repository;
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
        
        private Amazon.Amplify.Model.UpdateAppResponse CallAWSServiceOperation(IAmazonAmplify client, Amazon.Amplify.Model.UpdateAppRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Amplify", "UpdateApp");
            try
            {
                #if DESKTOP
                return client.UpdateApp(request);
                #elif CORECLR
                return client.UpdateAppAsync(request).GetAwaiter().GetResult();
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
            public System.String AccessToken { get; set; }
            public System.String AppId { get; set; }
            public System.String AutoBranchCreationConfig_BasicAuthCredential { get; set; }
            public System.String AutoBranchCreationConfig_BuildSpec { get; set; }
            public System.Boolean? AutoBranchCreationConfig_EnableAutoBuild { get; set; }
            public System.Boolean? AutoBranchCreationConfig_EnableBasicAuth { get; set; }
            public System.Boolean? AutoBranchCreationConfig_EnablePullRequestPreview { get; set; }
            public Dictionary<System.String, System.String> AutoBranchCreationConfig_EnvironmentVariable { get; set; }
            public System.String AutoBranchCreationConfig_Framework { get; set; }
            public Amazon.Amplify.Stage AutoBranchCreationConfig_Stage { get; set; }
            public List<System.String> AutoBranchCreationPattern { get; set; }
            public System.String BasicAuthCredential { get; set; }
            public System.String BuildSpec { get; set; }
            public List<Amazon.Amplify.Model.CustomRule> CustomRule { get; set; }
            public System.String Description { get; set; }
            public System.Boolean? EnableAutoBranchCreation { get; set; }
            public System.Boolean? EnableBasicAuth { get; set; }
            public System.Boolean? EnableBranchAutoBuild { get; set; }
            public Dictionary<System.String, System.String> EnvironmentVariable { get; set; }
            public System.String IamServiceRoleArn { get; set; }
            public System.String Name { get; set; }
            public System.String OauthToken { get; set; }
            public Amazon.Amplify.Platform Platform { get; set; }
            public System.String Repository { get; set; }
            public System.Func<Amazon.Amplify.Model.UpdateAppResponse, UpdateAMPAppCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.App;
        }
        
    }
}

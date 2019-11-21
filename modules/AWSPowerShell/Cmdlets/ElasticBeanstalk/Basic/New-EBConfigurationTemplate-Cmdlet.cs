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
using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

namespace Amazon.PowerShell.Cmdlets.EB
{
    /// <summary>
    /// Creates a configuration template. Templates are associated with a specific application
    /// and are used to deploy different versions of the application with the same configuration
    /// settings.
    /// 
    ///  
    /// <para>
    /// Templates aren't associated with any environment. The <code>EnvironmentName</code>
    /// response element is always <code>null</code>.
    /// </para><para>
    /// Related Topics
    /// </para><ul><li><para><a>DescribeConfigurationOptions</a></para></li><li><para><a>DescribeConfigurationSettings</a></para></li><li><para><a>ListAvailableSolutionStacks</a></para></li></ul>
    /// </summary>
    [Cmdlet("New", "EBConfigurationTemplate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse")]
    [AWSCmdlet("Calls the AWS Elastic Beanstalk CreateConfigurationTemplate API operation.", Operation = new[] {"CreateConfigurationTemplate"}, SelectReturnType = typeof(Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse))]
    [AWSCmdletOutput("Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse",
        "This cmdlet returns an Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewEBConfigurationTemplateCmdlet : AmazonElasticBeanstalkClientCmdlet, IExecutor
    {
        
        #region Parameter ApplicationName
        /// <summary>
        /// <para>
        /// <para>The name of the application to associate with this configuration template. If no application
        /// is found with this name, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code>
        /// error. </para>
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
        public System.String ApplicationName { get; set; }
        #endregion
        
        #region Parameter SourceConfiguration_ApplicationName
        /// <summary>
        /// <para>
        /// <para>The name of the application associated with the configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SourceConfiguration_ApplicationName { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>Describes this configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 4, ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter EnvironmentId
        /// <summary>
        /// <para>
        /// <para>The ID of the environment used with this configuration template.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 3, ValueFromPipelineByPropertyName = true)]
        public System.String EnvironmentId { get; set; }
        #endregion
        
        #region Parameter OptionSetting
        /// <summary>
        /// <para>
        /// <para>If specified, AWS Elastic Beanstalk sets the specified configuration option to the
        /// requested value. The new value overrides the value obtained from the solution stack
        /// or the source configuration template.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("OptionSettings")]
        public Amazon.ElasticBeanstalk.Model.ConfigurationOptionSetting[] OptionSetting { get; set; }
        #endregion
        
        #region Parameter PlatformArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the custom platform.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PlatformArn { get; set; }
        #endregion
        
        #region Parameter SolutionStackName
        /// <summary>
        /// <para>
        /// <para>The name of the solution stack used by this configuration. The solution stack specifies
        /// the operating system, architecture, and application server for a configuration template.
        /// It determines the set of configuration options as well as the possible and default
        /// values.</para><para> Use <a>ListAvailableSolutionStacks</a> to obtain a list of available solution stacks.
        /// </para><para> A solution stack name or a source configuration parameter must be specified, otherwise
        /// AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code> error. </para><para>If a solution stack name is not specified and the source configuration parameter is
        /// specified, AWS Elastic Beanstalk uses the same solution stack as the source configuration
        /// template.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true)]
        public System.String SolutionStackName { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Specifies the tags applied to the configuration template.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.ElasticBeanstalk.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter SourceConfiguration_TemplateName
        /// <summary>
        /// <para>
        /// <para>The name of the configuration template.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SourceConfiguration_TemplateName { get; set; }
        #endregion
        
        #region Parameter TemplateName
        /// <summary>
        /// <para>
        /// <para>The name of the configuration template.</para><para>Constraint: This name must be unique per application.</para><para>Default: If a configuration template already exists with this name, AWS Elastic Beanstalk
        /// returns an <code>InvalidParameterValue</code> error. </para>
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
        public System.String TemplateName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse).
        /// Specifying the name of a property of type Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ApplicationName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ApplicationName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ApplicationName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ApplicationName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-EBConfigurationTemplate (CreateConfigurationTemplate)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse, NewEBConfigurationTemplateCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ApplicationName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ApplicationName = this.ApplicationName;
            #if MODULAR
            if (this.ApplicationName == null && ParameterWasBound(nameof(this.ApplicationName)))
            {
                WriteWarning("You are passing $null as a value for parameter ApplicationName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Description = this.Description;
            context.EnvironmentId = this.EnvironmentId;
            if (this.OptionSetting != null)
            {
                context.OptionSetting = new List<Amazon.ElasticBeanstalk.Model.ConfigurationOptionSetting>(this.OptionSetting);
            }
            context.PlatformArn = this.PlatformArn;
            context.SolutionStackName = this.SolutionStackName;
            context.SourceConfiguration_ApplicationName = this.SourceConfiguration_ApplicationName;
            context.SourceConfiguration_TemplateName = this.SourceConfiguration_TemplateName;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.ElasticBeanstalk.Model.Tag>(this.Tag);
            }
            context.TemplateName = this.TemplateName;
            #if MODULAR
            if (this.TemplateName == null && ParameterWasBound(nameof(this.TemplateName)))
            {
                WriteWarning("You are passing $null as a value for parameter TemplateName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateRequest();
            
            if (cmdletContext.ApplicationName != null)
            {
                request.ApplicationName = cmdletContext.ApplicationName;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.EnvironmentId != null)
            {
                request.EnvironmentId = cmdletContext.EnvironmentId;
            }
            if (cmdletContext.OptionSetting != null)
            {
                request.OptionSettings = cmdletContext.OptionSetting;
            }
            if (cmdletContext.PlatformArn != null)
            {
                request.PlatformArn = cmdletContext.PlatformArn;
            }
            if (cmdletContext.SolutionStackName != null)
            {
                request.SolutionStackName = cmdletContext.SolutionStackName;
            }
            
             // populate SourceConfiguration
            var requestSourceConfigurationIsNull = true;
            request.SourceConfiguration = new Amazon.ElasticBeanstalk.Model.SourceConfiguration();
            System.String requestSourceConfiguration_sourceConfiguration_ApplicationName = null;
            if (cmdletContext.SourceConfiguration_ApplicationName != null)
            {
                requestSourceConfiguration_sourceConfiguration_ApplicationName = cmdletContext.SourceConfiguration_ApplicationName;
            }
            if (requestSourceConfiguration_sourceConfiguration_ApplicationName != null)
            {
                request.SourceConfiguration.ApplicationName = requestSourceConfiguration_sourceConfiguration_ApplicationName;
                requestSourceConfigurationIsNull = false;
            }
            System.String requestSourceConfiguration_sourceConfiguration_TemplateName = null;
            if (cmdletContext.SourceConfiguration_TemplateName != null)
            {
                requestSourceConfiguration_sourceConfiguration_TemplateName = cmdletContext.SourceConfiguration_TemplateName;
            }
            if (requestSourceConfiguration_sourceConfiguration_TemplateName != null)
            {
                request.SourceConfiguration.TemplateName = requestSourceConfiguration_sourceConfiguration_TemplateName;
                requestSourceConfigurationIsNull = false;
            }
             // determine if request.SourceConfiguration should be set to null
            if (requestSourceConfigurationIsNull)
            {
                request.SourceConfiguration = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.TemplateName != null)
            {
                request.TemplateName = cmdletContext.TemplateName;
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
        
        private Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse CallAWSServiceOperation(IAmazonElasticBeanstalk client, Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Elastic Beanstalk", "CreateConfigurationTemplate");
            try
            {
                #if DESKTOP
                return client.CreateConfigurationTemplate(request);
                #elif CORECLR
                return client.CreateConfigurationTemplateAsync(request).GetAwaiter().GetResult();
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
            public System.String ApplicationName { get; set; }
            public System.String Description { get; set; }
            public System.String EnvironmentId { get; set; }
            public List<Amazon.ElasticBeanstalk.Model.ConfigurationOptionSetting> OptionSetting { get; set; }
            public System.String PlatformArn { get; set; }
            public System.String SolutionStackName { get; set; }
            public System.String SourceConfiguration_ApplicationName { get; set; }
            public System.String SourceConfiguration_TemplateName { get; set; }
            public List<Amazon.ElasticBeanstalk.Model.Tag> Tag { get; set; }
            public System.String TemplateName { get; set; }
            public System.Func<Amazon.ElasticBeanstalk.Model.CreateConfigurationTemplateResponse, NewEBConfigurationTemplateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}

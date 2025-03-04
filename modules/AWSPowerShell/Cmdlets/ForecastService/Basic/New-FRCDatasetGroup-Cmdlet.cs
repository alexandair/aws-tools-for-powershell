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
using Amazon.ForecastService;
using Amazon.ForecastService.Model;

namespace Amazon.PowerShell.Cmdlets.FRC
{
    /// <summary>
    /// Creates an Amazon Forecast dataset group, which holds a collection of related datasets.
    /// You can add datasets to the dataset group when you create the dataset group, or you
    /// can add datasets later with the <a>UpdateDatasetGroup</a> operation.
    /// 
    ///  
    /// <para>
    /// After creating a dataset group and adding datasets, you use the dataset group when
    /// you create a predictor. For more information, see <a>howitworks-datasets-groups</a>.
    /// </para><para>
    /// To get a list of all your datasets groups, use the <a>ListDatasetGroups</a> operation.
    /// </para><note><para>
    /// The <code>Status</code> of a dataset group must be <code>ACTIVE</code> before you
    /// can create a predictor using the dataset group. Use the <a>DescribeDatasetGroup</a>
    /// operation to get the status.
    /// </para></note>
    /// </summary>
    [Cmdlet("New", "FRCDatasetGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Forecast Service CreateDatasetGroup API operation.", Operation = new[] {"CreateDatasetGroup"}, SelectReturnType = typeof(Amazon.ForecastService.Model.CreateDatasetGroupResponse))]
    [AWSCmdletOutput("System.String or Amazon.ForecastService.Model.CreateDatasetGroupResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.ForecastService.Model.CreateDatasetGroupResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewFRCDatasetGroupCmdlet : AmazonForecastServiceClientCmdlet, IExecutor
    {
        
        #region Parameter DatasetArn
        /// <summary>
        /// <para>
        /// <para>An array of Amazon Resource Names (ARNs) of the datasets that you want to include
        /// in the dataset group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("DatasetArns")]
        public System.String[] DatasetArn { get; set; }
        #endregion
        
        #region Parameter DatasetGroupName
        /// <summary>
        /// <para>
        /// <para>A name for the dataset group.</para>
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
        public System.String DatasetGroupName { get; set; }
        #endregion
        
        #region Parameter Domain
        /// <summary>
        /// <para>
        /// <para>The domain associated with the dataset group. The <code>Domain</code> and <code>DatasetType</code>
        /// that you choose determine the fields that must be present in the training data that
        /// you import to the dataset. For example, if you choose the <code>RETAIL</code> domain
        /// and <code>TARGET_TIME_SERIES</code> as the <code>DatasetType</code>, Amazon Forecast
        /// requires <code>item_id</code>, <code>timestamp</code>, and <code>demand</code> fields
        /// to be present in your data. For more information, see <a>howitworks-datasets-groups</a>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.ForecastService.Domain")]
        public Amazon.ForecastService.Domain Domain { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'DatasetGroupArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ForecastService.Model.CreateDatasetGroupResponse).
        /// Specifying the name of a property of type Amazon.ForecastService.Model.CreateDatasetGroupResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "DatasetGroupArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the DatasetGroupName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^DatasetGroupName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^DatasetGroupName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DatasetGroupName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-FRCDatasetGroup (CreateDatasetGroup)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ForecastService.Model.CreateDatasetGroupResponse, NewFRCDatasetGroupCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.DatasetGroupName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.DatasetArn != null)
            {
                context.DatasetArn = new List<System.String>(this.DatasetArn);
            }
            context.DatasetGroupName = this.DatasetGroupName;
            #if MODULAR
            if (this.DatasetGroupName == null && ParameterWasBound(nameof(this.DatasetGroupName)))
            {
                WriteWarning("You are passing $null as a value for parameter DatasetGroupName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Domain = this.Domain;
            #if MODULAR
            if (this.Domain == null && ParameterWasBound(nameof(this.Domain)))
            {
                WriteWarning("You are passing $null as a value for parameter Domain which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ForecastService.Model.CreateDatasetGroupRequest();
            
            if (cmdletContext.DatasetArn != null)
            {
                request.DatasetArns = cmdletContext.DatasetArn;
            }
            if (cmdletContext.DatasetGroupName != null)
            {
                request.DatasetGroupName = cmdletContext.DatasetGroupName;
            }
            if (cmdletContext.Domain != null)
            {
                request.Domain = cmdletContext.Domain;
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
        
        private Amazon.ForecastService.Model.CreateDatasetGroupResponse CallAWSServiceOperation(IAmazonForecastService client, Amazon.ForecastService.Model.CreateDatasetGroupRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Forecast Service", "CreateDatasetGroup");
            try
            {
                #if DESKTOP
                return client.CreateDatasetGroup(request);
                #elif CORECLR
                return client.CreateDatasetGroupAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> DatasetArn { get; set; }
            public System.String DatasetGroupName { get; set; }
            public Amazon.ForecastService.Domain Domain { get; set; }
            public System.Func<Amazon.ForecastService.Model.CreateDatasetGroupResponse, NewFRCDatasetGroupCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.DatasetGroupArn;
        }
        
    }
}

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
using Amazon.CostExplorer;
using Amazon.CostExplorer.Model;

namespace Amazon.PowerShell.Cmdlets.CE
{
    /// <summary>
    /// Retrieves all available filter values for a specified filter over a period of time.
    /// You can search the dimension values for an arbitrary string.<br/><br/>In the AWS.Tools.CostExplorer module, this cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "CEDimensionValue")]
    [OutputType("Amazon.CostExplorer.Model.GetDimensionValuesResponse")]
    [AWSCmdlet("Calls the AWS Cost Explorer GetDimensionValues API operation.", Operation = new[] {"GetDimensionValues"}, SelectReturnType = typeof(Amazon.CostExplorer.Model.GetDimensionValuesResponse))]
    [AWSCmdletOutput("Amazon.CostExplorer.Model.GetDimensionValuesResponse",
        "This cmdlet returns an Amazon.CostExplorer.Model.GetDimensionValuesResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetCEDimensionValueCmdlet : AmazonCostExplorerClientCmdlet, IExecutor
    {
        
        #region Parameter Context
        /// <summary>
        /// <para>
        /// <para>The context for the call to <code>GetDimensionValues</code>. This can be <code>RESERVATIONS</code>
        /// or <code>COST_AND_USAGE</code>. The default value is <code>COST_AND_USAGE</code>.
        /// If the context is set to <code>RESERVATIONS</code>, the resulting dimension values
        /// can be used in the <code>GetReservationUtilization</code> operation. If the context
        /// is set to <code>COST_AND_USAGE</code>, the resulting dimension values can be used
        /// in the <code>GetCostAndUsage</code> operation.</para><para>If you set the context to <code>COST_AND_USAGE</code>, you can use the following dimensions
        /// for searching:</para><ul><li><para>AZ - The Availability Zone. An example is <code>us-east-1a</code>.</para></li><li><para>DATABASE_ENGINE - The Amazon Relational Database Service database. Examples are Aurora
        /// or MySQL.</para></li><li><para>INSTANCE_TYPE - The type of Amazon EC2 instance. An example is <code>m4.xlarge</code>.</para></li><li><para>LEGAL_ENTITY_NAME - The name of the organization that sells you AWS services, such
        /// as Amazon Web Services.</para></li><li><para>LINKED_ACCOUNT - The description in the attribute map that includes the full name
        /// of the member account. The value field contains the AWS ID of the member account.</para></li><li><para>OPERATING_SYSTEM - The operating system. Examples are Windows or Linux.</para></li><li><para>OPERATION - The action performed. Examples include <code>RunInstance</code> and <code>CreateBucket</code>.</para></li><li><para>PLATFORM - The Amazon EC2 operating system. Examples are Windows or Linux.</para></li><li><para>PURCHASE_TYPE - The reservation type of the purchase to which this usage is related.
        /// Examples include On-Demand Instances and Standard Reserved Instances.</para></li><li><para>SERVICE - The AWS service such as Amazon DynamoDB.</para></li><li><para>USAGE_TYPE - The type of usage. An example is DataTransfer-In-Bytes. The response
        /// for the <code>GetDimensionValues</code> operation includes a unit attribute. Examples
        /// include GB and Hrs.</para></li><li><para>USAGE_TYPE_GROUP - The grouping of common usage types. An example is Amazon EC2: CloudWatch
        /// – Alarms. The response for this operation includes a unit attribute.</para></li><li><para>RECORD_TYPE - The different types of charges such as RI fees, usage costs, tax refunds,
        /// and credits.</para></li></ul><para>If you set the context to <code>RESERVATIONS</code>, you can use the following dimensions
        /// for searching:</para><ul><li><para>AZ - The Availability Zone. An example is <code>us-east-1a</code>.</para></li><li><para>CACHE_ENGINE - The Amazon ElastiCache operating system. Examples are Windows or Linux.</para></li><li><para>DEPLOYMENT_OPTION - The scope of Amazon Relational Database Service deployments. Valid
        /// values are <code>SingleAZ</code> and <code>MultiAZ</code>.</para></li><li><para>INSTANCE_TYPE - The type of Amazon EC2 instance. An example is <code>m4.xlarge</code>.</para></li><li><para>LINKED_ACCOUNT - The description in the attribute map that includes the full name
        /// of the member account. The value field contains the AWS ID of the member account.</para></li><li><para>PLATFORM - The Amazon EC2 operating system. Examples are Windows or Linux.</para></li><li><para>REGION - The AWS Region.</para></li><li><para>SCOPE (Utilization only) - The scope of a Reserved Instance (RI). Values are regional
        /// or a single Availability Zone.</para></li><li><para>TAG (Coverage only) - The tags that are associated with a Reserved Instance (RI).</para></li><li><para>TENANCY - The tenancy of a resource. Examples are shared or dedicated.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.CostExplorer.Context")]
        public Amazon.CostExplorer.Context Context { get; set; }
        #endregion
        
        #region Parameter Dimension
        /// <summary>
        /// <para>
        /// <para>The name of the dimension. Each <code>Dimension</code> is available for a different
        /// <code>Context</code>. For more information, see <code>Context</code>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.CostExplorer.Dimension")]
        public Amazon.CostExplorer.Dimension Dimension { get; set; }
        #endregion
        
        #region Parameter SearchString
        /// <summary>
        /// <para>
        /// <para>The value that you want to search the filter values for.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SearchString { get; set; }
        #endregion
        
        #region Parameter TimePeriod
        /// <summary>
        /// <para>
        /// <para>The start and end dates for retrieving the dimension values. The start date is inclusive,
        /// but the end date is exclusive. For example, if <code>start</code> is <code>2017-01-01</code>
        /// and <code>end</code> is <code>2017-05-01</code>, then the cost and usage data is retrieved
        /// from <code>2017-01-01</code> up to and including <code>2017-04-30</code> but not including
        /// <code>2017-05-01</code>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public Amazon.CostExplorer.Model.DateInterval TimePeriod { get; set; }
        #endregion
        
        #region Parameter NextPageToken
        /// <summary>
        /// <para>
        /// <para>The token to retrieve the next set of results. AWS provides the token when the response
        /// from a previous call has more results than the maximum page size.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> In the AWS.Tools.CostExplorer module, this parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextPageToken $null' for the first call and '-NextPageToken $AWSHistory.LastServiceResponse.NextPageToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("NextToken")]
        public System.String NextPageToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CostExplorer.Model.GetDimensionValuesResponse).
        /// Specifying the name of a property of type Amazon.CostExplorer.Model.GetDimensionValuesResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the TimePeriod parameter.
        /// The -PassThru parameter is deprecated, use -Select '^TimePeriod' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^TimePeriod' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter NoAutoIteration
        #if MODULAR
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextPageToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
        #endif
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
                context.Select = CreateSelectDelegate<Amazon.CostExplorer.Model.GetDimensionValuesResponse, GetCEDimensionValueCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.TimePeriod;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Context = this.Context;
            context.Dimension = this.Dimension;
            #if MODULAR
            if (this.Dimension == null && ParameterWasBound(nameof(this.Dimension)))
            {
                WriteWarning("You are passing $null as a value for parameter Dimension which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NextPageToken = this.NextPageToken;
            context.SearchString = this.SearchString;
            context.TimePeriod = this.TimePeriod;
            #if MODULAR
            if (this.TimePeriod == null && ParameterWasBound(nameof(this.TimePeriod)))
            {
                WriteWarning("You are passing $null as a value for parameter TimePeriod which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        #if MODULAR
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
            // create request and set iteration invariants
            var request = new Amazon.CostExplorer.Model.GetDimensionValuesRequest();
            
            if (cmdletContext.Context != null)
            {
                request.Context = cmdletContext.Context;
            }
            if (cmdletContext.Dimension != null)
            {
                request.Dimension = cmdletContext.Dimension;
            }
            if (cmdletContext.SearchString != null)
            {
                request.SearchString = cmdletContext.SearchString;
            }
            if (cmdletContext.TimePeriod != null)
            {
                request.TimePeriod = cmdletContext.TimePeriod;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextPageToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextPageToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextPageToken = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.NextPageToken;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #else
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.CostExplorer.Model.GetDimensionValuesRequest();
            
            if (cmdletContext.Context != null)
            {
                request.Context = cmdletContext.Context;
            }
            if (cmdletContext.Dimension != null)
            {
                request.Dimension = cmdletContext.Dimension;
            }
            if (cmdletContext.NextPageToken != null)
            {
                request.NextPageToken = cmdletContext.NextPageToken;
            }
            if (cmdletContext.SearchString != null)
            {
                request.SearchString = cmdletContext.SearchString;
            }
            if (cmdletContext.TimePeriod != null)
            {
                request.TimePeriod = cmdletContext.TimePeriod;
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
        #endif
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.CostExplorer.Model.GetDimensionValuesResponse CallAWSServiceOperation(IAmazonCostExplorer client, Amazon.CostExplorer.Model.GetDimensionValuesRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Cost Explorer", "GetDimensionValues");
            try
            {
                #if DESKTOP
                return client.GetDimensionValues(request);
                #elif CORECLR
                return client.GetDimensionValuesAsync(request).GetAwaiter().GetResult();
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
            public Amazon.CostExplorer.Context Context { get; set; }
            public Amazon.CostExplorer.Dimension Dimension { get; set; }
            public System.String NextPageToken { get; set; }
            public System.String SearchString { get; set; }
            public Amazon.CostExplorer.Model.DateInterval TimePeriod { get; set; }
            public System.Func<Amazon.CostExplorer.Model.GetDimensionValuesResponse, GetCEDimensionValueCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}

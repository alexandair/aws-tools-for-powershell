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
using Amazon.GameLift;
using Amazon.GameLift.Model;

namespace Amazon.PowerShell.Cmdlets.GML
{
    /// <summary>
    /// Retrieves properties for one or more player sessions. This action can be used in several
    /// ways: (1) provide a <code>PlayerSessionId</code> to request properties for a specific
    /// player session; (2) provide a <code>GameSessionId</code> to request properties for
    /// all player sessions in the specified game session; (3) provide a <code>PlayerId</code>
    /// to request properties for all player sessions of a specified player. 
    /// 
    ///  
    /// <para>
    /// To get game session record(s), specify only one of the following: a player session
    /// ID, a game session ID, or a player ID. You can filter this request by player session
    /// status. Use the pagination parameters to retrieve results as a set of sequential pages.
    /// If successful, a <a>PlayerSession</a> object is returned for each session matching
    /// the request.
    /// </para><para><i>Available in Amazon GameLift Local.</i></para><ul><li><para><a>CreatePlayerSession</a></para></li><li><para><a>CreatePlayerSessions</a></para></li><li><para><a>DescribePlayerSessions</a></para></li><li><para>
    /// Game session placements
    /// </para><ul><li><para><a>StartGameSessionPlacement</a></para></li><li><para><a>DescribeGameSessionPlacement</a></para></li><li><para><a>StopGameSessionPlacement</a></para></li></ul></li></ul><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "GMLPlayerSession")]
    [OutputType("Amazon.GameLift.Model.PlayerSession")]
    [AWSCmdlet("Calls the Amazon GameLift Service DescribePlayerSessions API operation.", Operation = new[] {"DescribePlayerSessions"}, SelectReturnType = typeof(Amazon.GameLift.Model.DescribePlayerSessionsResponse))]
    [AWSCmdletOutput("Amazon.GameLift.Model.PlayerSession or Amazon.GameLift.Model.DescribePlayerSessionsResponse",
        "This cmdlet returns a collection of Amazon.GameLift.Model.PlayerSession objects.",
        "The service call response (type Amazon.GameLift.Model.DescribePlayerSessionsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetGMLPlayerSessionCmdlet : AmazonGameLiftClientCmdlet, IExecutor
    {
        
        #region Parameter GameSessionId
        /// <summary>
        /// <para>
        /// <para>Unique identifier for the game session to retrieve player sessions for.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String GameSessionId { get; set; }
        #endregion
        
        #region Parameter PlayerId
        /// <summary>
        /// <para>
        /// <para>Unique identifier for a player to retrieve player sessions for.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PlayerId { get; set; }
        #endregion
        
        #region Parameter PlayerSessionId
        /// <summary>
        /// <para>
        /// <para>Unique identifier for a player session to retrieve.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PlayerSessionId { get; set; }
        #endregion
        
        #region Parameter PlayerSessionStatusFilter
        /// <summary>
        /// <para>
        /// <para>Player session status to filter results on.</para><para>Possible player session statuses include the following:</para><ul><li><para><b>RESERVED</b> -- The player session request has been received, but the player has
        /// not yet connected to the server process and/or been validated. </para></li><li><para><b>ACTIVE</b> -- The player has been validated by the server process and is currently
        /// connected.</para></li><li><para><b>COMPLETED</b> -- The player connection has been dropped.</para></li><li><para><b>TIMEDOUT</b> -- A player session request was received, but the player did not
        /// connect and/or was not validated within the timeout limit (60 seconds).</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PlayerSessionStatusFilter { get; set; }
        #endregion
        
        #region Parameter Limit
        /// <summary>
        /// <para>
        /// <para>Maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages. If a player session ID is specified,
        /// this parameter is ignored.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> In AWSPowerShell and AWSPowerShell.NetCore this parameter is used to limit the total number of items returned by the cmdlet.
        /// <br/>In AWS.Tools this parameter is simply passed to the service to specify how many items should be returned by each service call.
        /// <br/>Pipe the output of this cmdlet into Select-Object -First to terminate retrieving data pages early and control the number of items returned.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxItems")]
        public int? Limit { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>Token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this action. To start at the beginning of
        /// the result set, do not specify a value. If a player session ID is specified, this
        /// parameter is ignored.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextToken $null' for the first call and '-NextToken $AWSHistory.LastServiceResponse.NextToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'PlayerSessions'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameLift.Model.DescribePlayerSessionsResponse).
        /// Specifying the name of a property of type Amazon.GameLift.Model.DescribePlayerSessionsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "PlayerSessions";
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.GameLift.Model.DescribePlayerSessionsResponse, GetGMLPlayerSessionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.GameSessionId = this.GameSessionId;
            context.Limit = this.Limit;
            #if !MODULAR
            if (ParameterWasBound(nameof(this.Limit)) && this.Limit.HasValue)
            {
                WriteWarning("AWSPowerShell and AWSPowerShell.NetCore use the Limit parameter to limit the total number of items returned by the cmdlet." +
                    " This behavior is obsolete and will be removed in a future version of these modules. Pipe the output of this cmdlet into Select-Object -First to terminate" +
                    " retrieving data pages early and control the number of items returned. AWS.Tools already implements the new behavior of simply passing Limit" +
                    " to the service to specify how many items should be returned by each service call.");
            }
            #endif
            context.NextToken = this.NextToken;
            context.PlayerId = this.PlayerId;
            context.PlayerSessionId = this.PlayerSessionId;
            context.PlayerSessionStatusFilter = this.PlayerSessionStatusFilter;
            
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
            var useParameterSelect = this.Select.StartsWith("^");
            
            // create request and set iteration invariants
            var request = new Amazon.GameLift.Model.DescribePlayerSessionsRequest();
            
            if (cmdletContext.GameSessionId != null)
            {
                request.GameSessionId = cmdletContext.GameSessionId;
            }
            if (cmdletContext.Limit != null)
            {
                request.Limit = AutoIterationHelpers.ConvertEmitLimitToServiceTypeInt32(cmdletContext.Limit.Value);
            }
            if (cmdletContext.PlayerId != null)
            {
                request.PlayerId = cmdletContext.PlayerId;
            }
            if (cmdletContext.PlayerSessionId != null)
            {
                request.PlayerSessionId = cmdletContext.PlayerSessionId;
            }
            if (cmdletContext.PlayerSessionStatusFilter != null)
            {
                request.PlayerSessionStatusFilter = cmdletContext.PlayerSessionStatusFilter;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                
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
                    
                    _nextToken = response.NextToken;
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
            var useParameterSelect = this.Select.StartsWith("^");
            
            // create request and set iteration invariants
            var request = new Amazon.GameLift.Model.DescribePlayerSessionsRequest();
            if (cmdletContext.GameSessionId != null)
            {
                request.GameSessionId = cmdletContext.GameSessionId;
            }
            if (cmdletContext.PlayerId != null)
            {
                request.PlayerId = cmdletContext.PlayerId;
            }
            if (cmdletContext.PlayerSessionId != null)
            {
                request.PlayerSessionId = cmdletContext.PlayerSessionId;
            }
            if (cmdletContext.PlayerSessionStatusFilter != null)
            {
                request.PlayerSessionStatusFilter = cmdletContext.PlayerSessionStatusFilter;
            }
            
            // Initialize loop variants and commence piping
            System.String _nextToken = null;
            int? _emitLimit = null;
            int _retrievedSoFar = 0;
            if (AutoIterationHelpers.HasValue(cmdletContext.NextToken))
            {
                _nextToken = cmdletContext.NextToken;
            }
            if (AutoIterationHelpers.HasValue(cmdletContext.Limit))
            {
                _emitLimit = cmdletContext.Limit;
            }
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                if (_emitLimit.HasValue)
                {
                    request.Limit = AutoIterationHelpers.ConvertEmitLimitToInt32(_emitLimit.Value);
                }
                
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
                    int _receivedThisCall = response.PlayerSessions.Count;
                    
                    _nextToken = response.NextToken;
                    _retrievedSoFar += _receivedThisCall;
                    if (_emitLimit.HasValue)
                    {
                        _emitLimit -= _receivedThisCall;
                    }
                }
                catch (Exception e)
                {
                    if (_retrievedSoFar == 0 || !_emitLimit.HasValue)
                    {
                        output = new CmdletOutput { ErrorResponse = e };
                    }
                    else
                    {
                        break;
                    }
                }
                
                ProcessOutput(output);
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken) && (!_emitLimit.HasValue || _emitLimit.Value >= 1));
            
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #endif
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.GameLift.Model.DescribePlayerSessionsResponse CallAWSServiceOperation(IAmazonGameLift client, Amazon.GameLift.Model.DescribePlayerSessionsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameLift Service", "DescribePlayerSessions");
            try
            {
                #if DESKTOP
                return client.DescribePlayerSessions(request);
                #elif CORECLR
                return client.DescribePlayerSessionsAsync(request).GetAwaiter().GetResult();
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
            public System.String GameSessionId { get; set; }
            public int? Limit { get; set; }
            public System.String NextToken { get; set; }
            public System.String PlayerId { get; set; }
            public System.String PlayerSessionId { get; set; }
            public System.String PlayerSessionStatusFilter { get; set; }
            public System.Func<Amazon.GameLift.Model.DescribePlayerSessionsResponse, GetGMLPlayerSessionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.PlayerSessions;
        }
        
    }
}

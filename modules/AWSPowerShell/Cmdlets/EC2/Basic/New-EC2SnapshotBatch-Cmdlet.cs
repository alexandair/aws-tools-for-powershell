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
using Amazon.EC2;
using Amazon.EC2.Model;

namespace Amazon.PowerShell.Cmdlets.EC2
{
    /// <summary>
    /// Creates crash-consistent snapshots of multiple EBS volumes and stores the data in
    /// S3. Volumes are chosen by specifying an instance. Any attached volumes will produce
    /// one snapshot each that is crash-consistent across the instance. Boot volumes can be
    /// excluded by changing the paramaters.
    /// </summary>
    [Cmdlet("New", "EC2SnapshotBatch", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.EC2.Model.SnapshotInfo")]
    [AWSCmdlet("Calls the Amazon Elastic Compute Cloud (EC2) CreateSnapshots API operation.", Operation = new[] {"CreateSnapshots"}, SelectReturnType = typeof(Amazon.EC2.Model.CreateSnapshotsResponse))]
    [AWSCmdletOutput("Amazon.EC2.Model.SnapshotInfo or Amazon.EC2.Model.CreateSnapshotsResponse",
        "This cmdlet returns a collection of Amazon.EC2.Model.SnapshotInfo objects.",
        "The service call response (type Amazon.EC2.Model.CreateSnapshotsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewEC2SnapshotBatchCmdlet : AmazonEC2ClientCmdlet, IExecutor
    {
        
        #region Parameter CopyTagsFromSource
        /// <summary>
        /// <para>
        /// <para>Copies the tags from the specified volume to corresponding snapshot.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.EC2.CopyTagsFromSource")]
        public Amazon.EC2.CopyTagsFromSource CopyTagsFromSource { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para> A description propagated to every snapshot specified by the instance.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter InstanceSpecification_ExcludeBootVolume
        /// <summary>
        /// <para>
        /// <para>Excludes the root volume from being snapshotted.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? InstanceSpecification_ExcludeBootVolume { get; set; }
        #endregion
        
        #region Parameter InstanceSpecification_InstanceId
        /// <summary>
        /// <para>
        /// <para>The instance to specify which volumes should be snapshotted.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String InstanceSpecification_InstanceId { get; set; }
        #endregion
        
        #region Parameter TagSpecification
        /// <summary>
        /// <para>
        /// <para>Tags to apply to every snapshot specified by the instance.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TagSpecifications")]
        public Amazon.EC2.Model.TagSpecification[] TagSpecification { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Snapshots'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.EC2.Model.CreateSnapshotsResponse).
        /// Specifying the name of a property of type Amazon.EC2.Model.CreateSnapshotsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Snapshots";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the InstanceSpecification_InstanceId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^InstanceSpecification_InstanceId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^InstanceSpecification_InstanceId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.InstanceSpecification_InstanceId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-EC2SnapshotBatch (CreateSnapshots)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.EC2.Model.CreateSnapshotsResponse, NewEC2SnapshotBatchCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.InstanceSpecification_InstanceId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CopyTagsFromSource = this.CopyTagsFromSource;
            context.Description = this.Description;
            context.InstanceSpecification_ExcludeBootVolume = this.InstanceSpecification_ExcludeBootVolume;
            context.InstanceSpecification_InstanceId = this.InstanceSpecification_InstanceId;
            if (this.TagSpecification != null)
            {
                context.TagSpecification = new List<Amazon.EC2.Model.TagSpecification>(this.TagSpecification);
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
            var request = new Amazon.EC2.Model.CreateSnapshotsRequest();
            
            if (cmdletContext.CopyTagsFromSource != null)
            {
                request.CopyTagsFromSource = cmdletContext.CopyTagsFromSource;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            
             // populate InstanceSpecification
            var requestInstanceSpecificationIsNull = true;
            request.InstanceSpecification = new Amazon.EC2.Model.InstanceSpecification();
            System.Boolean? requestInstanceSpecification_instanceSpecification_ExcludeBootVolume = null;
            if (cmdletContext.InstanceSpecification_ExcludeBootVolume != null)
            {
                requestInstanceSpecification_instanceSpecification_ExcludeBootVolume = cmdletContext.InstanceSpecification_ExcludeBootVolume.Value;
            }
            if (requestInstanceSpecification_instanceSpecification_ExcludeBootVolume != null)
            {
                request.InstanceSpecification.ExcludeBootVolume = requestInstanceSpecification_instanceSpecification_ExcludeBootVolume.Value;
                requestInstanceSpecificationIsNull = false;
            }
            System.String requestInstanceSpecification_instanceSpecification_InstanceId = null;
            if (cmdletContext.InstanceSpecification_InstanceId != null)
            {
                requestInstanceSpecification_instanceSpecification_InstanceId = cmdletContext.InstanceSpecification_InstanceId;
            }
            if (requestInstanceSpecification_instanceSpecification_InstanceId != null)
            {
                request.InstanceSpecification.InstanceId = requestInstanceSpecification_instanceSpecification_InstanceId;
                requestInstanceSpecificationIsNull = false;
            }
             // determine if request.InstanceSpecification should be set to null
            if (requestInstanceSpecificationIsNull)
            {
                request.InstanceSpecification = null;
            }
            if (cmdletContext.TagSpecification != null)
            {
                request.TagSpecifications = cmdletContext.TagSpecification;
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
        
        private Amazon.EC2.Model.CreateSnapshotsResponse CallAWSServiceOperation(IAmazonEC2 client, Amazon.EC2.Model.CreateSnapshotsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Elastic Compute Cloud (EC2)", "CreateSnapshots");
            try
            {
                #if DESKTOP
                return client.CreateSnapshots(request);
                #elif CORECLR
                return client.CreateSnapshotsAsync(request).GetAwaiter().GetResult();
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
            public Amazon.EC2.CopyTagsFromSource CopyTagsFromSource { get; set; }
            public System.String Description { get; set; }
            public System.Boolean? InstanceSpecification_ExcludeBootVolume { get; set; }
            public System.String InstanceSpecification_InstanceId { get; set; }
            public List<Amazon.EC2.Model.TagSpecification> TagSpecification { get; set; }
            public System.Func<Amazon.EC2.Model.CreateSnapshotsResponse, NewEC2SnapshotBatchCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Snapshots;
        }
        
    }
}

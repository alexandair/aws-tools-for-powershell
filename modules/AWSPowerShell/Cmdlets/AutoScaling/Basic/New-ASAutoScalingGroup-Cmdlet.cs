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
using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

namespace Amazon.PowerShell.Cmdlets.AS
{
    /// <summary>
    /// Creates an Auto Scaling group with the specified name and attributes.
    /// 
    ///  
    /// <para>
    /// If you exceed your maximum limit of Auto Scaling groups, the call fails. For information
    /// about viewing this limit, see <a>DescribeAccountLimits</a>. For information about
    /// updating this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
    /// EC2 Auto Scaling Limits</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    [Cmdlet("New", "ASAutoScalingGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the AWS Auto Scaling CreateAutoScalingGroup API operation.", Operation = new[] {"CreateAutoScalingGroup"}, SelectReturnType = typeof(Amazon.AutoScaling.Model.CreateAutoScalingGroupResponse))]
    [AWSCmdletOutput("None or Amazon.AutoScaling.Model.CreateAutoScalingGroupResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.AutoScaling.Model.CreateAutoScalingGroupResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewASAutoScalingGroupCmdlet : AmazonAutoScalingClientCmdlet, IExecutor
    {
        
        #region Parameter AutoScalingGroupName
        /// <summary>
        /// <para>
        /// <para>The name of the Auto Scaling group. This name must be unique per Region per account.</para>
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
        public System.String AutoScalingGroupName { get; set; }
        #endregion
        
        #region Parameter AvailabilityZone
        /// <summary>
        /// <para>
        /// <para>One or more Availability Zones for the group. This parameter is optional if you specify
        /// one or more subnets for <code>VPCZoneIdentifier</code>.</para><para>Conditional: If your account supports EC2-Classic and VPC, this parameter is required
        /// to launch instances into EC2-Classic.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AvailabilityZones")]
        public System.String[] AvailabilityZone { get; set; }
        #endregion
        
        #region Parameter DefaultCooldown
        /// <summary>
        /// <para>
        /// <para>The amount of time, in seconds, after a scaling activity completes before another
        /// scaling activity can start. The default value is <code>300</code>.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/Cooldown.html">Scaling
        /// Cooldowns</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? DefaultCooldown { get; set; }
        #endregion
        
        #region Parameter DesiredCapacity
        /// <summary>
        /// <para>
        /// <para>The number of Amazon EC2 instances that the Auto Scaling group attempts to maintain.
        /// This number must be greater than or equal to the minimum size of the group and less
        /// than or equal to the maximum size of the group. If you do not specify a desired capacity,
        /// the default is the minimum size of the group.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? DesiredCapacity { get; set; }
        #endregion
        
        #region Parameter HealthCheckGracePeriod
        /// <summary>
        /// <para>
        /// <para>The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before checking
        /// the health status of an EC2 instance that has come into service. During this time,
        /// any health check failures for the instance are ignored. The default value is <code>0</code>.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html#health-check-grace-period">Health
        /// Check Grace Period</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.</para><para>Conditional: This parameter is required if you are adding an <code>ELB</code> health
        /// check.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? HealthCheckGracePeriod { get; set; }
        #endregion
        
        #region Parameter HealthCheckType
        /// <summary>
        /// <para>
        /// <para>The service to use for the health checks. The valid values are <code>EC2</code> and
        /// <code>ELB</code>. The default value is <code>EC2</code>. If you configure an Auto
        /// Scaling group to use ELB health checks, it considers the instance unhealthy if it
        /// fails either the EC2 status checks or the load balancer health checks.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// Checks for Auto Scaling Instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String HealthCheckType { get; set; }
        #endregion
        
        #region Parameter InstanceId
        /// <summary>
        /// <para>
        /// <para>The ID of the instance used to create a launch configuration for the group.</para><para>When you specify an ID of an instance, Amazon EC2 Auto Scaling creates a new launch
        /// configuration and associates it with the group. This launch configuration derives
        /// its attributes from the specified instance, except for the block device mapping.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-asg-from-instance.html">Create
        /// an Auto Scaling Group Using an EC2 Instance</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.</para><para>You must specify one of the following parameters in your request: <code>LaunchConfigurationName</code>,
        /// <code>LaunchTemplate</code>, <code>InstanceId</code>, or <code>MixedInstancesPolicy</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String InstanceId { get; set; }
        #endregion
        
        #region Parameter LaunchConfigurationName
        /// <summary>
        /// <para>
        /// <para>The name of the launch configuration.</para><para>If you do not specify <code>LaunchConfigurationName</code>, you must specify one of
        /// the following parameters: <code>InstanceId</code>, <code>LaunchTemplate</code>, or
        /// <code>MixedInstancesPolicy</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        public System.String LaunchConfigurationName { get; set; }
        #endregion
        
        #region Parameter LaunchTemplate_LaunchTemplateId
        /// <summary>
        /// <para>
        /// <para>The ID of the launch template. You must specify either a template ID or a template
        /// name.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LaunchTemplate_LaunchTemplateId { get; set; }
        #endregion
        
        #region Parameter LaunchTemplate_LaunchTemplateName
        /// <summary>
        /// <para>
        /// <para>The name of the launch template. You must specify either a template name or a template
        /// ID.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LaunchTemplate_LaunchTemplateName { get; set; }
        #endregion
        
        #region Parameter LifecycleHookSpecificationList
        /// <summary>
        /// <para>
        /// <para>One or more lifecycle hooks.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.AutoScaling.Model.LifecycleHookSpecification[] LifecycleHookSpecificationList { get; set; }
        #endregion
        
        #region Parameter LoadBalancerName
        /// <summary>
        /// <para>
        /// <para>A list of Classic Load Balancers associated with this Auto Scaling group. For Application
        /// Load Balancers and Network Load Balancers, specify a list of target groups using the
        /// <code>TargetGroupARNs</code> property instead.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Using
        /// a Load Balancer with an Auto Scaling Group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("LoadBalancerNames")]
        public System.String[] LoadBalancerName { get; set; }
        #endregion
        
        #region Parameter MaxSize
        /// <summary>
        /// <para>
        /// <para>The maximum size of the group.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 3, ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(Position = 3, ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Int32? MaxSize { get; set; }
        #endregion
        
        #region Parameter MinSize
        /// <summary>
        /// <para>
        /// <para>The minimum size of the group.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Int32? MinSize { get; set; }
        #endregion
        
        #region Parameter MixedInstancesPolicy
        /// <summary>
        /// <para>
        /// <para>An embedded object that specifies a mixed instances policy. The required parameters
        /// must be specified. If optional parameters are unspecified, their default values are
        /// used.</para><para>The policy includes parameters that not only define the distribution of On-Demand
        /// Instances and Spot Instances, the maximum price to pay for Spot Instances, and how
        /// the Auto Scaling group allocates instance types to fulfill On-Demand and Spot capacity,
        /// but also the parameters that specify the instance configuration information—the launch
        /// template and instance types.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_MixedInstancesPolicy.html">MixedInstancesPolicy</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-purchase-options.html">Auto
        /// Scaling Groups with Multiple Instance Types and Purchase Options</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.</para><para>You must specify one of the following parameters in your request: <code>LaunchConfigurationName</code>,
        /// <code>LaunchTemplate</code>, <code>InstanceId</code>, or <code>MixedInstancesPolicy</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.AutoScaling.Model.MixedInstancesPolicy MixedInstancesPolicy { get; set; }
        #endregion
        
        #region Parameter NewInstancesProtectedFromScaleIn
        /// <summary>
        /// <para>
        /// <para>Indicates whether newly launched instances are protected from termination by Amazon
        /// EC2 Auto Scaling when scaling in.</para><para>For more information about preventing instances from terminating on scale in, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// Protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? NewInstancesProtectedFromScaleIn { get; set; }
        #endregion
        
        #region Parameter PlacementGroup
        /// <summary>
        /// <para>
        /// <para>The name of the placement group into which to launch your instances, if any. A placement
        /// group is a logical grouping of instances within a single Availability Zone. You cannot
        /// specify multiple Availability Zones and a placement group. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PlacementGroup { get; set; }
        #endregion
        
        #region Parameter ServiceLinkedRoleARN
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group
        /// uses to call other AWS services on your behalf. By default, Amazon EC2 Auto Scaling
        /// uses a service-linked role named AWSServiceRoleForAutoScaling, which it creates if
        /// it does not exist. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-service-linked-role.html">Service-Linked
        /// Roles</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ServiceLinkedRoleARN { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>One or more tags.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling Groups and Instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.AutoScaling.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter TargetGroupARNs
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Names (ARN) of the target groups to associate with the Auto Scaling
        /// group. Instances are registered as targets in a target group, and traffic is routed
        /// to the target group.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Using
        /// a Load Balancer with an Auto Scaling Group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] TargetGroupARNs { get; set; }
        #endregion
        
        #region Parameter TerminationPolicy
        /// <summary>
        /// <para>
        /// <para>One or more termination policies used to select the instance to terminate. These policies
        /// are executed in the order that they are listed.</para><para>For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// Which Instances Auto Scaling Terminates During Scale In</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TerminationPolicies")]
        public System.String[] TerminationPolicy { get; set; }
        #endregion
        
        #region Parameter LaunchTemplate_Version
        /// <summary>
        /// <para>
        /// <para>The version number, <code>$Latest</code>, or <code>$Default</code>. If the value is
        /// <code>$Latest</code>, Amazon EC2 Auto Scaling selects the latest version of the launch
        /// template when launching instances. If the value is <code>$Default</code>, Amazon EC2
        /// Auto Scaling selects the default version of the launch template when launching instances.
        /// The default value is <code>$Default</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LaunchTemplate_Version { get; set; }
        #endregion
        
        #region Parameter VPCZoneIdentifier
        /// <summary>
        /// <para>
        /// <para>A comma-separated list of subnet IDs for your virtual private cloud (VPC).</para><para>If you specify <code>VPCZoneIdentifier</code> with <code>AvailabilityZones</code>,
        /// the subnets that you specify for this parameter must reside in those Availability
        /// Zones.</para><para>Conditional: If your account supports EC2-Classic and VPC, this parameter is required
        /// to launch instances into a VPC.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String VPCZoneIdentifier { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AutoScaling.Model.CreateAutoScalingGroupResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AutoScalingGroupName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AutoScalingGroupName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AutoScalingGroupName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AutoScalingGroupName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-ASAutoScalingGroup (CreateAutoScalingGroup)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AutoScaling.Model.CreateAutoScalingGroupResponse, NewASAutoScalingGroupCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AutoScalingGroupName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AutoScalingGroupName = this.AutoScalingGroupName;
            #if MODULAR
            if (this.AutoScalingGroupName == null && ParameterWasBound(nameof(this.AutoScalingGroupName)))
            {
                WriteWarning("You are passing $null as a value for parameter AutoScalingGroupName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.AvailabilityZone != null)
            {
                context.AvailabilityZone = new List<System.String>(this.AvailabilityZone);
            }
            context.DefaultCooldown = this.DefaultCooldown;
            context.DesiredCapacity = this.DesiredCapacity;
            context.HealthCheckGracePeriod = this.HealthCheckGracePeriod;
            context.HealthCheckType = this.HealthCheckType;
            context.InstanceId = this.InstanceId;
            context.LaunchConfigurationName = this.LaunchConfigurationName;
            context.LaunchTemplate_LaunchTemplateId = this.LaunchTemplate_LaunchTemplateId;
            context.LaunchTemplate_LaunchTemplateName = this.LaunchTemplate_LaunchTemplateName;
            context.LaunchTemplate_Version = this.LaunchTemplate_Version;
            if (this.LifecycleHookSpecificationList != null)
            {
                context.LifecycleHookSpecificationList = new List<Amazon.AutoScaling.Model.LifecycleHookSpecification>(this.LifecycleHookSpecificationList);
            }
            if (this.LoadBalancerName != null)
            {
                context.LoadBalancerName = new List<System.String>(this.LoadBalancerName);
            }
            context.MaxSize = this.MaxSize;
            #if MODULAR
            if (this.MaxSize == null && ParameterWasBound(nameof(this.MaxSize)))
            {
                WriteWarning("You are passing $null as a value for parameter MaxSize which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MinSize = this.MinSize;
            #if MODULAR
            if (this.MinSize == null && ParameterWasBound(nameof(this.MinSize)))
            {
                WriteWarning("You are passing $null as a value for parameter MinSize which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MixedInstancesPolicy = this.MixedInstancesPolicy;
            context.NewInstancesProtectedFromScaleIn = this.NewInstancesProtectedFromScaleIn;
            context.PlacementGroup = this.PlacementGroup;
            context.ServiceLinkedRoleARN = this.ServiceLinkedRoleARN;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.AutoScaling.Model.Tag>(this.Tag);
            }
            if (this.TargetGroupARNs != null)
            {
                context.TargetGroupARNs = new List<System.String>(this.TargetGroupARNs);
            }
            if (this.TerminationPolicy != null)
            {
                context.TerminationPolicy = new List<System.String>(this.TerminationPolicy);
            }
            context.VPCZoneIdentifier = this.VPCZoneIdentifier;
            
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
            var request = new Amazon.AutoScaling.Model.CreateAutoScalingGroupRequest();
            
            if (cmdletContext.AutoScalingGroupName != null)
            {
                request.AutoScalingGroupName = cmdletContext.AutoScalingGroupName;
            }
            if (cmdletContext.AvailabilityZone != null)
            {
                request.AvailabilityZones = cmdletContext.AvailabilityZone;
            }
            if (cmdletContext.DefaultCooldown != null)
            {
                request.DefaultCooldown = cmdletContext.DefaultCooldown.Value;
            }
            if (cmdletContext.DesiredCapacity != null)
            {
                request.DesiredCapacity = cmdletContext.DesiredCapacity.Value;
            }
            if (cmdletContext.HealthCheckGracePeriod != null)
            {
                request.HealthCheckGracePeriod = cmdletContext.HealthCheckGracePeriod.Value;
            }
            if (cmdletContext.HealthCheckType != null)
            {
                request.HealthCheckType = cmdletContext.HealthCheckType;
            }
            if (cmdletContext.InstanceId != null)
            {
                request.InstanceId = cmdletContext.InstanceId;
            }
            if (cmdletContext.LaunchConfigurationName != null)
            {
                request.LaunchConfigurationName = cmdletContext.LaunchConfigurationName;
            }
            
             // populate LaunchTemplate
            var requestLaunchTemplateIsNull = true;
            request.LaunchTemplate = new Amazon.AutoScaling.Model.LaunchTemplateSpecification();
            System.String requestLaunchTemplate_launchTemplate_LaunchTemplateId = null;
            if (cmdletContext.LaunchTemplate_LaunchTemplateId != null)
            {
                requestLaunchTemplate_launchTemplate_LaunchTemplateId = cmdletContext.LaunchTemplate_LaunchTemplateId;
            }
            if (requestLaunchTemplate_launchTemplate_LaunchTemplateId != null)
            {
                request.LaunchTemplate.LaunchTemplateId = requestLaunchTemplate_launchTemplate_LaunchTemplateId;
                requestLaunchTemplateIsNull = false;
            }
            System.String requestLaunchTemplate_launchTemplate_LaunchTemplateName = null;
            if (cmdletContext.LaunchTemplate_LaunchTemplateName != null)
            {
                requestLaunchTemplate_launchTemplate_LaunchTemplateName = cmdletContext.LaunchTemplate_LaunchTemplateName;
            }
            if (requestLaunchTemplate_launchTemplate_LaunchTemplateName != null)
            {
                request.LaunchTemplate.LaunchTemplateName = requestLaunchTemplate_launchTemplate_LaunchTemplateName;
                requestLaunchTemplateIsNull = false;
            }
            System.String requestLaunchTemplate_launchTemplate_Version = null;
            if (cmdletContext.LaunchTemplate_Version != null)
            {
                requestLaunchTemplate_launchTemplate_Version = cmdletContext.LaunchTemplate_Version;
            }
            if (requestLaunchTemplate_launchTemplate_Version != null)
            {
                request.LaunchTemplate.Version = requestLaunchTemplate_launchTemplate_Version;
                requestLaunchTemplateIsNull = false;
            }
             // determine if request.LaunchTemplate should be set to null
            if (requestLaunchTemplateIsNull)
            {
                request.LaunchTemplate = null;
            }
            if (cmdletContext.LifecycleHookSpecificationList != null)
            {
                request.LifecycleHookSpecificationList = cmdletContext.LifecycleHookSpecificationList;
            }
            if (cmdletContext.LoadBalancerName != null)
            {
                request.LoadBalancerNames = cmdletContext.LoadBalancerName;
            }
            if (cmdletContext.MaxSize != null)
            {
                request.MaxSize = cmdletContext.MaxSize.Value;
            }
            if (cmdletContext.MinSize != null)
            {
                request.MinSize = cmdletContext.MinSize.Value;
            }
            if (cmdletContext.MixedInstancesPolicy != null)
            {
                request.MixedInstancesPolicy = cmdletContext.MixedInstancesPolicy;
            }
            if (cmdletContext.NewInstancesProtectedFromScaleIn != null)
            {
                request.NewInstancesProtectedFromScaleIn = cmdletContext.NewInstancesProtectedFromScaleIn.Value;
            }
            if (cmdletContext.PlacementGroup != null)
            {
                request.PlacementGroup = cmdletContext.PlacementGroup;
            }
            if (cmdletContext.ServiceLinkedRoleARN != null)
            {
                request.ServiceLinkedRoleARN = cmdletContext.ServiceLinkedRoleARN;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.TargetGroupARNs != null)
            {
                request.TargetGroupARNs = cmdletContext.TargetGroupARNs;
            }
            if (cmdletContext.TerminationPolicy != null)
            {
                request.TerminationPolicies = cmdletContext.TerminationPolicy;
            }
            if (cmdletContext.VPCZoneIdentifier != null)
            {
                request.VPCZoneIdentifier = cmdletContext.VPCZoneIdentifier;
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
        
        private Amazon.AutoScaling.Model.CreateAutoScalingGroupResponse CallAWSServiceOperation(IAmazonAutoScaling client, Amazon.AutoScaling.Model.CreateAutoScalingGroupRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Auto Scaling", "CreateAutoScalingGroup");
            try
            {
                #if DESKTOP
                return client.CreateAutoScalingGroup(request);
                #elif CORECLR
                return client.CreateAutoScalingGroupAsync(request).GetAwaiter().GetResult();
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
            public System.String AutoScalingGroupName { get; set; }
            public List<System.String> AvailabilityZone { get; set; }
            public System.Int32? DefaultCooldown { get; set; }
            public System.Int32? DesiredCapacity { get; set; }
            public System.Int32? HealthCheckGracePeriod { get; set; }
            public System.String HealthCheckType { get; set; }
            public System.String InstanceId { get; set; }
            public System.String LaunchConfigurationName { get; set; }
            public System.String LaunchTemplate_LaunchTemplateId { get; set; }
            public System.String LaunchTemplate_LaunchTemplateName { get; set; }
            public System.String LaunchTemplate_Version { get; set; }
            public List<Amazon.AutoScaling.Model.LifecycleHookSpecification> LifecycleHookSpecificationList { get; set; }
            public List<System.String> LoadBalancerName { get; set; }
            public System.Int32? MaxSize { get; set; }
            public System.Int32? MinSize { get; set; }
            public Amazon.AutoScaling.Model.MixedInstancesPolicy MixedInstancesPolicy { get; set; }
            public System.Boolean? NewInstancesProtectedFromScaleIn { get; set; }
            public System.String PlacementGroup { get; set; }
            public System.String ServiceLinkedRoleARN { get; set; }
            public List<Amazon.AutoScaling.Model.Tag> Tag { get; set; }
            public List<System.String> TargetGroupARNs { get; set; }
            public List<System.String> TerminationPolicy { get; set; }
            public System.String VPCZoneIdentifier { get; set; }
            public System.Func<Amazon.AutoScaling.Model.CreateAutoScalingGroupResponse, NewASAutoScalingGroupCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}

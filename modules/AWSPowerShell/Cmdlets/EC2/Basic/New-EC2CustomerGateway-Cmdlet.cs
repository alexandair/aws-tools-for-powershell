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
    /// Provides information to AWS about your VPN customer gateway device. The customer gateway
    /// is the appliance at your end of the VPN connection. (The device on the AWS side of
    /// the VPN connection is the virtual private gateway.) You must provide the Internet-routable
    /// IP address of the customer gateway's external interface. The IP address must be static
    /// and can be behind a device performing network address translation (NAT).
    /// 
    ///  
    /// <para>
    /// For devices that use Border Gateway Protocol (BGP), you can also provide the device's
    /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
    /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534
    /// range).
    /// </para><note><para>
    /// Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception
    /// of 7224, which is reserved in the <code>us-east-1</code> Region, and 9059, which is
    /// reserved in the <code>eu-west-1</code> Region.
    /// </para></note><para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
    /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
    /// </para><important><para>
    /// You cannot create more than one customer gateway with the same VPN type, IP address,
    /// and BGP ASN parameter values. If you run an identical request more than one time,
    /// the first request creates the customer gateway, and subsequent requests return information
    /// about the existing customer gateway. The subsequent requests do not create new customer
    /// gateway resources.
    /// </para></important>
    /// </summary>
    [Cmdlet("New", "EC2CustomerGateway", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.EC2.Model.CustomerGateway")]
    [AWSCmdlet("Calls the Amazon Elastic Compute Cloud (EC2) CreateCustomerGateway API operation.", Operation = new[] {"CreateCustomerGateway"}, SelectReturnType = typeof(Amazon.EC2.Model.CreateCustomerGatewayResponse))]
    [AWSCmdletOutput("Amazon.EC2.Model.CustomerGateway or Amazon.EC2.Model.CreateCustomerGatewayResponse",
        "This cmdlet returns an Amazon.EC2.Model.CustomerGateway object.",
        "The service call response (type Amazon.EC2.Model.CreateCustomerGatewayResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewEC2CustomerGatewayCmdlet : AmazonEC2ClientCmdlet, IExecutor
    {
        
        #region Parameter BgpAsn
        /// <summary>
        /// <para>
        /// <para>For devices that support BGP, the customer gateway's BGP ASN.</para><para>Default: 65000</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(Position = 2, ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Int32? BgpAsn { get; set; }
        #endregion
        
        #region Parameter CertificateArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) for the customer gateway certificate.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CertificateArn { get; set; }
        #endregion
        
        #region Parameter PublicIp
        /// <summary>
        /// <para>
        /// <para>The Internet-routable IP address for the customer gateway's outside interface. The
        /// address must be static.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        [Alias("IpAddress")]
        public System.String PublicIp { get; set; }
        #endregion
        
        #region Parameter Type
        /// <summary>
        /// <para>
        /// <para>The type of VPN connection that this customer gateway supports (<code>ipsec.1</code>).</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.EC2.GatewayType")]
        public Amazon.EC2.GatewayType Type { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'CustomerGateway'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.EC2.Model.CreateCustomerGatewayResponse).
        /// Specifying the name of a property of type Amazon.EC2.Model.CreateCustomerGatewayResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "CustomerGateway";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Type parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Type' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Type' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Type), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-EC2CustomerGateway (CreateCustomerGateway)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.EC2.Model.CreateCustomerGatewayResponse, NewEC2CustomerGatewayCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Type;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.BgpAsn = this.BgpAsn;
            #if MODULAR
            if (this.BgpAsn == null && ParameterWasBound(nameof(this.BgpAsn)))
            {
                WriteWarning("You are passing $null as a value for parameter BgpAsn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.CertificateArn = this.CertificateArn;
            context.PublicIp = this.PublicIp;
            context.Type = this.Type;
            #if MODULAR
            if (this.Type == null && ParameterWasBound(nameof(this.Type)))
            {
                WriteWarning("You are passing $null as a value for parameter Type which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.EC2.Model.CreateCustomerGatewayRequest();
            
            if (cmdletContext.BgpAsn != null)
            {
                request.BgpAsn = cmdletContext.BgpAsn.Value;
            }
            if (cmdletContext.CertificateArn != null)
            {
                request.CertificateArn = cmdletContext.CertificateArn;
            }
            if (cmdletContext.PublicIp != null)
            {
                request.PublicIp = cmdletContext.PublicIp;
            }
            if (cmdletContext.Type != null)
            {
                request.Type = cmdletContext.Type;
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
        
        private Amazon.EC2.Model.CreateCustomerGatewayResponse CallAWSServiceOperation(IAmazonEC2 client, Amazon.EC2.Model.CreateCustomerGatewayRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Elastic Compute Cloud (EC2)", "CreateCustomerGateway");
            try
            {
                #if DESKTOP
                return client.CreateCustomerGateway(request);
                #elif CORECLR
                return client.CreateCustomerGatewayAsync(request).GetAwaiter().GetResult();
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
            public System.Int32? BgpAsn { get; set; }
            public System.String CertificateArn { get; set; }
            public System.String PublicIp { get; set; }
            public Amazon.EC2.GatewayType Type { get; set; }
            public System.Func<Amazon.EC2.Model.CreateCustomerGatewayResponse, NewEC2CustomerGatewayCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.CustomerGateway;
        }
        
    }
}

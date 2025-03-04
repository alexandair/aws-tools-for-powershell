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
using Amazon.Budgets;
using Amazon.Budgets.Model;

namespace Amazon.PowerShell.Cmdlets.BGT
{
    /// <summary>
    /// Creates a budget and, if included, notifications and subscribers. 
    /// 
    ///  <important><para>
    /// Only one of <code>BudgetLimit</code> or <code>PlannedBudgetLimits</code> can be present
    /// in the syntax at one time. Use the syntax that matches your case. The Request Syntax
    /// section shows the <code>BudgetLimit</code> syntax. For <code>PlannedBudgetLimits</code>,
    /// see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_CreateBudget.html#API_CreateBudget_Examples">Examples</a>
    /// section. 
    /// </para></important>
    /// </summary>
    [Cmdlet("New", "BGTBudget", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the AWS Budgets CreateBudget API operation.", Operation = new[] {"CreateBudget"}, SelectReturnType = typeof(Amazon.Budgets.Model.CreateBudgetResponse))]
    [AWSCmdletOutput("None or Amazon.Budgets.Model.CreateBudgetResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.Budgets.Model.CreateBudgetResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewBGTBudgetCmdlet : AmazonBudgetsClientCmdlet, IExecutor
    {
        
        #region Parameter AccountId
        /// <summary>
        /// <para>
        /// <para>The <code>accountId</code> that is associated with the budget.</para>
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
        public System.String AccountId { get; set; }
        #endregion
        
        #region Parameter BudgetLimit_Amount
        /// <summary>
        /// <para>
        /// <para>The cost or usage amount that is associated with a budget forecast, actual spend,
        /// or budget threshold.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_BudgetLimit_Amount")]
        public System.Decimal? BudgetLimit_Amount { get; set; }
        #endregion
        
        #region Parameter ActualSpend_Amount
        /// <summary>
        /// <para>
        /// <para>The cost or usage amount that is associated with a budget forecast, actual spend,
        /// or budget threshold.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CalculatedSpend_ActualSpend_Amount")]
        public System.Decimal? ActualSpend_Amount { get; set; }
        #endregion
        
        #region Parameter ForecastedSpend_Amount
        /// <summary>
        /// <para>
        /// <para>The cost or usage amount that is associated with a budget forecast, actual spend,
        /// or budget threshold.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CalculatedSpend_ForecastedSpend_Amount")]
        public System.Decimal? ForecastedSpend_Amount { get; set; }
        #endregion
        
        #region Parameter Budget_BudgetName
        /// <summary>
        /// <para>
        /// <para>The name of a budget. The name must be unique within an account. The <code>:</code>
        /// and <code>\</code> characters aren't allowed in <code>BudgetName</code>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Budget_BudgetName { get; set; }
        #endregion
        
        #region Parameter Budget_BudgetType
        /// <summary>
        /// <para>
        /// <para>Whether this budget tracks costs, usage, RI utilization, or RI coverage.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Budgets.BudgetType")]
        public Amazon.Budgets.BudgetType Budget_BudgetType { get; set; }
        #endregion
        
        #region Parameter Budget_CostFilter
        /// <summary>
        /// <para>
        /// <para>The cost filters, such as service or tag, that are applied to a budget.</para><para>AWS Budgets supports the following services as a filter for RI budgets:</para><ul><li><para>Amazon Elastic Compute Cloud - Compute</para></li><li><para>Amazon Redshift</para></li><li><para>Amazon Relational Database Service</para></li><li><para>Amazon ElastiCache</para></li><li><para>Amazon Elasticsearch Service</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostFilters")]
        public System.Collections.Hashtable Budget_CostFilter { get; set; }
        #endregion
        
        #region Parameter TimePeriod_End
        /// <summary>
        /// <para>
        /// <para>The end date for a budget. If you didn't specify an end date, AWS set your end date
        /// to <code>06/15/87 00:00 UTC</code>. The defaults are the same for the AWS Billing
        /// and Cost Management console and the API.</para><para>After the end date, AWS deletes the budget and all associated notifications and subscribers.
        /// You can change your end date with the <code>UpdateBudget</code> operation.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_TimePeriod_End")]
        public System.DateTime? TimePeriod_End { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeCredit
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes credits.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeCredit")]
        public System.Boolean? CostTypes_IncludeCredit { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeDiscount
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes discounts.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeDiscount")]
        public System.Boolean? CostTypes_IncludeDiscount { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeOtherSubscription
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes non-RI subscription costs.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeOtherSubscription")]
        public System.Boolean? CostTypes_IncludeOtherSubscription { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeRecurring
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes recurring fees such as monthly RI fees.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeRecurring")]
        public System.Boolean? CostTypes_IncludeRecurring { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeRefund
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes refunds.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeRefund")]
        public System.Boolean? CostTypes_IncludeRefund { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeSubscription
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes subscriptions.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeSubscription")]
        public System.Boolean? CostTypes_IncludeSubscription { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeSupport
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes support subscription fees.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeSupport")]
        public System.Boolean? CostTypes_IncludeSupport { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeTax
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes taxes.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeTax")]
        public System.Boolean? CostTypes_IncludeTax { get; set; }
        #endregion
        
        #region Parameter CostTypes_IncludeUpfront
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget includes upfront RI costs.</para><para>The default value is <code>true</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_IncludeUpfront")]
        public System.Boolean? CostTypes_IncludeUpfront { get; set; }
        #endregion
        
        #region Parameter Budget_LastUpdatedTime
        /// <summary>
        /// <para>
        /// <para>The last time that you updated this budget.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.DateTime? Budget_LastUpdatedTime { get; set; }
        #endregion
        
        #region Parameter NotificationsWithSubscriber
        /// <summary>
        /// <para>
        /// <para>A notification that you want to associate with a budget. A budget can have up to five
        /// notifications, and each notification can have one SNS subscriber and up to 10 email
        /// subscribers. If you include notifications and subscribers in your <code>CreateBudget</code>
        /// call, AWS creates the notifications and subscribers for you.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("NotificationsWithSubscribers")]
        public Amazon.Budgets.Model.NotificationWithSubscribers[] NotificationsWithSubscriber { get; set; }
        #endregion
        
        #region Parameter Budget_PlannedBudgetLimit
        /// <summary>
        /// <para>
        /// <para>A map containing multiple <code>BudgetLimit</code>, including current or future limits.</para><para><code>PlannedBudgetLimits</code> is available for cost or usage budget and supports
        /// monthly and quarterly <code>TimeUnit</code>. </para><para>For monthly budgets, provide 12 months of <code>PlannedBudgetLimits</code> values.
        /// This must start from the current month and include the next 11 months. The <code>key</code>
        /// is the start of the month, <code>UTC</code> in epoch seconds. </para><para>For quarterly budgets, provide 4 quarters of <code>PlannedBudgetLimits</code> value
        /// entries in standard calendar quarter increments. This must start from the current
        /// quarter and include the next 3 quarters. The <code>key</code> is the start of the
        /// quarter, <code>UTC</code> in epoch seconds. </para><para>If the planned budget expires before 12 months for monthly or 4 quarters for quarterly,
        /// provide the <code>PlannedBudgetLimits</code> values only for the remaining periods.</para><para>If the budget begins at a date in the future, provide <code>PlannedBudgetLimits</code>
        /// values from the start date of the budget. </para><para>After all of the <code>BudgetLimit</code> values in <code>PlannedBudgetLimits</code>
        /// are used, the budget continues to use the last limit as the <code>BudgetLimit</code>.
        /// At that point, the planned budget provides the same experience as a fixed budget.
        /// </para><para><code>DescribeBudget</code> and <code>DescribeBudgets</code> response along with
        /// <code>PlannedBudgetLimits</code> will also contain <code>BudgetLimit</code> representing
        /// the current month or quarter limit present in <code>PlannedBudgetLimits</code>. This
        /// only applies to budgets created with <code>PlannedBudgetLimits</code>. Budgets created
        /// without <code>PlannedBudgetLimits</code> will only contain <code>BudgetLimit</code>,
        /// and no <code>PlannedBudgetLimits</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_PlannedBudgetLimits")]
        public System.Collections.Hashtable Budget_PlannedBudgetLimit { get; set; }
        #endregion
        
        #region Parameter TimePeriod_Start
        /// <summary>
        /// <para>
        /// <para>The start date for a budget. If you created your budget and didn't specify a start
        /// date, AWS defaults to the start of your chosen time period (DAILY, MONTHLY, QUARTERLY,
        /// or ANNUALLY). For example, if you created your budget on January 24, 2018, chose <code>DAILY</code>,
        /// and didn't set a start date, AWS set your start date to <code>01/24/18 00:00 UTC</code>.
        /// If you chose <code>MONTHLY</code>, AWS set your start date to <code>01/01/18 00:00
        /// UTC</code>. The defaults are the same for the AWS Billing and Cost Management console
        /// and the API.</para><para>You can change your start date with the <code>UpdateBudget</code> operation.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_TimePeriod_Start")]
        public System.DateTime? TimePeriod_Start { get; set; }
        #endregion
        
        #region Parameter Budget_TimeUnit
        /// <summary>
        /// <para>
        /// <para>The length of time until a budget resets the actual and forecasted spend. <code>DAILY</code>
        /// is available only for <code>RI_UTILIZATION</code> and <code>RI_COVERAGE</code> budgets.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Budgets.TimeUnit")]
        public Amazon.Budgets.TimeUnit Budget_TimeUnit { get; set; }
        #endregion
        
        #region Parameter BudgetLimit_Unit
        /// <summary>
        /// <para>
        /// <para>The unit of measurement that is used for the budget forecast, actual spend, or budget
        /// threshold, such as dollars or GB.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_BudgetLimit_Unit")]
        public System.String BudgetLimit_Unit { get; set; }
        #endregion
        
        #region Parameter ActualSpend_Unit
        /// <summary>
        /// <para>
        /// <para>The unit of measurement that is used for the budget forecast, actual spend, or budget
        /// threshold, such as dollars or GB.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CalculatedSpend_ActualSpend_Unit")]
        public System.String ActualSpend_Unit { get; set; }
        #endregion
        
        #region Parameter ForecastedSpend_Unit
        /// <summary>
        /// <para>
        /// <para>The unit of measurement that is used for the budget forecast, actual spend, or budget
        /// threshold, such as dollars or GB.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CalculatedSpend_ForecastedSpend_Unit")]
        public System.String ForecastedSpend_Unit { get; set; }
        #endregion
        
        #region Parameter CostTypes_UseAmortized
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget uses the amortized rate.</para><para>The default value is <code>false</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_UseAmortized")]
        public System.Boolean? CostTypes_UseAmortized { get; set; }
        #endregion
        
        #region Parameter CostTypes_UseBlended
        /// <summary>
        /// <para>
        /// <para>Specifies whether a budget uses a blended rate.</para><para>The default value is <code>false</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Budget_CostTypes_UseBlended")]
        public System.Boolean? CostTypes_UseBlended { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Budgets.Model.CreateBudgetResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AccountId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AccountId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AccountId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AccountId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-BGTBudget (CreateBudget)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Budgets.Model.CreateBudgetResponse, NewBGTBudgetCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AccountId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AccountId = this.AccountId;
            #if MODULAR
            if (this.AccountId == null && ParameterWasBound(nameof(this.AccountId)))
            {
                WriteWarning("You are passing $null as a value for parameter AccountId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.BudgetLimit_Amount = this.BudgetLimit_Amount;
            context.BudgetLimit_Unit = this.BudgetLimit_Unit;
            context.Budget_BudgetName = this.Budget_BudgetName;
            #if MODULAR
            if (this.Budget_BudgetName == null && ParameterWasBound(nameof(this.Budget_BudgetName)))
            {
                WriteWarning("You are passing $null as a value for parameter Budget_BudgetName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Budget_BudgetType = this.Budget_BudgetType;
            #if MODULAR
            if (this.Budget_BudgetType == null && ParameterWasBound(nameof(this.Budget_BudgetType)))
            {
                WriteWarning("You are passing $null as a value for parameter Budget_BudgetType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ActualSpend_Amount = this.ActualSpend_Amount;
            context.ActualSpend_Unit = this.ActualSpend_Unit;
            context.ForecastedSpend_Amount = this.ForecastedSpend_Amount;
            context.ForecastedSpend_Unit = this.ForecastedSpend_Unit;
            if (this.Budget_CostFilter != null)
            {
                context.Budget_CostFilter = new Dictionary<System.String, List<System.String>>(StringComparer.Ordinal);
                foreach (var hashKey in this.Budget_CostFilter.Keys)
                {
                    object hashValue = this.Budget_CostFilter[hashKey];
                    if (hashValue == null)
                    {
                        context.Budget_CostFilter.Add((String)hashKey, null);
                        continue;
                    }
                    var enumerable = SafeEnumerable(hashValue);
                    var valueSet = new List<String>();
                    foreach (var s in enumerable)
                    {
                        valueSet.Add((String)s);
                    }
                    context.Budget_CostFilter.Add((String)hashKey, valueSet);
                }
            }
            context.CostTypes_IncludeCredit = this.CostTypes_IncludeCredit;
            context.CostTypes_IncludeDiscount = this.CostTypes_IncludeDiscount;
            context.CostTypes_IncludeOtherSubscription = this.CostTypes_IncludeOtherSubscription;
            context.CostTypes_IncludeRecurring = this.CostTypes_IncludeRecurring;
            context.CostTypes_IncludeRefund = this.CostTypes_IncludeRefund;
            context.CostTypes_IncludeSubscription = this.CostTypes_IncludeSubscription;
            context.CostTypes_IncludeSupport = this.CostTypes_IncludeSupport;
            context.CostTypes_IncludeTax = this.CostTypes_IncludeTax;
            context.CostTypes_IncludeUpfront = this.CostTypes_IncludeUpfront;
            context.CostTypes_UseAmortized = this.CostTypes_UseAmortized;
            context.CostTypes_UseBlended = this.CostTypes_UseBlended;
            context.Budget_LastUpdatedTime = this.Budget_LastUpdatedTime;
            if (this.Budget_PlannedBudgetLimit != null)
            {
                context.Budget_PlannedBudgetLimit = new Dictionary<System.String, Amazon.Budgets.Model.Spend>(StringComparer.Ordinal);
                foreach (var hashKey in this.Budget_PlannedBudgetLimit.Keys)
                {
                    context.Budget_PlannedBudgetLimit.Add((String)hashKey, (Spend)(this.Budget_PlannedBudgetLimit[hashKey]));
                }
            }
            context.TimePeriod_End = this.TimePeriod_End;
            context.TimePeriod_Start = this.TimePeriod_Start;
            context.Budget_TimeUnit = this.Budget_TimeUnit;
            #if MODULAR
            if (this.Budget_TimeUnit == null && ParameterWasBound(nameof(this.Budget_TimeUnit)))
            {
                WriteWarning("You are passing $null as a value for parameter Budget_TimeUnit which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.NotificationsWithSubscriber != null)
            {
                context.NotificationsWithSubscriber = new List<Amazon.Budgets.Model.NotificationWithSubscribers>(this.NotificationsWithSubscriber);
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
            var request = new Amazon.Budgets.Model.CreateBudgetRequest();
            
            if (cmdletContext.AccountId != null)
            {
                request.AccountId = cmdletContext.AccountId;
            }
            
             // populate Budget
            var requestBudgetIsNull = true;
            request.Budget = new Amazon.Budgets.Model.Budget();
            System.String requestBudget_budget_BudgetName = null;
            if (cmdletContext.Budget_BudgetName != null)
            {
                requestBudget_budget_BudgetName = cmdletContext.Budget_BudgetName;
            }
            if (requestBudget_budget_BudgetName != null)
            {
                request.Budget.BudgetName = requestBudget_budget_BudgetName;
                requestBudgetIsNull = false;
            }
            Amazon.Budgets.BudgetType requestBudget_budget_BudgetType = null;
            if (cmdletContext.Budget_BudgetType != null)
            {
                requestBudget_budget_BudgetType = cmdletContext.Budget_BudgetType;
            }
            if (requestBudget_budget_BudgetType != null)
            {
                request.Budget.BudgetType = requestBudget_budget_BudgetType;
                requestBudgetIsNull = false;
            }
            Dictionary<System.String, List<System.String>> requestBudget_budget_CostFilter = null;
            if (cmdletContext.Budget_CostFilter != null)
            {
                requestBudget_budget_CostFilter = cmdletContext.Budget_CostFilter;
            }
            if (requestBudget_budget_CostFilter != null)
            {
                request.Budget.CostFilters = requestBudget_budget_CostFilter;
                requestBudgetIsNull = false;
            }
            System.DateTime? requestBudget_budget_LastUpdatedTime = null;
            if (cmdletContext.Budget_LastUpdatedTime != null)
            {
                requestBudget_budget_LastUpdatedTime = cmdletContext.Budget_LastUpdatedTime.Value;
            }
            if (requestBudget_budget_LastUpdatedTime != null)
            {
                request.Budget.LastUpdatedTime = requestBudget_budget_LastUpdatedTime.Value;
                requestBudgetIsNull = false;
            }
            Dictionary<System.String, Amazon.Budgets.Model.Spend> requestBudget_budget_PlannedBudgetLimit = null;
            if (cmdletContext.Budget_PlannedBudgetLimit != null)
            {
                requestBudget_budget_PlannedBudgetLimit = cmdletContext.Budget_PlannedBudgetLimit;
            }
            if (requestBudget_budget_PlannedBudgetLimit != null)
            {
                request.Budget.PlannedBudgetLimits = requestBudget_budget_PlannedBudgetLimit;
                requestBudgetIsNull = false;
            }
            Amazon.Budgets.TimeUnit requestBudget_budget_TimeUnit = null;
            if (cmdletContext.Budget_TimeUnit != null)
            {
                requestBudget_budget_TimeUnit = cmdletContext.Budget_TimeUnit;
            }
            if (requestBudget_budget_TimeUnit != null)
            {
                request.Budget.TimeUnit = requestBudget_budget_TimeUnit;
                requestBudgetIsNull = false;
            }
            Amazon.Budgets.Model.Spend requestBudget_budget_BudgetLimit = null;
            
             // populate BudgetLimit
            var requestBudget_budget_BudgetLimitIsNull = true;
            requestBudget_budget_BudgetLimit = new Amazon.Budgets.Model.Spend();
            System.Decimal? requestBudget_budget_BudgetLimit_budgetLimit_Amount = null;
            if (cmdletContext.BudgetLimit_Amount != null)
            {
                requestBudget_budget_BudgetLimit_budgetLimit_Amount = cmdletContext.BudgetLimit_Amount.Value;
            }
            if (requestBudget_budget_BudgetLimit_budgetLimit_Amount != null)
            {
                requestBudget_budget_BudgetLimit.Amount = requestBudget_budget_BudgetLimit_budgetLimit_Amount.Value;
                requestBudget_budget_BudgetLimitIsNull = false;
            }
            System.String requestBudget_budget_BudgetLimit_budgetLimit_Unit = null;
            if (cmdletContext.BudgetLimit_Unit != null)
            {
                requestBudget_budget_BudgetLimit_budgetLimit_Unit = cmdletContext.BudgetLimit_Unit;
            }
            if (requestBudget_budget_BudgetLimit_budgetLimit_Unit != null)
            {
                requestBudget_budget_BudgetLimit.Unit = requestBudget_budget_BudgetLimit_budgetLimit_Unit;
                requestBudget_budget_BudgetLimitIsNull = false;
            }
             // determine if requestBudget_budget_BudgetLimit should be set to null
            if (requestBudget_budget_BudgetLimitIsNull)
            {
                requestBudget_budget_BudgetLimit = null;
            }
            if (requestBudget_budget_BudgetLimit != null)
            {
                request.Budget.BudgetLimit = requestBudget_budget_BudgetLimit;
                requestBudgetIsNull = false;
            }
            Amazon.Budgets.Model.CalculatedSpend requestBudget_budget_CalculatedSpend = null;
            
             // populate CalculatedSpend
            var requestBudget_budget_CalculatedSpendIsNull = true;
            requestBudget_budget_CalculatedSpend = new Amazon.Budgets.Model.CalculatedSpend();
            Amazon.Budgets.Model.Spend requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend = null;
            
             // populate ActualSpend
            var requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpendIsNull = true;
            requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend = new Amazon.Budgets.Model.Spend();
            System.Decimal? requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Amount = null;
            if (cmdletContext.ActualSpend_Amount != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Amount = cmdletContext.ActualSpend_Amount.Value;
            }
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Amount != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend.Amount = requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Amount.Value;
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpendIsNull = false;
            }
            System.String requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Unit = null;
            if (cmdletContext.ActualSpend_Unit != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Unit = cmdletContext.ActualSpend_Unit;
            }
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Unit != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend.Unit = requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend_actualSpend_Unit;
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpendIsNull = false;
            }
             // determine if requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend should be set to null
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpendIsNull)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend = null;
            }
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend != null)
            {
                requestBudget_budget_CalculatedSpend.ActualSpend = requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ActualSpend;
                requestBudget_budget_CalculatedSpendIsNull = false;
            }
            Amazon.Budgets.Model.Spend requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend = null;
            
             // populate ForecastedSpend
            var requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpendIsNull = true;
            requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend = new Amazon.Budgets.Model.Spend();
            System.Decimal? requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Amount = null;
            if (cmdletContext.ForecastedSpend_Amount != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Amount = cmdletContext.ForecastedSpend_Amount.Value;
            }
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Amount != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend.Amount = requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Amount.Value;
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpendIsNull = false;
            }
            System.String requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Unit = null;
            if (cmdletContext.ForecastedSpend_Unit != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Unit = cmdletContext.ForecastedSpend_Unit;
            }
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Unit != null)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend.Unit = requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend_forecastedSpend_Unit;
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpendIsNull = false;
            }
             // determine if requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend should be set to null
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpendIsNull)
            {
                requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend = null;
            }
            if (requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend != null)
            {
                requestBudget_budget_CalculatedSpend.ForecastedSpend = requestBudget_budget_CalculatedSpend_budget_CalculatedSpend_ForecastedSpend;
                requestBudget_budget_CalculatedSpendIsNull = false;
            }
             // determine if requestBudget_budget_CalculatedSpend should be set to null
            if (requestBudget_budget_CalculatedSpendIsNull)
            {
                requestBudget_budget_CalculatedSpend = null;
            }
            if (requestBudget_budget_CalculatedSpend != null)
            {
                request.Budget.CalculatedSpend = requestBudget_budget_CalculatedSpend;
                requestBudgetIsNull = false;
            }
            Amazon.Budgets.Model.TimePeriod requestBudget_budget_TimePeriod = null;
            
             // populate TimePeriod
            var requestBudget_budget_TimePeriodIsNull = true;
            requestBudget_budget_TimePeriod = new Amazon.Budgets.Model.TimePeriod();
            System.DateTime? requestBudget_budget_TimePeriod_timePeriod_End = null;
            if (cmdletContext.TimePeriod_End != null)
            {
                requestBudget_budget_TimePeriod_timePeriod_End = cmdletContext.TimePeriod_End.Value;
            }
            if (requestBudget_budget_TimePeriod_timePeriod_End != null)
            {
                requestBudget_budget_TimePeriod.End = requestBudget_budget_TimePeriod_timePeriod_End.Value;
                requestBudget_budget_TimePeriodIsNull = false;
            }
            System.DateTime? requestBudget_budget_TimePeriod_timePeriod_Start = null;
            if (cmdletContext.TimePeriod_Start != null)
            {
                requestBudget_budget_TimePeriod_timePeriod_Start = cmdletContext.TimePeriod_Start.Value;
            }
            if (requestBudget_budget_TimePeriod_timePeriod_Start != null)
            {
                requestBudget_budget_TimePeriod.Start = requestBudget_budget_TimePeriod_timePeriod_Start.Value;
                requestBudget_budget_TimePeriodIsNull = false;
            }
             // determine if requestBudget_budget_TimePeriod should be set to null
            if (requestBudget_budget_TimePeriodIsNull)
            {
                requestBudget_budget_TimePeriod = null;
            }
            if (requestBudget_budget_TimePeriod != null)
            {
                request.Budget.TimePeriod = requestBudget_budget_TimePeriod;
                requestBudgetIsNull = false;
            }
            Amazon.Budgets.Model.CostTypes requestBudget_budget_CostTypes = null;
            
             // populate CostTypes
            var requestBudget_budget_CostTypesIsNull = true;
            requestBudget_budget_CostTypes = new Amazon.Budgets.Model.CostTypes();
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeCredit = null;
            if (cmdletContext.CostTypes_IncludeCredit != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeCredit = cmdletContext.CostTypes_IncludeCredit.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeCredit != null)
            {
                requestBudget_budget_CostTypes.IncludeCredit = requestBudget_budget_CostTypes_costTypes_IncludeCredit.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeDiscount = null;
            if (cmdletContext.CostTypes_IncludeDiscount != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeDiscount = cmdletContext.CostTypes_IncludeDiscount.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeDiscount != null)
            {
                requestBudget_budget_CostTypes.IncludeDiscount = requestBudget_budget_CostTypes_costTypes_IncludeDiscount.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeOtherSubscription = null;
            if (cmdletContext.CostTypes_IncludeOtherSubscription != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeOtherSubscription = cmdletContext.CostTypes_IncludeOtherSubscription.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeOtherSubscription != null)
            {
                requestBudget_budget_CostTypes.IncludeOtherSubscription = requestBudget_budget_CostTypes_costTypes_IncludeOtherSubscription.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeRecurring = null;
            if (cmdletContext.CostTypes_IncludeRecurring != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeRecurring = cmdletContext.CostTypes_IncludeRecurring.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeRecurring != null)
            {
                requestBudget_budget_CostTypes.IncludeRecurring = requestBudget_budget_CostTypes_costTypes_IncludeRecurring.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeRefund = null;
            if (cmdletContext.CostTypes_IncludeRefund != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeRefund = cmdletContext.CostTypes_IncludeRefund.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeRefund != null)
            {
                requestBudget_budget_CostTypes.IncludeRefund = requestBudget_budget_CostTypes_costTypes_IncludeRefund.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeSubscription = null;
            if (cmdletContext.CostTypes_IncludeSubscription != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeSubscription = cmdletContext.CostTypes_IncludeSubscription.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeSubscription != null)
            {
                requestBudget_budget_CostTypes.IncludeSubscription = requestBudget_budget_CostTypes_costTypes_IncludeSubscription.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeSupport = null;
            if (cmdletContext.CostTypes_IncludeSupport != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeSupport = cmdletContext.CostTypes_IncludeSupport.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeSupport != null)
            {
                requestBudget_budget_CostTypes.IncludeSupport = requestBudget_budget_CostTypes_costTypes_IncludeSupport.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeTax = null;
            if (cmdletContext.CostTypes_IncludeTax != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeTax = cmdletContext.CostTypes_IncludeTax.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeTax != null)
            {
                requestBudget_budget_CostTypes.IncludeTax = requestBudget_budget_CostTypes_costTypes_IncludeTax.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_IncludeUpfront = null;
            if (cmdletContext.CostTypes_IncludeUpfront != null)
            {
                requestBudget_budget_CostTypes_costTypes_IncludeUpfront = cmdletContext.CostTypes_IncludeUpfront.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_IncludeUpfront != null)
            {
                requestBudget_budget_CostTypes.IncludeUpfront = requestBudget_budget_CostTypes_costTypes_IncludeUpfront.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_UseAmortized = null;
            if (cmdletContext.CostTypes_UseAmortized != null)
            {
                requestBudget_budget_CostTypes_costTypes_UseAmortized = cmdletContext.CostTypes_UseAmortized.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_UseAmortized != null)
            {
                requestBudget_budget_CostTypes.UseAmortized = requestBudget_budget_CostTypes_costTypes_UseAmortized.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
            System.Boolean? requestBudget_budget_CostTypes_costTypes_UseBlended = null;
            if (cmdletContext.CostTypes_UseBlended != null)
            {
                requestBudget_budget_CostTypes_costTypes_UseBlended = cmdletContext.CostTypes_UseBlended.Value;
            }
            if (requestBudget_budget_CostTypes_costTypes_UseBlended != null)
            {
                requestBudget_budget_CostTypes.UseBlended = requestBudget_budget_CostTypes_costTypes_UseBlended.Value;
                requestBudget_budget_CostTypesIsNull = false;
            }
             // determine if requestBudget_budget_CostTypes should be set to null
            if (requestBudget_budget_CostTypesIsNull)
            {
                requestBudget_budget_CostTypes = null;
            }
            if (requestBudget_budget_CostTypes != null)
            {
                request.Budget.CostTypes = requestBudget_budget_CostTypes;
                requestBudgetIsNull = false;
            }
             // determine if request.Budget should be set to null
            if (requestBudgetIsNull)
            {
                request.Budget = null;
            }
            if (cmdletContext.NotificationsWithSubscriber != null)
            {
                request.NotificationsWithSubscribers = cmdletContext.NotificationsWithSubscriber;
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
        
        private Amazon.Budgets.Model.CreateBudgetResponse CallAWSServiceOperation(IAmazonBudgets client, Amazon.Budgets.Model.CreateBudgetRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Budgets", "CreateBudget");
            try
            {
                #if DESKTOP
                return client.CreateBudget(request);
                #elif CORECLR
                return client.CreateBudgetAsync(request).GetAwaiter().GetResult();
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
            public System.String AccountId { get; set; }
            public System.Decimal? BudgetLimit_Amount { get; set; }
            public System.String BudgetLimit_Unit { get; set; }
            public System.String Budget_BudgetName { get; set; }
            public Amazon.Budgets.BudgetType Budget_BudgetType { get; set; }
            public System.Decimal? ActualSpend_Amount { get; set; }
            public System.String ActualSpend_Unit { get; set; }
            public System.Decimal? ForecastedSpend_Amount { get; set; }
            public System.String ForecastedSpend_Unit { get; set; }
            public Dictionary<System.String, List<System.String>> Budget_CostFilter { get; set; }
            public System.Boolean? CostTypes_IncludeCredit { get; set; }
            public System.Boolean? CostTypes_IncludeDiscount { get; set; }
            public System.Boolean? CostTypes_IncludeOtherSubscription { get; set; }
            public System.Boolean? CostTypes_IncludeRecurring { get; set; }
            public System.Boolean? CostTypes_IncludeRefund { get; set; }
            public System.Boolean? CostTypes_IncludeSubscription { get; set; }
            public System.Boolean? CostTypes_IncludeSupport { get; set; }
            public System.Boolean? CostTypes_IncludeTax { get; set; }
            public System.Boolean? CostTypes_IncludeUpfront { get; set; }
            public System.Boolean? CostTypes_UseAmortized { get; set; }
            public System.Boolean? CostTypes_UseBlended { get; set; }
            public System.DateTime? Budget_LastUpdatedTime { get; set; }
            public Dictionary<System.String, Amazon.Budgets.Model.Spend> Budget_PlannedBudgetLimit { get; set; }
            public System.DateTime? TimePeriod_End { get; set; }
            public System.DateTime? TimePeriod_Start { get; set; }
            public Amazon.Budgets.TimeUnit Budget_TimeUnit { get; set; }
            public List<Amazon.Budgets.Model.NotificationWithSubscribers> NotificationsWithSubscriber { get; set; }
            public System.Func<Amazon.Budgets.Model.CreateBudgetResponse, NewBGTBudgetCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}

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
using Amazon.LakeFormation;
using Amazon.LakeFormation.Model;

namespace Amazon.PowerShell.Cmdlets.LKF
{
    /// <summary>
    /// Revokes permissions to the principal to access metadata in the Data Catalog and data
    /// organized in underlying data storage such as Amazon S3.
    /// </summary>
    [Cmdlet("Revoke", "LKFPermission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the AWS Lake Formation RevokePermissions API operation.", Operation = new[] {"RevokePermissions"}, SelectReturnType = typeof(Amazon.LakeFormation.Model.RevokePermissionsResponse))]
    [AWSCmdletOutput("None or Amazon.LakeFormation.Model.RevokePermissionsResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.LakeFormation.Model.RevokePermissionsResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RevokeLKFPermissionCmdlet : AmazonLakeFormationClientCmdlet, IExecutor
    {
        
        #region Parameter Resource_Catalog
        /// <summary>
        /// <para>
        /// <para>The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your AWS Lake Formation environment. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.LakeFormation.Model.CatalogResource Resource_Catalog { get; set; }
        #endregion
        
        #region Parameter CatalogId
        /// <summary>
        /// <para>
        /// <para>The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your AWS Lake Formation environment. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CatalogId { get; set; }
        #endregion
        
        #region Parameter TableWithColumns_ColumnName
        /// <summary>
        /// <para>
        /// <para>The list of column names for the table. At least one of <code>ColumnNames</code> or
        /// <code>ColumnWildcard</code> is required.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_TableWithColumns_ColumnNames")]
        public System.String[] TableWithColumns_ColumnName { get; set; }
        #endregion
        
        #region Parameter Table_DatabaseName
        /// <summary>
        /// <para>
        /// <para>The name of the database for the table. Unique to a Data Catalog. A database is a
        /// set of associated table definitions organized into a logical group. You can Grant
        /// and Revoke database privileges to a principal. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_Table_DatabaseName")]
        public System.String Table_DatabaseName { get; set; }
        #endregion
        
        #region Parameter TableWithColumns_DatabaseName
        /// <summary>
        /// <para>
        /// <para>The name of the database for the table with columns resource. Unique to the Data Catalog.
        /// A database is a set of associated table definitions organized into a logical group.
        /// You can Grant and Revoke database privileges to a principal. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_TableWithColumns_DatabaseName")]
        public System.String TableWithColumns_DatabaseName { get; set; }
        #endregion
        
        #region Parameter Principal_DataLakePrincipalIdentifier
        /// <summary>
        /// <para>
        /// <para>An identifier for the AWS Lake Formation principal.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Principal_DataLakePrincipalIdentifier { get; set; }
        #endregion
        
        #region Parameter ColumnWildcard_ExcludedColumnName
        /// <summary>
        /// <para>
        /// <para>Excludes column names. Any column with this name will be excluded.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_TableWithColumns_ColumnWildcard_ExcludedColumnNames")]
        public System.String[] ColumnWildcard_ExcludedColumnName { get; set; }
        #endregion
        
        #region Parameter Database_Name
        /// <summary>
        /// <para>
        /// <para>The name of the database resource. Unique to the Data Catalog.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_Database_Name")]
        public System.String Database_Name { get; set; }
        #endregion
        
        #region Parameter Table_Name
        /// <summary>
        /// <para>
        /// <para>The name of the table.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_Table_Name")]
        public System.String Table_Name { get; set; }
        #endregion
        
        #region Parameter TableWithColumns_Name
        /// <summary>
        /// <para>
        /// <para>The name of the table resource. A table is a metadata definition that represents your
        /// data. You can Grant and Revoke table privileges to a principal. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_TableWithColumns_Name")]
        public System.String TableWithColumns_Name { get; set; }
        #endregion
        
        #region Parameter Permission
        /// <summary>
        /// <para>
        /// <para>The permissions revoked to the principal on the resource. For information about permissions,
        /// see <a href="https://docs-aws.amazon.com/michigan/latest/dg/security-data-access.html">Security
        /// and Access Control to Metadata and Data</a>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("Permissions")]
        public System.String[] Permission { get; set; }
        #endregion
        
        #region Parameter PermissionsWithGrantOption
        /// <summary>
        /// <para>
        /// <para>Indicates a list of permissions for which to revoke the grant option allowing the
        /// principal to pass permissions to other principals.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] PermissionsWithGrantOption { get; set; }
        #endregion
        
        #region Parameter DataLocation_ResourceArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) that uniquely identifies the data location resource.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Resource_DataLocation_ResourceArn")]
        public System.String DataLocation_ResourceArn { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.LakeFormation.Model.RevokePermissionsResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Permission parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Permission' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Permission' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.CatalogId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Revoke-LKFPermission (RevokePermissions)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.LakeFormation.Model.RevokePermissionsResponse, RevokeLKFPermissionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Permission;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.CatalogId = this.CatalogId;
            if (this.Permission != null)
            {
                context.Permission = new List<System.String>(this.Permission);
            }
            #if MODULAR
            if (this.Permission == null && ParameterWasBound(nameof(this.Permission)))
            {
                WriteWarning("You are passing $null as a value for parameter Permission which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.PermissionsWithGrantOption != null)
            {
                context.PermissionsWithGrantOption = new List<System.String>(this.PermissionsWithGrantOption);
            }
            context.Principal_DataLakePrincipalIdentifier = this.Principal_DataLakePrincipalIdentifier;
            context.Resource_Catalog = this.Resource_Catalog;
            context.Database_Name = this.Database_Name;
            context.DataLocation_ResourceArn = this.DataLocation_ResourceArn;
            context.Table_DatabaseName = this.Table_DatabaseName;
            context.Table_Name = this.Table_Name;
            if (this.TableWithColumns_ColumnName != null)
            {
                context.TableWithColumns_ColumnName = new List<System.String>(this.TableWithColumns_ColumnName);
            }
            if (this.ColumnWildcard_ExcludedColumnName != null)
            {
                context.ColumnWildcard_ExcludedColumnName = new List<System.String>(this.ColumnWildcard_ExcludedColumnName);
            }
            context.TableWithColumns_DatabaseName = this.TableWithColumns_DatabaseName;
            context.TableWithColumns_Name = this.TableWithColumns_Name;
            
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
            var request = new Amazon.LakeFormation.Model.RevokePermissionsRequest();
            
            if (cmdletContext.CatalogId != null)
            {
                request.CatalogId = cmdletContext.CatalogId;
            }
            if (cmdletContext.Permission != null)
            {
                request.Permissions = cmdletContext.Permission;
            }
            if (cmdletContext.PermissionsWithGrantOption != null)
            {
                request.PermissionsWithGrantOption = cmdletContext.PermissionsWithGrantOption;
            }
            
             // populate Principal
            var requestPrincipalIsNull = true;
            request.Principal = new Amazon.LakeFormation.Model.DataLakePrincipal();
            System.String requestPrincipal_principal_DataLakePrincipalIdentifier = null;
            if (cmdletContext.Principal_DataLakePrincipalIdentifier != null)
            {
                requestPrincipal_principal_DataLakePrincipalIdentifier = cmdletContext.Principal_DataLakePrincipalIdentifier;
            }
            if (requestPrincipal_principal_DataLakePrincipalIdentifier != null)
            {
                request.Principal.DataLakePrincipalIdentifier = requestPrincipal_principal_DataLakePrincipalIdentifier;
                requestPrincipalIsNull = false;
            }
             // determine if request.Principal should be set to null
            if (requestPrincipalIsNull)
            {
                request.Principal = null;
            }
            
             // populate Resource
            var requestResourceIsNull = true;
            request.Resource = new Amazon.LakeFormation.Model.Resource();
            Amazon.LakeFormation.Model.CatalogResource requestResource_resource_Catalog = null;
            if (cmdletContext.Resource_Catalog != null)
            {
                requestResource_resource_Catalog = cmdletContext.Resource_Catalog;
            }
            if (requestResource_resource_Catalog != null)
            {
                request.Resource.Catalog = requestResource_resource_Catalog;
                requestResourceIsNull = false;
            }
            Amazon.LakeFormation.Model.DatabaseResource requestResource_resource_Database = null;
            
             // populate Database
            var requestResource_resource_DatabaseIsNull = true;
            requestResource_resource_Database = new Amazon.LakeFormation.Model.DatabaseResource();
            System.String requestResource_resource_Database_database_Name = null;
            if (cmdletContext.Database_Name != null)
            {
                requestResource_resource_Database_database_Name = cmdletContext.Database_Name;
            }
            if (requestResource_resource_Database_database_Name != null)
            {
                requestResource_resource_Database.Name = requestResource_resource_Database_database_Name;
                requestResource_resource_DatabaseIsNull = false;
            }
             // determine if requestResource_resource_Database should be set to null
            if (requestResource_resource_DatabaseIsNull)
            {
                requestResource_resource_Database = null;
            }
            if (requestResource_resource_Database != null)
            {
                request.Resource.Database = requestResource_resource_Database;
                requestResourceIsNull = false;
            }
            Amazon.LakeFormation.Model.DataLocationResource requestResource_resource_DataLocation = null;
            
             // populate DataLocation
            var requestResource_resource_DataLocationIsNull = true;
            requestResource_resource_DataLocation = new Amazon.LakeFormation.Model.DataLocationResource();
            System.String requestResource_resource_DataLocation_dataLocation_ResourceArn = null;
            if (cmdletContext.DataLocation_ResourceArn != null)
            {
                requestResource_resource_DataLocation_dataLocation_ResourceArn = cmdletContext.DataLocation_ResourceArn;
            }
            if (requestResource_resource_DataLocation_dataLocation_ResourceArn != null)
            {
                requestResource_resource_DataLocation.ResourceArn = requestResource_resource_DataLocation_dataLocation_ResourceArn;
                requestResource_resource_DataLocationIsNull = false;
            }
             // determine if requestResource_resource_DataLocation should be set to null
            if (requestResource_resource_DataLocationIsNull)
            {
                requestResource_resource_DataLocation = null;
            }
            if (requestResource_resource_DataLocation != null)
            {
                request.Resource.DataLocation = requestResource_resource_DataLocation;
                requestResourceIsNull = false;
            }
            Amazon.LakeFormation.Model.TableResource requestResource_resource_Table = null;
            
             // populate Table
            var requestResource_resource_TableIsNull = true;
            requestResource_resource_Table = new Amazon.LakeFormation.Model.TableResource();
            System.String requestResource_resource_Table_table_DatabaseName = null;
            if (cmdletContext.Table_DatabaseName != null)
            {
                requestResource_resource_Table_table_DatabaseName = cmdletContext.Table_DatabaseName;
            }
            if (requestResource_resource_Table_table_DatabaseName != null)
            {
                requestResource_resource_Table.DatabaseName = requestResource_resource_Table_table_DatabaseName;
                requestResource_resource_TableIsNull = false;
            }
            System.String requestResource_resource_Table_table_Name = null;
            if (cmdletContext.Table_Name != null)
            {
                requestResource_resource_Table_table_Name = cmdletContext.Table_Name;
            }
            if (requestResource_resource_Table_table_Name != null)
            {
                requestResource_resource_Table.Name = requestResource_resource_Table_table_Name;
                requestResource_resource_TableIsNull = false;
            }
             // determine if requestResource_resource_Table should be set to null
            if (requestResource_resource_TableIsNull)
            {
                requestResource_resource_Table = null;
            }
            if (requestResource_resource_Table != null)
            {
                request.Resource.Table = requestResource_resource_Table;
                requestResourceIsNull = false;
            }
            Amazon.LakeFormation.Model.TableWithColumnsResource requestResource_resource_TableWithColumns = null;
            
             // populate TableWithColumns
            var requestResource_resource_TableWithColumnsIsNull = true;
            requestResource_resource_TableWithColumns = new Amazon.LakeFormation.Model.TableWithColumnsResource();
            List<System.String> requestResource_resource_TableWithColumns_tableWithColumns_ColumnName = null;
            if (cmdletContext.TableWithColumns_ColumnName != null)
            {
                requestResource_resource_TableWithColumns_tableWithColumns_ColumnName = cmdletContext.TableWithColumns_ColumnName;
            }
            if (requestResource_resource_TableWithColumns_tableWithColumns_ColumnName != null)
            {
                requestResource_resource_TableWithColumns.ColumnNames = requestResource_resource_TableWithColumns_tableWithColumns_ColumnName;
                requestResource_resource_TableWithColumnsIsNull = false;
            }
            System.String requestResource_resource_TableWithColumns_tableWithColumns_DatabaseName = null;
            if (cmdletContext.TableWithColumns_DatabaseName != null)
            {
                requestResource_resource_TableWithColumns_tableWithColumns_DatabaseName = cmdletContext.TableWithColumns_DatabaseName;
            }
            if (requestResource_resource_TableWithColumns_tableWithColumns_DatabaseName != null)
            {
                requestResource_resource_TableWithColumns.DatabaseName = requestResource_resource_TableWithColumns_tableWithColumns_DatabaseName;
                requestResource_resource_TableWithColumnsIsNull = false;
            }
            System.String requestResource_resource_TableWithColumns_tableWithColumns_Name = null;
            if (cmdletContext.TableWithColumns_Name != null)
            {
                requestResource_resource_TableWithColumns_tableWithColumns_Name = cmdletContext.TableWithColumns_Name;
            }
            if (requestResource_resource_TableWithColumns_tableWithColumns_Name != null)
            {
                requestResource_resource_TableWithColumns.Name = requestResource_resource_TableWithColumns_tableWithColumns_Name;
                requestResource_resource_TableWithColumnsIsNull = false;
            }
            Amazon.LakeFormation.Model.ColumnWildcard requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard = null;
            
             // populate ColumnWildcard
            var requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcardIsNull = true;
            requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard = new Amazon.LakeFormation.Model.ColumnWildcard();
            List<System.String> requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard_columnWildcard_ExcludedColumnName = null;
            if (cmdletContext.ColumnWildcard_ExcludedColumnName != null)
            {
                requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard_columnWildcard_ExcludedColumnName = cmdletContext.ColumnWildcard_ExcludedColumnName;
            }
            if (requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard_columnWildcard_ExcludedColumnName != null)
            {
                requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard.ExcludedColumnNames = requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard_columnWildcard_ExcludedColumnName;
                requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcardIsNull = false;
            }
             // determine if requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard should be set to null
            if (requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcardIsNull)
            {
                requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard = null;
            }
            if (requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard != null)
            {
                requestResource_resource_TableWithColumns.ColumnWildcard = requestResource_resource_TableWithColumns_resource_TableWithColumns_ColumnWildcard;
                requestResource_resource_TableWithColumnsIsNull = false;
            }
             // determine if requestResource_resource_TableWithColumns should be set to null
            if (requestResource_resource_TableWithColumnsIsNull)
            {
                requestResource_resource_TableWithColumns = null;
            }
            if (requestResource_resource_TableWithColumns != null)
            {
                request.Resource.TableWithColumns = requestResource_resource_TableWithColumns;
                requestResourceIsNull = false;
            }
             // determine if request.Resource should be set to null
            if (requestResourceIsNull)
            {
                request.Resource = null;
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
        
        private Amazon.LakeFormation.Model.RevokePermissionsResponse CallAWSServiceOperation(IAmazonLakeFormation client, Amazon.LakeFormation.Model.RevokePermissionsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Lake Formation", "RevokePermissions");
            try
            {
                #if DESKTOP
                return client.RevokePermissions(request);
                #elif CORECLR
                return client.RevokePermissionsAsync(request).GetAwaiter().GetResult();
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
            public System.String CatalogId { get; set; }
            public List<System.String> Permission { get; set; }
            public List<System.String> PermissionsWithGrantOption { get; set; }
            public System.String Principal_DataLakePrincipalIdentifier { get; set; }
            public Amazon.LakeFormation.Model.CatalogResource Resource_Catalog { get; set; }
            public System.String Database_Name { get; set; }
            public System.String DataLocation_ResourceArn { get; set; }
            public System.String Table_DatabaseName { get; set; }
            public System.String Table_Name { get; set; }
            public List<System.String> TableWithColumns_ColumnName { get; set; }
            public List<System.String> ColumnWildcard_ExcludedColumnName { get; set; }
            public System.String TableWithColumns_DatabaseName { get; set; }
            public System.String TableWithColumns_Name { get; set; }
            public System.Func<Amazon.LakeFormation.Model.RevokePermissionsResponse, RevokeLKFPermissionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}

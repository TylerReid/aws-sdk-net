/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBClusterSnapshots operation.
    /// Returns information about cluster snapshots. This API operation supports pagination.
    /// </summary>
    public partial class DescribeDBClusterSnapshotsRequest : AmazonDocDBRequest
    {
        private string _dbClusterIdentifier;
        private string _dbClusterSnapshotIdentifier;
        private List<Filter> _filters = new List<Filter>();
        private bool? _includePublic;
        private bool? _includeShared;
        private string _marker;
        private int? _maxRecords;
        private string _snapshotType;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The ID of the cluster to retrieve the list of cluster snapshots for. This parameter
        /// can't be used with the <code>DBClusterSnapshotIdentifier</code> parameter. This parameter
        /// is not case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If provided, must match the identifier of an existing <code>DBCluster</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// A specific cluster snapshot identifier to describe. This parameter can't be used with
        /// the <code>DBClusterIdentifier</code> parameter. This value is stored as a lowercase
        /// string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If provided, must match the identifier of an existing <code>DBClusterSnapshot</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If this identifier is for an automated snapshot, the <code>SnapshotType</code> parameter
        /// must also be specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DBClusterSnapshotIdentifier
        {
            get { return this._dbClusterSnapshotIdentifier; }
            set { this._dbClusterSnapshotIdentifier = value; }
        }

        // Check to see if DBClusterSnapshotIdentifier property is set
        internal bool IsSetDBClusterSnapshotIdentifier()
        {
            return this._dbClusterSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter is not currently supported.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludePublic. 
        /// <para>
        /// Set to <code>true</code> to include manual cluster snapshots that are public and can
        /// be copied or restored by any AWS account, and otherwise <code>false</code>. The default
        /// is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludePublic
        {
            get { return this._includePublic.GetValueOrDefault(); }
            set { this._includePublic = value; }
        }

        // Check to see if IncludePublic property is set
        internal bool IsSetIncludePublic()
        {
            return this._includePublic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeShared. 
        /// <para>
        /// Set to <code>true</code> to include shared manual cluster snapshots from other AWS
        /// accounts that this AWS account has been given permission to copy or restore, and otherwise
        /// <code>false</code>. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IncludeShared
        {
            get { return this._includeShared.GetValueOrDefault(); }
            set { this._includeShared = value; }
        }

        // Check to see if IncludeShared property is set
        internal bool IsSetIncludeShared()
        {
            return this._includeShared.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///  The maximum number of records to include in the response. If more records exist than
        /// the specified <code>MaxRecords</code> value, a pagination token (marker) is included
        /// in the response so that the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of cluster snapshots to be returned. You can specify one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>automated</code> - Return all cluster snapshots that Amazon DocumentDB has
        /// automatically created for your AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>manual</code> - Return all cluster snapshots that you have manually created
        /// for your AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>shared</code> - Return all manual cluster snapshots that have been shared to
        /// your AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public</code> - Return all cluster snapshots that have been marked as public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <code>SnapshotType</code> value, then both automated and manual
        /// cluster snapshots are returned. You can include shared cluster snapshots with these
        /// results by setting the <code>IncludeShared</code> parameter to <code>true</code>.
        /// You can include public cluster snapshots with these results by setting the<code>IncludePublic</code>
        /// parameter to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>IncludeShared</code> and <code>IncludePublic</code> parameters don't apply
        /// for <code>SnapshotType</code> values of <code>manual</code> or <code>automated</code>.
        /// The <code>IncludePublic</code> parameter doesn't apply when <code>SnapshotType</code>
        /// is set to <code>shared</code>. The <code>IncludeShared</code> parameter doesn't apply
        /// when <code>SnapshotType</code> is set to <code>public</code>.
        /// </para>
        /// </summary>
        public string SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }

    }
}
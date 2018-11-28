/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for the Amazon FSx for Lustre file system.
    /// </summary>
    public partial class LustreFileSystemConfiguration
    {
        private DataRepositoryConfiguration _dataRepositoryConfiguration;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property DataRepositoryConfiguration.
        /// </summary>
        public DataRepositoryConfiguration DataRepositoryConfiguration
        {
            get { return this._dataRepositoryConfiguration; }
            set { this._dataRepositoryConfiguration = value; }
        }

        // Check to see if DataRepositoryConfiguration property is set
        internal bool IsSetDataRepositoryConfiguration()
        {
            return this._dataRepositoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The UTC time that you want to begin your weekly maintenance window.
        /// </para>
        /// </summary>
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}
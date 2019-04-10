/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dbs.Transform;
using Aliyun.Acs.Dbs.Transform.V20190306;

namespace Aliyun.Acs.Dbs.Model.V20190306
{
    public class ConfigureBackupPlanRequest : RpcAcsRequest<ConfigureBackupPlanResponse>
    {
        public ConfigureBackupPlanRequest()
            : base("Dbs", "2019-03-06", "ConfigureBackupPlan", "cbs", "openAPI")
        {
        }

		private string sourceEndpointRegion;

		private int? duplicationArchivePeriod;

		private long? backupGatewayId;

		private string sourceEndpointInstanceID;

		private string sourceEndpointUserName;

		private string clientToken;

		private string sourceEndpointPassword;

		private string backupPlanId;

		private string backupObjects;

		private string ownerId;

		private int? sourceEndpointPort;

		private string sourceEndpointDatabaseName;

		private int? backupRetentionPeriod;

		private int? duplicationInfrequentAccessPeriod;

		private string backupPeriod;

		private string backupStartTime;

		private string sourceEndpointInstanceType;

		private string sourceEndpointIP;

		private string backupPlanName;

		private string sourceEndpointOracleSID;

		private string oSSBucketName;

		private bool? enableBackupLog;

		public string SourceEndpointRegion
		{
			get
			{
				return sourceEndpointRegion;
			}
			set	
			{
				sourceEndpointRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointRegion", value);
			}
		}

		public int? DuplicationArchivePeriod
		{
			get
			{
				return duplicationArchivePeriod;
			}
			set	
			{
				duplicationArchivePeriod = value;
				DictionaryUtil.Add(QueryParameters, "DuplicationArchivePeriod", value.ToString());
			}
		}

		public long? BackupGatewayId
		{
			get
			{
				return backupGatewayId;
			}
			set	
			{
				backupGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "BackupGatewayId", value.ToString());
			}
		}

		public string SourceEndpointInstanceID
		{
			get
			{
				return sourceEndpointInstanceID;
			}
			set	
			{
				sourceEndpointInstanceID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceID", value);
			}
		}

		public string SourceEndpointUserName
		{
			get
			{
				return sourceEndpointUserName;
			}
			set	
			{
				sourceEndpointUserName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointUserName", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string SourceEndpointPassword
		{
			get
			{
				return sourceEndpointPassword;
			}
			set	
			{
				sourceEndpointPassword = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPassword", value);
			}
		}

		public string BackupPlanId
		{
			get
			{
				return backupPlanId;
			}
			set	
			{
				backupPlanId = value;
				DictionaryUtil.Add(QueryParameters, "BackupPlanId", value);
			}
		}

		public string BackupObjects
		{
			get
			{
				return backupObjects;
			}
			set	
			{
				backupObjects = value;
				DictionaryUtil.Add(QueryParameters, "BackupObjects", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public int? SourceEndpointPort
		{
			get
			{
				return sourceEndpointPort;
			}
			set	
			{
				sourceEndpointPort = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointPort", value.ToString());
			}
		}

		public string SourceEndpointDatabaseName
		{
			get
			{
				return sourceEndpointDatabaseName;
			}
			set	
			{
				sourceEndpointDatabaseName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointDatabaseName", value);
			}
		}

		public int? BackupRetentionPeriod
		{
			get
			{
				return backupRetentionPeriod;
			}
			set	
			{
				backupRetentionPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupRetentionPeriod", value.ToString());
			}
		}

		public int? DuplicationInfrequentAccessPeriod
		{
			get
			{
				return duplicationInfrequentAccessPeriod;
			}
			set	
			{
				duplicationInfrequentAccessPeriod = value;
				DictionaryUtil.Add(QueryParameters, "DuplicationInfrequentAccessPeriod", value.ToString());
			}
		}

		public string BackupPeriod
		{
			get
			{
				return backupPeriod;
			}
			set	
			{
				backupPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupPeriod", value);
			}
		}

		public string BackupStartTime
		{
			get
			{
				return backupStartTime;
			}
			set	
			{
				backupStartTime = value;
				DictionaryUtil.Add(QueryParameters, "BackupStartTime", value);
			}
		}

		public string SourceEndpointInstanceType
		{
			get
			{
				return sourceEndpointInstanceType;
			}
			set	
			{
				sourceEndpointInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointInstanceType", value);
			}
		}

		public string SourceEndpointIP
		{
			get
			{
				return sourceEndpointIP;
			}
			set	
			{
				sourceEndpointIP = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointIP", value);
			}
		}

		public string BackupPlanName
		{
			get
			{
				return backupPlanName;
			}
			set	
			{
				backupPlanName = value;
				DictionaryUtil.Add(QueryParameters, "BackupPlanName", value);
			}
		}

		public string SourceEndpointOracleSID
		{
			get
			{
				return sourceEndpointOracleSID;
			}
			set	
			{
				sourceEndpointOracleSID = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointOracleSID", value);
			}
		}

		public string OSSBucketName
		{
			get
			{
				return oSSBucketName;
			}
			set	
			{
				oSSBucketName = value;
				DictionaryUtil.Add(QueryParameters, "OSSBucketName", value);
			}
		}

		public bool? EnableBackupLog
		{
			get
			{
				return enableBackupLog;
			}
			set	
			{
				enableBackupLog = value;
				DictionaryUtil.Add(QueryParameters, "EnableBackupLog", value.ToString());
			}
		}

        public override ConfigureBackupPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigureBackupPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
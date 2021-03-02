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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class UpdateDnsGtmAddressPoolRequest : RpcAcsRequest<UpdateDnsGtmAddressPoolResponse>
    {
        public UpdateDnsGtmAddressPoolRequest()
            : base("Alidns", "2015-01-09", "UpdateDnsGtmAddressPool", "alidns", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string lbaStrategy;

		private string addrPoolId;

		private string name;

		private string lang;

		private List<Addr> addrs = new List<Addr>(){ };

		public string LbaStrategy
		{
			get
			{
				return lbaStrategy;
			}
			set	
			{
				lbaStrategy = value;
				DictionaryUtil.Add(QueryParameters, "LbaStrategy", value);
			}
		}

		public string AddrPoolId
		{
			get
			{
				return addrPoolId;
			}
			set	
			{
				addrPoolId = value;
				DictionaryUtil.Add(QueryParameters, "AddrPoolId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public List<Addr> Addrs
		{
			get
			{
				return addrs;
			}

			set
			{
				addrs = value;
				for (int i = 0; i < addrs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".Mode", addrs[i].Mode);
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".AttributeInfo", addrs[i].AttributeInfo);
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".Remark", addrs[i].Remark);
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".Addr", addrs[i].Addr_);
					DictionaryUtil.Add(QueryParameters,"Addr." + (i + 1) + ".LbaWeight", addrs[i].LbaWeight);
				}
			}
		}

		public class Addr
		{

			private string mode;

			private string attributeInfo;

			private string remark;

			private string addr_;

			private int? lbaWeight;

			public string Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}

			public string AttributeInfo
			{
				get
				{
					return attributeInfo;
				}
				set	
				{
					attributeInfo = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public string Addr_
			{
				get
				{
					return addr_;
				}
				set	
				{
					addr_ = value;
				}
			}

			public int? LbaWeight
			{
				get
				{
					return lbaWeight;
				}
				set	
				{
					lbaWeight = value;
				}
			}
		}

        public override UpdateDnsGtmAddressPoolResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDnsGtmAddressPoolResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

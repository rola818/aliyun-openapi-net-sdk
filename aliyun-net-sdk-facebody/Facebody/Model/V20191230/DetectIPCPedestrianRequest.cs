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
using Aliyun.Acs.facebody.Transform;
using Aliyun.Acs.facebody.Transform.V20191230;

namespace Aliyun.Acs.facebody.Model.V20191230
{
    public class DetectIPCPedestrianRequest : RpcAcsRequest<DetectIPCPedestrianResponse>
    {
        public DetectIPCPedestrianRequest()
            : base("facebody", "2019-12-30", "DetectIPCPedestrian", "facebody", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string imageData;

		private int? width;

		private int? height;

		public string ImageData
		{
			get
			{
				return imageData;
			}
			set	
			{
				imageData = value;
				DictionaryUtil.Add(BodyParameters, "ImageData", value);
			}
		}

		public int? Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(BodyParameters, "Width", value.ToString());
			}
		}

		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(BodyParameters, "Height", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DetectIPCPedestrianResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DetectIPCPedestrianResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

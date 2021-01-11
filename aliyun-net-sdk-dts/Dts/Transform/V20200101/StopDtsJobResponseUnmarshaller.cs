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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class StopDtsJobResponseUnmarshaller
    {
        public static StopDtsJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopDtsJobResponse stopDtsJobResponse = new StopDtsJobResponse();

			stopDtsJobResponse.HttpResponse = _ctx.HttpResponse;
			stopDtsJobResponse.DynamicCode = _ctx.StringValue("StopDtsJob.DynamicCode");
			stopDtsJobResponse.DynamicMessage = _ctx.StringValue("StopDtsJob.DynamicMessage");
			stopDtsJobResponse.ErrCode = _ctx.StringValue("StopDtsJob.ErrCode");
			stopDtsJobResponse.ErrMessage = _ctx.StringValue("StopDtsJob.ErrMessage");
			stopDtsJobResponse.HttpStatusCode = _ctx.IntegerValue("StopDtsJob.HttpStatusCode");
			stopDtsJobResponse.RequestId = _ctx.StringValue("StopDtsJob.RequestId");
			stopDtsJobResponse.Success = _ctx.BooleanValue("StopDtsJob.Success");
        
			return stopDtsJobResponse;
        }
    }
}

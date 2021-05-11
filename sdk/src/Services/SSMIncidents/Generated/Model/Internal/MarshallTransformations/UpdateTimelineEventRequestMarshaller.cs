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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTimelineEvent Request Marshaller
    /// </summary>       
    public class UpdateTimelineEventRequestMarshaller : IMarshaller<IRequest, UpdateTimelineEventRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTimelineEventRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTimelineEventRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMIncidents");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/updateTimelineEvent";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetEventData())
                {
                    context.Writer.WritePropertyName("eventData");
                    context.Writer.Write(publicRequest.EventData);
                }

                if(publicRequest.IsSetEventId())
                {
                    context.Writer.WritePropertyName("eventId");
                    context.Writer.Write(publicRequest.EventId);
                }

                if(publicRequest.IsSetEventTime())
                {
                    context.Writer.WritePropertyName("eventTime");
                    context.Writer.Write(publicRequest.EventTime);
                }

                if(publicRequest.IsSetEventType())
                {
                    context.Writer.WritePropertyName("eventType");
                    context.Writer.Write(publicRequest.EventType);
                }

                if(publicRequest.IsSetIncidentRecordArn())
                {
                    context.Writer.WritePropertyName("incidentRecordArn");
                    context.Writer.Write(publicRequest.IncidentRecordArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateTimelineEventRequestMarshaller _instance = new UpdateTimelineEventRequestMarshaller();        

        internal static UpdateTimelineEventRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTimelineEventRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
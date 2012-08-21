/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using System;
    using System.Net;
    using Amazon.Glacier.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for DeleteVault operation
      /// </summary>
      internal class DeleteVaultResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          DeleteVaultResponse response = new DeleteVaultResponse();
          
          return response;
        }
           
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode) 
        { 
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context); 
           
          if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException")) 
          { 
            return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
          } 
   
          if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException")) 
          { 
            return new MissingParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
          } 
   
          if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException")) 
          { 
            return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
          } 
   
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException")) 
          { 
            return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
          } 
   
          return new AmazonGlacierException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode); 
        } 
  
        private static DeleteVaultResponseUnmarshaller instance; 
        public static DeleteVaultResponseUnmarshaller GetInstance() 
        { 
          if (instance == null) 
          { 
            instance = new DeleteVaultResponseUnmarshaller(); 
          } 
          return instance;
        } 
  
      }
    }
  

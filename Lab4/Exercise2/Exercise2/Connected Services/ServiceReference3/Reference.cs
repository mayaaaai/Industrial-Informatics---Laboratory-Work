﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exercise2.ServiceReference3 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name unit from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertTemp", ReplyAction="*")]
        Exercise2.ServiceReference3.ConvertTempResponse ConvertTemp(Exercise2.ServiceReference3.ConvertTempRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercise2.ServiceReference3.ConvertTempResponse> ConvertTempAsync(Exercise2.ServiceReference3.ConvertTempRequest request);
        
        // CODEGEN: Generating message contract since element name GetDateResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDate", ReplyAction="*")]
        Exercise2.ServiceReference3.GetDateResponse GetDate(Exercise2.ServiceReference3.GetDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDate", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercise2.ServiceReference3.GetDateResponse> GetDateAsync(Exercise2.ServiceReference3.GetDateRequest request);
        
        // CODEGEN: Generating message contract since element name FiveElementsListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FiveElementsList", ReplyAction="*")]
        Exercise2.ServiceReference3.FiveElementsListResponse FiveElementsList(Exercise2.ServiceReference3.FiveElementsListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FiveElementsList", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercise2.ServiceReference3.FiveElementsListResponse> FiveElementsListAsync(Exercise2.ServiceReference3.FiveElementsListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertRONtoEURO", ReplyAction="*")]
        double ConvertRONtoEURO(double ron);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertRONtoEURO", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertRONtoEUROAsync(double ron);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertTempRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertTemp", Namespace="http://tempuri.org/", Order=0)]
        public Exercise2.ServiceReference3.ConvertTempRequestBody Body;
        
        public ConvertTempRequest() {
        }
        
        public ConvertTempRequest(Exercise2.ServiceReference3.ConvertTempRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertTempRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double temp;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string unit;
        
        public ConvertTempRequestBody() {
        }
        
        public ConvertTempRequestBody(double temp, string unit) {
            this.temp = temp;
            this.unit = unit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertTempResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertTempResponse", Namespace="http://tempuri.org/", Order=0)]
        public Exercise2.ServiceReference3.ConvertTempResponseBody Body;
        
        public ConvertTempResponse() {
        }
        
        public ConvertTempResponse(Exercise2.ServiceReference3.ConvertTempResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertTempResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double ConvertTempResult;
        
        public ConvertTempResponseBody() {
        }
        
        public ConvertTempResponseBody(double ConvertTempResult) {
            this.ConvertTempResult = ConvertTempResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDate", Namespace="http://tempuri.org/", Order=0)]
        public Exercise2.ServiceReference3.GetDateRequestBody Body;
        
        public GetDateRequest() {
        }
        
        public GetDateRequest(Exercise2.ServiceReference3.GetDateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetDateRequestBody {
        
        public GetDateRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateResponse", Namespace="http://tempuri.org/", Order=0)]
        public Exercise2.ServiceReference3.GetDateResponseBody Body;
        
        public GetDateResponse() {
        }
        
        public GetDateResponse(Exercise2.ServiceReference3.GetDateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetDateResult;
        
        public GetDateResponseBody() {
        }
        
        public GetDateResponseBody(string GetDateResult) {
            this.GetDateResult = GetDateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FiveElementsListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FiveElementsList", Namespace="http://tempuri.org/", Order=0)]
        public Exercise2.ServiceReference3.FiveElementsListRequestBody Body;
        
        public FiveElementsListRequest() {
        }
        
        public FiveElementsListRequest(Exercise2.ServiceReference3.FiveElementsListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class FiveElementsListRequestBody {
        
        public FiveElementsListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FiveElementsListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FiveElementsListResponse", Namespace="http://tempuri.org/", Order=0)]
        public Exercise2.ServiceReference3.FiveElementsListResponseBody Body;
        
        public FiveElementsListResponse() {
        }
        
        public FiveElementsListResponse(Exercise2.ServiceReference3.FiveElementsListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FiveElementsListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Exercise2.ServiceReference3.ArrayOfString FiveElementsListResult;
        
        public FiveElementsListResponseBody() {
        }
        
        public FiveElementsListResponseBody(Exercise2.ServiceReference3.ArrayOfString FiveElementsListResult) {
            this.FiveElementsListResult = FiveElementsListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Exercise2.ServiceReference3.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Exercise2.ServiceReference3.WebService1Soap>, Exercise2.ServiceReference3.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Exercise2.ServiceReference3.ConvertTempResponse Exercise2.ServiceReference3.WebService1Soap.ConvertTemp(Exercise2.ServiceReference3.ConvertTempRequest request) {
            return base.Channel.ConvertTemp(request);
        }
        
        public double ConvertTemp(double temp, string unit) {
            Exercise2.ServiceReference3.ConvertTempRequest inValue = new Exercise2.ServiceReference3.ConvertTempRequest();
            inValue.Body = new Exercise2.ServiceReference3.ConvertTempRequestBody();
            inValue.Body.temp = temp;
            inValue.Body.unit = unit;
            Exercise2.ServiceReference3.ConvertTempResponse retVal = ((Exercise2.ServiceReference3.WebService1Soap)(this)).ConvertTemp(inValue);
            return retVal.Body.ConvertTempResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Exercise2.ServiceReference3.ConvertTempResponse> Exercise2.ServiceReference3.WebService1Soap.ConvertTempAsync(Exercise2.ServiceReference3.ConvertTempRequest request) {
            return base.Channel.ConvertTempAsync(request);
        }
        
        public System.Threading.Tasks.Task<Exercise2.ServiceReference3.ConvertTempResponse> ConvertTempAsync(double temp, string unit) {
            Exercise2.ServiceReference3.ConvertTempRequest inValue = new Exercise2.ServiceReference3.ConvertTempRequest();
            inValue.Body = new Exercise2.ServiceReference3.ConvertTempRequestBody();
            inValue.Body.temp = temp;
            inValue.Body.unit = unit;
            return ((Exercise2.ServiceReference3.WebService1Soap)(this)).ConvertTempAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Exercise2.ServiceReference3.GetDateResponse Exercise2.ServiceReference3.WebService1Soap.GetDate(Exercise2.ServiceReference3.GetDateRequest request) {
            return base.Channel.GetDate(request);
        }
        
        public string GetDate() {
            Exercise2.ServiceReference3.GetDateRequest inValue = new Exercise2.ServiceReference3.GetDateRequest();
            inValue.Body = new Exercise2.ServiceReference3.GetDateRequestBody();
            Exercise2.ServiceReference3.GetDateResponse retVal = ((Exercise2.ServiceReference3.WebService1Soap)(this)).GetDate(inValue);
            return retVal.Body.GetDateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Exercise2.ServiceReference3.GetDateResponse> Exercise2.ServiceReference3.WebService1Soap.GetDateAsync(Exercise2.ServiceReference3.GetDateRequest request) {
            return base.Channel.GetDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Exercise2.ServiceReference3.GetDateResponse> GetDateAsync() {
            Exercise2.ServiceReference3.GetDateRequest inValue = new Exercise2.ServiceReference3.GetDateRequest();
            inValue.Body = new Exercise2.ServiceReference3.GetDateRequestBody();
            return ((Exercise2.ServiceReference3.WebService1Soap)(this)).GetDateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Exercise2.ServiceReference3.FiveElementsListResponse Exercise2.ServiceReference3.WebService1Soap.FiveElementsList(Exercise2.ServiceReference3.FiveElementsListRequest request) {
            return base.Channel.FiveElementsList(request);
        }
        
        public Exercise2.ServiceReference3.ArrayOfString FiveElementsList() {
            Exercise2.ServiceReference3.FiveElementsListRequest inValue = new Exercise2.ServiceReference3.FiveElementsListRequest();
            inValue.Body = new Exercise2.ServiceReference3.FiveElementsListRequestBody();
            Exercise2.ServiceReference3.FiveElementsListResponse retVal = ((Exercise2.ServiceReference3.WebService1Soap)(this)).FiveElementsList(inValue);
            return retVal.Body.FiveElementsListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Exercise2.ServiceReference3.FiveElementsListResponse> Exercise2.ServiceReference3.WebService1Soap.FiveElementsListAsync(Exercise2.ServiceReference3.FiveElementsListRequest request) {
            return base.Channel.FiveElementsListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Exercise2.ServiceReference3.FiveElementsListResponse> FiveElementsListAsync(string text) {
            Exercise2.ServiceReference3.FiveElementsListRequest inValue = new Exercise2.ServiceReference3.FiveElementsListRequest();
            inValue.Body = new Exercise2.ServiceReference3.FiveElementsListRequestBody();
            return ((Exercise2.ServiceReference3.WebService1Soap)(this)).FiveElementsListAsync(inValue);
        }
        
        public double ConvertRONtoEURO(double ron) {
            return base.Channel.ConvertRONtoEURO(ron);
        }
        
        public System.Threading.Tasks.Task<double> ConvertRONtoEUROAsync(double ron) {
            return base.Channel.ConvertRONtoEUROAsync(ron);
        }
    }
}

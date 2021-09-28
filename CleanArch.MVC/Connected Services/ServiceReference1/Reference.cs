﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TBSAttachment", Namespace="http://schemas.datacontract.org/2004/07/TBS.Services.WebService")]
    public partial class TBSAttachment : object
    {
        
        private string FileNameField;
        
        private byte[] FileSourceField;
        
        private string FileTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName
        {
            get
            {
                return this.FileNameField;
            }
            set
            {
                this.FileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] FileSource
        {
            get
            {
                return this.FileSourceField;
            }
            set
            {
                this.FileSourceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileType
        {
            get
            {
                return this.FileTypeField;
            }
            set
            {
                this.FileTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TBSParameter", Namespace="http://schemas.datacontract.org/2004/07/TBS.Services.WebService")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSAttachment[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSAttachment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSParameter[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSFormData[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSFormData))]
    public partial class TBSParameter : object
    {
        
        private string NameField;
        
        private string TypeField;
        
        private object ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TBSFormData", Namespace="http://schemas.datacontract.org/2004/07/TBS.Services.WebService")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSAttachment[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSAttachment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSParameter[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSParameter))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.TBSFormData[]))]
    public partial class TBSFormData : object
    {
        
        private string ComponentIdField;
        
        private object ComponentValueField;
        
        private long FormIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ComponentId
        {
            get
            {
                return this.ComponentIdField;
            }
            set
            {
                this.ComponentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object ComponentValue
        {
            get
            {
                return this.ComponentValueField;
            }
            set
            {
                this.ComponentValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long FormId
        {
            get
            {
                return this.FormIdField;
            }
            set
            {
                this.FormIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWorkflowService")]
    public interface IWorkflowService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/StartEmailWorkFlow", ReplyAction="http://tempuri.org/IWorkflowService/StartEmailWorkFlowResponse")]
        System.Threading.Tasks.Task<long> StartEmailWorkFlowAsync(long WorkflowId, string tokenID, string messageID, string emailLink, string[] fromContactAddress, string[] toContactAddress, string[] ccContactAddress, string messageText, ServiceReference1.TBSAttachment[] Attachments);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/StartSMSWorkFlow", ReplyAction="http://tempuri.org/IWorkflowService/StartSMSWorkFlowResponse")]
        System.Threading.Tasks.Task<long> StartSMSWorkFlowAsync(long WorkflowId, string tokenID, string messageID, string mobileNo, string messageText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/StartIVRWorkFlow", ReplyAction="http://tempuri.org/IWorkflowService/StartIVRWorkFlowResponse")]
        System.Threading.Tasks.Task<long> StartIVRWorkFlowAsync(long WorkflowId, string tokenID, int customerProfileID, int contactType, long boxCode, string contactKey, byte[] fileContent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/StartWorkflow", ReplyAction="http://tempuri.org/IWorkflowService/StartWorkflowResponse")]
        System.Threading.Tasks.Task<long> StartWorkflowAsync(long workflowId, ServiceReference1.TBSParameter[] Params, ServiceReference1.TBSAttachment[] attachment, long StarterUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/GetTicketStatus", ReplyAction="http://tempuri.org/IWorkflowService/GetTicketStatusResponse")]
        System.Threading.Tasks.Task<int> GetTicketStatusAsync(string TicketNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/StartTicketWorkflow", ReplyAction="http://tempuri.org/IWorkflowService/StartTicketWorkflowResponse")]
        System.Threading.Tasks.Task<string> StartTicketWorkflowAsync(long workflowId, ServiceReference1.TBSParameter[] paramList, ServiceReference1.TBSAttachment[] attachmentList, long StarterUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/UpdateTaskStatusId", ReplyAction="http://tempuri.org/IWorkflowService/UpdateTaskStatusIdResponse")]
        System.Threading.Tasks.Task UpdateTaskStatusIdAsync(long workflowId, long taskId, long workflowInstanceId, long taskStatusId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/UpdateMessageDeliveryStatus", ReplyAction="http://tempuri.org/IWorkflowService/UpdateMessageDeliveryStatusResponse")]
        System.Threading.Tasks.Task UpdateMessageDeliveryStatusAsync(int MessageId, int StatusId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/ExitTaskFromWaitStatus", ReplyAction="http://tempuri.org/IWorkflowService/ExitTaskFromWaitStatusResponse")]
        System.Threading.Tasks.Task<bool> ExitTaskFromWaitStatusAsync(long workflowInstanceId, long ActivityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/DoneTask", ReplyAction="http://tempuri.org/IWorkflowService/DoneTaskResponse")]
        System.Threading.Tasks.Task<bool> DoneTaskAsync(long workflowInstanceId, long ActivityId, long resultCondition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkflowService/DoneTaskWithData", ReplyAction="http://tempuri.org/IWorkflowService/DoneTaskWithDataResponse")]
        System.Threading.Tasks.Task<int> DoneTaskWithDataAsync(long workflowInstanceId, long ActivityId, long resultCondition, ServiceReference1.TBSFormData[] formData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IWorkflowServiceChannel : ServiceReference1.IWorkflowService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class WorkflowServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IWorkflowService>, ServiceReference1.IWorkflowService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WorkflowServiceClient() : 
                base(WorkflowServiceClient.GetDefaultBinding(), WorkflowServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWorkflowService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WorkflowServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WorkflowServiceClient.GetBindingForEndpoint(endpointConfiguration), WorkflowServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WorkflowServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WorkflowServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WorkflowServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WorkflowServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WorkflowServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<long> StartEmailWorkFlowAsync(long WorkflowId, string tokenID, string messageID, string emailLink, string[] fromContactAddress, string[] toContactAddress, string[] ccContactAddress, string messageText, ServiceReference1.TBSAttachment[] Attachments)
        {
            return base.Channel.StartEmailWorkFlowAsync(WorkflowId, tokenID, messageID, emailLink, fromContactAddress, toContactAddress, ccContactAddress, messageText, Attachments);
        }
        
        public System.Threading.Tasks.Task<long> StartSMSWorkFlowAsync(long WorkflowId, string tokenID, string messageID, string mobileNo, string messageText)
        {
            return base.Channel.StartSMSWorkFlowAsync(WorkflowId, tokenID, messageID, mobileNo, messageText);
        }
        
        public System.Threading.Tasks.Task<long> StartIVRWorkFlowAsync(long WorkflowId, string tokenID, int customerProfileID, int contactType, long boxCode, string contactKey, byte[] fileContent)
        {
            return base.Channel.StartIVRWorkFlowAsync(WorkflowId, tokenID, customerProfileID, contactType, boxCode, contactKey, fileContent);
        }
        
        public System.Threading.Tasks.Task<long> StartWorkflowAsync(long workflowId, ServiceReference1.TBSParameter[] Params, ServiceReference1.TBSAttachment[] attachment, long StarterUserId)
        {
            return base.Channel.StartWorkflowAsync(workflowId, Params, attachment, StarterUserId);
        }
        
        public System.Threading.Tasks.Task<int> GetTicketStatusAsync(string TicketNo)
        {
            return base.Channel.GetTicketStatusAsync(TicketNo);
        }
        
        public System.Threading.Tasks.Task<string> StartTicketWorkflowAsync(long workflowId, ServiceReference1.TBSParameter[] paramList, ServiceReference1.TBSAttachment[] attachmentList, long StarterUserId)
        {
            return base.Channel.StartTicketWorkflowAsync(workflowId, paramList, attachmentList, StarterUserId);
        }
        
        public System.Threading.Tasks.Task UpdateTaskStatusIdAsync(long workflowId, long taskId, long workflowInstanceId, long taskStatusId)
        {
            return base.Channel.UpdateTaskStatusIdAsync(workflowId, taskId, workflowInstanceId, taskStatusId);
        }
        
        public System.Threading.Tasks.Task UpdateMessageDeliveryStatusAsync(int MessageId, int StatusId)
        {
            return base.Channel.UpdateMessageDeliveryStatusAsync(MessageId, StatusId);
        }
        
        public System.Threading.Tasks.Task<bool> ExitTaskFromWaitStatusAsync(long workflowInstanceId, long ActivityId)
        {
            return base.Channel.ExitTaskFromWaitStatusAsync(workflowInstanceId, ActivityId);
        }
        
        public System.Threading.Tasks.Task<bool> DoneTaskAsync(long workflowInstanceId, long ActivityId, long resultCondition)
        {
            return base.Channel.DoneTaskAsync(workflowInstanceId, ActivityId, resultCondition);
        }
        
        public System.Threading.Tasks.Task<int> DoneTaskWithDataAsync(long workflowInstanceId, long ActivityId, long resultCondition, ServiceReference1.TBSFormData[] formData)
        {
            return base.Channel.DoneTaskWithDataAsync(workflowInstanceId, ActivityId, resultCondition, formData);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWorkflowService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWorkflowService))
            {
                return new System.ServiceModel.EndpointAddress("http://172.20.11.32/TBSWorkflowService/WorkflowService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WorkflowServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWorkflowService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WorkflowServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWorkflowService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IWorkflowService,
        }
    }
}
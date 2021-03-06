﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLayer.BusinessServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusinessServices.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchEmployeeByNameBS", ReplyAction="http://tempuri.org/IService1/SearchEmployeeByNameBSResponse")]
        System.Data.DataTable SearchEmployeeByNameBS(string fName, string lName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchEmployeeByNameBS", ReplyAction="http://tempuri.org/IService1/SearchEmployeeByNameBSResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchEmployeeByNameBSAsync(string fName, string lName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchProjectBS", ReplyAction="http://tempuri.org/IService1/SearchProjectBSResponse")]
        System.Data.DataTable SearchProjectBS(string projName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchProjectBS", ReplyAction="http://tempuri.org/IService1/SearchProjectBSResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchProjectBSAsync(string projName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchCategoryBS", ReplyAction="http://tempuri.org/IService1/SearchCategoryBSResponse")]
        System.Data.DataTable SearchCategoryBS(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchCategoryBS", ReplyAction="http://tempuri.org/IService1/SearchCategoryBSResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchCategoryBSAsync(string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchSkillBS", ReplyAction="http://tempuri.org/IService1/SearchSkillBSResponse")]
        System.Data.DataTable SearchSkillBS(string skillName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchSkillBS", ReplyAction="http://tempuri.org/IService1/SearchSkillBSResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchSkillBSAsync(string skillName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : BusinessLayer.BusinessServices.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<BusinessLayer.BusinessServices.IService1>, BusinessLayer.BusinessServices.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable SearchEmployeeByNameBS(string fName, string lName) {
            return base.Channel.SearchEmployeeByNameBS(fName, lName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchEmployeeByNameBSAsync(string fName, string lName) {
            return base.Channel.SearchEmployeeByNameBSAsync(fName, lName);
        }
        
        public System.Data.DataTable SearchProjectBS(string projName) {
            return base.Channel.SearchProjectBS(projName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchProjectBSAsync(string projName) {
            return base.Channel.SearchProjectBSAsync(projName);
        }
        
        public System.Data.DataTable SearchCategoryBS(string categoryName) {
            return base.Channel.SearchCategoryBS(categoryName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchCategoryBSAsync(string categoryName) {
            return base.Channel.SearchCategoryBSAsync(categoryName);
        }
        
        public System.Data.DataTable SearchSkillBS(string skillName) {
            return base.Channel.SearchSkillBS(skillName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchSkillBSAsync(string skillName) {
            return base.Channel.SearchSkillBSAsync(skillName);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntoVentaCliente.WSProductos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.com/webservices/", ConfigurationName="WSProductos.WSProductosSoap")]
    public interface WSProductosSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ConsultarProductosResult del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ConsultarProductos", ReplyAction="*")]
        PuntoVentaCliente.WSProductos.ConsultarProductosResponse ConsultarProductos(PuntoVentaCliente.WSProductos.ConsultarProductosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ConsultarProductos", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.ConsultarProductosResponse> ConsultarProductosAsync(PuntoVentaCliente.WSProductos.ConsultarProductosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento json del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarProducto", ReplyAction="*")]
        PuntoVentaCliente.WSProductos.InsertarProductoResponse InsertarProducto(PuntoVentaCliente.WSProductos.InsertarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/InsertarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.InsertarProductoResponse> InsertarProductoAsync(PuntoVentaCliente.WSProductos.InsertarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/EliminarProducto", ReplyAction="*")]
        bool EliminarProducto(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/EliminarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarProductoAsync(int id);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento json del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ActualizarProducto", ReplyAction="*")]
        PuntoVentaCliente.WSProductos.ActualizarProductoResponse ActualizarProducto(PuntoVentaCliente.WSProductos.ActualizarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/ActualizarProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.ActualizarProductoResponse> ActualizarProductoAsync(PuntoVentaCliente.WSProductos.ActualizarProductoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento busqueda del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/BuscarProductos", ReplyAction="*")]
        PuntoVentaCliente.WSProductos.BuscarProductosResponse BuscarProductos(PuntoVentaCliente.WSProductos.BuscarProductosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/BuscarProductos", ReplyAction="*")]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.BuscarProductosResponse> BuscarProductosAsync(PuntoVentaCliente.WSProductos.BuscarProductosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarProductosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarProductos", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.ConsultarProductosRequestBody Body;
        
        public ConsultarProductosRequest() {
        }
        
        public ConsultarProductosRequest(PuntoVentaCliente.WSProductos.ConsultarProductosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ConsultarProductosRequestBody {
        
        public ConsultarProductosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultarProductosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultarProductosResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.ConsultarProductosResponseBody Body;
        
        public ConsultarProductosResponse() {
        }
        
        public ConsultarProductosResponse(PuntoVentaCliente.WSProductos.ConsultarProductosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class ConsultarProductosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConsultarProductosResult;
        
        public ConsultarProductosResponseBody() {
        }
        
        public ConsultarProductosResponseBody(string ConsultarProductosResult) {
            this.ConsultarProductosResult = ConsultarProductosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarProducto", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.InsertarProductoRequestBody Body;
        
        public InsertarProductoRequest() {
        }
        
        public InsertarProductoRequest(PuntoVentaCliente.WSProductos.InsertarProductoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarProductoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string json;
        
        public InsertarProductoRequestBody() {
        }
        
        public InsertarProductoRequestBody(string json) {
            this.json = json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarProductoResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.InsertarProductoResponseBody Body;
        
        public InsertarProductoResponse() {
        }
        
        public InsertarProductoResponse(PuntoVentaCliente.WSProductos.InsertarProductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class InsertarProductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertarProductoResult;
        
        public InsertarProductoResponseBody() {
        }
        
        public InsertarProductoResponseBody(bool InsertarProductoResult) {
            this.InsertarProductoResult = InsertarProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizarProducto", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.ActualizarProductoRequestBody Body;
        
        public ActualizarProductoRequest() {
        }
        
        public ActualizarProductoRequest(PuntoVentaCliente.WSProductos.ActualizarProductoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class ActualizarProductoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string json;
        
        public ActualizarProductoRequestBody() {
        }
        
        public ActualizarProductoRequestBody(string json) {
            this.json = json;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizarProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizarProductoResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.ActualizarProductoResponseBody Body;
        
        public ActualizarProductoResponse() {
        }
        
        public ActualizarProductoResponse(PuntoVentaCliente.WSProductos.ActualizarProductoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class ActualizarProductoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ActualizarProductoResult;
        
        public ActualizarProductoResponseBody() {
        }
        
        public ActualizarProductoResponseBody(bool ActualizarProductoResult) {
            this.ActualizarProductoResult = ActualizarProductoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarProductosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarProductos", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.BuscarProductosRequestBody Body;
        
        public BuscarProductosRequest() {
        }
        
        public BuscarProductosRequest(PuntoVentaCliente.WSProductos.BuscarProductosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class BuscarProductosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string busqueda;
        
        public BuscarProductosRequestBody() {
        }
        
        public BuscarProductosRequestBody(string busqueda) {
            this.busqueda = busqueda;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuscarProductosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuscarProductosResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public PuntoVentaCliente.WSProductos.BuscarProductosResponseBody Body;
        
        public BuscarProductosResponse() {
        }
        
        public BuscarProductosResponse(PuntoVentaCliente.WSProductos.BuscarProductosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class BuscarProductosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BuscarProductosResult;
        
        public BuscarProductosResponseBody() {
        }
        
        public BuscarProductosResponseBody(string BuscarProductosResult) {
            this.BuscarProductosResult = BuscarProductosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSProductosSoapChannel : PuntoVentaCliente.WSProductos.WSProductosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSProductosSoapClient : System.ServiceModel.ClientBase<PuntoVentaCliente.WSProductos.WSProductosSoap>, PuntoVentaCliente.WSProductos.WSProductosSoap {
        
        public WSProductosSoapClient() {
        }
        
        public WSProductosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSProductosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSProductosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSProductosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSProductos.ConsultarProductosResponse PuntoVentaCliente.WSProductos.WSProductosSoap.ConsultarProductos(PuntoVentaCliente.WSProductos.ConsultarProductosRequest request) {
            return base.Channel.ConsultarProductos(request);
        }
        
        public string ConsultarProductos() {
            PuntoVentaCliente.WSProductos.ConsultarProductosRequest inValue = new PuntoVentaCliente.WSProductos.ConsultarProductosRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.ConsultarProductosRequestBody();
            PuntoVentaCliente.WSProductos.ConsultarProductosResponse retVal = ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).ConsultarProductos(inValue);
            return retVal.Body.ConsultarProductosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.ConsultarProductosResponse> PuntoVentaCliente.WSProductos.WSProductosSoap.ConsultarProductosAsync(PuntoVentaCliente.WSProductos.ConsultarProductosRequest request) {
            return base.Channel.ConsultarProductosAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.ConsultarProductosResponse> ConsultarProductosAsync() {
            PuntoVentaCliente.WSProductos.ConsultarProductosRequest inValue = new PuntoVentaCliente.WSProductos.ConsultarProductosRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.ConsultarProductosRequestBody();
            return ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).ConsultarProductosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSProductos.InsertarProductoResponse PuntoVentaCliente.WSProductos.WSProductosSoap.InsertarProducto(PuntoVentaCliente.WSProductos.InsertarProductoRequest request) {
            return base.Channel.InsertarProducto(request);
        }
        
        public bool InsertarProducto(string json) {
            PuntoVentaCliente.WSProductos.InsertarProductoRequest inValue = new PuntoVentaCliente.WSProductos.InsertarProductoRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.InsertarProductoRequestBody();
            inValue.Body.json = json;
            PuntoVentaCliente.WSProductos.InsertarProductoResponse retVal = ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).InsertarProducto(inValue);
            return retVal.Body.InsertarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.InsertarProductoResponse> PuntoVentaCliente.WSProductos.WSProductosSoap.InsertarProductoAsync(PuntoVentaCliente.WSProductos.InsertarProductoRequest request) {
            return base.Channel.InsertarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.InsertarProductoResponse> InsertarProductoAsync(string json) {
            PuntoVentaCliente.WSProductos.InsertarProductoRequest inValue = new PuntoVentaCliente.WSProductos.InsertarProductoRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.InsertarProductoRequestBody();
            inValue.Body.json = json;
            return ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).InsertarProductoAsync(inValue);
        }
        
        public bool EliminarProducto(int id) {
            return base.Channel.EliminarProducto(id);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarProductoAsync(int id) {
            return base.Channel.EliminarProductoAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSProductos.ActualizarProductoResponse PuntoVentaCliente.WSProductos.WSProductosSoap.ActualizarProducto(PuntoVentaCliente.WSProductos.ActualizarProductoRequest request) {
            return base.Channel.ActualizarProducto(request);
        }
        
        public bool ActualizarProducto(string json) {
            PuntoVentaCliente.WSProductos.ActualizarProductoRequest inValue = new PuntoVentaCliente.WSProductos.ActualizarProductoRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.ActualizarProductoRequestBody();
            inValue.Body.json = json;
            PuntoVentaCliente.WSProductos.ActualizarProductoResponse retVal = ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).ActualizarProducto(inValue);
            return retVal.Body.ActualizarProductoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.ActualizarProductoResponse> PuntoVentaCliente.WSProductos.WSProductosSoap.ActualizarProductoAsync(PuntoVentaCliente.WSProductos.ActualizarProductoRequest request) {
            return base.Channel.ActualizarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.ActualizarProductoResponse> ActualizarProductoAsync(string json) {
            PuntoVentaCliente.WSProductos.ActualizarProductoRequest inValue = new PuntoVentaCliente.WSProductos.ActualizarProductoRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.ActualizarProductoRequestBody();
            inValue.Body.json = json;
            return ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).ActualizarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PuntoVentaCliente.WSProductos.BuscarProductosResponse PuntoVentaCliente.WSProductos.WSProductosSoap.BuscarProductos(PuntoVentaCliente.WSProductos.BuscarProductosRequest request) {
            return base.Channel.BuscarProductos(request);
        }
        
        public string BuscarProductos(string busqueda) {
            PuntoVentaCliente.WSProductos.BuscarProductosRequest inValue = new PuntoVentaCliente.WSProductos.BuscarProductosRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.BuscarProductosRequestBody();
            inValue.Body.busqueda = busqueda;
            PuntoVentaCliente.WSProductos.BuscarProductosResponse retVal = ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).BuscarProductos(inValue);
            return retVal.Body.BuscarProductosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.BuscarProductosResponse> PuntoVentaCliente.WSProductos.WSProductosSoap.BuscarProductosAsync(PuntoVentaCliente.WSProductos.BuscarProductosRequest request) {
            return base.Channel.BuscarProductosAsync(request);
        }
        
        public System.Threading.Tasks.Task<PuntoVentaCliente.WSProductos.BuscarProductosResponse> BuscarProductosAsync(string busqueda) {
            PuntoVentaCliente.WSProductos.BuscarProductosRequest inValue = new PuntoVentaCliente.WSProductos.BuscarProductosRequest();
            inValue.Body = new PuntoVentaCliente.WSProductos.BuscarProductosRequestBody();
            inValue.Body.busqueda = busqueda;
            return ((PuntoVentaCliente.WSProductos.WSProductosSoap)(this)).BuscarProductosAsync(inValue);
        }
    }
}

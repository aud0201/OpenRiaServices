//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ServiceModel;

namespace TestDomainServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using OpenRiaServices;
    using OpenRiaServices.DomainServices;
    using OpenRiaServices.DomainServices.Client;
    using OpenRiaServices.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    
    /// <summary>
    /// The 'IncludesA' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TestDomainServices")]
    public sealed partial class IncludesA : Entity
    {
        
        private string _bp1;
        
        private string _cp1;
        
        private string _dp2;
        
        private int _id;
        
        private string _p1;
        
        private string _p2;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnBP1Changing(string value);
        partial void OnBP1Changed();
        partial void OnCP1Changing(string value);
        partial void OnCP1Changed();
        partial void OnDP2Changing(string value);
        partial void OnDP2Changed();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnP1Changing(string value);
        partial void OnP1Changed();
        partial void OnP2Changing(string value);
        partial void OnP2Changed();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="IncludesA"/> class.
        /// </summary>
        public IncludesA()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'BP1' value.
        /// </summary>
        [DataMember()]
        [Editable(false)]
        public string BP1
        {
            get
            {
                return this._bp1;
            }
            set
            {
                if ((this._bp1 != value))
                {
                    this.OnBP1Changing(value);
                    this.ValidateProperty("BP1", value);
                    this._bp1 = value;
                    this.RaisePropertyChanged("BP1");
                    this.OnBP1Changed();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'CP1' value.
        /// </summary>
        [DataMember()]
        [Editable(false)]
        public string CP1
        {
            get
            {
                return this._cp1;
            }
            set
            {
                if ((this._cp1 != value))
                {
                    this.OnCP1Changing(value);
                    this.ValidateProperty("CP1", value);
                    this._cp1 = value;
                    this.RaisePropertyChanged("CP1");
                    this.OnCP1Changed();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'DP2' value.
        /// </summary>
        [DataMember()]
        [Editable(false)]
        public string DP2
        {
            get
            {
                return this._dp2;
            }
            set
            {
                if ((this._dp2 != value))
                {
                    this.OnDP2Changing(value);
                    this.ValidateProperty("DP2", value);
                    this._dp2 = value;
                    this.RaisePropertyChanged("DP2");
                    this.OnDP2Changed();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'ID' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIDChanging(value);
                    this.ValidateProperty("ID", value);
                    this._id = value;
                    this.RaisePropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'P1' value.
        /// </summary>
        [DataMember()]
        public string P1
        {
            get
            {
                return this._p1;
            }
            set
            {
                if ((this._p1 != value))
                {
                    this.OnP1Changing(value);
                    this.RaiseDataMemberChanging("P1");
                    this.ValidateProperty("P1", value);
                    this._p1 = value;
                    this.RaiseDataMemberChanged("P1");
                    this.OnP1Changed();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'P2' value.
        /// </summary>
        [DataMember()]
        public string P2
        {
            get
            {
                return this._p2;
            }
            set
            {
                if ((this._p2 != value))
                {
                    this.OnP2Changing(value);
                    this.RaiseDataMemberChanging("P2");
                    this.ValidateProperty("P2", value);
                    this._p2 = value;
                    this.RaiseDataMemberChanged("P2");
                    this.OnP2Changed();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'IncludeScenariosTestProvider' DomainService.
    /// </summary>
    public sealed partial class IncludeScenariosTestProvider : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="IncludeScenariosTestProvider"/> class.
        /// </summary>
        public IncludeScenariosTestProvider() : 
                this(new WebDomainClient<IIncludeScenariosTestProviderContract>(new Uri("TestDomainServices-IncludeScenariosTestProvider.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="IncludeScenariosTestProvider"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The IncludeScenariosTestProvider service URI.</param>
        public IncludeScenariosTestProvider(Uri serviceUri) : 
                this(new WebDomainClient<IIncludeScenariosTestProviderContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="IncludeScenariosTestProvider"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public IncludeScenariosTestProvider(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="IncludesA"/> entity instances that have been loaded into this <see cref="IncludeScenariosTestProvider"/> instance.
        /// </summary>
        public EntitySet<IncludesA> IncludesAs
        {
            get
            {
                return base.EntityContainer.GetEntitySet<IncludesA>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="IncludesA"/> entity instances using the 'GetAs' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="IncludesA"/> entity instances.</returns>
        public EntityQuery<IncludesA> GetAsQuery()
        {
            this.ValidateMethod("GetAsQuery", null);
            return base.CreateQuery<IncludesA>("GetAs", null, false, true);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new IncludeScenariosTestProviderEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'IncludeScenariosTestProvider' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IIncludeScenariosTestProviderContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetAs' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/IncludeScenariosTestProvider/GetAsDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/IncludeScenariosTestProvider/GetAs", ReplyAction="http://tempuri.org/IncludeScenariosTestProvider/GetAsResponse")]
            [WebGet()]
            IAsyncResult BeginGetAs(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetAs'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetAs'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetAs' operation.</returns>
            QueryResult<IncludesA> EndGetAs(IAsyncResult result);
        }
        
        internal sealed class IncludeScenariosTestProviderEntityContainer : EntityContainer
        {
            
            public IncludeScenariosTestProviderEntityContainer()
            {
                this.CreateEntitySet<IncludesA>(EntitySetOperations.None);
            }
        }
    }
}

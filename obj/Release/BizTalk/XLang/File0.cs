
#pragma warning disable 162

namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq), 
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class prtType_HaloPointToTableBonus : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public prtType_HaloPointToTableBonus(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public prtType_HaloPointToTableBonus(prtType_HaloPointToTableBonus p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            prtType_HaloPointToTableBonus p = new prtType_HaloPointToTableBonus(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(prtType_HaloPointToTableBonus),
            typeof(__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq),
            typeof(__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Log_Halo_PointBucketDeduct_Request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Log_Halo_PointBucketDeduct_Request(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Log_Halo_PointBucketDeduct_Request(PortType_Log_Halo_PointBucketDeduct_Request p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Log_Halo_PointBucketDeduct_Request p = new PortType_Log_Halo_PointBucketDeduct_Request(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Log_Halo_PointBucketDeduct_Request),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "HaloS2S_PointBucketDeduction",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest), 
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Port_HaloS2S_PointBucketDeduction : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Port_HaloS2S_PointBucketDeduction(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Port_HaloS2S_PointBucketDeduction(PortType_Port_HaloS2S_PointBucketDeduction p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Port_HaloS2S_PointBucketDeduction p = new PortType_Port_HaloS2S_PointBucketDeduction(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo HaloS2S_PointBucketDeduction = new Microsoft.XLANGs.Core.OperationInfo
        (
            "HaloS2S_PointBucketDeduction",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Port_HaloS2S_PointBucketDeduction),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "HaloS2S_PointBucketDeduction" ] = HaloS2S_PointBucketDeduction;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Log_Halo_PointBucketDeduct_Response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Log_Halo_PointBucketDeduct_Response(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Log_Halo_PointBucketDeduct_Response(PortType_Log_Halo_PointBucketDeduct_Response p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Log_Halo_PointBucketDeduct_Response p = new PortType_Log_Halo_PointBucketDeduct_Response(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Log_Halo_PointBucketDeduct_Response),
            typeof(__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization(PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization p = new PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization),
            typeof(__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_rcv_PointConversionReq : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_rcv_PointConversionReq(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_rcv_PointConversionReq(PortType_rcv_PointConversionReq p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_rcv_PointConversionReq p = new PortType_rcv_PointConversionReq(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_rcv_PointConversionReq),
            typeof(__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 549 "C:\Shalini\Backup\GIT\Tiger.BT.Gaming.OMA\Tiger.BT.Gaming.ConvertHaloPointsToTableBonus\Orchestration\CovertHaloPointToTableBonus.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "prt_HaloPointToTableBonus", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.prtType_HaloPointToTableBonus),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_rcv_PointConversionReq),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Request),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Port_HaloS2S_PointBucketDeduction),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Response),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization)
        },
        new System.String[] {
            "prt_HaloPointToTableBonus",
            "Log_rcv_PointConversionReq",
            "Log_Halo_PointBucketDeduct_Request",
            "Port_HaloS2S_PointBucketDeduction",
            "Log_Halo_PointBucketDeduct_Response",
            "Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class CovertHaloPointToTableBonus : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CovertHaloPointToTableBonus));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static CovertHaloPointToTableBonus()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __CovertHaloPointToTableBonus_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CovertHaloPointToTableBonus(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CovertHaloPointToTableBonus", tracker)
        {
            ConstructorHelper();
        }

        public CovertHaloPointToTableBonus(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CovertHaloPointToTableBonus")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>208fe516-651d-445e-82bd-2af65f9f74b1</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ec8da5c7-04df-428f-ac81-81ff690426a1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>rcv_PointConversionReq</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>307110c9-bdb0-4b51-83e6-09336622f2c7</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fd29f5d3-788d-46d1-b081-5e5452f8737b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c5260be9-0f5a-4ed5-8813-fdcefe18bbe9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>c5de931d-4c58-4466-94cf-dc6cd85dac49</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3ce09c62-6ffc-49a9-8324-2f1c924af905</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>25eafb90-373d-4cab-a051-72968108c1cb</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>5eec9f78-5d5d-42b6-bf4e-f51c11bd7e6a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>fea58e0e-57b4-4cb3-bc43-4b6e1be83529</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>cf6c4a56-78ca-4f5a-93fe-efb407dee35a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fd92d822-4724-4c80-b566-ec3f313791ae</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>86771d55-e832-43ff-9b51-46c91c2acc12</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>06bacfe0-f52c-45d3-8065-2dac49b7b408</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f318f19b-395c-4343-a164-887abc179237</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Msg_Halo_PointBucketDeduct_Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>24243bbd-ee5e-4a4f-98fa-34e17379bc19</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>1fb8f2f0-f78d-4d9f-a099-f2b2ce745603</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>45f4ea58-7d24-4459-91ed-5f42f849d9e7</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>747e7018-abda-481e-af37-3db1179fc088</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>26c9d101-896f-4877-997f-40beb49f5d4b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0211a2b9-67c4-4c5b-b0d6-996bb01f47f7</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>28df9812-a153-415b-9453-b94496ecf69c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>3e195208-5745-4c21-8fcd-8b1c373d14bb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>const_PointtoTableBonus</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>54586de2-bcc1-4aaa-ba9b-95744b3ba6c8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>trm_HaloPoint_To_TableBonus</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>4e1fb13c-d97d-4ccb-b211-f26a7fbf87b2</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8afc2780-3f65-4607-831d-3c358e4f36f2</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_7</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>71c0ecf8-9298-4a5c-afec-054815ba3989</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>1e49b890-bc65-45e2-96e2-f9d59dfc7349</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>53485f61-ccbf-4d98-a8e3-a2be4b37d0c3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e1e36f52-c2ec-4794-9338-1032efbd8ecd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>snd_PointConversionReq</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CovertHaloPointToTableBonus'</ActionName><IsAtomic>0</IsAtomic><Line>549</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>575</Line><Position>22</Position><ShapeID>'ec8da5c7-04df-428f-ac81-81ff690426a1'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>580</Line><Position>13</Position><ShapeID>'307110c9-bdb0-4b51-83e6-09336622f2c7'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>582</Line><Position>22</Position><ShapeID>'fd29f5d3-788d-46d1-b081-5e5452f8737b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>587</Line><Position>13</Position><ShapeID>'c5260be9-0f5a-4ed5-8813-fdcefe18bbe9'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Request</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>593</Line><Position>13</Position><ShapeID>'fea58e0e-57b4-4cb3-bc43-4b6e1be83529'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Request</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Request</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>599</Line><Position>13</Position><ShapeID>'f318f19b-395c-4343-a164-887abc179237'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Request</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>601</Line><Position>13</Position><ShapeID>'24243bbd-ee5e-4a4f-98fa-34e17379bc19'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Request</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>603</Line><Position>13</Position><ShapeID>'1fb8f2f0-f78d-4d9f-a099-f2b2ce745603'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Response</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>605</Line><Position>13</Position><ShapeID>'45f4ea58-7d24-4459-91ed-5f42f849d9e7'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Response</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>607</Line><Position>13</Position><ShapeID>'747e7018-abda-481e-af37-3db1179fc088'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Response</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>613</Line><Position>13</Position><ShapeID>'28df9812-a153-415b-9453-b94496ecf69c'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Response</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>615</Line><Position>13</Position><ShapeID>'3e195208-5745-4c21-8fcd-8b1c373d14bb'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusRes</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Response</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>623</Line><Position>13</Position><ShapeID>'e1e36f52-c2ec-4794-9338-1032efbd8ecd'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusRes</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='826f44e3-47f7-46b7-a2e5-7a73a67157c7' LowerBound='1.1' HigherBound='125.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='21f4f0ba-18f0-4b6a-8bb7-eaac936c6747' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='prtType_HaloPointToTableBonus' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b1899b6b-6dc1-417f-8061-d59cfb65737a' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='5caa4a22-d614-4abd-900d-cd84b68edb54' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='2718c562-2b0a-4275-bab6-56ec901ff848' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.52' HigherBound='8.89'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8f11a767-fbb0-4b23-9ec0-7e4373964443' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Log_Halo_PointBucketDeduct_Request' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8637a494-8ae0-4672-b2f0-026c9acf1144' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ebba05b6-70de-4196-ad15-277e33ecc496' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.131'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='f1ce6e94-1c93-4389-9b30-164364122fd0' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Port_HaloS2S_PointBucketDeduction' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8a91127a-d85d-4b20-a9db-4eed19444bc6' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='HaloS2S_PointBucketDeduction' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='23e9a1ca-c1c2-4722-b2e4-1e7c7237389d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.131'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='47c83251-c155-4687-9643-c035d36950d6' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='22.133' HigherBound='22.252'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='c990868e-0145-4b37-9469-3728ed0c94b9' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Log_Halo_PointBucketDeduct_Response' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dbca0a14-d80f-414a-8c5c-e385ccbf869a' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='776e355b-3e50-44c9-b787-a4bf209a43e3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.132'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='5dcc8356-7344-4147-8fec-35e248f8ffd1' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='36e6d276-ad86-465f-be29-1e98aaca0b52' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ab7fd49f-2b31-42aa-bac4-6e882ee933b0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.53'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='71f83dc7-3399-4420-a2fd-2df795445ac6' ParentLink='Module_PortType' LowerBound='39.1' HigherBound='46.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_rcv_PointConversionReq' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='08f6a6cc-1e4a-4e26-be6c-2f56b27dd204' ParentLink='PortType_OperationDeclaration' LowerBound='41.1' HigherBound='45.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='68ccf253-5adb-4aad-b979-8f1bf4531835' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='43.13' HigherBound='43.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5abfd845-8663-4bba-8af8-e26785d45b43' ParentLink='Module_ServiceDeclaration' LowerBound='46.1' HigherBound='124.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CovertHaloPointToTableBonus' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='232aba83-cfd6-4d45-9248-6b0f5f6e28b2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Tiger.BT.RESTBehaviour.JWTTokenUtil' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='var_JWTUtility' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='50b9f5b6-355c-4fff-9fcd-2d1965768a07' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='var_Token' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7f6b4ba9-5a25-4616-b416-cd53d826fc3f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.Deserialization.Deserialization' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='var_deserialization' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='71910a33-8d05-431c-8522-9fd1f87d8631' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msg_BTHaloPointToTableBonusReq' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='03236421-b9a5-4bca-b7c4-6d04940a8fe7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msg_BTHaloPointToTableBonusRes' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d0045019-0b4d-40e3-a52b-9a9859d3cf93' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='63.1' HigherBound='64.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_Halo_PointBucketDeduct_Request' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='5602d2d8-56f9-483a-9d68-bdaf274d9105' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_Halo_PointBucketDeduct_Response' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6c8e91d4-f5d9-441c-a7c0-1b84a83585eb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HaloS2S_Service_Request' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='740b92bd-9d22-4e84-af21-59a995e8dc9e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HaloS2S_Service_Response' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='208fe516-651d-445e-82bd-2af65f9f74b1' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='ec8da5c7-04df-428f-ac81-81ff690426a1' ParentLink='ServiceBody_Statement' LowerBound='72.1' HigherBound='77.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='prt_HaloPointToTableBonus' />
                    <om:Property Name='MessageName' Value='msg_BTHaloPointToTableBonusReq' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='rcv_PointConversionReq' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='307110c9-bdb0-4b51-83e6-09336622f2c7' ParentLink='ServiceBody_Statement' LowerBound='77.1' HigherBound='79.1'>
                    <om:Property Name='PortName' Value='Log_rcv_PointConversionReq' />
                    <om:Property Name='MessageName' Value='msg_BTHaloPointToTableBonusReq' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_4' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='fd29f5d3-788d-46d1-b081-5e5452f8737b' ParentLink='ServiceBody_Statement' LowerBound='79.1' HigherBound='84.1'>
                    <om:Property Name='Expression' Value='var_Token=var_JWTUtility.GenerateToken(msg_BTHaloPointToTableBonusReq.PatronID,false);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Table Bonus&quot;,msg_BTHaloPointToTableBonusReq.PatronID);&#xD;&#xA;//System.Diagnostics.Debug.WriteLine(var_Token); ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='c5260be9-0f5a-4ed5-8813-fdcefe18bbe9' ParentLink='ServiceBody_Statement' LowerBound='84.1' HigherBound='90.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='c5de931d-4c58-4466-94cf-dc6cd85dac49' ParentLink='ComplexStatement_Statement' LowerBound='87.1' HigherBound='89.1'>
                        <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_Halo_PointBucketDeduct_Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='3ce09c62-6ffc-49a9-8324-2f1c924af905' ParentLink='Transform_InputMessagePartRef' LowerBound='88.153' HigherBound='88.183'>
                            <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='25eafb90-373d-4cab-a051-72968108c1cb' ParentLink='Transform_OutputMessagePartRef' LowerBound='88.28' HigherBound='88.62'>
                            <om:Property Name='MessageRef' Value='Msg_Halo_PointBucketDeduct_Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_4' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='5eec9f78-5d5d-42b6-bf4e-f51c11bd7e6a' ParentLink='Construct_MessageRef' LowerBound='85.23' HigherBound='85.57'>
                        <om:Property Name='Ref' Value='Msg_Halo_PointBucketDeduct_Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='fea58e0e-57b4-4cb3-bc43-4b6e1be83529' ParentLink='ServiceBody_Statement' LowerBound='90.1' HigherBound='96.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_2' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='cf6c4a56-78ca-4f5a-93fe-efb407dee35a' ParentLink='ComplexStatement_Statement' LowerBound='93.1' HigherBound='95.1'>
                        <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_HaloS2S_Service_Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='fd92d822-4724-4c80-b566-ec3f313791ae' ParentLink='Transform_InputMessagePartRef' LowerBound='94.139' HigherBound='94.173'>
                            <om:Property Name='MessageRef' Value='Msg_Halo_PointBucketDeduct_Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_5' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='86771d55-e832-43ff-9b51-46c91c2acc12' ParentLink='Transform_OutputMessagePartRef' LowerBound='94.28' HigherBound='94.55'>
                            <om:Property Name='MessageRef' Value='Msg_HaloS2S_Service_Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_6' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='06bacfe0-f52c-45d3-8065-2dac49b7b408' ParentLink='Construct_MessageRef' LowerBound='91.23' HigherBound='91.50'>
                        <om:Property Name='Ref' Value='Msg_HaloS2S_Service_Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='f318f19b-395c-4343-a164-887abc179237' ParentLink='ServiceBody_Statement' LowerBound='96.1' HigherBound='98.1'>
                    <om:Property Name='PortName' Value='Log_Halo_PointBucketDeduct_Request' />
                    <om:Property Name='MessageName' Value='Msg_HaloS2S_Service_Request' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Msg_Halo_PointBucketDeduct_Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='24243bbd-ee5e-4a4f-98fa-34e17379bc19' ParentLink='ServiceBody_Statement' LowerBound='98.1' HigherBound='100.1'>
                    <om:Property Name='PortName' Value='Port_HaloS2S_PointBucketDeduction' />
                    <om:Property Name='MessageName' Value='Msg_HaloS2S_Service_Request' />
                    <om:Property Name='OperationName' Value='HaloS2S_PointBucketDeduction' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='1fb8f2f0-f78d-4d9f-a099-f2b2ce745603' ParentLink='ServiceBody_Statement' LowerBound='100.1' HigherBound='102.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='Port_HaloS2S_PointBucketDeduction' />
                    <om:Property Name='MessageName' Value='Msg_HaloS2S_Service_Response' />
                    <om:Property Name='OperationName' Value='HaloS2S_PointBucketDeduction' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='45f4ea58-7d24-4459-91ed-5f42f849d9e7' ParentLink='ServiceBody_Statement' LowerBound='102.1' HigherBound='104.1'>
                    <om:Property Name='PortName' Value='Log_Halo_PointBucketDeduct_Response' />
                    <om:Property Name='MessageName' Value='Msg_HaloS2S_Service_Response' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='747e7018-abda-481e-af37-3db1179fc088' ParentLink='ServiceBody_Statement' LowerBound='104.1' HigherBound='110.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_3' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='26c9d101-896f-4877-997f-40beb49f5d4b' ParentLink='ComplexStatement_Statement' LowerBound='107.1' HigherBound='109.1'>
                        <om:Property Name='Expression' Value='Msg_Halo_PointBucketDeduct_Response = var_deserialization.DeserializeMessage(Msg_HaloS2S_Service_Response);' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_2' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='0211a2b9-67c4-4c5b-b0d6-996bb01f47f7' ParentLink='Construct_MessageRef' LowerBound='105.23' HigherBound='105.58'>
                        <om:Property Name='Ref' Value='Msg_Halo_PointBucketDeduct_Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='28df9812-a153-415b-9453-b94496ecf69c' ParentLink='ServiceBody_Statement' LowerBound='110.1' HigherBound='112.1'>
                    <om:Property Name='PortName' Value='Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization' />
                    <om:Property Name='MessageName' Value='Msg_Halo_PointBucketDeduct_Response' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_3' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='3e195208-5745-4c21-8fcd-8b1c373d14bb' ParentLink='ServiceBody_Statement' LowerBound='112.1' HigherBound='120.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='const_PointtoTableBonus' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='54586de2-bcc1-4aaa-ba9b-95744b3ba6c8' ParentLink='ComplexStatement_Statement' LowerBound='115.1' HigherBound='117.1'>
                        <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.map_HaloPointConversion_To_TableBonusCreditRes' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='trm_HaloPoint_To_TableBonus' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='4e1fb13c-d97d-4ccb-b211-f26a7fbf87b2' ParentLink='Transform_InputMessagePartRef' LowerBound='116.160' HigherBound='116.190'>
                            <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='8afc2780-3f65-4607-831d-3c358e4f36f2' ParentLink='Transform_InputMessagePartRef' LowerBound='116.192' HigherBound='116.227'>
                            <om:Property Name='MessageRef' Value='Msg_Halo_PointBucketDeduct_Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_7' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='71c0ecf8-9298-4a5c-afec-054815ba3989' ParentLink='Transform_OutputMessagePartRef' LowerBound='116.28' HigherBound='116.58'>
                            <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusRes' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='1e49b890-bc65-45e2-96e2-f9d59dfc7349' ParentLink='ComplexStatement_Statement' LowerBound='117.1' HigherBound='119.1'>
                        <om:Property Name='Expression' Value='msg_BTHaloPointToTableBonusRes(WCF.OutboundCustomHeaders) = &quot;&lt;headers&gt;&lt;token&gt;&quot; + var_Token + &quot;&lt;/token&gt;&lt;/headers&gt;&quot;;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='53485f61-ccbf-4d98-a8e3-a2be4b37d0c3' ParentLink='Construct_MessageRef' LowerBound='113.23' HigherBound='113.53'>
                        <om:Property Name='Ref' Value='msg_BTHaloPointToTableBonusRes' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='e1e36f52-c2ec-4794-9338-1032efbd8ecd' ParentLink='ServiceBody_Statement' LowerBound='120.1' HigherBound='122.1'>
                    <om:Property Name='PortName' Value='prt_HaloPointToTableBonus' />
                    <om:Property Name='MessageName' Value='msg_BTHaloPointToTableBonusRes' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='snd_PointConversionReq' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f35d0640-d76a-422d-85f3-c77e8c97f986' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='49.1' HigherBound='51.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.prtType_HaloPointToTableBonus' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='prt_HaloPointToTableBonus' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6063863b-47bb-4b42-8e3d-9d45cc8b32ba' ParentLink='PortDeclaration_CLRAttribute' LowerBound='49.1' HigherBound='50.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b5811cd6-7cb9-4594-84ac-c24c1ab5b39e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='51.1' HigherBound='53.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Request' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Log_Halo_PointBucketDeduct_Request' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2eda9e04-0e4e-42df-bc55-e39b80e22408' ParentLink='PortDeclaration_CLRAttribute' LowerBound='51.1' HigherBound='52.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cdbda598-5061-4d97-81ad-631343d56651' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='53.1' HigherBound='55.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='38' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Port_HaloS2S_PointBucketDeduction' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_HaloS2S_PointBucketDeduction' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2456f7ac-732b-416e-91df-3c43e8a379fa' ParentLink='PortDeclaration_CLRAttribute' LowerBound='53.1' HigherBound='54.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4bbbcb2e-c656-4282-9420-dc23becfa15d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='55.1' HigherBound='57.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='14' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Response' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Log_Halo_PointBucketDeduct_Response' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='f4f7b952-82e9-4b2f-8edd-a2891f14a87f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='55.1' HigherBound='56.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ec5eab8f-2454-4fa7-96ef-4f70f4d682a6' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='57.1' HigherBound='59.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='29' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='65a668fd-0172-4a22-a92f-00edf188ae50' ParentLink='PortDeclaration_CLRAttribute' LowerBound='57.1' HigherBound='58.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d4dbaf13-0194-40d9-b1f3-3158a4ac8294' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='59.1' HigherBound='61.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='0' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_rcv_PointConversionReq' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Log_rcv_PointConversionReq' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='9a14bd48-096f-41dd-baeb-63ff08f1b50f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='59.1' HigherBound='60.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CovertHaloPointToTableBonus_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CovertHaloPointToTableBonus_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CovertHaloPointToTableBonus")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CovertHaloPointToTableBonus __svc__ = (CovertHaloPointToTableBonus)_service;
                __CovertHaloPointToTableBonus_root_0 __ctx0__ = (__CovertHaloPointToTableBonus_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.prt_HaloPointToTableBonus != null)
                {
                    __svc__.prt_HaloPointToTableBonus.Close(this, null);
                    __svc__.prt_HaloPointToTableBonus = null;
                }
                if (__svc__.Log_Halo_PointBucketDeduct_Request != null)
                {
                    __svc__.Log_Halo_PointBucketDeduct_Request.Close(this, null);
                    __svc__.Log_Halo_PointBucketDeduct_Request = null;
                }
                if (__svc__.Port_HaloS2S_PointBucketDeduction != null)
                {
                    __svc__.Port_HaloS2S_PointBucketDeduction.Close(this, null);
                    __svc__.Port_HaloS2S_PointBucketDeduction = null;
                }
                if (__svc__.Log_Halo_PointBucketDeduct_Response != null)
                {
                    __svc__.Log_Halo_PointBucketDeduct_Response.Close(this, null);
                    __svc__.Log_Halo_PointBucketDeduct_Response = null;
                }
                if (__svc__.Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization != null)
                {
                    __svc__.Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization.Close(this, null);
                    __svc__.Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization = null;
                }
                if (__svc__.Log_rcv_PointConversionReq != null)
                {
                    __svc__.Log_rcv_PointConversionReq.Close(this, null);
                    __svc__.Log_rcv_PointConversionReq = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __CovertHaloPointToTableBonus_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CovertHaloPointToTableBonus_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CovertHaloPointToTableBonus")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CovertHaloPointToTableBonus __svc__ = (CovertHaloPointToTableBonus)_service;
                __CovertHaloPointToTableBonus_root_0 __ctx0__ = (__CovertHaloPointToTableBonus_root_0)(__svc__._stateMgrs[0]);
                __CovertHaloPointToTableBonus_1 __ctx1__ = (__CovertHaloPointToTableBonus_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msg_BTHaloPointToTableBonusReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __ctx1__.__msg_BTHaloPointToTableBonusReq = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_Halo_PointBucketDeduct_Request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Request);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Request = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__var_Token = null;
                if (__ctx1__ != null)
                    __ctx1__.__var_JWTUtility = null;
                if (__ctx1__ != null)
                    __ctx1__.__var_deserialization = null;
                if (__ctx1__ != null && __ctx1__.__Msg_Halo_PointBucketDeduct_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Response = null;
                }
                if (__ctx1__ != null && __ctx1__.__msg_BTHaloPointToTableBonusRes != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __ctx1__.__msg_BTHaloPointToTableBonusRes = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Request);
                    __ctx1__.__Msg_HaloS2S_Service_Request = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Response);
                    __ctx1__.__Msg_HaloS2S_Service_Response = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msg_BTHaloPointToTableBonusReq")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq __msg_BTHaloPointToTableBonusReq;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msg_BTHaloPointToTableBonusRes")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes __msg_BTHaloPointToTableBonusRes;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_Halo_PointBucketDeduct_Request")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest __Msg_Halo_PointBucketDeduct_Request;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_Halo_PointBucketDeduct_Response")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse __Msg_Halo_PointBucketDeduct_Response;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HaloS2S_Service_Request")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HaloS2S_Service_Request;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HaloS2S_Service_Response")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse __Msg_HaloS2S_Service_Response;
            [Microsoft.XLANGs.Core.UserVariableAttribute("var_JWTUtility")]
            internal Tiger.BT.RESTBehaviour.JWTTokenUtil __var_JWTUtility;
            [Microsoft.XLANGs.Core.UserVariableAttribute("var_Token")]
            internal System.String __var_Token;
            [Microsoft.XLANGs.Core.UserVariableAttribute("var_deserialization")]
            internal Tiger.BT.Gaming.Deserialization.Deserialization __var_deserialization;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("prt_HaloPointToTableBonus")]
        internal prtType_HaloPointToTableBonus prt_HaloPointToTableBonus;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Log_rcv_PointConversionReq")]
        internal PortType_rcv_PointConversionReq Log_rcv_PointConversionReq;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Log_Halo_PointBucketDeduct_Request")]
        internal PortType_Log_Halo_PointBucketDeduct_Request Log_Halo_PointBucketDeduct_Request;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_HaloS2S_PointBucketDeduction")]
        internal PortType_Port_HaloS2S_PointBucketDeduction Port_HaloS2S_PointBucketDeduction;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Log_Halo_PointBucketDeduct_Response")]
        internal PortType_Log_Halo_PointBucketDeduct_Response Log_Halo_PointBucketDeduct_Response;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization")]
        internal PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {prtType_HaloPointToTableBonus.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("prt_HaloPointToTableBonus", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "prt_HaloPointToTableBonus"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_rcv_PointConversionReq.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Log_rcv_PointConversionReq", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Log_rcv_PointConversionReq"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Log_Halo_PointBucketDeduct_Request.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Log_Halo_PointBucketDeduct_Request", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Log_Halo_PointBucketDeduct_Request"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Port_HaloS2S_PointBucketDeduction.HaloS2S_PointBucketDeduction},
                                               typeof(CovertHaloPointToTableBonus).GetField("Port_HaloS2S_PointBucketDeduction", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Port_HaloS2S_PointBucketDeduction"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Log_Halo_PointBucketDeduct_Response.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Log_Halo_PointBucketDeduct_Response", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Log_Halo_PointBucketDeduct_Response"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                h[_portInfo[4].Name] = _portInfo[4];
                h[_portInfo[5].Name] = _portInfo[5];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "ec8da5c7-04df-428f-ac81-81ff690426a1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "ec8da5c7-04df-428f-ac81-81ff690426a1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "307110c9-bdb0-4b51-83e6-09336622f2c7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "307110c9-bdb0-4b51-83e6-09336622f2c7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "fd29f5d3-788d-46d1-b081-5e5452f8737b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "fd29f5d3-788d-46d1-b081-5e5452f8737b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "c5260be9-0f5a-4ed5-8813-fdcefe18bbe9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "c5260be9-0f5a-4ed5-8813-fdcefe18bbe9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "fea58e0e-57b4-4cb3-bc43-4b6e1be83529", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "fea58e0e-57b4-4cb3-bc43-4b6e1be83529", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "f318f19b-395c-4343-a164-887abc179237", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "f318f19b-395c-4343-a164-887abc179237", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "24243bbd-ee5e-4a4f-98fa-34e17379bc19", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "24243bbd-ee5e-4a4f-98fa-34e17379bc19", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "1fb8f2f0-f78d-4d9f-a099-f2b2ce745603", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "1fb8f2f0-f78d-4d9f-a099-f2b2ce745603", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "45f4ea58-7d24-4459-91ed-5f42f849d9e7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "45f4ea58-7d24-4459-91ed-5f42f849d9e7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "747e7018-abda-481e-af37-3db1179fc088", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "747e7018-abda-481e-af37-3db1179fc088", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "28df9812-a153-415b-9453-b94496ecf69c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "28df9812-a153-415b-9453-b94496ecf69c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "3e195208-5745-4c21-8fcd-8b1c373d14bb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "3e195208-5745-4c21-8fcd-8b1c373d14bb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "e1e36f52-c2ec-4794-9338-1032efbd8ecd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "e1e36f52-c2ec-4794-9338-1032efbd8ecd", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,4,4,4,5,6,6,7,7,8,8,9,10,10,11,12,12,12,13,14,14,14,15,16,16,17,18,18,18,19,20,20,21,22,22,22,23,24,24,25,26,26,26,27,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CovertHaloPointToTableBonus_root_0 __ctx0__ = (__CovertHaloPointToTableBonus_root_0)_stateMgrs[0];
            __CovertHaloPointToTableBonus_1 __ctx1__ = (__CovertHaloPointToTableBonus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                prt_HaloPointToTableBonus = new prtType_HaloPointToTableBonus(0, this);
                Log_Halo_PointBucketDeduct_Request = new PortType_Log_Halo_PointBucketDeduct_Request(2, this);
                Port_HaloS2S_PointBucketDeduction = new PortType_Port_HaloS2S_PointBucketDeduction(3, this);
                Log_Halo_PointBucketDeduct_Response = new PortType_Log_Halo_PointBucketDeduct_Response(4, this);
                Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization = new PortType_Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization(5, this);
                Log_rcv_PointConversionReq = new PortType_rcv_PointConversionReq(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], prt_HaloPointToTableBonus, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CovertHaloPointToTableBonus_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __CovertHaloPointToTableBonus_root_0 __ctx0__ = (__CovertHaloPointToTableBonus_root_0)_stateMgrs[0];
            __CovertHaloPointToTableBonus_1 __ctx1__ = (__CovertHaloPointToTableBonus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__var_JWTUtility = default(Tiger.BT.RESTBehaviour.JWTTokenUtil);
                __ctx1__.__var_Token = default(System.String);
                __ctx1__.__var_deserialization = default(Tiger.BT.Gaming.Deserialization.Deserialization);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!prt_HaloPointToTableBonus.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msg_BTHaloPointToTableBonusReq != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                __ctx1__.__msg_BTHaloPointToTableBonusReq = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq("msg_BTHaloPointToTableBonusReq", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                prt_HaloPointToTableBonus.ReceiveMessage(0, __msgEnv__, __ctx1__.__msg_BTHaloPointToTableBonusReq, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __edata.PortName = @"prt_HaloPointToTableBonus";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__var_JWTUtility = new Tiger.BT.RESTBehaviour.JWTTokenUtil();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__var_Token = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__var_deserialization = new Tiger.BT.Gaming.Deserialization.Deserialization();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Log_rcv_PointConversionReq.SendMessage(0, __ctx1__.__msg_BTHaloPointToTableBonusReq, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Log_rcv_PointConversionReq != null)
                {
                    Log_rcv_PointConversionReq.Close(__ctx1__, __seg__);
                    Log_rcv_PointConversionReq = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __edata.PortName = @"Log_rcv_PointConversionReq";
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx1__.__var_Token = __ctx1__.__var_JWTUtility.GenerateToken((System.String)__ctx1__.__msg_BTHaloPointToTableBonusReq.part.GetDistinguishedField("PatronID"), false);
                if (__ctx1__ != null)
                    __ctx1__.__var_JWTUtility = null;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                System.Diagnostics.EventLog.WriteEntry("Table Bonus", (System.String)__ctx1__.__msg_BTHaloPointToTableBonusReq.part.GetDistinguishedField("PatronID"));
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest __Msg_Halo_PointBucketDeduct_Request = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest("Msg_Halo_PointBucketDeduct_Request", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_Halo_PointBucketDeduct_Request), new object[] {__Msg_Halo_PointBucketDeduct_Request.part}, new object[] {__ctx1__.__msg_BTHaloPointToTableBonusReq.part});

                    if (__ctx1__.__Msg_Halo_PointBucketDeduct_Request != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Request);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Request = __Msg_Halo_PointBucketDeduct_Request;
                    __ctx1__.RefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Request);
                }
                __ctx1__.__Msg_Halo_PointBucketDeduct_Request.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Request);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                {
                    __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HaloS2S_Service_Request = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest("Msg_HaloS2S_Service_Request", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_HaloS2S_Service_Request), new object[] {__Msg_HaloS2S_Service_Request.part}, new object[] {__ctx1__.__Msg_Halo_PointBucketDeduct_Request.part});

                    if (__ctx1__.__Msg_HaloS2S_Service_Request != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Request);
                    __ctx1__.__Msg_HaloS2S_Service_Request = __Msg_HaloS2S_Service_Request;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HaloS2S_Service_Request);
                }
                __ctx1__.__Msg_HaloS2S_Service_Request.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Request);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Request);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_Halo_PointBucketDeduct_Request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Request);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Request = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Log_Halo_PointBucketDeduct_Request.SendMessage(0, __ctx1__.__Msg_HaloS2S_Service_Request, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Log_Halo_PointBucketDeduct_Request != null)
                {
                    Log_Halo_PointBucketDeduct_Request.Close(__ctx1__, __seg__);
                    Log_Halo_PointBucketDeduct_Request = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Request);
                    __edata.PortName = @"Log_Halo_PointBucketDeduct_Request";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_HaloS2S_PointBucketDeduction.SendMessage(0, __ctx1__.__Msg_HaloS2S_Service_Request, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Request);
                    __edata.PortName = @"Port_HaloS2S_PointBucketDeduction";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Request);
                    __ctx1__.__Msg_HaloS2S_Service_Request = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!Port_HaloS2S_PointBucketDeduction.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__Msg_HaloS2S_Service_Response != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Response);
                __ctx1__.__Msg_HaloS2S_Service_Response = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse("Msg_HaloS2S_Service_Response", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg_HaloS2S_Service_Response);
                Port_HaloS2S_PointBucketDeduction.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg_HaloS2S_Service_Response, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_HaloS2S_PointBucketDeduction != null)
                {
                    Port_HaloS2S_PointBucketDeduction.Close(__ctx1__, __seg__);
                    Port_HaloS2S_PointBucketDeduction = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Response);
                    __edata.PortName = @"Port_HaloS2S_PointBucketDeduction";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Log_Halo_PointBucketDeduct_Response.SendMessage(0, __ctx1__.__Msg_HaloS2S_Service_Response, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Log_Halo_PointBucketDeduct_Response != null)
                {
                    Log_Halo_PointBucketDeduct_Response.Close(__ctx1__, __seg__);
                    Log_Halo_PointBucketDeduct_Response = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Response);
                    __edata.PortName = @"Log_Halo_PointBucketDeduct_Response";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse __Msg_Halo_PointBucketDeduct_Response = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentResponse("Msg_Halo_PointBucketDeduct_Response", __ctx1__);

                    __Msg_Halo_PointBucketDeduct_Response.part.LoadFrom(__ctx1__.__var_deserialization.DeserializeMessage(CreateMessageWrapperForUserCode(__ctx1__.__Msg_HaloS2S_Service_Response)));
                    if (__ctx1__ != null)
                        __ctx1__.__var_deserialization = null;
                    if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Response != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Response);
                        __ctx1__.__Msg_HaloS2S_Service_Response = null;
                    }

                    if (__ctx1__.__Msg_Halo_PointBucketDeduct_Response != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Response = __Msg_Halo_PointBucketDeduct_Response;
                    __ctx1__.RefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                }
                __ctx1__.__Msg_Halo_PointBucketDeduct_Response.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization.SendMessage(0, __ctx1__.__Msg_Halo_PointBucketDeduct_Response, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization != null)
                {
                    Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization.Close(__ctx1__, __seg__);
                    Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    __edata.PortName = @"Port_Msg_Halo_PointBucketDeduct_Response_AfterDeserialization";
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes __msg_BTHaloPointToTableBonusRes = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes("msg_BTHaloPointToTableBonusRes", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.map_HaloPointConversion_To_TableBonusCreditRes), new object[] {__msg_BTHaloPointToTableBonusRes.part}, new object[] {__ctx1__.__msg_BTHaloPointToTableBonusReq.part, __ctx1__.__Msg_Halo_PointBucketDeduct_Response.part});
                    __msg_BTHaloPointToTableBonusRes.SetPropertyValue(typeof(WCF.OutboundCustomHeaders), "<headers><token>" + __ctx1__.__var_Token + "</token></headers>");
                    if (__ctx1__ != null)
                        __ctx1__.__var_Token = null;

                    if (__ctx1__.__msg_BTHaloPointToTableBonusRes != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __ctx1__.__msg_BTHaloPointToTableBonusRes = __msg_BTHaloPointToTableBonusRes;
                    __ctx1__.RefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                }
                __ctx1__.__msg_BTHaloPointToTableBonusRes.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_Halo_PointBucketDeduct_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Response = null;
                }
                if (__ctx1__ != null && __ctx1__.__msg_BTHaloPointToTableBonusReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __ctx1__.__msg_BTHaloPointToTableBonusReq = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                prt_HaloPointToTableBonus.SendMessage(0, __ctx1__.__msg_BTHaloPointToTableBonusRes, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (prt_HaloPointToTableBonus != null)
                {
                    prt_HaloPointToTableBonus.Close(__ctx1__, __seg__);
                    prt_HaloPointToTableBonus = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __edata.PortName = @"prt_HaloPointToTableBonus";
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msg_BTHaloPointToTableBonusRes != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __ctx1__.__msg_BTHaloPointToTableBonusRes = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 54;
            case 54:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{D3CCA88F-D318-4E57-A30D-4D6CAE729EBF}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq__)
        },
        0,
        @"http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq#PointTableBonusConversion"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes__)
        },
        0,
        @"http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes#PointTableBonusConversion"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest _schema = new Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest();

        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl#s2sRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse _schema = new Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse();

        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl#s2sResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo_BallyPointAdjustmentRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}

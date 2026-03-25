
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
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1)
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
            typeof(__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1),
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
    sealed internal class PortType_Log_PointTConversionReqAndResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Log_PointTConversionReqAndResponse(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Log_PointTConversionReqAndResponse(PortType_Log_PointTConversionReqAndResponse p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Log_PointTConversionReqAndResponse p = new PortType_Log_PointTConversionReqAndResponse(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Log_PointTConversionReqAndResponse),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Log_Response_PointConversion : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Log_Response_PointConversion(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Log_Response_PointConversion(PortType_Log_Response_PointConversion p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Log_Response_PointConversion p = new PortType_Log_Response_PointConversion(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Log_Response_PointConversion),
            typeof(__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes),
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
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq), 
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Log_RequestAndResponse_PointConversion : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Log_RequestAndResponse_PointConversion(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Log_RequestAndResponse_PointConversion(PortType_Log_RequestAndResponse_PointConversion p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Log_RequestAndResponse_PointConversion p = new PortType_Log_RequestAndResponse_PointConversion(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Log_RequestAndResponse_PointConversion),
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
    sealed internal class PortType_Send_Test_HAlo_Svc_RQ : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Send_Test_HAlo_Svc_RQ(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Send_Test_HAlo_Svc_RQ(PortType_Send_Test_HAlo_Svc_RQ p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Send_Test_HAlo_Svc_RQ p = new PortType_Send_Test_HAlo_Svc_RQ(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Send_Test_HAlo_Svc_RQ),
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
        "S2SMessagePostOperation",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest), 
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_HAlo_S2S_Service : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_HAlo_S2S_Service(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_HAlo_S2S_Service(PortType_HAlo_S2S_Service p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_HAlo_S2S_Service p = new PortType_HAlo_S2S_Service(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo S2SMessagePostOperation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "S2SMessagePostOperation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_HAlo_S2S_Service),
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
                h[ "S2SMessagePostOperation" ] = S2SMessagePostOperation;
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
    sealed internal class PortType_Send_Test_HAlo_Svc_RS : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Send_Test_HAlo_Svc_RS(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Send_Test_HAlo_Svc_RS(PortType_Send_Test_HAlo_Svc_RS p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Send_Test_HAlo_Svc_RS p = new PortType_Send_Test_HAlo_Svc_RS(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Send_Test_HAlo_Svc_RS),
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
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Log_TestEnquiryPointBlanceResult : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Log_TestEnquiryPointBlanceResult(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Log_TestEnquiryPointBlanceResult(PortType_Log_TestEnquiryPointBlanceResult p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Log_TestEnquiryPointBlanceResult p = new PortType_Log_TestEnquiryPointBlanceResult(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Log_TestEnquiryPointBlanceResult),
            typeof(__messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes),
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
    //#line 966 "C:\Users\omk0029.cyk\Documents\SourceCode\Tiger.BT.Gaming.ConvertHaloPointsToTableBonus\Orchestration\CovertHaloPointToTableBonus.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Log_RequestAndResponse_PointConversion", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_RequestAndResponse_PointConversion),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_rcv_PointConversionReq),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Request),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Port_HaloS2S_PointBucketDeduction),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Response),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Send_Test_HAlo_Svc_RQ),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_HAlo_S2S_Service),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Send_Test_HAlo_Svc_RS),
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Response_PointConversion)
        },
        new System.String[] {
            "Log_RequestAndResponse_PointConversion",
            "Log_rcv_PointConversionReq",
            "Log_Halo_PointBucketDeduct_Request",
            "Port_HaloS2S_PointBucketDeduction",
            "Log_Halo_PointBucketDeduct_Response",
            "Port_Send_Test_HAlo_Svc_RQ",
            "Port_HAlo_S2S_Service",
            "Port_Send_Test_HAlo_Svc_RS",
            "Log_Response_PointConversion"
        },
        new System.Type[] {
            null,
            null,
            null,
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
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>32b773c0-6017-45be-8b89-eb78b1ecaf14</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2c85639a-8cb9-4ca2-823e-a7fde9826c57</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
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
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0470b756-b2ee-4c5d-8126-bae5468f7a71</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>bfccb8b8-29cf-43f9-b08d-412e278ae6fc</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
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
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>02dfd10f-08a0-4f2a-b44d-07087797d43b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
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
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>45f4ea58-7d24-4459-91ed-5f42f849d9e7</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>dcdedb18-ff10-4bbd-83d6-bd8eccebde24</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>c86a7773-58dd-46b9-8419-209b46f07c36</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a6f30845-612b-4cd8-b55f-0e96600910b1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_8</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>6abb9b55-dc7b-4daa-b47e-3f135302eff0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_7</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9faf7be8-7d23-4c53-8a48-97a33aa0297a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_18</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9747d611-e5dc-4688-acdd-9d51a8e169cb</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_19</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>7fb167c1-37f3-4c9a-b699-02c894bef8ed</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9294f159-d69c-4f6e-9fa1-15ee577c9e47</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_9</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>a671ef52-d79e-41b3-b090-bf0ba39bcacd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_8</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>883d4c82-6383-4acf-b2eb-7646772bc34b</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_20</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ed9a22d7-dfab-4297-a30d-8dfc693e2c4e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_21</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0f714700-6a01-418d-a2fc-f84eae53fac7</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>76ca3a35-932d-472f-bb97-77b159ce4f96</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Test_HAlo_Svc_RQ</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9c8f3a0e-c505-442c-9fab-fbaa189e1e9a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_HAlo_Svc_PatronPointBalanceEnq</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>6db38fae-dfb4-44da-85fc-e20d154e830d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_HAlo_Svc_PatronPointBalanceEnq</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>5cd83052-70b4-4d50-8cbf-e9d016eb430a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Test_HAlo_Svc_RS</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a6f2b01e-d1df-4292-ba28-e42c387de58c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_HAlo_RS</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>3f510c6f-701d-4452-a1b5-b6c268555df5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a3d5d28d-847f-4b6e-9511-4882f15f38bd</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>08d67014-7d18-481e-9bed-25ebad7b5bc1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>const_PointtoTableBonus</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>916bbdfe-6bda-4ae5-a4ad-1c37250df8c9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>954037bd-81cd-4a73-b378-b496893d20aa</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_4</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1e70b5ed-8a3c-462e-9c96-61e88e21e5da</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>909ab3e7-13eb-485c-94fa-1dada888ae05</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>93ee04e5-2050-411a-ac6e-5a892e23472b</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_7</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c6e5b0cc-eda6-4c67-bb09-8454153c0769</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>f19433ee-54a2-4e7a-a19d-be78d8b7716f</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e5a06732-89cf-4b0d-9895-c66056af3411</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_4</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>1aa4921f-308e-4fb8-a2d4-d38271e8c98a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>73dc1f85-9d9e-4d19-80c2-24b2b97d1e7b</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_8</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2379d6fd-9ef9-4002-9a25-07db448f8a79</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_9</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>48707b36-77c6-4b5b-9446-15f1bd58aa56</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_10</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>663c808b-9103-4a23-9902-092ad5662764</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6253b6c1-4d22-4802-ba3f-85f1d98ad2c1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>201bc8e6-ecaa-4c4c-bf87-14fe496f6461</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e1e36f52-c2ec-4794-9338-1032efbd8ecd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>snd_PointConversionReq</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CovertHaloPointToTableBonus'</ActionName><IsAtomic>0</IsAtomic><Line>966</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>1002</Line><Position>22</Position><ShapeID>'ec8da5c7-04df-428f-ac81-81ff690426a1'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1007</Line><Position>13</Position><ShapeID>'307110c9-bdb0-4b51-83e6-09336622f2c7'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1009</Line><Position>22</Position><ShapeID>'fd29f5d3-788d-46d1-b081-5e5452f8737b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1014</Line><Position>13</Position><ShapeID>'c5260be9-0f5a-4ed5-8813-fdcefe18bbe9'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Request</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentRequest1</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1020</Line><Position>13</Position><ShapeID>'fea58e0e-57b4-4cb3-bc43-4b6e1be83529'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Request1</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Request</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentRequest1</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1026</Line><Position>13</Position><ShapeID>'f318f19b-395c-4343-a164-887abc179237'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Request1</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1028</Line><Position>13</Position><ShapeID>'24243bbd-ee5e-4a4f-98fa-34e17379bc19'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Request1</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1030</Line><Position>13</Position><ShapeID>'02dfd10f-08a0-4f2a-b44d-07087797d43b'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HaloS2S_Service_Response1</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1032</Line><Position>13</Position><ShapeID>'747e7018-abda-481e-af37-3db1179fc088'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Response</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1038</Line><Position>13</Position><ShapeID>'45f4ea58-7d24-4459-91ed-5f42f849d9e7'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Response</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1040</Line><Position>13</Position><ShapeID>'dcdedb18-ff10-4bbd-83d6-bd8eccebde24'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1043</Line><Position>17</Position><ShapeID>'a6f30845-612b-4cd8-b55f-0e96600910b1'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_RQ_Type</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1049</Line><Position>17</Position><ShapeID>'9294f159-d69c-4f6e-9fa1-15ee577c9e47'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RQ</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_HAlo_RQ_Type</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1055</Line><Position>17</Position><ShapeID>'76ca3a35-932d-472f-bb97-77b159ce4f96'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RQ</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1057</Line><Position>17</Position><ShapeID>'9c8f3a0e-c505-442c-9fab-fbaa189e1e9a'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RQ</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1059</Line><Position>17</Position><ShapeID>'6db38fae-dfb4-44da-85fc-e20d154e830d'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RS</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1061</Line><Position>17</Position><ShapeID>'5cd83052-70b4-4d50-8cbf-e9d016eb430a'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_Svc_RS</name><part>part</part><schema>Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1063</Line><Position>17</Position><ShapeID>'a6f2b01e-d1df-4292-ba28-e42c387de58c'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_HAlo_RS_Type</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1069</Line><Position>17</Position><ShapeID>'08d67014-7d18-481e-9bed-25ebad7b5bc1'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusRes</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_HAlo_RS_Type</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1080</Line><Position>17</Position><ShapeID>'e5a06732-89cf-4b0d-9895-c66056af3411'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusRes</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msg_BTHaloPointToTableBonusReq</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Msg_Halo_PointBucketDeduct_Response</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1089</Line><Position>13</Position><ShapeID>'201bc8e6-ecaa-4c4c-bf87-14fe496f6461'</ShapeID>
<Messages>
	<MsgInfo><name>msg_BTHaloPointToTableBonusRes</name><part>part</part><schema>Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1091</Line><Position>13</Position><ShapeID>'e1e36f52-c2ec-4794-9338-1032efbd8ecd'</ShapeID>
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
    <om:Element Type='Module' OID='826f44e3-47f7-46b7-a2e5-7a73a67157c7' LowerBound='1.1' HigherBound='218.1'>
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
                <om:Element Type='MessageRef' OID='776e355b-3e50-44c9-b787-a4bf209a43e3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.54'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='71f83dc7-3399-4420-a2fd-2df795445ac6' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_rcv_PointConversionReq' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='08f6a6cc-1e4a-4e26-be6c-2f56b27dd204' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='68ccf253-5adb-4aad-b979-8f1bf4531835' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='db1d9808-4a6f-4a49-a543-735d9705687b' ParentLink='Module_PortType' LowerBound='39.1' HigherBound='46.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Log_PointTConversionReqAndResponse' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b0b77a07-ffc2-417f-a9f2-5f0712ada88d' ParentLink='PortType_OperationDeclaration' LowerBound='41.1' HigherBound='45.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='907d1472-a4ac-469b-9d73-807136389925' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='43.13' HigherBound='43.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='06e41f6e-5f64-4283-908b-d29142299dd9' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='43.52' HigherBound='43.89'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='522a2fd1-a63e-43bf-a393-d9978020eb27' ParentLink='Module_PortType' LowerBound='46.1' HigherBound='53.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Log_Response_PointConversion' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='de37492f-9e83-4baf-b9cc-f9ca61097100' ParentLink='PortType_OperationDeclaration' LowerBound='48.1' HigherBound='52.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='5e1186c5-59c4-4d01-8fa3-f91c46dd13d0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='50.13' HigherBound='50.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e45ecd14-cb86-4d8f-84f2-f9b66d6c1272' ParentLink='Module_PortType' LowerBound='53.1' HigherBound='60.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Log_RequestAndResponse_PointConversion' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8b7b3879-a334-4c85-a5dc-c06178b9aaf6' ParentLink='PortType_OperationDeclaration' LowerBound='55.1' HigherBound='59.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='cc662bdb-2460-454f-af7b-c2c8082ed2b8' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='57.13' HigherBound='57.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='1c23afff-dc85-44d2-9b50-6868dff44d8a' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='57.52' HigherBound='57.89'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='f30ff326-cdb5-44b7-9575-5f528f5ef2a4' ParentLink='Module_PortType' LowerBound='60.1' HigherBound='67.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Send_Test_HAlo_Svc_RQ' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7e9a0775-2001-4822-b76e-35c0cdfa05c7' ParentLink='PortType_OperationDeclaration' LowerBound='62.1' HigherBound='66.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ff23fe6a-8d63-4866-bc72-f411750e1660' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='64.13' HigherBound='64.131'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='04d6d730-7012-474a-ab78-f4ba8cdbb3cc' ParentLink='Module_PortType' LowerBound='67.1' HigherBound='74.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_HAlo_S2S_Service' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='9875be2c-037c-4b92-9b3b-c9f3dbb79f07' ParentLink='PortType_OperationDeclaration' LowerBound='69.1' HigherBound='73.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='S2SMessagePostOperation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='27fc50b7-0e74-4762-afc3-65f299f95eaa' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='71.13' HigherBound='71.131'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='dd96990c-ca2a-490c-9f94-b875e2535a5b' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='71.133' HigherBound='71.252'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='ad774f0f-6951-4f81-9a4c-d11878c83969' ParentLink='Module_PortType' LowerBound='74.1' HigherBound='81.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Send_Test_HAlo_Svc_RS' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='04525d05-a77d-4f76-9b82-d9e99d3b3635' ParentLink='PortType_OperationDeclaration' LowerBound='76.1' HigherBound='80.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='abc727fa-8eb0-4f60-bbda-de2a366d3d5d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='78.13' HigherBound='78.132'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='66138d0f-7997-4602-a8e1-29a9cd70d820' ParentLink='Module_PortType' LowerBound='81.1' HigherBound='88.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Log_TestEnquiryPointBlanceResult' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a7834368-b54d-40a3-8dee-c84ab3099b0d' ParentLink='PortType_OperationDeclaration' LowerBound='83.1' HigherBound='87.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4459e325-a285-4c13-91b3-a2f01e9c368f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='85.13' HigherBound='85.50'>
                    <om:Property Name='Ref' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='5abfd845-8663-4bba-8af8-e26785d45b43' ParentLink='Module_ServiceDeclaration' LowerBound='88.1' HigherBound='217.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CovertHaloPointToTableBonus' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='232aba83-cfd6-4d45-9248-6b0f5f6e28b2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='119.1' HigherBound='120.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Tiger.BT.RESTBehaviour.JWTTokenUtil' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='var_JWTUtility' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='50b9f5b6-355c-4fff-9fcd-2d1965768a07' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='120.1' HigherBound='121.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='var_Token' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7f6b4ba9-5a25-4616-b416-cd53d826fc3f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='121.1' HigherBound='122.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.Deserialization.Deserialization' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='var_deserialization' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='71910a33-8d05-431c-8522-9fd1f87d8631' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='109.1' HigherBound='110.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msg_BTHaloPointToTableBonusReq' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='03236421-b9a5-4bca-b7c4-6d04940a8fe7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='110.1' HigherBound='111.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msg_BTHaloPointToTableBonusRes' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d0045019-0b4d-40e3-a52b-9a9859d3cf93' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='111.1' HigherBound='112.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentRequest1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_Halo_PointBucketDeduct_Request' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6c8e91d4-f5d9-441c-a7c0-1b84a83585eb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='112.1' HigherBound='113.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HaloS2S_Service_Request1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='740b92bd-9d22-4e84-af21-59a995e8dc9e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='113.1' HigherBound='114.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HaloS2S_Service_Response1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b4b9f487-8c00-44f3-8d0b-89898a0ea6ac' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='114.1' HigherBound='115.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_Halo_PointBucketDeduct_Response' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c73a2bbf-a7f1-4e42-ae8b-44bae371b729' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='115.1' HigherBound='116.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_RQ_Type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='59dcc535-c35f-4bbc-8499-3c8387d23896' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='116.1' HigherBound='117.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_Svc_RQ' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='55508d8a-0ab9-45fd-99cb-695de8529117' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='117.1' HigherBound='118.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_Svc_RS' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='37d2c1b9-5d26-4c81-8afe-9a984fdcb1a8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='118.1' HigherBound='119.1'>
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_HAlo_RS_Type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='208fe516-651d-445e-82bd-2af65f9f74b1' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='ec8da5c7-04df-428f-ac81-81ff690426a1' ParentLink='ServiceBody_Statement' LowerBound='124.1' HigherBound='129.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Log_RequestAndResponse_PointConversion' />
                    <om:Property Name='MessageName' Value='msg_BTHaloPointToTableBonusReq' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='rcv_PointConversionReq' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='307110c9-bdb0-4b51-83e6-09336622f2c7' ParentLink='ServiceBody_Statement' LowerBound='129.1' HigherBound='131.1'>
                    <om:Property Name='PortName' Value='Log_rcv_PointConversionReq' />
                    <om:Property Name='MessageName' Value='msg_BTHaloPointToTableBonusReq' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_4' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='fd29f5d3-788d-46d1-b081-5e5452f8737b' ParentLink='ServiceBody_Statement' LowerBound='131.1' HigherBound='136.1'>
                    <om:Property Name='Expression' Value='var_Token=var_JWTUtility.GenerateToken(msg_BTHaloPointToTableBonusReq.PatronID,false);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Table Bonus&quot;,msg_BTHaloPointToTableBonusReq.PatronID);&#xD;&#xA;//System.Diagnostics.Debug.WriteLine(var_Token); ' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='c5260be9-0f5a-4ed5-8813-fdcefe18bbe9' ParentLink='ServiceBody_Statement' LowerBound='136.1' HigherBound='142.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='c5de931d-4c58-4466-94cf-dc6cd85dac49' ParentLink='ComplexStatement_Statement' LowerBound='139.1' HigherBound='141.1'>
                        <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_Halo_PointBucketDeduct_Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='32b773c0-6017-45be-8b89-eb78b1ecaf14' ParentLink='Transform_InputMessagePartRef' LowerBound='140.153' HigherBound='140.183'>
                            <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusReq' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='2c85639a-8cb9-4ca2-823e-a7fde9826c57' ParentLink='Transform_OutputMessagePartRef' LowerBound='140.28' HigherBound='140.62'>
                            <om:Property Name='MessageRef' Value='Msg_Halo_PointBucketDeduct_Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_4' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='5eec9f78-5d5d-42b6-bf4e-f51c11bd7e6a' ParentLink='Construct_MessageRef' LowerBound='137.23' HigherBound='137.57'>
                        <om:Property Name='Ref' Value='Msg_Halo_PointBucketDeduct_Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='fea58e0e-57b4-4cb3-bc43-4b6e1be83529' ParentLink='ServiceBody_Statement' LowerBound='142.1' HigherBound='148.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_2' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='cf6c4a56-78ca-4f5a-93fe-efb407dee35a' ParentLink='ComplexStatement_Statement' LowerBound='145.1' HigherBound='147.1'>
                        <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_HaloS2S_Service_Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_2' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='0470b756-b2ee-4c5d-8126-bae5468f7a71' ParentLink='Transform_InputMessagePartRef' LowerBound='146.140' HigherBound='146.174'>
                            <om:Property Name='MessageRef' Value='Msg_Halo_PointBucketDeduct_Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_5' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='bfccb8b8-29cf-43f9-b08d-412e278ae6fc' ParentLink='Transform_OutputMessagePartRef' LowerBound='146.28' HigherBound='146.56'>
                            <om:Property Name='MessageRef' Value='Msg_HaloS2S_Service_Request1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_6' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='06bacfe0-f52c-45d3-8065-2dac49b7b408' ParentLink='Construct_MessageRef' LowerBound='143.23' HigherBound='143.51'>
                        <om:Property Name='Ref' Value='Msg_HaloS2S_Service_Request1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='f318f19b-395c-4343-a164-887abc179237' ParentLink='ServiceBody_Statement' LowerBound='148.1' HigherBound='150.1'>
                    <om:Property Name='PortName' Value='Log_Halo_PointBucketDeduct_Request' />
                    <om:Property Name='MessageName' Value='Msg_HaloS2S_Service_Request1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Msg_Halo_PointBucketDeduct_Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='24243bbd-ee5e-4a4f-98fa-34e17379bc19' ParentLink='ServiceBody_Statement' LowerBound='150.1' HigherBound='152.1'>
                    <om:Property Name='PortName' Value='Port_HaloS2S_PointBucketDeduction' />
                    <om:Property Name='MessageName' Value='Msg_HaloS2S_Service_Request1' />
                    <om:Property Name='OperationName' Value='HaloS2S_PointBucketDeduction' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='02dfd10f-08a0-4f2a-b44d-07087797d43b' ParentLink='ServiceBody_Statement' LowerBound='152.1' HigherBound='154.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='Port_HaloS2S_PointBucketDeduction' />
                    <om:Property Name='MessageName' Value='Msg_HaloS2S_Service_Response1' />
                    <om:Property Name='OperationName' Value='HaloS2S_PointBucketDeduction' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='747e7018-abda-481e-af37-3db1179fc088' ParentLink='ServiceBody_Statement' LowerBound='154.1' HigherBound='160.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_3' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='26c9d101-896f-4877-997f-40beb49f5d4b' ParentLink='ComplexStatement_Statement' LowerBound='157.1' HigherBound='159.1'>
                        <om:Property Name='Expression' Value='Msg_Halo_PointBucketDeduct_Response = var_deserialization.DeserializeMessage(Msg_HaloS2S_Service_Response1);' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_2' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='0211a2b9-67c4-4c5b-b0d6-996bb01f47f7' ParentLink='Construct_MessageRef' LowerBound='155.23' HigherBound='155.58'>
                        <om:Property Name='Ref' Value='Msg_Halo_PointBucketDeduct_Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='45f4ea58-7d24-4459-91ed-5f42f849d9e7' ParentLink='ServiceBody_Statement' LowerBound='160.1' HigherBound='162.1'>
                    <om:Property Name='PortName' Value='Log_Halo_PointBucketDeduct_Response' />
                    <om:Property Name='MessageName' Value='Msg_Halo_PointBucketDeduct_Response' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='dcdedb18-ff10-4bbd-83d6-bd8eccebde24' ParentLink='ServiceBody_Statement' LowerBound='162.1' HigherBound='211.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='c86a7773-58dd-46b9-8419-209b46f07c36' ParentLink='ReallyComplexStatement_Branch' LowerBound='163.13' HigherBound='200.1'>
                        <om:Property Name='Expression' Value='Msg_Halo_PointBucketDeduct_Response.s2sBody.WAT.@errorCode==&quot;&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='a6f30845-612b-4cd8-b55f-0e96600910b1' ParentLink='ComplexStatement_Statement' LowerBound='165.1' HigherBound='171.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_8' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Transform' OID='6abb9b55-dc7b-4daa-b47e-3f135302eff0' ParentLink='ComplexStatement_Statement' LowerBound='168.1' HigherBound='170.1'>
                                <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.map_BTHaloPointReqToHaloReq' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_7' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='9faf7be8-7d23-4c53-8a48-97a33aa0297a' ParentLink='Transform_InputMessagePartRef' LowerBound='169.131' HigherBound='169.161'>
                                    <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusReq' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_18' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='9747d611-e5dc-4688-acdd-9d51a8e169cb' ParentLink='Transform_OutputMessagePartRef' LowerBound='169.32' HigherBound='169.48'>
                                    <om:Property Name='MessageRef' Value='Msg_HAlo_RQ_Type' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_19' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='7fb167c1-37f3-4c9a-b699-02c894bef8ed' ParentLink='Construct_MessageRef' LowerBound='166.27' HigherBound='166.43'>
                                <om:Property Name='Ref' Value='Msg_HAlo_RQ_Type' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Construct' OID='9294f159-d69c-4f6e-9fa1-15ee577c9e47' ParentLink='ComplexStatement_Statement' LowerBound='171.1' HigherBound='177.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_9' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Transform' OID='a671ef52-d79e-41b3-b090-bf0ba39bcacd' ParentLink='ComplexStatement_Statement' LowerBound='174.1' HigherBound='176.1'>
                                <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_HAloReqToHAloSvcReq' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_8' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='883d4c82-6383-4acf-b2eb-7646772bc34b' ParentLink='Transform_InputMessagePartRef' LowerBound='175.127' HigherBound='175.143'>
                                    <om:Property Name='MessageRef' Value='Msg_HAlo_RQ_Type' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_20' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='ed9a22d7-dfab-4297-a30d-8dfc693e2c4e' ParentLink='Transform_OutputMessagePartRef' LowerBound='175.32' HigherBound='175.47'>
                                    <om:Property Name='MessageRef' Value='Msg_HAlo_Svc_RQ' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_21' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='0f714700-6a01-418d-a2fc-f84eae53fac7' ParentLink='Construct_MessageRef' LowerBound='172.27' HigherBound='172.42'>
                                <om:Property Name='Ref' Value='Msg_HAlo_Svc_RQ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='76ca3a35-932d-472f-bb97-77b159ce4f96' ParentLink='ComplexStatement_Statement' LowerBound='177.1' HigherBound='179.1'>
                            <om:Property Name='PortName' Value='Port_Send_Test_HAlo_Svc_RQ' />
                            <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RQ' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Test_HAlo_Svc_RQ' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Send' OID='9c8f3a0e-c505-442c-9fab-fbaa189e1e9a' ParentLink='ComplexStatement_Statement' LowerBound='179.1' HigherBound='181.1'>
                            <om:Property Name='PortName' Value='Port_HAlo_S2S_Service' />
                            <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RQ' />
                            <om:Property Name='OperationName' Value='S2SMessagePostOperation' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_HAlo_Svc_PatronPointBalanceEnq' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='6db38fae-dfb4-44da-85fc-e20d154e830d' ParentLink='ComplexStatement_Statement' LowerBound='181.1' HigherBound='183.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='Port_HAlo_S2S_Service' />
                            <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RS' />
                            <om:Property Name='OperationName' Value='S2SMessagePostOperation' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_HAlo_Svc_PatronPointBalanceEnq' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Send' OID='5cd83052-70b4-4d50-8cbf-e9d016eb430a' ParentLink='ComplexStatement_Statement' LowerBound='183.1' HigherBound='185.1'>
                            <om:Property Name='PortName' Value='Port_Send_Test_HAlo_Svc_RS' />
                            <om:Property Name='MessageName' Value='Msg_HAlo_Svc_RS' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Test_HAlo_Svc_RS' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='a6f2b01e-d1df-4292-ba28-e42c387de58c' ParentLink='ComplexStatement_Statement' LowerBound='185.1' HigherBound='191.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_HAlo_RS' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='3f510c6f-701d-4452-a1b5-b6c268555df5' ParentLink='ComplexStatement_Statement' LowerBound='188.1' HigherBound='190.1'>
                                <om:Property Name='Expression' Value='Msg_HAlo_RS_Type = var_deserialization.DeserializeMessage(Msg_HAlo_Svc_RS);' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_4' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='a3d5d28d-847f-4b6e-9511-4882f15f38bd' ParentLink='Construct_MessageRef' LowerBound='186.27' HigherBound='186.43'>
                                <om:Property Name='Ref' Value='Msg_HAlo_RS_Type' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Construct' OID='08d67014-7d18-481e-9bed-25ebad7b5bc1' ParentLink='ComplexStatement_Statement' LowerBound='191.1' HigherBound='199.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='const_PointtoTableBonus' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='916bbdfe-6bda-4ae5-a4ad-1c37250df8c9' ParentLink='Construct_MessageRef' LowerBound='192.27' HigherBound='192.57'>
                                <om:Property Name='Ref' Value='msg_BTHaloPointToTableBonusRes' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Transform' OID='954037bd-81cd-4a73-b378-b496893d20aa' ParentLink='ComplexStatement_Statement' LowerBound='194.1' HigherBound='196.1'>
                                <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.map_ToFinalResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_4' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='1e70b5ed-8a3c-462e-9c96-61e88e21e5da' ParentLink='Transform_InputMessagePartRef' LowerBound='195.133' HigherBound='195.149'>
                                    <om:Property Name='MessageRef' Value='Msg_HAlo_RS_Type' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='909ab3e7-13eb-485c-94fa-1dada888ae05' ParentLink='Transform_InputMessagePartRef' LowerBound='195.151' HigherBound='195.181'>
                                    <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusReq' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='93ee04e5-2050-411a-ac6e-5a892e23472b' ParentLink='Transform_OutputMessagePartRef' LowerBound='195.32' HigherBound='195.62'>
                                    <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusRes' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_7' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='c6e5b0cc-eda6-4c67-bb09-8454153c0769' ParentLink='ComplexStatement_Statement' LowerBound='196.1' HigherBound='198.1'>
                                <om:Property Name='Expression' Value='msg_BTHaloPointToTableBonusRes(WCF.OutboundCustomHeaders) = &quot;&lt;headers&gt;&lt;token&gt;&quot; + var_Token + &quot;&lt;/token&gt;&lt;/headers&gt;&quot;;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='f19433ee-54a2-4e7a-a19d-be78d8b7716f' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='e5a06732-89cf-4b0d-9895-c66056af3411' ParentLink='ComplexStatement_Statement' LowerBound='202.1' HigherBound='210.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_4' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Transform' OID='1aa4921f-308e-4fb8-a2d4-d38271e8c98a' ParentLink='ComplexStatement_Statement' LowerBound='205.1' HigherBound='207.1'>
                                <om:Property Name='ClassName' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.map_HaloPointConversion_To_TableBonusCreditRes_Copy' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_3' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='73dc1f85-9d9e-4d19-80c2-24b2b97d1e7b' ParentLink='Transform_InputMessagePartRef' LowerBound='206.169' HigherBound='206.199'>
                                    <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusReq' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_8' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='2379d6fd-9ef9-4002-9a25-07db448f8a79' ParentLink='Transform_InputMessagePartRef' LowerBound='206.201' HigherBound='206.236'>
                                    <om:Property Name='MessageRef' Value='Msg_Halo_PointBucketDeduct_Response' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_9' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='48707b36-77c6-4b5b-9446-15f1bd58aa56' ParentLink='Transform_OutputMessagePartRef' LowerBound='206.32' HigherBound='206.62'>
                                    <om:Property Name='MessageRef' Value='msg_BTHaloPointToTableBonusRes' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_10' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='663c808b-9103-4a23-9902-092ad5662764' ParentLink='ComplexStatement_Statement' LowerBound='207.1' HigherBound='209.1'>
                                <om:Property Name='Expression' Value='msg_BTHaloPointToTableBonusRes(WCF.OutboundCustomHeaders) = &quot;&lt;headers&gt;&lt;token&gt;&quot; + var_Token + &quot;&lt;/token&gt;&lt;/headers&gt;&quot;;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='6253b6c1-4d22-4802-ba3f-85f1d98ad2c1' ParentLink='Construct_MessageRef' LowerBound='203.27' HigherBound='203.57'>
                                <om:Property Name='Ref' Value='msg_BTHaloPointToTableBonusRes' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='201bc8e6-ecaa-4c4c-bf87-14fe496f6461' ParentLink='ServiceBody_Statement' LowerBound='211.1' HigherBound='213.1'>
                    <om:Property Name='PortName' Value='Log_Response_PointConversion' />
                    <om:Property Name='MessageName' Value='msg_BTHaloPointToTableBonusRes' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_3' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='e1e36f52-c2ec-4794-9338-1032efbd8ecd' ParentLink='ServiceBody_Statement' LowerBound='213.1' HigherBound='215.1'>
                    <om:Property Name='PortName' Value='Log_RequestAndResponse_PointConversion' />
                    <om:Property Name='MessageName' Value='msg_BTHaloPointToTableBonusRes' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='snd_PointConversionReq' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cdbda598-5061-4d97-81ad-631343d56651' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='91.1' HigherBound='93.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='2456f7ac-732b-416e-91df-3c43e8a379fa' ParentLink='PortDeclaration_CLRAttribute' LowerBound='91.1' HigherBound='92.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d4dbaf13-0194-40d9-b1f3-3158a4ac8294' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='93.1' HigherBound='95.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='9a14bd48-096f-41dd-baeb-63ff08f1b50f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='93.1' HigherBound='94.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b5811cd6-7cb9-4594-84ac-c24c1ab5b39e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='95.1' HigherBound='97.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='14' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Request' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Log_Halo_PointBucketDeduct_Request' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2eda9e04-0e4e-42df-bc55-e39b80e22408' ParentLink='PortDeclaration_CLRAttribute' LowerBound='95.1' HigherBound='96.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='955e2c38-e9f1-471f-a445-40e1a0bcca73' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='97.1' HigherBound='99.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='0' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_RequestAndResponse_PointConversion' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Log_RequestAndResponse_PointConversion' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='b64b6601-bcb7-4220-920a-87cac80216a2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='97.1' HigherBound='98.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7f51ebc1-c977-4d44-a95e-ec10af5bdb76' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='99.1' HigherBound='101.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='80' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Send_Test_HAlo_Svc_RQ' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Send_Test_HAlo_Svc_RQ' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='eb16e792-7be2-44dd-b481-bd58b916231a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='99.1' HigherBound='100.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8c02f2fc-5dd9-41d7-9ca4-c3038829e2bd' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='101.1' HigherBound='103.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='85' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_HAlo_S2S_Service' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_HAlo_S2S_Service' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e93982a7-63af-4c46-97ae-5c60f8ecd3f1' ParentLink='PortDeclaration_CLRAttribute' LowerBound='101.1' HigherBound='102.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='9401fc7d-ae31-4b06-a7f4-63c428789ad2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='103.1' HigherBound='105.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='90' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Send_Test_HAlo_Svc_RS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Send_Test_HAlo_Svc_RS' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='1c56e5a7-c23d-40b8-809b-df2ebf3c7088' ParentLink='PortDeclaration_CLRAttribute' LowerBound='103.1' HigherBound='104.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4bbbcb2e-c656-4282-9420-dc23becfa15d' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='105.1' HigherBound='107.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='45' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Halo_PointBucketDeduct_Response' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Log_Halo_PointBucketDeduct_Response' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='f4f7b952-82e9-4b2f-8edd-a2891f14a87f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='105.1' HigherBound='106.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f35d0640-d76a-422d-85f3-c77e8c97f986' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='107.1' HigherBound='109.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='117' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PortType_Log_Response_PointConversion' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Log_Response_PointConversion' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6063863b-47bb-4b42-8e3d-9d45cc8b32ba' ParentLink='PortDeclaration_CLRAttribute' LowerBound='107.1' HigherBound='108.1'>
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

                if (__svc__.Log_Halo_PointBucketDeduct_Request != null)
                {
                    __svc__.Log_Halo_PointBucketDeduct_Request.Close(this, null);
                    __svc__.Log_Halo_PointBucketDeduct_Request = null;
                }
                if (__svc__.Log_rcv_PointConversionReq != null)
                {
                    __svc__.Log_rcv_PointConversionReq.Close(this, null);
                    __svc__.Log_rcv_PointConversionReq = null;
                }
                if (__svc__.Log_Halo_PointBucketDeduct_Response != null)
                {
                    __svc__.Log_Halo_PointBucketDeduct_Response.Close(this, null);
                    __svc__.Log_Halo_PointBucketDeduct_Response = null;
                }
                if (__svc__.Port_Send_Test_HAlo_Svc_RS != null)
                {
                    __svc__.Port_Send_Test_HAlo_Svc_RS.Close(this, null);
                    __svc__.Port_Send_Test_HAlo_Svc_RS = null;
                }
                if (__svc__.Port_HaloS2S_PointBucketDeduction != null)
                {
                    __svc__.Port_HaloS2S_PointBucketDeduction.Close(this, null);
                    __svc__.Port_HaloS2S_PointBucketDeduction = null;
                }
                if (__svc__.Log_RequestAndResponse_PointConversion != null)
                {
                    __svc__.Log_RequestAndResponse_PointConversion.Close(this, null);
                    __svc__.Log_RequestAndResponse_PointConversion = null;
                }
                if (__svc__.Port_Send_Test_HAlo_Svc_RQ != null)
                {
                    __svc__.Port_Send_Test_HAlo_Svc_RQ.Close(this, null);
                    __svc__.Port_Send_Test_HAlo_Svc_RQ = null;
                }
                if (__svc__.Log_Response_PointConversion != null)
                {
                    __svc__.Log_Response_PointConversion.Close(this, null);
                    __svc__.Log_Response_PointConversion = null;
                }
                if (__svc__.Port_HAlo_S2S_Service != null)
                {
                    __svc__.Port_HAlo_S2S_Service.Close(this, null);
                    __svc__.Port_HAlo_S2S_Service = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper2;
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
                __CovertHaloPointToTableBonus_1 __ctx1__ = (__CovertHaloPointToTableBonus_1)(__svc__._stateMgrs[1]);
                __CovertHaloPointToTableBonus_root_0 __ctx0__ = (__CovertHaloPointToTableBonus_root_0)(__svc__._stateMgrs[0]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_Halo_PointBucketDeduct_Request != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Request);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Request = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RQ != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __ctx1__.__Msg_HAlo_Svc_RQ = null;
                }
                if (__ctx1__ != null && __ctx1__.__msg_BTHaloPointToTableBonusRes != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __ctx1__.__msg_BTHaloPointToTableBonusRes = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Response1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Response1);
                    __ctx1__.__Msg_HaloS2S_Service_Response1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__var_deserialization = null;
                if (__ctx1__ != null && __ctx1__.__Msg_Halo_PointBucketDeduct_Response != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Response = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Request1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Request1);
                    __ctx1__.__Msg_HaloS2S_Service_Request1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__var_JWTUtility = null;
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RS != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                    __ctx1__.__Msg_HAlo_Svc_RS = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RS_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                    __ctx1__.__Msg_HAlo_RS_Type = null;
                }
                if (__ctx1__ != null && __ctx1__.__msg_BTHaloPointToTableBonusReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __ctx1__.__msg_BTHaloPointToTableBonusReq = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RQ_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                    __ctx1__.__Msg_HAlo_RQ_Type = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__var_Token = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msg_BTHaloPointToTableBonusReq")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq __msg_BTHaloPointToTableBonusReq;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msg_BTHaloPointToTableBonusRes")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes __msg_BTHaloPointToTableBonusRes;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_Halo_PointBucketDeduct_Request")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1 __Msg_Halo_PointBucketDeduct_Request;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HaloS2S_Service_Request1")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HaloS2S_Service_Request1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HaloS2S_Service_Response1")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse __Msg_HaloS2S_Service_Response1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_Halo_PointBucketDeduct_Response")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1 __Msg_Halo_PointBucketDeduct_Response;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_RQ_Type")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance __Msg_HAlo_RQ_Type;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_Svc_RQ")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HAlo_Svc_RQ;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_Svc_RS")]
            public __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse __Msg_HAlo_Svc_RS;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_HAlo_RS_Type")]
            public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse __Msg_HAlo_RS_Type;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Log_RequestAndResponse_PointConversion")]
        internal PortType_Log_RequestAndResponse_PointConversion Log_RequestAndResponse_PointConversion;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Send_Test_HAlo_Svc_RQ")]
        internal PortType_Send_Test_HAlo_Svc_RQ Port_Send_Test_HAlo_Svc_RQ;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_HAlo_S2S_Service")]
        internal PortType_HAlo_S2S_Service Port_HAlo_S2S_Service;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Send_Test_HAlo_Svc_RS")]
        internal PortType_Send_Test_HAlo_Svc_RS Port_Send_Test_HAlo_Svc_RS;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Log_Response_PointConversion")]
        internal PortType_Log_Response_PointConversion Log_Response_PointConversion;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Log_RequestAndResponse_PointConversion.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Log_RequestAndResponse_PointConversion", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Log_RequestAndResponse_PointConversion"),
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
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Send_Test_HAlo_Svc_RQ.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Port_Send_Test_HAlo_Svc_RQ", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Port_Send_Test_HAlo_Svc_RQ"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_HAlo_S2S_Service.S2SMessagePostOperation},
                                               typeof(CovertHaloPointToTableBonus).GetField("Port_HAlo_S2S_Service", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Port_HAlo_S2S_Service"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Send_Test_HAlo_Svc_RS.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Port_Send_Test_HAlo_Svc_RS", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Port_Send_Test_HAlo_Svc_RS"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Log_Response_PointConversion.Operation_1},
                                               typeof(CovertHaloPointToTableBonus).GetField("Log_Response_PointConversion", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CovertHaloPointToTableBonus), "Log_Response_PointConversion"),
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
                h[_portInfo[6].Name] = _portInfo[6];
                h[_portInfo[7].Name] = _portInfo[7];
                h[_portInfo[8].Name] = _portInfo[8];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "02dfd10f-08a0-4f2a-b44d-07087797d43b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "02dfd10f-08a0-4f2a-b44d-07087797d43b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "747e7018-abda-481e-af37-3db1179fc088", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "747e7018-abda-481e-af37-3db1179fc088", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "45f4ea58-7d24-4459-91ed-5f42f849d9e7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "45f4ea58-7d24-4459-91ed-5f42f849d9e7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "dcdedb18-ff10-4bbd-83d6-bd8eccebde24", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "a6f30845-612b-4cd8-b55f-0e96600910b1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "a6f30845-612b-4cd8-b55f-0e96600910b1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "9294f159-d69c-4f6e-9fa1-15ee577c9e47", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "9294f159-d69c-4f6e-9fa1-15ee577c9e47", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "76ca3a35-932d-472f-bb97-77b159ce4f96", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "76ca3a35-932d-472f-bb97-77b159ce4f96", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "9c8f3a0e-c505-442c-9fab-fbaa189e1e9a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "9c8f3a0e-c505-442c-9fab-fbaa189e1e9a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "6db38fae-dfb4-44da-85fc-e20d154e830d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "6db38fae-dfb4-44da-85fc-e20d154e830d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "5cd83052-70b4-4d50-8cbf-e9d016eb430a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "5cd83052-70b4-4d50-8cbf-e9d016eb430a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "a6f2b01e-d1df-4292-ba28-e42c387de58c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "a6f2b01e-d1df-4292-ba28-e42c387de58c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "08d67014-7d18-481e-9bed-25ebad7b5bc1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "08d67014-7d18-481e-9bed-25ebad7b5bc1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "e5a06732-89cf-4b0d-9895-c66056af3411", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "e5a06732-89cf-4b0d-9895-c66056af3411", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "dcdedb18-ff10-4bbd-83d6-bd8eccebde24", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "201bc8e6-ecaa-4c4c-bf87-14fe496f6461", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "201bc8e6-ecaa-4c4c-bf87-14fe496f6461", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "e1e36f52-c2ec-4794-9338-1032efbd8ecd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "e1e36f52-c2ec-4794-9338-1032efbd8ecd", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,4,4,4,5,6,6,7,7,8,8,9,10,10,11,12,12,12,13,14,14,14,15,16,16,17,18,18,19,20,20,20,21,22,22,23,23,24,25,25,26,27,27,27,28,29,29,29,30,31,31,32,33,33,33,34,35,35,36,37,37,38,22,39,39,40,41,42,42,42,43,44,44,44,45,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CovertHaloPointToTableBonus_1 __ctx1__ = (__CovertHaloPointToTableBonus_1)_stateMgrs[1];
            __CovertHaloPointToTableBonus_root_0 __ctx0__ = (__CovertHaloPointToTableBonus_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Port_HaloS2S_PointBucketDeduction = new PortType_Port_HaloS2S_PointBucketDeduction(3, this);
                Log_rcv_PointConversionReq = new PortType_rcv_PointConversionReq(1, this);
                Log_Halo_PointBucketDeduct_Request = new PortType_Log_Halo_PointBucketDeduct_Request(2, this);
                Log_RequestAndResponse_PointConversion = new PortType_Log_RequestAndResponse_PointConversion(0, this);
                Port_Send_Test_HAlo_Svc_RQ = new PortType_Send_Test_HAlo_Svc_RQ(5, this);
                Port_HAlo_S2S_Service = new PortType_HAlo_S2S_Service(6, this);
                Port_Send_Test_HAlo_Svc_RS = new PortType_Send_Test_HAlo_Svc_RS(7, this);
                Log_Halo_PointBucketDeduct_Response = new PortType_Log_Halo_PointBucketDeduct_Response(4, this);
                Log_Response_PointConversion = new PortType_Log_Response_PointConversion(8, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Log_RequestAndResponse_PointConversion, this);
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
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __CovertHaloPointToTableBonus_1 __ctx1__ = (__CovertHaloPointToTableBonus_1)_stateMgrs[1];
            __CovertHaloPointToTableBonus_root_0 __ctx0__ = (__CovertHaloPointToTableBonus_root_0)_stateMgrs[0];

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
                if (!Log_RequestAndResponse_PointConversion.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msg_BTHaloPointToTableBonusReq != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                __ctx1__.__msg_BTHaloPointToTableBonusReq = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusReq("msg_BTHaloPointToTableBonusReq", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                Log_RequestAndResponse_PointConversion.ReceiveMessage(0, __msgEnv__, __ctx1__.__msg_BTHaloPointToTableBonusReq, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __edata.PortName = @"Log_RequestAndResponse_PointConversion";
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
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1 __Msg_Halo_PointBucketDeduct_Request = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1("Msg_Halo_PointBucketDeduct_Request", __ctx1__);

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
                    __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HaloS2S_Service_Request1 = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest("Msg_HaloS2S_Service_Request1", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_HaloS2S_Service_Request), new object[] {__Msg_HaloS2S_Service_Request1.part}, new object[] {__ctx1__.__Msg_Halo_PointBucketDeduct_Request.part});

                    if (__ctx1__.__Msg_HaloS2S_Service_Request1 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Request1);
                    __ctx1__.__Msg_HaloS2S_Service_Request1 = __Msg_HaloS2S_Service_Request1;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HaloS2S_Service_Request1);
                }
                __ctx1__.__Msg_HaloS2S_Service_Request1.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Request1);
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
                Log_Halo_PointBucketDeduct_Request.SendMessage(0, __ctx1__.__Msg_HaloS2S_Service_Request1, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
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
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Request1);
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
                Port_HaloS2S_PointBucketDeduction.SendMessage(0, __ctx1__.__Msg_HaloS2S_Service_Request1, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Request1);
                    __edata.PortName = @"Port_HaloS2S_PointBucketDeduction";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Request1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Request1);
                    __ctx1__.__Msg_HaloS2S_Service_Request1 = null;
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
                if (__ctx1__.__Msg_HaloS2S_Service_Response1 != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Response1);
                __ctx1__.__Msg_HaloS2S_Service_Response1 = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse("Msg_HaloS2S_Service_Response1", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg_HaloS2S_Service_Response1);
                Port_HaloS2S_PointBucketDeduction.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg_HaloS2S_Service_Response1, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
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
                    __edata.Messages.Add(__ctx1__.__Msg_HaloS2S_Service_Response1);
                    __edata.PortName = @"Port_HaloS2S_PointBucketDeduction";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1 __Msg_Halo_PointBucketDeduct_Response = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1("Msg_Halo_PointBucketDeduct_Response", __ctx1__);

                    __Msg_Halo_PointBucketDeduct_Response.part.LoadFrom(__ctx1__.__var_deserialization.DeserializeMessage(CreateMessageWrapperForUserCode(__ctx1__.__Msg_HaloS2S_Service_Response1)));
                    if (__ctx1__ != null && __ctx1__.__Msg_HaloS2S_Service_Response1 != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HaloS2S_Service_Response1);
                        __ctx1__.__Msg_HaloS2S_Service_Response1 = null;
                    }

                    if (__ctx1__.__Msg_Halo_PointBucketDeduct_Response != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    __ctx1__.__Msg_Halo_PointBucketDeduct_Response = __Msg_Halo_PointBucketDeduct_Response;
                    __ctx1__.RefMessage(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                }
                __ctx1__.__Msg_Halo_PointBucketDeduct_Response.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Log_Halo_PointBucketDeduct_Response.SendMessage(0, __ctx1__.__Msg_Halo_PointBucketDeduct_Response, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Log_Halo_PointBucketDeduct_Response != null)
                {
                    Log_Halo_PointBucketDeduct_Response.Close(__ctx1__, __seg__);
                    Log_Halo_PointBucketDeduct_Response = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    __edata.PortName = @"Log_Halo_PointBucketDeduct_Response";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                __condition__ = (System.String)__ctx1__.__Msg_Halo_PointBucketDeduct_Response.part.GetDistinguishedField("s2sBody.WAT.errorCode") == "";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 70;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance __Msg_HAlo_RQ_Type = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance("Msg_HAlo_RQ_Type", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.map_BTHaloPointReqToHaloReq), new object[] {__Msg_HAlo_RQ_Type.part}, new object[] {__ctx1__.__msg_BTHaloPointToTableBonusReq.part});

                    if (__ctx1__.__Msg_HAlo_RQ_Type != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                    __ctx1__.__Msg_HAlo_RQ_Type = __Msg_HAlo_RQ_Type;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                }
                __ctx1__.__Msg_HAlo_RQ_Type.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RQ_Type);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    Tracker.FireEvent(__eventLocations[24],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                {
                    __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest __Msg_HAlo_Svc_RQ = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sRequest("Msg_HAlo_Svc_RQ", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.Trfm_HAloReqToHAloSvcReq), new object[] {__Msg_HAlo_Svc_RQ.part}, new object[] {__ctx1__.__Msg_HAlo_RQ_Type.part});

                    if (__ctx1__.__Msg_HAlo_Svc_RQ != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __ctx1__.__Msg_HAlo_Svc_RQ = __Msg_HAlo_Svc_RQ;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                }
                __ctx1__.__Msg_HAlo_Svc_RQ.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RQ_Type);
                    Tracker.FireEvent(__eventLocations[26],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RQ_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RQ_Type);
                    __ctx1__.__Msg_HAlo_RQ_Type = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_Send_Test_HAlo_Svc_RQ.SendMessage(0, __ctx1__.__Msg_HAlo_Svc_RQ, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __edata.PortName = @"Port_Send_Test_HAlo_Svc_RQ";
                    Tracker.FireEvent(__eventLocations[28],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_HAlo_S2S_Service.SendMessage(0, __ctx1__.__Msg_HAlo_Svc_RQ, null, null, out __ctx0__.__subWrapper2, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 55;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __edata.PortName = @"Port_HAlo_S2S_Service";
                    Tracker.FireEvent(__eventLocations[30],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RQ != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RQ);
                    __ctx1__.__Msg_HAlo_Svc_RQ = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 56;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                if (!Port_HAlo_S2S_Service.GetMessageId(__ctx0__.__subWrapper2.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[1]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                if (__ctx1__.__Msg_HAlo_Svc_RS != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                __ctx1__.__Msg_HAlo_Svc_RS = new __messagetype_Tiger_BT_Gaming_HAloS2S_S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl_s2sResponse("Msg_HAlo_Svc_RS", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                Port_HAlo_S2S_Service.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg_HAlo_Svc_RS, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RS);
                    __edata.PortName = @"Port_HAlo_S2S_Service";
                    Tracker.FireEvent(__eventLocations[32],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                if ( !PreProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_Send_Test_HAlo_Svc_RS.SendMessage(0, __ctx1__.__Msg_HAlo_Svc_RS, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_Svc_RS);
                    __edata.PortName = @"Port_Send_Test_HAlo_Svc_RS";
                    Tracker.FireEvent(__eventLocations[34],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse __Msg_HAlo_RS_Type = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse("Msg_HAlo_RS_Type", __ctx1__);

                    __Msg_HAlo_RS_Type.part.LoadFrom(__ctx1__.__var_deserialization.DeserializeMessage(CreateMessageWrapperForUserCode(__ctx1__.__Msg_HAlo_Svc_RS)));
                    if (__ctx1__ != null && __ctx1__.__Msg_HAlo_Svc_RS != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_Svc_RS);
                        __ctx1__.__Msg_HAlo_Svc_RS = null;
                    }

                    if (__ctx1__.__Msg_HAlo_RS_Type != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                    __ctx1__.__Msg_HAlo_RS_Type = __Msg_HAlo_RS_Type;
                    __ctx1__.RefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                }
                __ctx1__.__Msg_HAlo_RS_Type.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 65;
            case 65:
                if ( !PreProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RS_Type);
                    Tracker.FireEvent(__eventLocations[36],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 66;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 67;
            case 67:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes __msg_BTHaloPointToTableBonusRes = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes("msg_BTHaloPointToTableBonusRes", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.map_ToFinalResponse), new object[] {__msg_BTHaloPointToTableBonusRes.part}, new object[] {__ctx1__.__Msg_HAlo_RS_Type.part, __ctx1__.__msg_BTHaloPointToTableBonusReq.part});
                    __msg_BTHaloPointToTableBonusRes.SetPropertyValue(typeof(WCF.OutboundCustomHeaders), "<headers><token>" + __ctx1__.__var_Token + "</token></headers>");

                    if (__ctx1__.__msg_BTHaloPointToTableBonusRes != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __ctx1__.__msg_BTHaloPointToTableBonusRes = __msg_BTHaloPointToTableBonusRes;
                    __ctx1__.RefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                }
                __ctx1__.__msg_BTHaloPointToTableBonusRes.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 68:
                if ( !PreProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __edata.Messages.Add(__ctx1__.__Msg_HAlo_RS_Type);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    Tracker.FireEvent(__eventLocations[38],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_HAlo_RS_Type != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_HAlo_RS_Type);
                    __ctx1__.__Msg_HAlo_RS_Type = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 69;
            case 69:
                if ( !PostProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 73;
            case 70:
                if ( !PreProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 71;
            case 71:
                {
                    __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes __msg_BTHaloPointToTableBonusRes = new __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BT_ConvertPointToTableBonusRes("msg_BTHaloPointToTableBonusRes", __ctx1__);

                    ApplyTransform(typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map.map_HaloPointConversion_To_TableBonusCreditRes_Copy), new object[] {__msg_BTHaloPointToTableBonusRes.part}, new object[] {__ctx1__.__msg_BTHaloPointToTableBonusReq.part, __ctx1__.__Msg_Halo_PointBucketDeduct_Response.part});
                    __msg_BTHaloPointToTableBonusRes.SetPropertyValue(typeof(WCF.OutboundCustomHeaders), "<headers><token>" + __ctx1__.__var_Token + "</token></headers>");

                    if (__ctx1__.__msg_BTHaloPointToTableBonusRes != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __ctx1__.__msg_BTHaloPointToTableBonusRes = __msg_BTHaloPointToTableBonusRes;
                    __ctx1__.RefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                }
                __ctx1__.__msg_BTHaloPointToTableBonusRes.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 72;
            case 72:
                if ( !PreProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusReq);
                    __edata.Messages.Add(__ctx1__.__Msg_Halo_PointBucketDeduct_Response);
                    Tracker.FireEvent(__eventLocations[40],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 73;
            case 73:
                if ( !PreProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__var_deserialization = null;
                if (__ctx1__ != null)
                    __ctx1__.__var_Token = null;
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
                if (Port_Send_Test_HAlo_Svc_RS != null)
                {
                    Port_Send_Test_HAlo_Svc_RS.Close(__ctx1__, __seg__);
                    Port_Send_Test_HAlo_Svc_RS = null;
                }
                if (Port_HAlo_S2S_Service != null)
                {
                    Port_HAlo_S2S_Service.Close(__ctx1__, __seg__);
                    Port_HAlo_S2S_Service = null;
                }
                if (Port_Send_Test_HAlo_Svc_RQ != null)
                {
                    Port_Send_Test_HAlo_Svc_RQ.Close(__ctx1__, __seg__);
                    Port_Send_Test_HAlo_Svc_RQ = null;
                }
                Tracker.FireEvent(__eventLocations[41],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 74;
            case 74:
                if ( !PreProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 75;
            case 75:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 76;
            case 76:
                if ( !PreProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Log_Response_PointConversion.SendMessage(0, __ctx1__.__msg_BTHaloPointToTableBonusRes, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (Log_Response_PointConversion != null)
                {
                    Log_Response_PointConversion.Close(__ctx1__, __seg__);
                    Log_Response_PointConversion = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 77;
            case 77:
                if ( !PreProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __edata.PortName = @"Log_Response_PointConversion";
                    Tracker.FireEvent(__eventLocations[43],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 78;
            case 78:
                if ( !PreProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[44],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 79;
            case 79:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 80 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 80;
            case 80:
                if ( !PreProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Log_RequestAndResponse_PointConversion.SendMessage(0, __ctx1__.__msg_BTHaloPointToTableBonusRes, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Log_RequestAndResponse_PointConversion != null)
                {
                    Log_RequestAndResponse_PointConversion.Close(__ctx1__, __seg__);
                    Log_RequestAndResponse_PointConversion = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 81;
            case 81:
                if ( !PreProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __edata.PortName = @"Log_RequestAndResponse_PointConversion";
                    Tracker.FireEvent(__eventLocations[45],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msg_BTHaloPointToTableBonusRes != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msg_BTHaloPointToTableBonusRes);
                    __ctx1__.__msg_BTHaloPointToTableBonusRes = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 82;
            case 82:
                if ( !PreProgressInc( __seg__, __ctx__, 83 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 83;
            case 83:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 84 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 84;
            case 84:
                if ( !PreProgressInc( __seg__, __ctx__, 85 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 85;
            case 85:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{D2A69C4D-6BBB-45F6-A3B4-D31E8E9EF2B3}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{ED349B6F-6BB2-4DD6-A7B5-BDEB88762C8E}"))
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
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1 _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentResponse1(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentRequest1 _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentRequest1();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentRequest1",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentRequest1)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_Halo1_HaloPointAdjustmentRequest1(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyRequestPlayerBalance(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse _schema = new Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse();

        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse",
        new System.Type[]{
            typeof(Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse__)
        },
        0,
        @"http://www.gamingstandards.com/s2s/schemas/v1.2.6/#s2sMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Tiger_BT_Gaming_ConvertHaloPointsToTableBonus_Schema_BallyGetPropertyBalancesResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}

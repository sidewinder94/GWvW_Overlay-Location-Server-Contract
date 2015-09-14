using System.ServiceModel;

namespace GWvW_Overlay_Location_Server_Contracts
{
    [ServiceContract(CallbackContract = typeof(ILocationServiceCallBack))]
    public interface ILocationService
    {
        //[OperationContract]
    }
}
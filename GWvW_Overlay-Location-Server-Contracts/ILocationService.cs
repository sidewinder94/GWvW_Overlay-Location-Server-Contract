using System;
using System.ServiceModel;

namespace GWvW_Overlay_Location_Server_Contracts
{
    [ServiceContract(CallbackContract = typeof(ILocationServiceCallBack))]
    public interface ILocationService
    {
        [OperationContract(IsInitiating = true,
                           IsTerminating = false)]
        Guid SubscribeClient(Client newClient);

        [OperationContract(IsInitiating = false,
                           IsTerminating = false,
                           IsOneWay = true)]
        void SendPosition(Guid clientId, Position position);


        [OperationContract(IsTerminating = true,
                           IsInitiating = false,
                           IsOneWay = true)]
        void UnsubscribeClient(Guid clientId);
    }
}
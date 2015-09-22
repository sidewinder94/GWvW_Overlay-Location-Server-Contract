using System;
using System.ServiceModel;

namespace GWvW_Overlay_Location_Server_Contracts
{
    [ServiceContract(CallbackContract = typeof(ILocationServiceCallBack))]
    public interface ILocationService
    {
        [OperationContract()]
        Guid SubscribeClient(Client newClient);

        [OperationContract(IsOneWay = true)]
        void SendPosition(Guid clientId, Position position);

        [OperationContract]
        bool ValidateAPIKey(String apiKey);

        [OperationContract(IsOneWay = true)]
        void UnsubscribeClient(Guid clientId);
    }
}
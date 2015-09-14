using System.Collections.Generic;
using System.ServiceModel;

namespace GWvW_Overlay_Location_Server_Contracts
{
    public interface ILocationServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void ReceivePositions(List<Position> positions);
    }
}
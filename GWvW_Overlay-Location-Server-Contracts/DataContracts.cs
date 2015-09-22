using System;
using System.Runtime.Serialization;

namespace GWvW_Overlay_Location_Server_Contracts
{
    [DataContract]
    public class Client
    {
        [DataMember(IsRequired = true)]
        public String AnetAccountApiKey;

        [DataMember]
        public String CharacterName;


        public Guid Id;
        public String AccountId;
        public String AccountName;
        public int ServerId;

        public int MapId
        {
            get { return Position.MapId; }
            set { Position.MapId = value; }
        }

        [DataMember(IsRequired = true)]
        public Position Position;

    }

    [DataContract]
    public class Position
    {
        [DataMember(IsRequired = true)]
        public double X, Y;

        [DataMember(IsRequired = true)]
        public int MapId;

    }
}

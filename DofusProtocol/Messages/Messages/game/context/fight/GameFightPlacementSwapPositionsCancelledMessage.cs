

// Generated on 12/20/2015 16:36:49
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class GameFightPlacementSwapPositionsCancelledMessage : Message
    {
        public const uint Id = 6546;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int requestId;
        public double cancellerId;
        
        public GameFightPlacementSwapPositionsCancelledMessage()
        {
        }
        
        public GameFightPlacementSwapPositionsCancelledMessage(int requestId, double cancellerId)
        {
            this.requestId = requestId;
            this.cancellerId = cancellerId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(requestId);
            writer.WriteDouble(cancellerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            requestId = reader.ReadInt();
            if (requestId < 0)
                throw new Exception("Forbidden value on requestId = " + requestId + ", it doesn't respect the following condition : requestId < 0");
            cancellerId = reader.ReadDouble();
            if (cancellerId < -9.007199254740992E15 || cancellerId > 9.007199254740992E15)
                throw new Exception("Forbidden value on cancellerId = " + cancellerId + ", it doesn't respect the following condition : cancellerId < -9.007199254740992E15 || cancellerId > 9.007199254740992E15");
        }
        
    }
    
}
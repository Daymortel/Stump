

// Generated on 03/06/2014 18:50:09
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class GameFightJoinRequestMessage : Message
    {
        public const uint Id = 701;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int fighterId;
        public int fightId;
        
        public GameFightJoinRequestMessage()
        {
        }
        
        public GameFightJoinRequestMessage(int fighterId, int fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(fighterId);
            writer.WriteInt(fightId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fighterId = reader.ReadInt();
            fightId = reader.ReadInt();
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(int) + sizeof(int);
        }
        
    }
    
}
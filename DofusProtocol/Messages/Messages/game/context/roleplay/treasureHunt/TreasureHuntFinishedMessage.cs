

// Generated on 02/11/2015 10:20:34
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class TreasureHuntFinishedMessage : Message
    {
        public const uint Id = 6483;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte questType;
        
        public TreasureHuntFinishedMessage()
        {
        }
        
        public TreasureHuntFinishedMessage(sbyte questType)
        {
            this.questType = questType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(questType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            questType = reader.ReadSByte();
            if (questType < 0)
                throw new Exception("Forbidden value on questType = " + questType + ", it doesn't respect the following condition : questType < 0");
        }
        
    }
    
}


// Generated on 08/04/2015 13:24:43
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class BasicStatMessage : Message
    {
        public const uint Id = 6530;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short statId;
        
        public BasicStatMessage()
        {
        }
        
        public BasicStatMessage(short statId)
        {
            this.statId = statId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(statId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            statId = reader.ReadVarShort();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
        }
        
    }
    
}
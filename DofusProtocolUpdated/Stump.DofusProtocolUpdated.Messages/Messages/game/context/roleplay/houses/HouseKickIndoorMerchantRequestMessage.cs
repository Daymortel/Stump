

// Generated on 03/06/2014 18:50:13
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class HouseKickIndoorMerchantRequestMessage : Message
    {
        public const uint Id = 5661;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short cellId;
        
        public HouseKickIndoorMerchantRequestMessage()
        {
        }
        
        public HouseKickIndoorMerchantRequestMessage(short cellId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cellId = reader.ReadShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(short);
        }
        
    }
    
}
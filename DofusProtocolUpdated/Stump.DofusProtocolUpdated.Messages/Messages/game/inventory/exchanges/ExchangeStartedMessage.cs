

// Generated on 03/06/2014 18:50:24
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class ExchangeStartedMessage : Message
    {
        public const uint Id = 5512;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte exchangeType;
        
        public ExchangeStartedMessage()
        {
        }
        
        public ExchangeStartedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(exchangeType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            exchangeType = reader.ReadSByte();
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(sbyte);
        }
        
    }
    
}
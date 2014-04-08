

// Generated on 03/06/2014 18:50:18
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class IgnoredDeleteResultMessage : Message
    {
        public const uint Id = 5677;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string name;
        
        public IgnoredDeleteResultMessage()
        {
        }
        
        public IgnoredDeleteResultMessage(string name)
        {
            this.name = name;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            name = reader.ReadUTF();
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(short) + Encoding.UTF8.GetByteCount(name);
        }
        
    }
    
}
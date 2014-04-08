

// Generated on 03/06/2014 18:49:58
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class BasicPingMessage : Message
    {
        public const uint Id = 182;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool quiet;
        
        public BasicPingMessage()
        {
        }
        
        public BasicPingMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(quiet);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            quiet = reader.ReadBoolean();
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(bool);
        }
        
    }
    
}
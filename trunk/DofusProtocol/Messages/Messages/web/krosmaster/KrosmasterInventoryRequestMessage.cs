
// Generated on 01/04/2013 14:36:02
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class KrosmasterInventoryRequestMessage : Message
    {
        public const uint Id = 6344;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public KrosmasterInventoryRequestMessage()
        {
        }
        
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}
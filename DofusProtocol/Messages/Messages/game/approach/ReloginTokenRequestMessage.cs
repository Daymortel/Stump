

// Generated on 08/04/2015 13:24:49
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class ReloginTokenRequestMessage : Message
    {
        public const uint Id = 6540;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public ReloginTokenRequestMessage()
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
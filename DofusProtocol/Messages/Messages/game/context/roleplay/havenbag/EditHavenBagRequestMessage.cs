

// Generated on 09/26/2016 01:50:01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class EditHavenBagRequestMessage : Message
    {
        public const uint Id = 6626;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public EditHavenBagRequestMessage()
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
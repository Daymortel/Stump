

// Generated on 03/06/2014 18:50:04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class CharacterSelectedSuccessMessage : Message
    {
        public const uint Id = 153;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterBaseInformations infos;
        
        public CharacterSelectedSuccessMessage()
        {
        }
        
        public CharacterSelectedSuccessMessage(Types.CharacterBaseInformations infos)
        {
            this.infos = infos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            infos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            infos = new Types.CharacterBaseInformations();
            infos.Deserialize(reader);
        }
        
        public override int GetSerializationSize()
        {
            return infos.GetSerializationSize();
        }
        
    }
    
}
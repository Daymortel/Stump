

// Generated on 03/06/2014 18:50:31
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
    public class FightDispellableEffectExtendedInformations
    {
        public const short Id = 208;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public short actionId;
        public int sourceId;
        public Types.AbstractFightDispellableEffect effect;
        
        public FightDispellableEffectExtendedInformations()
        {
        }
        
        public FightDispellableEffectExtendedInformations(short actionId, int sourceId, Types.AbstractFightDispellableEffect effect)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
            this.effect = effect;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(actionId);
            writer.WriteInt(sourceId);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            actionId = reader.ReadShort();
            if (actionId < 0)
                throw new Exception("Forbidden value on actionId = " + actionId + ", it doesn't respect the following condition : actionId < 0");
            sourceId = reader.ReadInt();
            effect = Types.ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadShort());
            effect.Deserialize(reader);
        }
        
        public virtual int GetSerializationSize()
        {
            return sizeof(short) + sizeof(int) + sizeof(short) + effect.GetSerializationSize();
        }
        
    }
    
}
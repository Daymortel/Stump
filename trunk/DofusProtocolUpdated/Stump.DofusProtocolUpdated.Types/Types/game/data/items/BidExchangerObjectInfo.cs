

// Generated on 12/12/2013 16:57:32
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
    public class BidExchangerObjectInfo
    {
        public const short Id = 122;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int objectUID;
        public IEnumerable<Types.ObjectEffect> effects;
        public IEnumerable<int> prices;
        
        public BidExchangerObjectInfo()
        {
        }
        
        public BidExchangerObjectInfo(int objectUID, IEnumerable<Types.ObjectEffect> effects, IEnumerable<int> prices)
        {
            this.objectUID = objectUID;
            this.effects = effects;
            this.prices = prices;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(objectUID);
            writer.WriteUShort((ushort)effects.Count());
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)prices.Count());
            foreach (var entry in prices)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 (effects as Types.ObjectEffect[])[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 (effects as Types.ObjectEffect[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            prices = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (prices as int[])[i] = reader.ReadInt();
            }
        }
        
        public virtual int GetSerializationSize()
        {
            return sizeof(int) + sizeof(short) + effects.Sum(x => sizeof(short) + x.GetSerializationSize()) + sizeof(short) + prices.Sum(x => sizeof(int));
        }
        
    }
    
}


// Generated on 12/12/2013 16:57:22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class StorageObjectsRemoveMessage : Message
    {
        public const uint Id = 6035;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public IEnumerable<int> objectUIDList;
        
        public StorageObjectsRemoveMessage()
        {
        }
        
        public StorageObjectsRemoveMessage(IEnumerable<int> objectUIDList)
        {
            this.objectUIDList = objectUIDList;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort((ushort)objectUIDList.Count());
            foreach (var entry in objectUIDList)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = reader.ReadUShort();
            objectUIDList = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectUIDList as int[])[i] = reader.ReadInt();
            }
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(short) + objectUIDList.Sum(x => sizeof(int));
        }
        
    }
    
}
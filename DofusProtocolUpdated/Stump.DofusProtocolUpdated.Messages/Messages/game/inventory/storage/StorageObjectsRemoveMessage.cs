

// Generated on 03/06/2014 18:50:26
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
            var objectUIDList_before = writer.Position;
            var objectUIDList_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in objectUIDList)
            {
                 writer.WriteInt(entry);
                 objectUIDList_count++;
            }
            var objectUIDList_after = writer.Position;
            writer.Seek((int)objectUIDList_before);
            writer.WriteUShort((ushort)objectUIDList_count);
            writer.Seek((int)objectUIDList_after);

        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = reader.ReadUShort();
            var objectUIDList_ = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectUIDList_[i] = reader.ReadInt();
            }
            objectUIDList = objectUIDList_;
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(short) + objectUIDList.Sum(x => sizeof(int));
        }
        
    }
    
}


// Generated on 03/06/2014 18:50:34
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
    public class GameRolePlayNpcQuestFlag
    {
        public const short Id = 384;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public IEnumerable<short> questsToValidId;
        public IEnumerable<short> questsToStartId;
        
        public GameRolePlayNpcQuestFlag()
        {
        }
        
        public GameRolePlayNpcQuestFlag(IEnumerable<short> questsToValidId, IEnumerable<short> questsToStartId)
        {
            this.questsToValidId = questsToValidId;
            this.questsToStartId = questsToStartId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            var questsToValidId_before = writer.Position;
            var questsToValidId_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in questsToValidId)
            {
                 writer.WriteShort(entry);
                 questsToValidId_count++;
            }
            var questsToValidId_after = writer.Position;
            writer.Seek((int)questsToValidId_before);
            writer.WriteUShort((ushort)questsToValidId_count);
            writer.Seek((int)questsToValidId_after);

            var questsToStartId_before = writer.Position;
            var questsToStartId_count = 0;
            writer.WriteUShort(0);
            foreach (var entry in questsToStartId)
            {
                 writer.WriteShort(entry);
                 questsToStartId_count++;
            }
            var questsToStartId_after = writer.Position;
            writer.Seek((int)questsToStartId_before);
            writer.WriteUShort((ushort)questsToStartId_count);
            writer.Seek((int)questsToStartId_after);

        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            var limit = reader.ReadUShort();
            var questsToValidId_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToValidId_[i] = reader.ReadShort();
            }
            questsToValidId = questsToValidId_;
            limit = reader.ReadUShort();
            var questsToStartId_ = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToStartId_[i] = reader.ReadShort();
            }
            questsToStartId = questsToStartId_;
        }
        
        public virtual int GetSerializationSize()
        {
            return sizeof(short) + questsToValidId.Sum(x => sizeof(short)) + sizeof(short) + questsToStartId.Sum(x => sizeof(short));
        }
        
    }
    
}
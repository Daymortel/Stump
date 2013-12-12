

// Generated on 12/12/2013 16:57:02
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class JobCrafterDirectoryEntryMessage : Message
    {
        public const uint Id = 6044;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
        public IEnumerable<Types.JobCrafterDirectoryEntryJobInfo> jobInfoList;
        public Types.EntityLook playerLook;
        
        public JobCrafterDirectoryEntryMessage()
        {
        }
        
        public JobCrafterDirectoryEntryMessage(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, IEnumerable<Types.JobCrafterDirectoryEntryJobInfo> jobInfoList, Types.EntityLook playerLook)
        {
            this.playerInfo = playerInfo;
            this.jobInfoList = jobInfoList;
            this.playerLook = playerLook;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            playerInfo.Serialize(writer);
            writer.WriteUShort((ushort)jobInfoList.Count());
            foreach (var entry in jobInfoList)
            {
                 entry.Serialize(writer);
            }
            playerLook.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
            playerInfo.Deserialize(reader);
            var limit = reader.ReadUShort();
            jobInfoList = new Types.JobCrafterDirectoryEntryJobInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (jobInfoList as Types.JobCrafterDirectoryEntryJobInfo[])[i] = new Types.JobCrafterDirectoryEntryJobInfo();
                 (jobInfoList as Types.JobCrafterDirectoryEntryJobInfo[])[i].Deserialize(reader);
            }
            playerLook = new Types.EntityLook();
            playerLook.Deserialize(reader);
        }
        
        public override int GetSerializationSize()
        {
            return playerInfo.GetSerializationSize() + sizeof(short) + jobInfoList.Sum(x => x.GetSerializationSize()) + playerLook.GetSerializationSize();
        }
        
    }
    
}
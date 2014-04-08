

// Generated on 03/06/2014 18:50:35
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
    public class FriendSpouseOnlineInformations : FriendSpouseInformations
    {
        public const short Id = 93;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public bool inFight;
        public bool followSpouse;
        public int mapId;
        public short subAreaId;
        
        public FriendSpouseOnlineInformations()
        {
        }
        
        public FriendSpouseOnlineInformations(int spouseAccountId, int spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, Types.EntityLook spouseEntityLook, Types.BasicGuildInformations guildInfo, sbyte alignmentSide, bool inFight, bool followSpouse, int mapId, short subAreaId)
         : base(spouseAccountId, spouseId, spouseName, spouseLevel, breed, sex, spouseEntityLook, guildInfo, alignmentSide)
        {
            this.inFight = inFight;
            this.followSpouse = followSpouse;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, inFight);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, followSpouse);
            writer.WriteByte(flag1);
            writer.WriteInt(mapId);
            writer.WriteShort(subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            inFight = BooleanByteWrapper.GetFlag(flag1, 0);
            followSpouse = BooleanByteWrapper.GetFlag(flag1, 1);
            mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            subAreaId = reader.ReadShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
        }
        
        public override int GetSerializationSize()
        {
            return base.GetSerializationSize() + sizeof(bool) + 0 + sizeof(int) + sizeof(short);
        }
        
    }
    
}
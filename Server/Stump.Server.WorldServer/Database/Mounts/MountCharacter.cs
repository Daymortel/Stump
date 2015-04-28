﻿using Stump.ORM;
using Stump.ORM.SubSonic.SQLGeneration.Schema;

namespace Stump.Server.WorldServer.Database.Mounts
{
    public class MountCharacterRelator
    {
        public static string FetchByCharacterId = "SELECT * FROM mounts_characters WHERE CharacterId={0}";
    }

    [TableName("mounts_characters")]
    public class MountCharacter : IAutoGeneratedRecord
    {
        [Index]
        [PrimaryKey("CharacterId", false)]
        public int CharacterId
        {
            get;
            set;
        }

        public int MountId
        {
            get;
            set;
        }
    }
}
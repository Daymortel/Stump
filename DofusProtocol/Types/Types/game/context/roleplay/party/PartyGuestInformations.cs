

// Generated on 03/02/2014 20:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
    public class PartyGuestInformations
    {
        public const short Id = 374;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int guestId;
        public int hostId;
        public string name;
        public Types.EntityLook guestLook;
        public sbyte breed;
        public bool sex;
        
        public PartyGuestInformations()
        {
        }
        
        public PartyGuestInformations(int guestId, int hostId, string name, Types.EntityLook guestLook, sbyte breed, bool sex)
        {
            this.guestId = guestId;
            this.hostId = hostId;
            this.name = name;
            this.guestLook = guestLook;
            this.breed = breed;
            this.sex = sex;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(guestId);
            writer.WriteInt(hostId);
            writer.WriteUTF(name);
            guestLook.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            guestId = reader.ReadInt();
            if (guestId < 0)
                throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
            hostId = reader.ReadInt();
            if (hostId < 0)
                throw new Exception("Forbidden value on hostId = " + hostId + ", it doesn't respect the following condition : hostId < 0");
            name = reader.ReadUTF();
            guestLook = new Types.EntityLook();
            guestLook.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
        }
        
        public virtual int GetSerializationSize()
        {
            return sizeof(int) + sizeof(int) + sizeof(short) + Encoding.UTF8.GetByteCount(name) + guestLook.GetSerializationSize() + sizeof(sbyte) + sizeof(bool);
        }
        
    }
    
}
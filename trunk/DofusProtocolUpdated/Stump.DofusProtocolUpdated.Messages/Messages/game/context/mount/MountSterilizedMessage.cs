

// Generated on 12/12/2013 16:56:58
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class MountSterilizedMessage : Message
    {
        public const uint Id = 5977;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mountId;
        
        public MountSterilizedMessage()
        {
        }
        
        public MountSterilizedMessage(double mountId)
        {
            this.mountId = mountId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(mountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mountId = reader.ReadDouble();
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(double);
        }
        
    }
    
}
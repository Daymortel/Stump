

// Generated on 12/12/2013 16:57:26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class DownloadSetSpeedRequestMessage : Message
    {
        public const uint Id = 1512;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte downloadSpeed;
        
        public DownloadSetSpeedRequestMessage()
        {
        }
        
        public DownloadSetSpeedRequestMessage(sbyte downloadSpeed)
        {
            this.downloadSpeed = downloadSpeed;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(downloadSpeed);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            downloadSpeed = reader.ReadSByte();
            if (downloadSpeed < 1 || downloadSpeed > 10)
                throw new Exception("Forbidden value on downloadSpeed = " + downloadSpeed + ", it doesn't respect the following condition : downloadSpeed < 1 || downloadSpeed > 10");
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(sbyte);
        }
        
    }
    
}


// Generated on 12/12/2013 16:57:03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class NpcDialogQuestionMessage : Message
    {
        public const uint Id = 5617;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short messageId;
        public IEnumerable<string> dialogParams;
        public IEnumerable<short> visibleReplies;
        
        public NpcDialogQuestionMessage()
        {
        }
        
        public NpcDialogQuestionMessage(short messageId, IEnumerable<string> dialogParams, IEnumerable<short> visibleReplies)
        {
            this.messageId = messageId;
            this.dialogParams = dialogParams;
            this.visibleReplies = visibleReplies;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(messageId);
            writer.WriteUShort((ushort)dialogParams.Count());
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteUShort((ushort)visibleReplies.Count());
            foreach (var entry in visibleReplies)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            messageId = reader.ReadShort();
            if (messageId < 0)
                throw new Exception("Forbidden value on messageId = " + messageId + ", it doesn't respect the following condition : messageId < 0");
            var limit = reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dialogParams as string[])[i] = reader.ReadUTF();
            }
            limit = reader.ReadUShort();
            visibleReplies = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (visibleReplies as short[])[i] = reader.ReadShort();
            }
        }
        
        public override int GetSerializationSize()
        {
            return sizeof(short) + sizeof(short) + dialogParams.Sum(x => sizeof(short) + Encoding.UTF8.GetByteCount(x)) + sizeof(short) + visibleReplies.Sum(x => sizeof(short));
        }
        
    }
    
}
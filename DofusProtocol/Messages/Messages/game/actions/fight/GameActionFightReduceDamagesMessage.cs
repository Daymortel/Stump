

// Generated on 03/02/2014 20:42:32
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;
using Stump.DofusProtocol.Types;

namespace Stump.DofusProtocol.Messages
{
    public class GameActionFightReduceDamagesMessage : AbstractGameActionMessage
    {
        public const uint Id = 5526;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int targetId;
        public int amount;
        
        public GameActionFightReduceDamagesMessage()
        {
        }
        
        public GameActionFightReduceDamagesMessage(short actionId, int sourceId, int targetId, int amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteInt(amount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadInt();
            amount = reader.ReadInt();
            if (amount < 0)
                throw new Exception("Forbidden value on amount = " + amount + ", it doesn't respect the following condition : amount < 0");
        }
        
        public override int GetSerializationSize()
        {
            return base.GetSerializationSize() + sizeof(int) + sizeof(int);
        }
        
    }
    
}

// Generated on 01/04/2013 14:36:05
using System;
using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
    public class HumanOption
    {
        public const short Id = 406;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public HumanOption()
        {
        }
        
        
        public virtual void Serialize(IDataWriter writer)
        {
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
        }
        
    }
    
}
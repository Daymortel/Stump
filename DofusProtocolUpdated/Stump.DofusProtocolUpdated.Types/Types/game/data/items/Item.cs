

// Generated on 03/06/2014 18:50:34
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
    public class Item
    {
        public const short Id = 7;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        
        public Item()
        {
        }
        
        
        public virtual void Serialize(IDataWriter writer)
        {
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
        }
        
        public virtual int GetSerializationSize()
        {
            return 0;
            ;
        }
        
    }
    
}
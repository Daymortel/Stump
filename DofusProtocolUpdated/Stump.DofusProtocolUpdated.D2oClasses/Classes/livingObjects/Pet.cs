

// Generated on 12/12/2013 16:57:40
using System;
using System.Collections.Generic;
using Stump.DofusProtocol.D2oClasses;
using Stump.DofusProtocol.D2oClasses.Tools.D2o;

namespace Stump.DofusProtocol.D2oClasses
{
    [D2OClass("Pet", "com.ankamagames.dofus.datacenter.livingObjects")]
    [Serializable]
    public class Pet : IDataObject, IIndexedData
    {
        public const String MODULE = "Pets";
        public int id;
        public List<int> foodItems;
        public List<int> foodTypes;
        int IIndexedData.Id
        {
            get { return (int)id; }
        }
        [D2OIgnore]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [D2OIgnore]
        public List<int> FoodItems
        {
            get { return foodItems; }
            set { foodItems = value; }
        }
        [D2OIgnore]
        public List<int> FoodTypes
        {
            get { return foodTypes; }
            set { foodTypes = value; }
        }
    }
}
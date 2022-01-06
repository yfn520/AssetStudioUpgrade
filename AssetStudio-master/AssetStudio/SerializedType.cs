using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetStudio
{
    public class SerializedType
    {
        public int classID;
        public bool m_IsStrippedType;
        public short m_ScriptTypeIndex = -1;
        public TypeTree m_Type;
        public byte[] m_ScriptID = new byte[0]; //Hash128
        public byte[] m_OldTypeHash = new byte[0]; //Hash128
        public int[] m_TypeDependencies = new int[0];
        public string m_KlassName;
        public string m_NameSpace;
        public string m_AsmName;
    }
}

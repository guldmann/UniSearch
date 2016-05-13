using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSearch.IndexServiceReference;

namespace UniSearch
{
    class ExtensionComparer : IEqualityComparer<IndexFile>
    {
        public bool Equals(IndexFile if1, IndexFile if2)
        {
            if (if1.Extensionk__BackingField == null && if2.Extensionk__BackingField == null)
            {
                return true; 
            }
            if (if1.Extensionk__BackingField.ToUpper() == if2.Extensionk__BackingField.ToUpper())
            {
                return true; 
            }
            
            return false; 
        }

        public int GetHashCode(IndexFile iFile)
        {
            return  iFile.Extensionk__BackingField.GetHashCode(); 
        }

    }
}

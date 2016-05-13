using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pcis.common
{
    [Serializable]
    
    public class IndexFile  : IEquatable<IndexFile>
    {
        public string Name { get; set; }
        public string Folder { get; set; }
        public string type { get; set; }
        public string Extension { get; set; }
        public string MD5 { get; set;  }
        public string FullName()
        {
            return Folder +"\\" + Name; 
        }


        public bool Equals(IndexFile other)
        {
            
            if(Object.ReferenceEquals(other, null)) return false;
            if (object.ReferenceEquals(this, other)) return true;

            return MD5.Equals(other.MD5); 
            
        }

        public int GetHashCode(IndexFile obj)
        {
            int hashName = Name?.GetHashCode() ?? 0;
            int hashFolder = Folder?.GetHashCode() ?? 0;
            int hashExtension = Extension?.GetHashCode() ?? 0;
            int hashMD5 = MD5?.GetHashCode() ?? 0;
            return hashName ^ hashFolder ^ hashExtension ^ hashMD5; 
        }


    }
}

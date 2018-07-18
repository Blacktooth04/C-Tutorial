using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class AccessModifiers
    {

        // private
        // only accessible within this class
        private int privateInt;
        private void setInt(int methodInt)
        {
            // now private int will be whatever value is ran through
            privateInt += methodInt;
        }

        // public
        // accessible by any code within the same namespace
        // or another namespace that references it
        public int getInt(int methodInt)
        {
            // publicInt is private, so only this class can access it.
            // however, since this method is public, outside classes can
            // access the privateInt variable
            return privateInt;
        }

        // protected
        // accessible within this class or any derived class
        protected int protectedInt = 12;

        // internal
        // accessible by any code within the namespace, but not in another namespace
        // also protected internal for access to derived classes
        internal int internalInt = 13;

        
    }
}

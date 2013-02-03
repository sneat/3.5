using System;

using System.Reflection;
using System.Runtime.InteropServices;

namespace BMDGLC
{
    class SwitcherAPIHelper
    {
        /// <summary>
        /// This helper method is used for calling the "CreateIterator" method on various Switcher API
        /// objects. The CreateIterator pattern is a common pattern used throughout the Switcher API in
        /// order to get children objects (For example, getting a Mix Effect block iterator from a Switcher
        /// or getting a Key iterator from a Mix Effect bock).
        /// The CreateIterator pattern works well in native COM, but isn't so convinent in C#. You must
        /// parse in the IID of the interface you wish to get (as a reference), as well as an IntPtr
        /// to get the actual interface. The IntPtr must then be converted to the interface you are
        /// interested in (via COMs IUnknown class).
        /// </summary>
        /// <typeparam name="A">The type of the parent interface that implements "CreateIterator"</typeparam>
        /// <typeparam name="B">The type of the iterator interface</typeparam>
        /// <param name="baseClass">A reference to the parent class</param>
        /// <param name="output">An out reference to the new iterator object</param>
        /// <returns>True on success</returns>
        public static bool CreateIterator<A, B>(A baseClass, out B output)
        {
            // Get the guid of the type we are requesting
            Guid guid = typeof(B).GUID;

            // Get the method called "CreateIterator" on the base class.
            // We use runtime reflection to get the CreateIterator method, as C# generics don't
            // really allow us to call this directly: the base classes that implement CreateIterator do
            // not come from a common ancestry.
            MethodInfo method = typeof(A).GetMethod("CreateIterator",
                new Type[] { typeof(Guid).MakeByRefType(), typeof(IntPtr).MakeByRefType() });

            if (method == null)
            {
                output = default(B);
                return false;
            }

            object[] parameters = new object[] { guid, null };
            method.Invoke(baseClass, parameters);

            // Get the IUknown from the pointer, and cast (QueryInterface) to our required type.
            output = (B)Marshal.GetObjectForIUnknown((IntPtr)parameters[1]);

            return true;
        }
    }
}

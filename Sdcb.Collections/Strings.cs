using System;
using System.Runtime.Serialization;

namespace Sdcb.Collections
{
    internal static class Strings
    {
        public const string Arg_KeyNotFoundWithKey = "The given key '{0}' was not present in the dictionary.";
        public const string ArgumentOutOfRange_NeedNonNegNum = "Non-negative number required.";
        public const string Arg_ArrayPlusOffTooSmall = "Destination array is not long enough to copy all the items in the collection. Check array index and length.";
        public const string Argument_AddingDuplicateWithKey = "An item with the same key has already been added. Key: {0}";
        public const string InvalidOperation_ConcurrentOperationsNotSupported = "Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection's state is no longer correct.";
        public const string InvalidOperation_EnumFailedVersion = "Collection was modified; enumeration operation may not execute.";
        public const string NotSupported_KeyCollectionSet = "Mutating a key collection derived from a dictionary is not allowed.";
    }
}

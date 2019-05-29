namespace Sdcb.Collections
{
    // The shared fields between a BidirectionalDictionary and its reverse view, updates in one will reflect in the other as they're shared through this class
    internal sealed class BidirectionalDictionaryShared
    {
        // The number of initialized items, either in collection or in free list
        public int Count;
        public int Version;
        public int FreeList = -1;
        public int FreeCount;
    }
}

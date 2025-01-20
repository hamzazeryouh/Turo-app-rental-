

namespace Turo.Infrastructure.Helpers
{
    public class PaginatedList<T>
    {
        public IEnumerable<T> Items { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }
        public int PageNumber { get; private set; }
        public int PageSize { get; private set; }

        public PaginatedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            Items = items;
            TotalCount = count;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
    }

}

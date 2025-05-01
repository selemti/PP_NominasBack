using System;
using System.Collections.Generic;

namespace PP_NominasBack.Common
{
    public record PagedResult<T>(IEnumerable<T> Items, int TotalCount, int PageNumber, int PageSize)
    {
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    }
}

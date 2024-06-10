using Auctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auctions.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}

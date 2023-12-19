using Microsoft.EntityFrameworkCore;
using XChallengeWebApi.Domains;
using XChallengeWebApi.Interfaces;
using XChallengeWebApi.Contexts;
using XChallengeWebApi.Utils;

namespace XChallengeWebApi.Repositories
{
    public class LogAcessoRepository : ILogAcessoRepository
    {
        private readonly XChallengeContext _context;

        public LogAcessoRepository()
        {
            _context = new XChallengeContext();
        }


    }
}

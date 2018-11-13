using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyGuide.Models
{
    public class EFQuestionRepository : IQuestionRepository
    {
        private ApplicationDbContext context;

        public EFQuestionRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Question> Questions => context.Questions;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyGuide.Models
{
    public interface IQuestionRepository
    {
        IQueryable<Question> Questions { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyGuide.Models
{
    public class FakeRepository : IQuestionRepository
    {
        public IQueryable<Question> Questions => new List<Question>
            {
                new Question { qaID = 1, question = "question1", answer = "answer1", catID = 1, subID = 1 },
                new Question { qaID = 2, question = "question2", answer = "answer2", catID = 1, subID = 2 },
                new Question { qaID = 3, question = "question3", answer = "answer3", catID = 2, subID = 1 }
            }.AsQueryable<Question>();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyGuide.Models;

namespace StudyGuide.Controllers
{
    public class QuestionController : Controller
    {
        private IQuestionRepository repository;

        public QuestionController(IQuestionRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Questions);
    }
}

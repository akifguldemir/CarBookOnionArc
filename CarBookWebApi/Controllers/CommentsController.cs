using CarBookApplication.Features.RepositoryPattern.CommentRepositories;
using CarbookDomain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentsRepository;

        public CommentsController(IGenericRepository<Comment> commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }

        [HttpGet]
        public IActionResult CommentList() 
        {
            var values = _commentsRepository.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentsRepository.Create(comment);
            return Ok("Yorum eklendi");
        }

        [HttpDelete]
        public IActionResult RemoveComment(int Id)
        {
            var value = _commentsRepository.GetById(Id);
            _commentsRepository.Remove(value);
            return Ok("Yorum silindi");
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentsRepository.Update(comment);
            return Ok("Yorum silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var value = _commentsRepository.GetById(id);
            return Ok(value);
        }
    }
}

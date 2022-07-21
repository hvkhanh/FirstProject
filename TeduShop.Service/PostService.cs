using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastucture;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using System.Linq;
namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalrow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pagesize, out int totalrow);
        void SaveChange();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategories" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pagesize, out int totalrow)
        {
            //TODO: Select all post by tag
            return _postRepository.GetMultiPaging(x=>x.Status ,out totalrow,page,pagesize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalrow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalrow, page, pagesize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleByID(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
